using arac_oto_kiralama.sınıflar;
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
    public partial class kullanıcı_sformu : Form
    {




        public kullanıcı_sformu()
        {
            InitializeComponent();
        }

        private void kullanıcı_sformu_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button3.Visible = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.","UYARI" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiracı kira = new kiracı();
            kira.isim = textBox1.Text;
            kira.soyad = textBox2.Text;
            kira.yaş = Convert.ToInt32(textBox3.Text);  
            kira.tcno = Convert.ToInt32(textBox4.Text);


            kira.tamamla();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            kefil kefil = new kefil();

            kefil.isim = textBox5.Text;
            kefil.soyad = textBox6.Text;
            kefil.yaş =Convert.ToInt32(textBox7.Text);  

            kefil.tcno =Convert.ToInt32(textBox8.Text);


            kefil.tamamla(); 



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(textBox1.Text.Length > 0)
            {
                parkyeri parkyeri = new parkyeri();

                int a;
                int[] liste = { 1, 2, 3, 4, 5, 6 };

                Random rnd = new Random();

                a = rnd.Next(liste.Length);

                int sonuc = parkyeri.parkyerigoster(a);

                MessageBox.Show($"aracınızı {sonuc} numaralı park alanından alabilirsiniz");


            }

            else
            {
                MessageBox.Show("lutfen bilgileri eksiksiz giriniz . ");
            }






        }

        private void lUTFENOKUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kiralama_sayfası kira = new kiralama_sayfası();
            kira.Show();
            this.Hide(); 
        }
    }
}
