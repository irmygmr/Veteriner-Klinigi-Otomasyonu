namespace VeterinerKlinigiOtomasyonu
{
    partial class KullaniciKayitForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKayitOl = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnIptal);
            this.groupControl1.Controls.Add(this.btnKayitOl);
            this.groupControl1.Controls.Add(this.txtSifre);
            this.groupControl1.Controls.Add(this.lblSifre);
            this.groupControl1.Controls.Add(this.txtKullaniciAdi);
            this.groupControl1.Controls.Add(this.lblKullaniciAdi);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.lblTelefon);
            this.groupControl1.Controls.Add(this.cmbCinsiyet);
            this.groupControl1.Controls.Add(this.lblCinsiyet);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(432, 453);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kullanıcı Kayıt Formu";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnKayitOl.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKayitOl.Appearance.Options.UseBackColor = true;
            this.btnKayitOl.Appearance.Options.UseFont = true;
            this.btnKayitOl.Appearance.Options.UseForeColor = true;
            this.btnKayitOl.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayitOl.Location = new System.Drawing.Point(220, 330);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(130, 40);
            this.btnKayitOl.TabIndex = 12;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Appearance.Options.UseBackColor = true;
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Appearance.Options.UseForeColor = true;
            this.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Location = new System.Drawing.Point(84, 330);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(130, 40);
            this.btnIptal.TabIndex = 13;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(150, 280);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(200, 30);
            this.txtSifre.TabIndex = 11;
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(30, 283);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(43, 23);
            this.lblSifre.TabIndex = 10;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(150, 230);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 30);
            this.txtKullaniciAdi.TabIndex = 9;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.Appearance.Options.UseFont = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(30, 233);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(106, 23);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(150, 180);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtTelefon.Size = new System.Drawing.Size(200, 30);
            this.txtTelefon.TabIndex = 7;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelefon.Appearance.Options.UseFont = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 183);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(92, 23);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "İletişim No:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(150, 130);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCinsiyet.Properties.Appearance.Options.UseFont = true;
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 30);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCinsiyet.Appearance.Options.UseFont = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(30, 133);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(68, 23);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(150, 80);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            this.txtSoyad.Size = new System.Drawing.Size(200, 30);
            this.txtSoyad.TabIndex = 3;
            // 
            // lblSoyad
            // 
            this.lblSoyad.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoyad.Appearance.Options.UseFont = true;
            this.lblSoyad.Location = new System.Drawing.Point(30, 83);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(82, 23);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyadınız:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(150, 40);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(200, 30);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(30, 43);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(56, 23);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adınız:";
            // 
            // KullaniciKayitForm
            // 
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.groupControl1);
            this.Name = "KullaniciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kayıt";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl lblSoyad;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private DevExpress.XtraEditors.LabelControl lblCinsiyet;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl lblTelefon;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.SimpleButton btnKayitOl;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
    }
}
