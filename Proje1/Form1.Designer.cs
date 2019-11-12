namespace Proje1
{
    partial class frmMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdMus = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.bttnGiris = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblKA = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSf = new System.Windows.Forms.Label();
            this.lblKayit = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKA = new System.Windows.Forms.TextBox();
            this.txtSf = new System.Windows.Forms.TextBox();
            this.bttnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdMus
            // 
            this.rdMus.AutoSize = true;
            this.rdMus.Location = new System.Drawing.Point(57, 60);
            this.rdMus.Name = "rdMus";
            this.rdMus.Size = new System.Drawing.Size(75, 21);
            this.rdMus.TabIndex = 0;
            this.rdMus.TabStop = true;
            this.rdMus.Text = "Müşteri";
            this.rdMus.UseVisualStyleBackColor = true;
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Location = new System.Drawing.Point(198, 60);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(129, 21);
            this.rdAdmin.TabIndex = 1;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Şirket Yöneticisi";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(54, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(88, 17);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Kullanıcı Adı:";
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Location = new System.Drawing.Point(54, 178);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(41, 17);
            this.lblPw.TabIndex = 3;
            this.lblPw.Text = "Şifre:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(126, 21);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(87, 17);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "Kullanıcı Tipi";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 129);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(198, 173);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(100, 22);
            this.txtPw.TabIndex = 6;
            // 
            // bttnGiris
            // 
            this.bttnGiris.Location = new System.Drawing.Point(148, 234);
            this.bttnGiris.Name = "bttnGiris";
            this.bttnGiris.Size = new System.Drawing.Size(75, 23);
            this.bttnGiris.TabIndex = 7;
            this.bttnGiris.Text = "Giris";
            this.bttnGiris.UseVisualStyleBackColor = true;
            this.bttnGiris.Click += new System.EventHandler(this.bttnGiris_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(421, 60);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(92, 17);
            this.lblAdSoyad.TabIndex = 9;
            this.lblAdSoyad.Text = "Ad ve Soyad:";
            // 
            // lblKA
            // 
            this.lblKA.AutoSize = true;
            this.lblKA.Location = new System.Drawing.Point(421, 129);
            this.lblKA.Name = "lblKA";
            this.lblKA.Size = new System.Drawing.Size(88, 17);
            this.lblKA.TabIndex = 10;
            this.lblKA.Text = "Kullanıcı Adı:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(421, 94);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 17);
            this.lblAdres.TabIndex = 11;
            this.lblAdres.Text = "Adres:";
            // 
            // lblSf
            // 
            this.lblSf.AutoSize = true;
            this.lblSf.Location = new System.Drawing.Point(421, 160);
            this.lblSf.Name = "lblSf";
            this.lblSf.Size = new System.Drawing.Size(41, 17);
            this.lblSf.TabIndex = 12;
            this.lblSf.Text = "Şifre:";
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(558, 21);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(125, 17);
            this.lblKayit.TabIndex = 13;
            this.lblKayit.Text = "Yeni Musteri Kaydi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(561, 59);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 14;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(561, 91);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 22);
            this.txtAdres.TabIndex = 15;
            // 
            // txtKA
            // 
            this.txtKA.Location = new System.Drawing.Point(561, 126);
            this.txtKA.Name = "txtKA";
            this.txtKA.Size = new System.Drawing.Size(100, 22);
            this.txtKA.TabIndex = 16;
            // 
            // txtSf
            // 
            this.txtSf.Location = new System.Drawing.Point(561, 157);
            this.txtSf.Name = "txtSf";
            this.txtSf.Size = new System.Drawing.Size(100, 22);
            this.txtSf.TabIndex = 17;
            // 
            // bttnKayit
            // 
            this.bttnKayit.Location = new System.Drawing.Point(572, 219);
            this.bttnKayit.Name = "bttnKayit";
            this.bttnKayit.Size = new System.Drawing.Size(75, 23);
            this.bttnKayit.TabIndex = 18;
            this.bttnKayit.Text = "Kayit Ol";
            this.bttnKayit.UseVisualStyleBackColor = true;
            this.bttnKayit.Click += new System.EventHandler(this.bttnKayit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.bttnKayit);
            this.Controls.Add(this.txtSf);
            this.Controls.Add(this.txtKA);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.lblSf);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblKA);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.bttnGiris);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.rdMus);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Siparis Otomasyonu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdMus;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPw;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Button bttnGiris;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKA;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSf;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKA;
        private System.Windows.Forms.TextBox txtSf;
        private System.Windows.Forms.Button bttnKayit;
    }
}

