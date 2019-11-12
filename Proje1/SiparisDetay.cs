using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    public class SiparisDetay
    {
        public Urun urun = new Urun();
        public int urunMiktari;
        public float vergiOrani = 0.18f;

        public SiparisDetay(Urun ur,int miktar)
        {
            urun = ur;
            urunMiktari = miktar;
        }

        public decimal AraFiyatlama()
        {
            return urunMiktari * urun.Fiyat;
        }

        public int AraAgirlik()
        {
            return urunMiktari * urun.Agirlik;
        }
    }
}
