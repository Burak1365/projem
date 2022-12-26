using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_oto_kiralama.sınıflar
{
    public abstract class kişibase
    {
        public string isim { get; set; }

        public string soyad { get; set; }

        public int yaş { get; set; }

        public int  tcno { get; set; }


        public virtual void tamamla()
        {

        }


    }

    
        

}
