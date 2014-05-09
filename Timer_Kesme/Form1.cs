using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_Kesme
{
    public partial class Form1 : Form
    {
        int[] timer0_div = { 2, 4, 8, 16, 32, 64, 128, 256 };
        int[] timer1_div = { 1, 2, 4, 8 };
        int[] timer2_div = { 1, 4, 16 };


        public Form1()
        {
            InitializeComponent();
        }


        private void comboBox_PreScalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void comboBox_Timer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (comboBox_Timer.SelectedIndex==0)
            {
                comboBox_PreScalar.DataSource = timer0_div;
                progressBar1.Maximum = 256;
                progressBar1.Value = 0;
            }
            else if (comboBox_Timer.SelectedIndex==1)
            {
                comboBox_PreScalar.DataSource = timer1_div;
                progressBar1.Maximum = 65536;
                progressBar1.Value = 0;
            }
            else if (comboBox_Timer.SelectedIndex==2)
            {
                comboBox_PreScalar.DataSource = timer2_div;
                progressBar1.Maximum = 256;
                progressBar1.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            double time = 0;
            dataGridView1.Rows.Clear();
            int prescalar = Convert.ToInt32(comboBox_PreScalar.SelectedItem);
            try
            {
                time = Convert.ToDouble(textBox_wanted_time.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Time değeri hatalı girildi.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (comboBox_Timer.SelectedIndex==0)
            {
                Timer0(prescalar, time);
            }
            else if (comboBox_Timer.SelectedIndex==1)
            {
                Timer1(prescalar, time);
            }
            else if (comboBox_Timer.SelectedIndex==2)
            {
                Timer2(prescalar, time);
            }
        }

        private void Timer2(int prescalar, double time)
        {
            double interrupts = 0;
            for (int i = 0; i < 256; i++)
            {
                interrupts = (time * 1000000) / (prescalar * (256 - i) * 4);
                if (interrupts - (int)interrupts == 0 && checkBox_sadece_tamsayi.Checked==true)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                else if (checkBox_sadece_tamsayi.Checked == false)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                progressBar1.Value++;
            }
        }

        private void Timer1(int prescalar, double time)
        {
            double interrupts = 0;
            for (int i = 0; i < 65536; i++)
            {
                interrupts = (time * 1000000) / (prescalar * (65536 - i) * 4);
                if (interrupts - (int)interrupts == 0 && checkBox_sadece_tamsayi.Checked==true)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                else if (checkBox_sadece_tamsayi.Checked == false)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                progressBar1.Value++;
            }
        }

        void Timer0(int prescalar, double time)
        {
            double interrupts = 0;
            for (int i = 0; i < 256; i++)
            {
                interrupts = (time * 1000000) / (prescalar * (256 - i) * 4);
                if (interrupts-(int)interrupts==0 && checkBox_sadece_tamsayi.Checked==true)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                else if(checkBox_sadece_tamsayi.Checked==false)
                {
                    dataGridView1.Rows.Add(i, interrupts);
                }
                progressBar1.Value++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Hesap_makinasi.Hesap_araci hesap = new Hesap_makinasi.Hesap_araci();
                hesap.Show();
        }
    }
}
