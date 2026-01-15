namespace VeterinerKlinigiOtomasyonu
{
    partial class GirisSecimForm
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
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblHosgeldiniz = new DevExpress.XtraEditors.LabelControl();
            this.btnVeteriner = new DevExpress.XtraEditors.SimpleButton();
            this.btnKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseForeColor = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Location = new System.Drawing.Point(0, 100);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.lblBaslik.Size = new System.Drawing.Size(800, 100);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Tarçın Veteriner Kliniği";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHosgeldiniz.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblHosgeldiniz.Appearance.Options.UseFont = true;
            this.lblHosgeldiniz.Appearance.Options.UseForeColor = true;
            this.lblHosgeldiniz.Appearance.Options.UseTextOptions = true;
            this.lblHosgeldiniz.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHosgeldiniz.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(0, 208);
            this.lblHosgeldiniz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(800, 50);
            this.lblHosgeldiniz.TabIndex = 1;
            this.lblHosgeldiniz.Text = "Hoş Geldiniz, lütfen giriş türünü seçiniz";
            // 
            // btnVeteriner
            // 
            this.btnVeteriner.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnVeteriner.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnVeteriner.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnVeteriner.Appearance.Options.UseBackColor = true;
            this.btnVeteriner.Appearance.Options.UseFont = true;
            this.btnVeteriner.Appearance.Options.UseForeColor = true;
            this.btnVeteriner.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnVeteriner.AppearanceHovered.Options.UseBackColor = true;
            this.btnVeteriner.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnVeteriner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVeteriner.Location = new System.Drawing.Point(134, 280);
            this.btnVeteriner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVeteriner.Name = "btnVeteriner";
            this.btnVeteriner.Size = new System.Drawing.Size(255, 153);
            this.btnVeteriner.TabIndex = 2;
            this.btnVeteriner.Text = "VETERİNER\nGİRİŞİ";
            // 
            // btnKullanici
            // 
            this.btnKullanici.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnKullanici.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnKullanici.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKullanici.Appearance.Options.UseBackColor = true;
            this.btnKullanici.Appearance.Options.UseFont = true;
            this.btnKullanici.Appearance.Options.UseForeColor = true;
            this.btnKullanici.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnKullanici.AppearanceHovered.Options.UseBackColor = true;
            this.btnKullanici.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullanici.Location = new System.Drawing.Point(395, 280);
            this.btnKullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKullanici.Name = "btnKullanici";
            this.btnKullanici.Size = new System.Drawing.Size(255, 153);
            this.btnKullanici.TabIndex = 3;
            this.btnKullanici.Text = "KULLANICI\nGİRİŞİ";
            // 
            // GirisSecimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::VeterinerKlinigiOtomasyonu.Properties.Resources.Gemini_Generated_Image_8k41hw8k41hw8k41;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnKullanici);
            this.Controls.Add(this.btnVeteriner);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "GirisSecimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarçın Veteriner Kliniği - Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.LabelControl lblHosgeldiniz;
        private DevExpress.XtraEditors.SimpleButton btnVeteriner;
        private DevExpress.XtraEditors.SimpleButton btnKullanici;
    }
}
