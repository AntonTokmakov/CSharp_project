using System;
using System.Windows.Forms;

namespace multi_window
{
    public partial class City_F : Form
    {
        public City_F()
        {
            InitializeComponent();
        }

        private void City_F_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    if (tb_oblast.Text.Trim() == "")
                    {
                        tb_oblast.Focus();
                        throw new Exception("Вы не ввели область");
                    }

                    if (tb_city_name.Text.Trim() == "")
                    {
                        tb_city_name.Focus();
                        throw new Exception("Вы не ввели наименовение города");
                    }

                    if (tb_count_people.Text.Trim() == "")
                    {
                        tb_count_people.Focus();
                        throw new Exception("Вы не ввели количество человек");
                    }

                    double peopleCount = Convert.ToDouble(tb_count_people.Text);
                    if (!(peopleCount >= 0.01 && peopleCount <= 500.00))
                    {
                        tb_count_people.Focus();
                        throw new Exception("Введенное значение должно быть от 0.01 до 500");
                    }

                    if (tb_year_money.Text.Trim() == "")
                    {
                        tb_year_money.Focus();
                        throw new Exception("Вы не ввели бюджет города");
                    }

                    try
                    {
                        int moneyCount = Convert.ToInt32(tb_year_money.Text);

                        if (!(moneyCount >= 100 && moneyCount <= 500000))
                        {
                            tb_year_money.Focus();
                            throw new Exception("Бюджет города должен быть от 100 до 500000 млн.");
                        }
                    }
                    catch (FormatException)
                    {
                        e.Cancel = true;
                        tb_year_money.Focus();
                        MessageBox.Show("Бюджет города должен целым числом", "Ошибка");
                    }
                }
                catch (FormatException) 
                {
                    e.Cancel = true;
                    tb_count_people.Focus();
                    MessageBox.Show("Кол-во человек должно быть вещественным числом", "Ошибка");
                }
                catch (Exception ex) 
                {
                    e.Cancel= true;
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
    }
}
