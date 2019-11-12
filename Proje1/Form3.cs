using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            frmMain frm = (frmMain)this.MdiParent;

            //cbox
            foreach (Musteri item in frm.musteriler)
            {
                cboxMus.Items.Add(item.AdSoyad);
            }

            //cbox
            foreach (Urun item in frm.urunler)
            {
                chlistAdminUrun.Items.Add(item.Isim);
            }
        }

        private void bttnCikar_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            int i;
            for (i = 0; i < chlistAdminUrun.CheckedItems.Count; i++)
            {
                foreach (Urun item in frm.urunler)
                {
                    if (item.Isim == chlistAdminUrun.CheckedItems[i].ToString())
                    {
                        chlistAdminUrun.Items.Remove(chlistAdminUrun.CheckedItems[i]);
                        frm.urunler.Remove(item);
                        break;
                    }
                }
            }
        }

        private void bttnCikis_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void bttnEG_Click(object sender, EventArgs e)
        {
            frmMain frm = (frmMain)this.MdiParent;
            foreach (Urun item in frm.urunler)
            {
                if (txti.Text == item.Isim)
                {
                    item.Fiyat = Convert.ToDecimal(txtf.Text);
                    item.Agirlik = Convert.ToInt32(txta.Text);
                    RefleshList();
                    MessageBox.Show("Başarıyla Güncellenmiştir");
                    return;
                }
            }
            Urun yeniur = new Urun();
            yeniur.Fiyat = Convert.ToDecimal(txtf.Text);
            yeniur.Agirlik = Convert.ToInt32(txta.Text);
            yeniur.Isim = txti.Text;
            frm.urunler.Add(yeniur);
            RefleshList();
            MessageBox.Show("Yeni Urun Basariyla Eklenmistir");
        }

        public void RefleshList()
        {
            frmMain frm = (frmMain)this.MdiParent;
            chlistAdminUrun.Items.Clear();
            foreach (Urun item in frm.urunler)
            {
                chlistAdminUrun.Items.Add(item.Isim);
            }
        }

        private void bttnLog_Click(object sender, EventArgs e)
        {
            lstMusLog.Items.Clear();
            frmMain frm = (frmMain)this.MdiParent;
            foreach (Musteri item in frm.musteriler)
            {
                if (cboxMus.SelectedItem.ToString() == item.AdSoyad)
                {
                    lstMusLog.Items.Add(item.MusteriLog);
                }
            }
        }
    }
}
