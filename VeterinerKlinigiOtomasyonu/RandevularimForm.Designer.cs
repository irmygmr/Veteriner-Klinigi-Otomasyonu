namespace VeterinerKlinigiOtomasyonu
{
    partial class RandevularimForm
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
            this.tabControlRandevular = new DevExpress.XtraTab.XtraTabControl();
            this.tabAktif = new DevExpress.XtraTab.XtraTabPage();
            this.lblMesaj = new DevExpress.XtraEditors.LabelControl();
            this.gridAktif = new DevExpress.XtraGrid.GridControl();
            this.viewAktif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarihA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHayvanA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklamaA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIptal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtnIptal = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.tabGecmis = new DevExpress.XtraTab.XtraTabPage();
            this.gridGecmis = new DevExpress.XtraGrid.GridControl();
            this.viewGecmis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarihG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHayvanG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklamaG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumG = new DevExpress.XtraGrid.Columns.GridColumn(); // New Status Column for Past appointments
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRandevular)).BeginInit();
            this.tabControlRandevular.SuspendLayout();
            this.tabAktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnIptal)).BeginInit();
            this.tabGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControlRandevular
            // 
            this.tabControlRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRandevular.Location = new System.Drawing.Point(0, 0);
            this.tabControlRandevular.Name = "tabControlRandevular";
            this.tabControlRandevular.SelectedTabPage = this.tabAktif;
            this.tabControlRandevular.Size = new System.Drawing.Size(1130, 600);
            this.tabControlRandevular.TabIndex = 0;
            this.tabControlRandevular.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAktif,
            this.tabGecmis});
            // 
            // tabAktif
            // 
            this.tabAktif.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96))))); // Green
            this.tabAktif.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabAktif.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabAktif.Appearance.Header.Options.UseBackColor = true;
            this.tabAktif.Appearance.Header.Options.UseFont = true;
            this.tabAktif.Appearance.Header.Options.UseForeColor = true;
            this.tabAktif.Controls.Add(this.lblMesaj);
            this.tabAktif.Controls.Add(this.gridAktif);
            this.tabAktif.Name = "tabAktif";
            this.tabAktif.Size = new System.Drawing.Size(1124, 566);
            this.tabAktif.Text = "AKTİF / GELECEK RANDEVULARIM";
            // 
            // lblMesaj
            // 
            this.lblMesaj.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMesaj.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblMesaj.Appearance.Options.UseFont = true;
            this.lblMesaj.Appearance.Options.UseForeColor = true;
            this.lblMesaj.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMesaj.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMesaj.Location = new System.Drawing.Point(2, 23);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(1120, 269);
            this.lblMesaj.TabIndex = 1;
            this.lblMesaj.Text = "Aktif randevunuz bulunmamaktadır.";
            this.lblMesaj.Visible = false;
            // 
            // gridAktif
            // 
            this.gridAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAktif.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridAktif.Location = new System.Drawing.Point(2, 23);
            this.gridAktif.MainView = this.viewAktif;
            this.gridAktif.Margin = new System.Windows.Forms.Padding(4);
            this.gridAktif.Name = "gridAktif";
            this.gridAktif.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnIptal});
            this.gridAktif.Size = new System.Drawing.Size(1120, 269);
            this.gridAktif.TabIndex = 0;
            this.gridAktif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAktif});
            // 
            // viewAktif
            // 
            this.viewAktif.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.viewAktif.Appearance.Row.Options.UseBackColor = true;
            this.viewAktif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdA,
            this.colTarihA,
            this.colHayvanA,
            this.colAciklamaA,
            this.colIptal,
            this.colDurumA});
            this.viewAktif.DetailHeight = 431;
            this.viewAktif.GridControl = this.gridAktif;
            this.viewAktif.Name = "viewAktif";
            this.viewAktif.OptionsBehavior.Editable = true;
            this.viewAktif.OptionsView.ShowGroupPanel = false;
            // 
            // colIdA
            // 
            this.colIdA.Caption = "Id";
            this.colIdA.FieldName = "Id";
            this.colIdA.Name = "colIdA";
            // 
            // colTarihA
            // 
            this.colTarihA.Caption = "Tarih";
            this.colTarihA.DisplayFormat.FormatString = "g";
            this.colTarihA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarihA.FieldName = "Tarih";
            this.colTarihA.MinWidth = 27;
            this.colTarihA.Name = "colTarihA";
            this.colTarihA.OptionsColumn.AllowEdit = false;
            this.colTarihA.Visible = true;
            this.colTarihA.VisibleIndex = 0;
            this.colTarihA.Width = 100;
            // 
            // colHayvanA
            // 
            this.colHayvanA.Caption = "Hayvan";
            this.colHayvanA.FieldName = "Hayvan";
            this.colHayvanA.MinWidth = 27;
            this.colHayvanA.Name = "colHayvanA";
            this.colHayvanA.OptionsColumn.AllowEdit = false;
            this.colHayvanA.Visible = true;
            this.colHayvanA.VisibleIndex = 1;
            this.colHayvanA.Width = 100;
            // 
            // colAciklamaA
            // 
            this.colAciklamaA.Caption = "Açıklama";
            this.colAciklamaA.FieldName = "Aciklama";
            this.colAciklamaA.MinWidth = 27;
            this.colAciklamaA.Name = "colAciklamaA";
            this.colAciklamaA.OptionsColumn.AllowEdit = false;
            this.colAciklamaA.Visible = true;
            this.colAciklamaA.VisibleIndex = 2;
            this.colAciklamaA.Width = 100;
            // 
            // colIptal
            // 
            this.colIptal.Caption = "İşlem";
            this.colIptal.ColumnEdit = this.repoBtnIptal;
            this.colIptal.Name = "colIptal";
            this.colIptal.Visible = true;
            this.colIptal.VisibleIndex = 3;
            this.colIptal.Width = 70;
            // 
            // colDurumA
            // 
            this.colDurumA.Caption = "Durum";
            this.colDurumA.FieldName = "Durum";
            this.colDurumA.Name = "colDurumA";
            // Debug için görünür yapıyoruz
            this.colDurumA.Visible = true;
            this.colDurumA.VisibleIndex = 4;
            // 
            // repoBtnIptal
            // 
            this.repoBtnIptal.AutoHeight = false;
            this.repoBtnIptal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repoBtnIptal.Name = "repoBtnIptal";
            this.repoBtnIptal.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtnIptal.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtnIptal_ButtonClick);
            // 
            // tabGecmis
            // 
            this.tabGecmis.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141))))); // Gray
            this.tabGecmis.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabGecmis.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabGecmis.Appearance.Header.Options.UseBackColor = true;
            this.tabGecmis.Appearance.Header.Options.UseFont = true;
            this.tabGecmis.Appearance.Header.Options.UseForeColor = true;
            this.tabGecmis.Controls.Add(this.gridGecmis);
            this.tabGecmis.Name = "tabGecmis";
            this.tabGecmis.Size = new System.Drawing.Size(1124, 566);
            this.tabGecmis.Text = "GEÇMİŞ RANDEVULARIM";
            // 
            // gridGecmis
            // 
            this.gridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGecmis.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridGecmis.Location = new System.Drawing.Point(2, 25);
            this.gridGecmis.MainView = this.viewGecmis;
            this.gridGecmis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.Size = new System.Drawing.Size(1118, 265);
            this.gridGecmis.TabIndex = 0;
            this.gridGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGecmis});
            // 
            // viewGecmis
            // 
            this.viewGecmis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarihG,
            this.colHayvanG,
            this.colAciklamaG});
            this.viewGecmis.DetailHeight = 431;
            this.viewGecmis.GridControl = this.gridGecmis;
            this.viewGecmis.Name = "viewGecmis";
            this.viewGecmis.OptionsBehavior.Editable = false;
            this.viewGecmis.OptionsView.ShowGroupPanel = false;
            // 
            // colTarihG
            // 
            this.colTarihG.Caption = "Tarih";
            this.colTarihG.DisplayFormat.FormatString = "g";
            this.colTarihG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarihG.FieldName = "Tarih";
            this.colTarihG.MinWidth = 27;
            this.colTarihG.Name = "colTarihG";
            this.colTarihG.Visible = true;
            this.colTarihG.VisibleIndex = 0;
            this.colTarihG.Width = 100;
            // 
            // colHayvanG
            // 
            this.colHayvanG.Caption = "Hayvan";
            this.colHayvanG.FieldName = "Hayvan";
            this.colHayvanG.MinWidth = 27;
            this.colHayvanG.Name = "colHayvanG";
            this.colHayvanG.Visible = true;
            this.colHayvanG.VisibleIndex = 1;
            this.colHayvanG.Width = 100;
            // 
            // colAciklamaG
            // 
            this.colAciklamaG.Caption = "Açıklama";
            this.colAciklamaG.FieldName = "Aciklama";
            this.colAciklamaG.MinWidth = 27;
            this.colAciklamaG.Name = "colAciklamaG";
            this.colAciklamaG.Visible = true;
            this.colAciklamaG.VisibleIndex = 2;
            this.colAciklamaG.Width = 100;
            // 
            // RandevularimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 600);
            this.Controls.Add(this.tabControlRandevular);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RandevularimForm";
            this.Text = "Randevularım";
            this.Load += new System.EventHandler(this.RandevularimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRandevular)).EndInit();
            this.tabControlRandevular.ResumeLayout(false);
            this.tabAktif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnIptal)).EndInit();
            this.tabGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlRandevular;
        private DevExpress.XtraTab.XtraTabPage tabAktif;
        private DevExpress.XtraGrid.GridControl gridAktif;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAktif;
        private DevExpress.XtraGrid.Columns.GridColumn colIdA;
        private DevExpress.XtraEditors.LabelControl lblMesaj;
        private DevExpress.XtraTab.XtraTabPage tabGecmis;
        private DevExpress.XtraGrid.GridControl gridGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView viewGecmis;
        private DevExpress.XtraGrid.Columns.GridColumn colTarihA;
        private DevExpress.XtraGrid.Columns.GridColumn colHayvanA;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklamaA;
        private DevExpress.XtraGrid.Columns.GridColumn colIptal;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumA; // Added Durum (Active)
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnIptal;
        private DevExpress.XtraGrid.Columns.GridColumn colTarihG;
        private DevExpress.XtraGrid.Columns.GridColumn colHayvanG;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklamaG;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumG;
    }
}
