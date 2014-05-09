using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hesap_makinasi
{
    public partial class Hesap_araci : Form
    {
        static public bool durum = false;
        public Hesap_araci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = maskedTextBox_istenen.Text;
            string liste="";
            int gun = 0, saat = 0, dakika = 0, saniye = 0, milisayiye = 0;
            double sonuc = 0;
            try
            {
                gun = Convert.ToInt32(text.Substring(0, 2));
            }
            catch (Exception)
            {
                gun = 0;
            }
            try
            {
                saat = Convert.ToInt32(text.Substring(7,2));
            }
            catch (Exception)
            {
                saat = 0;
            } try
            {
                dakika = Convert.ToInt32(text.Substring(13, 2));
            }
            catch (Exception)
            {
                dakika = 0;
            } try
            {
                saniye = Convert.ToInt32(text.Substring(19, 2));
            }
            catch (Exception)
            {
                saniye = 0;
            } try
            {
                milisayiye = Convert.ToInt32(text.Substring(25, 3));
            }
            catch (Exception)
            {
                milisayiye = 0;
            }
            sonuc += gun * 86400;
            sonuc += saat * 3600;
            sonuc += saniye;
            sonuc += dakika * 60;
            sonuc += milisayiye / 1000.0;
            textBox1.Text = sonuc.ToString(".###");
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
    }
}
