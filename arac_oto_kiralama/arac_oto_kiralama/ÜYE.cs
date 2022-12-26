using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_oto_kiralama
{
    public partial class ÜYE : Form
    {
        public ÜYE()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string telno = maskedTextBox1.Text.ToString();
            MessageBox.Show($"{telno} NUMARALI TELEFON NUMARANIZA GİRİŞ YETKİ LİNKİ GÖNDERİLDİ.");
        }

        private void ÜYE_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiralama_sayfası kira = new kiralama_sayfası();

            kira.Show();
            this.Hide();

        }
    }
}
