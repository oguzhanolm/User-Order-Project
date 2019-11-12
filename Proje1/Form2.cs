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
    public partial class Form2 : Form
    {
            
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            
            //
            foreach (Urun item in frm.urunler)
            {
                chlistUrunler.Items.Add(item.Isim);
            }




            //Odeme Hide
            lblTipSec.Visible = false;
            rdCheck.Visible = false;
            rdKredi.Visible = false;
            rdNakit.Visible = false;
            lblName.Visible = false;
            lblBankID.Visible = false;
            lblNakit.Visible = false;
            lblNumber.Visible = false;
            lblTip.Visible = false;
            txtName.Visible = false;
            txtBankID.Visible = false;
            txtNakit.Visible = false;
            txtNumber.Visible = false;
            cboxTip.Visible = false;
            lblDate.Visible = false;
            txtAy.Visible = false;
            txtYil.Visible = false;
            lblTaksim.Visible = false;
            bttnOnay.Visible = false;



        }

        private void bttnSip_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;

            for (int i = 0; i < chlistUrunler.CheckedItems.Count; i++)
            {
                foreach (Urun item in frm.urunler)
                {
                    if (chlistUrunler.CheckedItems[i].ToString() == item.Isim)
                    {
                        SiparisDetay sipd = new SiparisDetay(item, Convert.ToInt32(txtUrSay.Text));
                        frm.siparis.siparisler.Add(sipd);
                    }

                       
                }
            }
                SiparisListesiReflesh();
        }
            
        
        private void SiparisListesiReflesh()
        {
            frmMain frm = (frmMain)this.MdiParent;
            decimal araToplam = 0;
            chlistSip.Items.Clear();
            foreach (SiparisDetay item in frm.siparis.siparisler)
            {      
                    chlistSip.Items.Add(item.urun.Isim + " Urunu " + item.urunMiktari.ToString() + "Adet");
                    araToplam += item.urun.Fiyat * item.urunMiktari;
            }
            lblAraToplam.Text = (araToplam+(araToplam/100*18)).ToString();

        }

        private void bttnIptal_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            for (int i = 0; i < chlistSip.CheckedItems.Count; i++)
            {
                foreach (SiparisDetay item in frm.siparis.siparisler)
                {
                    if (chlistSip.CheckedItems[i].ToString() == item.urun.Isim + " Urunu " + item.urunMiktari.ToString() + "Adet")
                    {
                        frm.siparis.siparisler.Remove(item);
                        break;
                    }


                }
            }
            SiparisListesiReflesh();
        }


        private void bttnOdeme_Click_1(object sender, EventArgs e)
        {
            lblUrunler.Visible = false;
            chlistUrunler.Visible = false;
            lblUrSay.Visible = false;
            txtUrSay.Visible = false;
            bttnSip.Visible = false;
            chlistSip.Visible = false;
            bttnOdeme.Visible = false;
            bttnIptal.Visible = false;
            lblAT.Visible = false;
            lblAraToplam.Visible = false;

            //Odeme Show

            lblTipSec.Visible = true;
            rdCheck.Visible = true;
            rdKredi.Visible = true;
            rdNakit.Visible = true;
        }

        private void rdNakit_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Visible = false;
            lblBankID.Visible = false;
            lblNakit.Visible = true;
            lblNumber.Visible = false;
            lblTip.Visible = false;
            txtName.Visible = false;
            txtBankID.Visible = false;
            txtNakit.Visible = true;
            txtNumber.Visible = false;
            cboxTip.Visible = false;
            lblDate.Visible = false;
            txtAy.Visible = false;
            txtYil.Visible = false;
            lblTaksim.Visible = false;
            bttnOnay.Visible = true;
        }

        private void rdCheck_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Visible = true;
            lblBankID.Visible = true;
            lblNakit.Visible = false;
            lblNumber.Visible = false;
            lblTip.Visible = false;
            txtName.Visible = true;
            txtBankID.Visible = true;
            txtNakit.Visible = false;
            txtNumber.Visible = false;
            cboxTip.Visible = false;
            lblDate.Visible = false;
            txtAy.Visible = false;
            txtYil.Visible = false;
            lblTaksim.Visible = false;
            bttnOnay.Visible = true;
        }

        private void rdKredi_CheckedChanged(object sender, EventArgs e)
        {
            lblName.Visible = false;
            lblBankID.Visible = false;
            lblNakit.Visible = false;
            lblNumber.Visible = true;
            lblTip.Visible = true;
            txtName.Visible = false;
            txtBankID.Visible = false;
            txtNakit.Visible = false;
            txtNumber.Visible = true;
            cboxTip.Visible = true;
            lblDate.Visible = true;
            txtAy.Visible = true;
            txtYil.Visible = true;
            lblTaksim.Visible = true;
            bttnOnay.Visible = true;
        }

        private void bttnOnay_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            if (rdCheck.Checked)
            {
                Check cek = new Check();
                cek.BankID = txtBankID.Text;
                cek.Name = txtName.Text;
                MessageBox.Show(cek.Onaylama());
                foreach (SiparisDetay item in frm.siparis.siparisler)
                {
                    frm.CurrentMusteri.MusteriLog += item.urun.Isim +" Urunu "+ item.urunMiktari.ToString() + "Adet" + item.AraAgirlik().ToString() + " Ağırlığında Alınmıştır";
                }
                frm.CurrentMusteri.MusteriLog += "- Çekle Ödenmiştir";
            }
            else if (rdNakit.Checked)
            {
                Cash nakit = new Cash();
                nakit.cashTendered = Convert.ToDecimal(txtNakit.Text);
                MessageBox.Show("Paranızın Üstü:" + (nakit.cashTendered - Convert.ToDecimal(lblAraToplam.Text)));
                foreach (SiparisDetay item in frm.siparis.siparisler)
                {
                    frm.CurrentMusteri.MusteriLog += item.urun.Isim + " Urunu " + item.urunMiktari.ToString() + "Adet" + item.AraAgirlik().ToString() + " Ağırlığında Alınmıştır";
                }
                frm.CurrentMusteri.MusteriLog += "- Nakit Ödenmiştir";
            }
            else if (rdKredi.Checked)
            {
                Credit kart = new Credit();
                kart.Number = txtNumber.Text;
                kart.Type = cboxTip.SelectedText;
                kart.expDate = txtAy.Text + "/" + txtYil.Text;
                MessageBox.Show(kart.Onaylama()+kart.Type);
                foreach (SiparisDetay item in frm.siparis.siparisler)
                {
                    frm.CurrentMusteri.MusteriLog += item.urun.Isim + " Urunu " + item.urunMiktari.ToString() + "Adet"+item.AraAgirlik().ToString()+" Ağırlığında Alınmıştır";
                }
                frm.CurrentMusteri.MusteriLog += "- Kredi Kartıyla Ödenmiştir";
            }

            frm.Controls["txtId"].Visible = true;
            frm.Controls["txtId"].Text = "";
            frm.Controls["txtPw"].Visible = true;
            frm.Controls["txtPw"].Text = "";
            frm.Controls["lblId"].Visible = true;
            frm.Controls["bttnGiris"].Visible = true;
            frm.Controls["lblPw"].Visible = true;
            frm.Controls["lblTip"].Visible = true;
            frm.Controls["rdAdmin"].Visible = true;
            frm.Controls["rdMus"].Visible = true;
            frm.Controls["lblKA"].Visible = true;
            frm.Controls["lblSf"].Visible = true;
            frm.Controls["lblAdSoyad"].Visible = true;
            frm.Controls["lblAdres"].Visible = true;
            frm.Controls["lblKayit"].Visible = true;
            frm.Controls["txtAdres"].Visible = true;
            frm.Controls["txtAdres"].Text = "";
            frm.Controls["txtAdSoyad"].Visible = true;
            frm.Controls["txtAdSoyad"].Text = "";
            frm.Controls["txtKA"].Visible = true;
            frm.Controls["txtKA"].Text = "";
            frm.Controls["txtSf"].Visible = true;
            frm.Controls["txtSf"].Text = "";
            frm.Controls["bttnKayit"].Visible = true;
            frm.siparis.siparisler.Clear();
            this.Close();

        }

        private void bttnCik_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            frm.Controls["txtId"].Visible = true;
            frm.Controls["txtId"].Text = "";
            frm.Controls["txtPw"].Visible = true;
            frm.Controls["txtPw"].Text = "";
            frm.Controls["lblId"].Visible = true;
            frm.Controls["bttnGiris"].Visible = true;
            frm.Controls["lblPw"].Visible = true;
            frm.Controls["lblTip"].Visible = true;
            frm.Controls["rdAdmin"].Visible = true;
            frm.Controls["rdMus"].Visible = true;
            frm.Controls["lblKA"].Visible = true;
            frm.Controls["lblSf"].Visible = true;
            frm.Controls["lblAdSoyad"].Visible = true;
            frm.Controls["lblAdres"].Visible = true;
            frm.Controls["lblKayit"].Visible = true;
            frm.Controls["txtAdres"].Visible = true;
            frm.Controls["txtAdres"].Text = "";
            frm.Controls["txtAdSoyad"].Visible = true;
            frm.Controls["txtAdSoyad"].Text = "";
            frm.Controls["txtKA"].Visible = true;
            frm.Controls["txtKA"].Text = "";
            frm.Controls["txtSf"].Visible = true;
            frm.Controls["txtSf"].Text = "";
            frm.Controls["bttnKayit"].Visible = true;
            frm.siparis.siparisler.Clear();
            this.Close();
        }
    }
}
