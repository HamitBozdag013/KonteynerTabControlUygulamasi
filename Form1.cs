using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonteynerTabControlUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                textBox4.Text = "";
                textBox4.Text += textBox1.Text + "\r\n";
                textBox4.Text += textBox2.Text + "\r\n";
                textBox4.Text += textBox3.Text + "\r\n";
                textBox4.Text += "------------------------------------------- \r\n";

                decimal hesap = 0;

                textBox4.Text += string.Format("Ürünler \t \t \t B. Fiyat \t Tutar \r\n");

                if (numericUpDown1.Value > 0)
                {
                    hesap += numericUpDown1.Value * 12;
                    textBox4.Text += string.Format(comboBox1.Text + "\t \t 12.00 \t {0:C}", numericUpDown1.Value * 12) + "\r\n";
                }
                if (numericUpDown2.Value > 0)
                {
                    hesap += numericUpDown2.Value * 20;
                    textBox4.Text += string.Format(comboBox2.Text + "\t \t 20.00 \t {0:C}", numericUpDown2.Value * 20) + "\r\n";
                }

                if (numericUpDown3.Value > 0)
                {
                    hesap += numericUpDown3.Value * 30;
                    textBox4.Text += string.Format(comboBox3.Text + "\t \t \t 30.00 \t {0:C}", numericUpDown3.Value * 30) + "\r\n";
                }

                if (numericUpDown4.Value > 0)
                {
                    hesap += numericUpDown4.Value * 8;
                    textBox4.Text += string.Format(comboBox4.Text + " \t \t 8.00 \t {0:C}", numericUpDown4.Value * 8) + "\r\n";
                }

                if (numericUpDown5.Value > 0)
                {
                    hesap += numericUpDown5.Value * 10;
                    textBox4.Text += string.Format(comboBox5.Text + " \t \t \t 10.00 \t {0:C}", numericUpDown5.Value * 10) + "\r\n";
                }

                if (numericUpDown6.Value > 0)
                {
                    hesap += numericUpDown6.Value * 5;
                    textBox4.Text += string.Format(comboBox6.Text + " \t \t \t 5.00 \t {0:C}", numericUpDown6.Value * 5) + "\r\n";
                }

                textBox4.Text += "------------------------------------------- \r\n";
                textBox4.Text += string.Format("Toplam Tutar : {0:C}", hesap);


            }
        }
    }
}
