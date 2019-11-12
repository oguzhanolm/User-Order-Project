using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proje1
{
    public partial class frmMain : Form
    {
        public Siparis siparis = new Siparis();
        public List<Urun> urunler = new List<Urun>();
        public Musteri CurrentMusteri;
        //Liste Oluşturma
        public List<Musteri> musteriler = new List<Musteri>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            string isim, fiyat, agirlik;
            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Read);
            string dosya_yolu = @"C:\Users\\" + Environment.UserName + "\\Desktop\\Musteriler\\Urunler.txt";
            
            StreamReader sw = new StreamReader(fs);
            while (true)
            {


                if ((isim = sw.ReadLine()) == null)
                    break;
                fiyat = sw.ReadLine();
                agirlik = sw.ReadLine();
                Urun ur = new Urun();
                ur.Agirlik = Convert.ToInt32(agirlik);
                ur.Fiyat = Convert.ToDecimal(fiyat);
                ur.Isim = isim;
                urunler.Add(ur);
            }
            sw.Close();
            fs.Close();
            //urunler listesine txtden veri girişi
            //Klasör Oluşturma
            Directory.CreateDirectory(@"C:\Users\\" + Environment.UserName + "\\Desktop\\Musteriler");

            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                }
            }
        }

        private void bttnGiris_Click(object sender, EventArgs e)
        {
            bool kontrol=false;
            foreach (Musteri item in musteriler)
            {
                kontrol = item.GirisKontrol(txtId.Text, txtPw.Text);
                if (kontrol)
                {
                    CurrentMusteri = item;
                    break;
                }
                    
            }

            if (rdMus.Checked==true) {

                if (kontrol == true)
                {
                    Form2 MusPan = new Form2();
                    MusPan.MdiParent = this;
                    MusPan.Show();

                    txtId.Visible = false;
                    txtPw.Visible = false;
                    lblId.Visible = false;
                    bttnGiris.Visible = false;
                    lblPw.Visible = false;
                    lblTip.Visible = false;
                    rdAdmin.Visible = false;
                    rdMus.Visible = false;
                    lblKA.Visible = false;
                    lblSf.Visible = false;
                    lblAdSoyad.Visible = false;
                    lblAdres.Visible = false;
                    lblKayit.Visible = false;
                    txtAdres.Visible = false;
                    txtAdSoyad.Visible = false;
                    txtKA.Visible = false;
                    txtSf.Visible = false;
                    bttnKayit.Visible = false;
                }
                else
                    MessageBox.Show("Musteri Kullanıcı Adı ve Şifresi Yanlıştır.Eğer Yeni Müşteriyseniz Lütfen Kayıt Olunuz!");
              

            }
            else if(rdAdmin.Checked == true)
            {
                if (txtId.Text == "admin" && txtPw.Text == "admin")
                {
                    Form3 YonPan = new Form3();
                    YonPan.MdiParent = this;
                    YonPan.Show();

                    txtId.Visible = false;
                    txtPw.Visible = false;
                    lblId.Visible = false;
                    bttnGiris.Visible = false;
                    lblPw.Visible = false;
                    lblTip.Visible = false;
                    rdAdmin.Visible = false;
                    rdMus.Visible = false;
                    lblKA.Visible = false;
                    lblSf.Visible = false;
                    lblAdSoyad.Visible = false;
                    lblAdres.Visible = false;
                    lblKayit.Visible = false;
                    txtAdres.Visible = false;
                    txtAdSoyad.Visible = false;
                    txtKA.Visible = false;
                    txtSf.Visible = false;
                    bttnKayit.Visible = false;
                }
            }
        }

        private void bttnKayit_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri(txtKA.Text,txtSf.Text,txtAdSoyad.Text,txtAdres.Text);
            musteriler.Add(m);
        }

    }
}
