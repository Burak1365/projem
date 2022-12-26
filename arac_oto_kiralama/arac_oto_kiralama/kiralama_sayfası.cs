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
    public partial class kiralama_sayfası : Form
    {
        public kiralama_sayfası()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "MERCEDES";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 900;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked )
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }

            

        }
        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "FORD";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 500;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked )
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }

            

        }
         
        

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "VOLVO";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 700;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked )
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "AUDI";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 750;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked )
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "BMW";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 1000;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked)
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }

            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "TOYOTA";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 400;
            textBox2.Text = arc.ucret.ToString();

            if (checkBox1.Checked)
            {
                arc.yuzde20(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString());
                listBox2.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else if (checkBox2.Checked )
            {
                arc.yuzde50(arc.ucret);

                listBox1.Items.Add(arc.ucret.ToString() + arc.aracmodel);
            }
            else
            {
                listBox1.Items.Add(arc.ucret);
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "HONDA";
            araç arc = new araç(textBox1.Text);
            arc.ucret = 500;
            textBox2.Text = arc.ucret.ToString();

            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                MessageBox.Show("kişisel bilgilerinizin girişi için yönlendiriliyorsunuz ...");
                kullanıcı_sformu user = new kullanıcı_sformu();

                user.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("lütfen model seçimi yapınız.");
            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bilgisil sil = new bilgisil();

            sil.sil(textBox1.Text, textBox2.Text); 


        }

        private void kiralama_sayfası_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}