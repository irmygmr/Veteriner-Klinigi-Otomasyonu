namespace VeterinerKlinigiOtomasyonu
{
    partial class HastaForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.colAd = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAd = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFotograf = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colFotograf = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSahibi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSahibi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnYeniKayit = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSahibi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 74);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(933, 480);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(200, 290);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colAd,
            this.colFotograf,
            this.colSahibi});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colAd,
            this.layoutViewField_colFotograf,
            this.layoutViewField_colSahibi});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // colAd
            // 
            this.colAd.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.colAd.AppearanceCell.Options.UseFont = true;
            this.colAd.AppearanceCell.Options.UseTextOptions = true;
            this.colAd.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAd.Caption = "Ad";
            this.colAd.FieldName = "Ad";
            this.colAd.LayoutViewField = this.layoutViewField_colAd;
            this.colAd.Name = "colAd";
            this.colAd.OptionsColumn.AllowEdit = false;
            this.colAd.Visible = true;
            // 
            // layoutViewField_colAd
            // 
            this.layoutViewField_colAd.EditorPreferredWidth = 200;
            this.layoutViewField_colAd.Location = new System.Drawing.Point(0, 200);
            this.layoutViewField_colAd.Name = "layoutViewField_colAd";
            this.layoutViewField_colAd.Size = new System.Drawing.Size(200, 40);
            this.layoutViewField_colAd.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colAd.TextVisible = false;
            // 
            // colFotograf
            // 
            this.colFotograf.Caption = "Fotoğraf";
            this.colFotograf.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colFotograf.FieldName = "Fotograf";
            this.colFotograf.LayoutViewField = this.layoutViewField_colFotograf;
            this.colFotograf.Name = "colFotograf";
            this.colFotograf.OptionsColumn.AllowEdit = false;
            this.colFotograf.Visible = true;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // layoutViewField_colFotograf
            // 
            this.layoutViewField_colFotograf.EditorPreferredWidth = 200;
            this.layoutViewField_colFotograf.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colFotograf.Name = "layoutViewField_colFotograf";
            this.layoutViewField_colFotograf.Size = new System.Drawing.Size(200, 200);
            this.layoutViewField_colFotograf.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colFotograf.TextVisible = false;
            // 
            // colSahibi
            // 
            this.colSahibi.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colSahibi.AppearanceCell.Options.UseFont = true;
            this.colSahibi.AppearanceCell.Options.UseTextOptions = true;
            this.colSahibi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSahibi.Caption = "Sahibinin Adı";
            this.colSahibi.FieldName = "Sahibi";
            this.colSahibi.LayoutViewField = this.layoutViewField_colSahibi;
            this.colSahibi.Name = "colSahibi";
            this.colSahibi.OptionsColumn.AllowEdit = false;
            this.colSahibi.Visible = true;
            // 
            // layoutViewField_colSahibi
            // 
            this.layoutViewField_colSahibi.EditorPreferredWidth = 200;
            this.layoutViewField_colSahibi.Location = new System.Drawing.Point(0, 240);
            this.layoutViewField_colSahibi.Name = "layoutViewField_colSahibi";
            this.layoutViewField_colSahibi.Size = new System.Drawing.Size(200, 40);
            this.layoutViewField_colSahibi.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_colSahibi.TextVisible = false;
            // 
             // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnYeniKayit);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(933, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnYeniKayit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnYeniKayit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnYeniKayit.Appearance.Options.UseBackColor = true;
            this.btnYeniKayit.Appearance.Options.UseFont = true;
            this.btnYeniKayit.Appearance.Options.UseForeColor = true;
            this.btnYeniKayit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnYeniKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniKayit.ImageOptions.Image = null;
            this.btnYeniKayit.Location = new System.Drawing.Point(14, 18);
            this.btnYeniKayit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(120, 40);
            this.btnYeniKayit.TabIndex = 0;
            this.btnYeniKayit.Text = "YENİ KAYIT";
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Location = new System.Drawing.Point(140, 18);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(266, 18);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 40);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HastaForm";
            this.Text = "Hasta Kayıt ve Listesi";
            this.Load += new System.EventHandler(this.HastaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSahibi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAd;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAd;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFotograf;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFotograf;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSahibi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSahibi;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYeniKayit;
    }
}
