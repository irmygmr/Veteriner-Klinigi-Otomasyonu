namespace VeterinerKlinigiOtomasyonu
{
    partial class KayitFormu
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
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtTur = new DevExpress.XtraEditors.TextEdit();
            this.txtSahip = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.lblTur = new DevExpress.XtraEditors.LabelControl();
            this.lblSahip = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSahip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(20, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            this.txtAd.Size = new System.Drawing.Size(340, 32);
            this.txtAd.TabIndex = 0;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(20, 115);
            this.txtTur.Name = "txtTur";
            this.txtTur.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTur.Properties.Appearance.Options.UseFont = true;
            this.txtTur.Size = new System.Drawing.Size(340, 32);
            this.txtTur.TabIndex = 1;
            // 
            // txtSahip
            // 
            this.txtSahip.Location = new System.Drawing.Point(20, 185);
            this.txtSahip.Name = "txtSahip";
            this.txtSahip.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSahip.Properties.Appearance.Options.UseFont = true;
            this.txtSahip.Size = new System.Drawing.Size(340, 32);
            this.txtSahip.TabIndex = 2;
            // 
            // lblAd
            // 
            this.lblAd.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAd.Appearance.Options.UseFont = true;
            this.lblAd.Location = new System.Drawing.Point(20, 20);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(86, 23);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Hayvan Adı";
            // 
            // lblTur
            // 
            this.lblTur.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTur.Appearance.Options.UseFont = true;
            this.lblTur.Location = new System.Drawing.Point(20, 90);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(88, 23);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Türü / Cinsi";
            // 
            // lblSahip
            // 
            this.lblSahip.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSahip.Appearance.Options.UseFont = true;
            this.lblSahip.Location = new System.Drawing.Point(20, 160);
            this.lblSahip.Name = "lblSahip";
            this.lblSahip.Size = new System.Drawing.Size(46, 23);
            this.lblSahip.TabIndex = 5;
            this.lblSahip.Text = "Sahibi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKaydet.Location = new System.Drawing.Point(20, 310);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(340, 45);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(20, 255);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbCinsiyet.Properties.Appearance.Options.UseFont = true;
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cmbCinsiyet.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbCinsiyet.Size = new System.Drawing.Size(340, 32);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCinsiyet.Appearance.Options.UseFont = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(20, 230);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(59, 23);
            this.lblCinsiyet.TabIndex = 8;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(400, 45);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(200, 200);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 9;
            this.pbResim.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnResimSec.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnResimSec.Appearance.Options.UseBackColor = true;
            this.btnResimSec.Appearance.Options.UseForeColor = true;
            this.btnResimSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnResimSec.Location = new System.Drawing.Point(400, 260);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(200, 32);
            this.btnResimSec.TabIndex = 10;
            this.btnResimSec.Text = "Fotoğraf Seç";
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // KayitFormu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblSahip);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtSahip);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "KayitFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Hasta Kaydı";
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSahip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtTur;
        private DevExpress.XtraEditors.TextEdit txtSahip;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.LabelControl lblTur;
        private DevExpress.XtraEditors.LabelControl lblSahip;
        private DevExpress.XtraEditors.LabelControl lblCinsiyet;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.PictureBox pbResim;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
    }
}