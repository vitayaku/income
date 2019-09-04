using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Доход_по_вкладу
{
    public partial class Form1 : Form
    {
        int sum, percent;
        string times;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sum = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                sum = 0;
            }
            times = Convert.ToString(comboBox1.SelectedItem);
            if (sum == 0 || times.Equals(String.Empty))
            {
                MessageBox.Show("Необходимо указать сумму и срок вклада.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    sum = Convert.ToInt32(textBox1.Text);
                    times = Convert.ToString(comboBox1.SelectedItem);
                    switch (times)
                    {
                        case "1 месяц":
                            percent = 1;
                            break;
                        case "3 месяца":
                            percent = 3;
                            break;
                        case "6 месяцев":
                            percent = 6;
                            break;
                        case "12 месяцев":
                            percent = 12;
                            break;
                    }
                    result = sum * percent * 0.01;
                    label3.Text = "Доход составит " + result;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message, "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back))
                return;
            else
                e.Handled = true;
        }
    }
}
