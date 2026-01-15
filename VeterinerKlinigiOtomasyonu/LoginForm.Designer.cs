namespace VeterinerKlinigiOtomasyonu
{
    partial class LoginForm
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
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.lblSifre = new DevExpress.XtraEditors.LabelControl();
            this.btnKayitOl = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.rbKullanici = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(118, 237);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.AutoHeight = false;
            this.txtKullanici.Size = new System.Drawing.Size(280, 30);
            this.txtKullanici.TabIndex = 0;
            this.txtKullanici.EditValueChanged += new System.EventHandler(this.txtKullanici_EditValueChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(118, 273);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.AutoHeight = false;
            this.txtSifre.Properties.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(280, 30);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGiris.Location = new System.Drawing.Point(118, 350);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(280, 40);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Location = new System.Drawing.Point(187, 177);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(125, 41);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Giriş Yap";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKullanici.Appearance.Options.UseFont = true;
            this.lblKullanici.Location = new System.Drawing.Point(19, 240);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(93, 23);
            this.lblKullanici.TabIndex = 4;
            this.lblKullanici.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSifre.Appearance.Options.UseFont = true;
            this.lblSifre.Location = new System.Drawing.Point(79, 276);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(33, 23);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKayitOl.Appearance.Options.UseFont = true;
            this.btnKayitOl.Location = new System.Drawing.Point(118, 400);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(280, 40);
            this.btnKayitOl.TabIndex = 8;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Appearance.Options.UseForeColor = true;
            this.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnIptal.Location = new System.Drawing.Point(404, 12);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // rbKullanici
            // 
            this.rbKullanici.AutoSize = true;
            this.rbKullanici.BackColor = System.Drawing.Color.Transparent;
            this.rbKullanici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbKullanici.Location = new System.Drawing.Point(250, 315);
            this.rbKullanici.Name = "rbKullanici";
            this.rbKullanici.Size = new System.Drawing.Size(94, 27);
            this.rbKullanici.TabIndex = 7;
            this.rbKullanici.Text = "Kullanıcı";
            this.rbKullanici.UseVisualStyleBackColor = false;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rbAdmin.Checked = true;
            this.rbAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbAdmin.Location = new System.Drawing.Point(130, 315);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(90, 27);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Yönetici";
            this.rbAdmin.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.Gemini_Generated_Image_hs6cnphs6cnphs6c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(516, 523);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.rbKullanici);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veteriner Kliniği - Giriş";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl lblKullanici;
        private DevExpress.XtraEditors.LabelControl lblSifre;
        private DevExpress.XtraEditors.SimpleButton btnKayitOl;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        public System.Windows.Forms.RadioButton rbKullanici;
        public System.Windows.Forms.RadioButton rbAdmin;
    }
}