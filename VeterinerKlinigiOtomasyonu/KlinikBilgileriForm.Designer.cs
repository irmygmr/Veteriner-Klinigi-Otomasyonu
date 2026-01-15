namespace VeterinerKlinigiOtomasyonu
{
    partial class KlinikBilgileriForm
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
            this.groupKlinik = new DevExpress.XtraEditors.GroupControl();
            this.lblSaatler = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblEmailBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblTel = new DevExpress.XtraEditors.LabelControl();
            this.lblTelBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblAdres = new DevExpress.XtraEditors.LabelControl();
            this.lblAdresBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblKlinikAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupKlinik)).BeginInit();
            this.groupKlinik.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupKlinik
            // 
            this.groupKlinik.Controls.Add(this.lblSaatler);
            this.groupKlinik.Controls.Add(this.lblEmail);
            this.groupKlinik.Controls.Add(this.lblEmailBaslik);
            this.groupKlinik.Controls.Add(this.lblTel);
            this.groupKlinik.Controls.Add(this.lblTelBaslik);
            this.groupKlinik.Controls.Add(this.lblAdres);
            this.groupKlinik.Controls.Add(this.lblAdresBaslik);
            this.groupKlinik.Controls.Add(this.lblKlinikAdi);
            this.groupKlinik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKlinik.Location = new System.Drawing.Point(27, 25);
            this.groupKlinik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupKlinik.Name = "groupKlinik";
            this.groupKlinik.Size = new System.Drawing.Size(613, 442);
            this.groupKlinik.TabIndex = 0;
            this.groupKlinik.Text = "Klinik İletişim Bilgileri";
            // 
            // lblSaatler
            // 
            this.lblSaatler.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSaatler.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblSaatler.Appearance.Options.UseFont = true;
            this.lblSaatler.Appearance.Options.UseForeColor = true;
            this.lblSaatler.Appearance.Options.UseTextOptions = true;
            this.lblSaatler.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSaatler.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSaatler.Location = new System.Drawing.Point(40, 345);
            this.lblSaatler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSaatler.Name = "lblSaatler";
            this.lblSaatler.Size = new System.Drawing.Size(533, 49);
            this.lblSaatler.TabIndex = 7;
            this.lblSaatler.Text = "Çalışma Saatleri: Hafta içi 09:00 - 18:00\r\nHafta sonu: 10:00 - 16:00 (Pazar Kapal" +
    "ı)";
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 283);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "bilgi@tarcinvet.com.tr";
            // 
            // lblEmailBaslik
            // 
            this.lblEmailBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailBaslik.Appearance.Options.UseFont = true;
            this.lblEmailBaslik.Location = new System.Drawing.Point(40, 258);
            this.lblEmailBaslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEmailBaslik.Name = "lblEmailBaslik";
            this.lblEmailBaslik.Size = new System.Drawing.Size(64, 23);
            this.lblEmailBaslik.TabIndex = 5;
            this.lblEmailBaslik.Text = "E-Posta:";
            // 
            // lblTel
            // 
            this.lblTel.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTel.Appearance.Options.UseFont = true;
            this.lblTel.Location = new System.Drawing.Point(40, 222);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(129, 23);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "0 (216) 123 45 67";
            // 
            // lblTelBaslik
            // 
            this.lblTelBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelBaslik.Appearance.Options.UseFont = true;
            this.lblTelBaslik.Location = new System.Drawing.Point(40, 197);
            this.lblTelBaslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTelBaslik.Name = "lblTelBaslik";
            this.lblTelBaslik.Size = new System.Drawing.Size(65, 23);
            this.lblTelBaslik.TabIndex = 3;
            this.lblTelBaslik.Text = "Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAdres.Appearance.Options.UseFont = true;
            this.lblAdres.Location = new System.Drawing.Point(40, 135);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(309, 46);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Cumhuriyet Mah. Atatürk Cad. No:123/A\r\nKadıköy / İSTANBUL";
            // 
            // lblAdresBaslik
            // 
            this.lblAdresBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdresBaslik.Appearance.Options.UseFont = true;
            this.lblAdresBaslik.Location = new System.Drawing.Point(40, 111);
            this.lblAdresBaslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAdresBaslik.Name = "lblAdresBaslik";
            this.lblAdresBaslik.Size = new System.Drawing.Size(51, 23);
            this.lblAdresBaslik.TabIndex = 1;
            this.lblAdresBaslik.Text = "Adres:";
            // 
            // lblKlinikAdi
            // 
            this.lblKlinikAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblKlinikAdi.Appearance.ForeColor = System.Drawing.Color.Teal;
            this.lblKlinikAdi.Appearance.Options.UseFont = true;
            this.lblKlinikAdi.Appearance.Options.UseForeColor = true;
            this.lblKlinikAdi.Location = new System.Drawing.Point(40, 49);
            this.lblKlinikAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblKlinikAdi.Name = "lblKlinikAdi";
            this.lblKlinikAdi.Size = new System.Drawing.Size(296, 37);
            this.lblKlinikAdi.TabIndex = 0;
            this.lblKlinikAdi.Text = "Tarçın Veteriner Kliniği";
            // 
            // KlinikBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(667, 492);
            this.Controls.Add(this.groupKlinik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KlinikBilgileriForm";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Klinik Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.groupKlinik)).EndInit();
            this.groupKlinik.ResumeLayout(false);
            this.groupKlinik.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupKlinik;
        private DevExpress.XtraEditors.LabelControl lblKlinikAdi;
        private DevExpress.XtraEditors.LabelControl lblAdresBaslik;
        private DevExpress.XtraEditors.LabelControl lblAdres;
        private DevExpress.XtraEditors.LabelControl lblTelBaslik;
        private DevExpress.XtraEditors.LabelControl lblTel;
        private DevExpress.XtraEditors.LabelControl lblEmailBaslik;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblSaatler;
    }
}
