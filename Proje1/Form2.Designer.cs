namespace Proje1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chlistUrunler = new System.Windows.Forms.CheckedListBox();
            this.lblUrunler = new System.Windows.Forms.Label();
            this.bttnSip = new System.Windows.Forms.Button();
            this.lblUrSay = new System.Windows.Forms.Label();
            this.txtUrSay = new System.Windows.Forms.TextBox();
            this.chlistSip = new System.Windows.Forms.CheckedListBox();
            this.lblAT = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.bttnIptal = new System.Windows.Forms.Button();
            this.bttnOdeme = new System.Windows.Forms.Button();
            this.rdNakit = new System.Windows.Forms.RadioButton();
            this.rdCheck = new System.Windows.Forms.RadioButton();
            this.rdKredi = new System.Windows.Forms.RadioButton();
            this.lblTipSec = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBankID = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBankID = new System.Windows.Forms.TextBox();
            this.txtNakit = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cboxTip = new System.Windows.Forms.ComboBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.lblTaksim = new System.Windows.Forms.Label();
            this.bttnOnay = new System.Windows.Forms.Button();
            this.bttnCik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chlistUrunler
            // 
            this.chlistUrunler.FormattingEnabled = true;
            this.chlistUrunler.Location = new System.Drawing.Point(12, 45);
            this.chlistUrunler.Name = "chlistUrunler";
            this.chlistUrunler.Size = new System.Drawing.Size(151, 378);
            this.chlistUrunler.TabIndex = 0;
            // 
            // lblUrunler
            // 
            this.lblUrunler.AutoSize = true;
            this.lblUrunler.Location = new System.Drawing.Point(12, 9);
            this.lblUrunler.Name = "lblUrunler";
            this.lblUrunler.Size = new System.Drawing.Size(55, 17);
            this.lblUrunler.TabIndex = 1;
            this.lblUrunler.Text = "Ürünler";
            // 
            // bttnSip
            // 
            this.bttnSip.Location = new System.Drawing.Point(413, 60);
            this.bttnSip.Name = "bttnSip";
            this.bttnSip.Size = new System.Drawing.Size(75, 23);
            this.bttnSip.TabIndex = 2;
            this.bttnSip.Text = "Sipariş";
            this.bttnSip.UseVisualStyleBackColor = true;
            this.bttnSip.Click += new System.EventHandler(this.bttnSip_Click);
            // 
            // lblUrSay
            // 
            this.lblUrSay.AutoSize = true;
            this.lblUrSay.Location = new System.Drawing.Point(189, 63);
            this.lblUrSay.Name = "lblUrSay";
            this.lblUrSay.Size = new System.Drawing.Size(84, 17);
            this.lblUrSay.TabIndex = 3;
            this.lblUrSay.Text = "Ürün Sayısı:";
            // 
            // txtUrSay
            // 
            this.txtUrSay.Location = new System.Drawing.Point(274, 60);
            this.txtUrSay.Name = "txtUrSay";
            this.txtUrSay.Size = new System.Drawing.Size(100, 22);
            this.txtUrSay.TabIndex = 4;
            // 
            // chlistSip
            // 
            this.chlistSip.FormattingEnabled = true;
            this.chlistSip.Location = new System.Drawing.Point(192, 191);
            this.chlistSip.Name = "chlistSip";
            this.chlistSip.Size = new System.Drawing.Size(282, 174);
            this.chlistSip.TabIndex = 5;
            // 
            // lblAT
            // 
            this.lblAT.AutoSize = true;
            this.lblAT.Location = new System.Drawing.Point(319, 380);
            this.lblAT.Name = "lblAT";
            this.lblAT.Size = new System.Drawing.Size(85, 17);
            this.lblAT.TabIndex = 6;
            this.lblAT.Text = "Ara Toplam:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(410, 380);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(16, 17);
            this.lblAraToplam.TabIndex = 7;
            this.lblAraToplam.Text = "0";
            // 
            // bttnIptal
            // 
            this.bttnIptal.Location = new System.Drawing.Point(198, 380);
            this.bttnIptal.Name = "bttnIptal";
            this.bttnIptal.Size = new System.Drawing.Size(75, 23);
            this.bttnIptal.TabIndex = 8;
            this.bttnIptal.Text = "İptal Et";
            this.bttnIptal.UseVisualStyleBackColor = true;
            this.bttnIptal.Click += new System.EventHandler(this.bttnIptal_Click);
            // 
            // bttnOdeme
            // 
            this.bttnOdeme.Location = new System.Drawing.Point(237, 162);
            this.bttnOdeme.Name = "bttnOdeme";
            this.bttnOdeme.Size = new System.Drawing.Size(201, 23);
            this.bttnOdeme.TabIndex = 9;
            this.bttnOdeme.Text = "Siparişi Tamamla";
            this.bttnOdeme.UseVisualStyleBackColor = true;
            this.bttnOdeme.Click += new System.EventHandler(this.bttnOdeme_Click_1);
            // 
            // rdNakit
            // 
            this.rdNakit.AutoSize = true;
            this.rdNakit.Location = new System.Drawing.Point(566, 63);
            this.rdNakit.Name = "rdNakit";
            this.rdNakit.Size = new System.Drawing.Size(61, 21);
            this.rdNakit.TabIndex = 11;
            this.rdNakit.TabStop = true;
            this.rdNakit.Text = "Nakit";
            this.rdNakit.UseVisualStyleBackColor = true;
            this.rdNakit.CheckedChanged += new System.EventHandler(this.rdNakit_CheckedChanged);
            // 
            // rdCheck
            // 
            this.rdCheck.AutoSize = true;
            this.rdCheck.Location = new System.Drawing.Point(566, 104);
            this.rdCheck.Name = "rdCheck";
            this.rdCheck.Size = new System.Drawing.Size(53, 21);
            this.rdCheck.TabIndex = 12;
            this.rdCheck.TabStop = true;
            this.rdCheck.Text = "Çek";
            this.rdCheck.UseVisualStyleBackColor = true;
            this.rdCheck.CheckedChanged += new System.EventHandler(this.rdCheck_CheckedChanged);
            // 
            // rdKredi
            // 
            this.rdKredi.AutoSize = true;
            this.rdKredi.Location = new System.Drawing.Point(566, 147);
            this.rdKredi.Name = "rdKredi";
            this.rdKredi.Size = new System.Drawing.Size(95, 21);
            this.rdKredi.TabIndex = 13;
            this.rdKredi.TabStop = true;
            this.rdKredi.Text = "Kredi Kartı";
            this.rdKredi.UseVisualStyleBackColor = true;
            this.rdKredi.CheckedChanged += new System.EventHandler(this.rdKredi_CheckedChanged);
            // 
            // lblTipSec
            // 
            this.lblTipSec.AutoSize = true;
            this.lblTipSec.Location = new System.Drawing.Point(563, 27);
            this.lblTipSec.Name = "lblTipSec";
            this.lblTipSec.Size = new System.Drawing.Size(141, 17);
            this.lblTipSec.TabIndex = 14;
            this.lblTipSec.Text = "Ödeme Tipini Seçiniz";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(708, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 17);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "İsim:";
            // 
            // lblBankID
            // 
            this.lblBankID.AutoSize = true;
            this.lblBankID.Location = new System.Drawing.Point(708, 104);
            this.lblBankID.Name = "lblBankID";
            this.lblBankID.Size = new System.Drawing.Size(57, 17);
            this.lblBankID.TabIndex = 16;
            this.lblBankID.Text = "BankID:";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(708, 151);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(94, 17);
            this.lblNakit.TabIndex = 17;
            this.lblNakit.Text = "Verilen Tutar:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(708, 194);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(60, 17);
            this.lblNumber.TabIndex = 18;
            this.lblNumber.Text = "Kart No:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(708, 244);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(65, 17);
            this.lblTip.TabIndex = 19;
            this.lblTip.Text = "Kart Tipi:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(747, 292);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 17);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Son Kullanma Tarihi";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(798, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 21;
            // 
            // txtBankID
            // 
            this.txtBankID.Location = new System.Drawing.Point(798, 101);
            this.txtBankID.Name = "txtBankID";
            this.txtBankID.Size = new System.Drawing.Size(100, 22);
            this.txtBankID.TabIndex = 22;
            // 
            // txtNakit
            // 
            this.txtNakit.Location = new System.Drawing.Point(798, 148);
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(100, 22);
            this.txtNakit.TabIndex = 23;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(798, 191);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 24;
            // 
            // cboxTip
            // 
            this.cboxTip.FormattingEnabled = true;
            this.cboxTip.Items.AddRange(new object[] {
            "MasterCard",
            "Visa",
            "Maestro"});
            this.cboxTip.Location = new System.Drawing.Point(798, 241);
            this.cboxTip.Name = "cboxTip";
            this.cboxTip.Size = new System.Drawing.Size(100, 24);
            this.cboxTip.TabIndex = 25;
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(750, 322);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(52, 22);
            this.txtAy.TabIndex = 26;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(830, 322);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(52, 22);
            this.txtYil.TabIndex = 27;
            // 
            // lblTaksim
            // 
            this.lblTaksim.AutoSize = true;
            this.lblTaksim.Location = new System.Drawing.Point(808, 322);
            this.lblTaksim.Name = "lblTaksim";
            this.lblTaksim.Size = new System.Drawing.Size(12, 17);
            this.lblTaksim.TabIndex = 28;
            this.lblTaksim.Text = "/";
            // 
            // bttnOnay
            // 
            this.bttnOnay.Location = new System.Drawing.Point(780, 380);
            this.bttnOnay.Name = "bttnOnay";
            this.bttnOnay.Size = new System.Drawing.Size(75, 23);
            this.bttnOnay.TabIndex = 29;
            this.bttnOnay.Text = "Onayla";
            this.bttnOnay.UseVisualStyleBackColor = true;
            this.bttnOnay.Click += new System.EventHandler(this.bttnOnay_Click);
            // 
            // bttnCik
            // 
            this.bttnCik.Location = new System.Drawing.Point(905, 415);
            this.bttnCik.Name = "bttnCik";
            this.bttnCik.Size = new System.Drawing.Size(75, 23);
            this.bttnCik.TabIndex = 30;
            this.bttnCik.Text = "Çıkış";
            this.bttnCik.UseVisualStyleBackColor = true;
            this.bttnCik.Click += new System.EventHandler(this.bttnCik_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.bttnCik);
            this.Controls.Add(this.bttnOnay);
            this.Controls.Add(this.lblTaksim);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.cboxTip);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtNakit);
            this.Controls.Add(this.txtBankID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.lblBankID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTipSec);
            this.Controls.Add(this.rdKredi);
            this.Controls.Add(this.rdCheck);
            this.Controls.Add(this.rdNakit);
            this.Controls.Add(this.bttnOdeme);
            this.Controls.Add(this.bttnIptal);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.lblAT);
            this.Controls.Add(this.chlistSip);
            this.Controls.Add(this.txtUrSay);
            this.Controls.Add(this.lblUrSay);
            this.Controls.Add(this.bttnSip);
            this.Controls.Add(this.lblUrunler);
            this.Controls.Add(this.chlistUrunler);
            this.Name = "Form2";
            this.Text = "Müşteri Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlistUrunler;
        private System.Windows.Forms.Label lblUrunler;
        private System.Windows.Forms.Button bttnSip;
        private System.Windows.Forms.Label lblUrSay;
        private System.Windows.Forms.TextBox txtUrSay;
        private System.Windows.Forms.CheckedListBox chlistSip;
        private System.Windows.Forms.Label lblAT;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Button bttnIptal;
        private System.Windows.Forms.Button bttnOdeme;
        private System.Windows.Forms.RadioButton rdNakit;
        private System.Windows.Forms.RadioButton rdCheck;
        private System.Windows.Forms.RadioButton rdKredi;
        private System.Windows.Forms.Label lblTipSec;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBankID;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBankID;
        private System.Windows.Forms.TextBox txtNakit;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cboxTip;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.Label lblTaksim;
        private System.Windows.Forms.Button bttnOnay;
        private System.Windows.Forms.Button bttnCik;
    }
}