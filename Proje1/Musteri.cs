using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proje1
{
    public class Musteri
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }

        public string MusteriLog { get; set; }
        public Musteri(string id,string sifre,string AdS,string Adr)
        {
            AdSoyad = AdS;
            Adres = Adr;
            string dosya_yolu = @"C:\Users\\"+ Environment.UserName+ "\\Desktop\\Musteriler\\" + AdSoyad + ".txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(id);
            sw.WriteLine(sifre);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public bool GirisKontrol(string i,string s)
        {
            string kontrolid, kontrolsif;
            string dosya_yolu = @"C:\Users\\" + Environment.UserName + "\\Desktop\\Musteriler\\" + AdSoyad + ".txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            kontrolid = sw.ReadLine();
            kontrolsif = sw.ReadLine();
            if (kontrolid != i || kontrolsif != s)
            {
                sw.Close();
                fs.Close();
                return false;
            }
            sw.Close();
            fs.Close();
            return true;
        }
    }
}
