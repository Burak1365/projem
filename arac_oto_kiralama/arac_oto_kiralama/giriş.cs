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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pROJEHAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nesne yönelimli programlama dersi için dönem projesi amacıyla yapılmıştır. Öğrenilen her konu proje üstünde denenmiştir..","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiralama_sayfası kira = new kiralama_sayfası();

            kira.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜYE UYE = new ÜYE();

            UYE.Show();
            this.Hide();
        }
    }
}
