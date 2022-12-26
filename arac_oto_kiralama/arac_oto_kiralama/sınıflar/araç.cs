using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace arac_oto_kiralama.sınıflar
{
    public class araç
    {
        public string aracmodel;


        public int ucret;


        public araç(string aracmodel)
        {
            if(aracmodel == "FORD")
            {
                System.Windows.Forms.MessageBox.Show("FORD ARACI SEÇİLDİ");
            }
            else if(aracmodel == "VOLVO")
            {
                System.Windows.Forms.MessageBox.Show("VOLVO ARACI SEÇİLDİ");
            }
            else if (aracmodel == "MERCEDES")
            {
                System.Windows.Forms.MessageBox.Show("MERCEDES ARACI SEÇİLDİ");
            }
            else if (aracmodel == "AUDI")
            {
                System.Windows.Forms.MessageBox.Show("AUDI ARACI SEÇİLDİ");
            }
            else if (aracmodel == "BMW")
            {
                System.Windows.Forms.MessageBox.Show("BMW ARACI SEÇİLDİ");
            }
            else if (aracmodel == "TOYOTA")
            {
                System.Windows.Forms.MessageBox.Show("TOYOTA ARACI SEÇİLDİ");
            }
            else if (aracmodel == "HONDA")
            {
                System.Windows.Forms.MessageBox.Show("HONDA ARACI SEÇİLDİ");
            }

        }


        public int yuzde20(int fiyat)
        {
            fiyat = fiyat - (fiyat * 5 / 10); //yuzde20 indirimi kaptık. //metod çalışmadı

            return fiyat; 
        }

        public int  yuzde50(int fiyat)
        {
            fiyat = fiyat - (fiyat * 1/2); //yuzde50 indirimi kaptık.//metod çalışmadı

            return fiyat;
        }


        public void sil(string adres1 , string adres2)
        {
            adres1 = " ";
            adres2 = " ";

        }







    }
}
