namespace VeterinerKlinigiOtomasyonu
{
    partial class ProfilForm
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
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.btnHayvanEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.lblSoyad = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridHayvanlar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAdP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsiyetP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.btnHayvanEkle);
            this.groupControl1.Controls.Add(this.lblTelefon);
            this.groupControl1.Controls.Add(this.cmbCinsiyet);
            this.groupControl1.Controls.Add(this.lblCinsiyet);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.lblSoyad);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.lblAd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1073, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Kullanıcı Bilgileri";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(375, 40);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(150, 170);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "BİLGİLERİ\nGÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            // btnHayvanEkle
            // 
            this.btnHayvanEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnHayvanEkle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHayvanEkle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnHayvanEkle.Appearance.Options.UseBackColor = true;
            this.btnHayvanEkle.Appearance.Options.UseFont = true;
            this.btnHayvanEkle.Appearance.Options.UseForeColor = true;
            this.btnHayvanEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnHayvanEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHayvanEkle.Location = new System.Drawing.Point(591, 83);
            this.btnHayvanEkle.Name = "btnHayvanEkle";
            this.btnHayvanEkle.Size = new System.Drawing.Size(262, 57);
            this.btnHayvanEkle.TabIndex = 1;
            this.btnHayvanEkle.Text = "+ Hayvan Ekle";
            this.btnHayvanEkle.Click += new System.EventHandler(this.btnHayvanEkle_Click);
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
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.gridHayvanlar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 250);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1073, 317);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Sahip Olduğunuz Hayvanlar";
            // 
            // gridHayvanlar
            // 
            this.gridHayvanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHayvanlar.Location = new System.Drawing.Point(2, 37);
            this.gridHayvanlar.MainView = this.gridView1;
            this.gridHayvanlar.Name = "gridHayvanlar";
            this.gridHayvanlar.Size = new System.Drawing.Size(1069, 278);
            this.gridHayvanlar.TabIndex = 0;
            this.gridHayvanlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdP,
            this.colTurP,
            this.colCinsiyetP});
            this.gridView1.GridControl = this.gridHayvanlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAdP
            // 
            this.colAdP.Caption = "Hayvan Adı";
            this.colAdP.FieldName = "Hayvan Adı";
            this.colAdP.Name = "colAdP";
            this.colAdP.Visible = true;
            this.colAdP.VisibleIndex = 0;
            // 
            // colTurP
            // 
            this.colTurP.Caption = "Tür";
            this.colTurP.FieldName = "Tur";
            this.colTurP.Name = "colTurP";
            this.colTurP.Visible = true;
            this.colTurP.VisibleIndex = 1;
            // 
            // colCinsiyetP
            // 
            this.colCinsiyetP.Caption = "Cinsiyet";
            this.colCinsiyetP.FieldName = "Cinsiyet";
            this.colCinsiyetP.Name = "colCinsiyetP";
            this.colCinsiyetP.Visible = true;
            this.colCinsiyetP.VisibleIndex = 2;
            // 
            // ProfilForm
            // 
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(1073, 567);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ProfilForm";
            this.Text = "Profilim";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridHayvanlar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnHayvanEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraGrid.Columns.GridColumn colAdP;
        private DevExpress.XtraGrid.Columns.GridColumn colTurP;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsiyetP;
    }
}
