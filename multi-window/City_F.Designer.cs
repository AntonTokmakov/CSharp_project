namespace multi_window
{
    partial class City_F
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_oblast = new System.Windows.Forms.TextBox();
            this.tb_city_name = new System.Windows.Forms.TextBox();
            this.tb_count_people = new System.Windows.Forms.TextBox();
            this.tb_year_money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Location = new System.Drawing.Point(270, 223);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_back.Location = new System.Drawing.Point(396, 223);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Отмена";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Наименование области";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование города";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Число жителей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Годовой бюджет";
            // 
            // tb_oblast
            // 
            this.tb_oblast.Location = new System.Drawing.Point(213, 32);
            this.tb_oblast.Name = "tb_oblast";
            this.tb_oblast.Size = new System.Drawing.Size(258, 22);
            this.tb_oblast.TabIndex = 6;
            // 
            // tb_city_name
            // 
            this.tb_city_name.Location = new System.Drawing.Point(213, 75);
            this.tb_city_name.Name = "tb_city_name";
            this.tb_city_name.Size = new System.Drawing.Size(258, 22);
            this.tb_city_name.TabIndex = 7;
            // 
            // tb_count_people
            // 
            this.tb_count_people.Location = new System.Drawing.Point(213, 119);
            this.tb_count_people.Name = "tb_count_people";
            this.tb_count_people.Size = new System.Drawing.Size(132, 22);
            this.tb_count_people.TabIndex = 8;
            // 
            // tb_year_money
            // 
            this.tb_year_money.Location = new System.Drawing.Point(213, 173);
            this.tb_year_money.Name = "tb_year_money";
            this.tb_year_money.Size = new System.Drawing.Size(132, 22);
            this.tb_year_money.TabIndex = 9;
            // 
            // City_F
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_back;
            this.ClientSize = new System.Drawing.Size(534, 281);
            this.Controls.Add(this.tb_year_money);
            this.Controls.Add(this.tb_count_people);
            this.Controls.Add(this.tb_city_name);
            this.Controls.Add(this.tb_oblast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "City_F";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "City_F";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.City_F_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_oblast;
        public System.Windows.Forms.TextBox tb_city_name;
        public System.Windows.Forms.TextBox tb_count_people;
        public System.Windows.Forms.TextBox tb_year_money;
    }
}