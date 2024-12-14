using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_window
{
    public partial class Main_F : Form
    {
        public Main_F()
        {
            InitializeComponent();
        }

        private void Main_F_Load(object sender, EventArgs e)
        {
            buttonEnable(false);
            buttonDeleteAndUpdate(false);
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            City_F cityForm = new City_F();
            

            if (cityForm.ShowDialog() == DialogResult.OK)
            {
                Oblact oblact = new Oblact();
                oblact.OblactString = cityForm.tb_oblast.Text;
                oblact.City = cityForm.tb_city_name.Text;
                oblact.CountPeople = Convert.ToDouble(cityForm.tb_count_people.Text);
                oblact.YearMoney = Convert.ToInt32(cityForm.tb_year_money.Text);
                lb_spisok.Items.Add(oblact);
                buttonEnable(true);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lb_spisok.SelectedIndex != -1) 
            {
                City_F cityForm = new City_F();

                Oblact oblast = (Oblact) lb_spisok.SelectedItem;

                cityForm.tb_oblast.Text = oblast.OblactString;
                cityForm.tb_city_name.Text = oblast.City;
                cityForm.tb_count_people.Text = oblast.CountPeople.ToString();
                cityForm.tb_year_money.Text = oblast.YearMoney.ToString();

                if (cityForm.ShowDialog() == DialogResult.OK)
                {
                    oblast.OblactString = cityForm.tb_oblast.Text;
                    oblast.City = cityForm.tb_city_name.Text;
                    oblast.CountPeople = Convert.ToDouble(cityForm.tb_count_people.Text);
                    oblast.YearMoney = Convert.ToInt32(cityForm.tb_year_money.Text);
                    lb_spisok.Items[lb_spisok.SelectedIndex] = oblast;
                }
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lb_spisok.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
                return;
            }

            lb_spisok.Items.RemoveAt(lb_spisok.SelectedIndex);

            if (lb_spisok.Items.Count == 0)
            {
                buttonEnable(false);
            }


        }

        private void buttonEnable(bool enable)
        {
            btn_calculate.Enabled = enable;
            btn_save.Enabled = enable;
            toolStripButton5.Enabled = enable;
            strip_save.Enabled = enable;
            toolStripButton6.Enabled = enable;
        }

        private void buttonDeleteAndUpdate(bool enable)
        {
            btn_delete.Enabled = enable;
            btn_update.Enabled = enable;
            strip_update.Enabled= enable;
            strip_delete.Enabled= enable;
            toolStrip_update.Enabled = enable;
            toolStrip_delete.Enabled = enable;
        }

        private void clearText()
        {
            lb_calc.Text = "";
            tool_oblast.Text = "";
            tool_city.Text = "";
            tool_people.Text = "";
            tool_budget.Text = "";
        }

        private void lb_spisok_TabIndexChanged(object sender, EventArgs e)
        {
            if (lb_spisok.SelectedIndex != -1)
            {
                Oblact obl = lb_spisok.SelectedItem as Oblact;
                tool_oblast.Text = obl.OblactString;
                tool_city.Text = obl.City;
                tool_people.Text = obl.CountPeople.ToString();
                tool_budget.Text = obl.YearMoney.ToString();
                buttonDeleteAndUpdate(true);
            }
            else
            {
                buttonDeleteAndUpdate(false);
                clearText();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!(lb_spisok.Items.Count > 0))
            {
                MessageBox.Show("Не введены элементы", "Информация");
                return;
            }

            Save_D.FileName = "Информация об областях";

            if (Save_D.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(File.Open(Save_D.FileName, FileMode.Create)))
                {
                    for (int i = 0; i < lb_spisok.Items.Count; i++)
                    {
                        Oblact oblact = lb_spisok.Items[i] as Oblact;
                        if (oblact != null)
                        {
                            sw.WriteLine(oblact.getView());
                        }
                    }
                }
            }
        }

        // загрузить
        private void button1_Click(object sender, EventArgs e)
        {
            if (Open_D.ShowDialog() == DialogResult.OK)
            {
                lb_spisok.Items.Clear();
                clearText();
                using (StreamReader sr = new StreamReader(File.Open(Open_D.FileName, FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        try
                        {
                            Oblact oblact = new Oblact
                            {
                                OblactString = parts[0],
                                City = parts[1],
                                YearMoney = int.Parse(parts[2]),
                                CountPeople = double.Parse(parts[3])
                            };
                            lb_spisok.Items.Add(oblact);
                        } catch {}
                    }
                    buttonDeleteAndUpdate(false);
                    if (lb_spisok.Items.Count != 0)
                        buttonEnable(true);
                    else
                        MessageBox.Show("Элементы в файле не найдены", "Информация");
                }
            }

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (lb_spisok.Items.Count == 0)
            {
                MessageBox.Show("Элементов в списке нет", "Информация");
                return;
            }            

            Oblact maxOblact = lb_spisok.Items[0] as Oblact;

            if (lb_spisok.Items.Count == 1)
            {
                lb_calc.Text = $"{maxOblact.OblactString} {maxOblact.City} {Math.Round(maxOblact.YearMoney / maxOblact.CountPeople, 2)}";
                return;
            }

            double maxBudgetPerPerson = maxOblact.YearMoney / maxOblact.CountPeople;

            foreach (Oblact oblact in lb_spisok.Items)
            {
                double budgetPerPerson = oblact.YearMoney / oblact.CountPeople;

                if (budgetPerPerson > maxBudgetPerPerson)
                {
                    maxBudgetPerPerson = budgetPerPerson;
                    maxOblact = oblact;
                }
            }

            lb_calc.Text = $"{maxOblact.OblactString} {maxOblact.City} {Math.Round(maxBudgetPerPerson, 2)}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lb_spisok.SelectedIndex = -1;
        }
    }
}
