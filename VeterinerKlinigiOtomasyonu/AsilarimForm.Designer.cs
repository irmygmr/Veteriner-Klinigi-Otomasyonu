namespace VeterinerKlinigiOtomasyonu
{
    partial class AsilarimForm
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
            this.tabControlAsilar = new DevExpress.XtraTab.XtraTabControl();
            this.tabAktif = new DevExpress.XtraTab.XtraTabPage();
            this.gridAktif = new DevExpress.XtraGrid.GridControl();
            this.viewAktif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHayvanAdiA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsiAdiA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarihA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabGecmis = new DevExpress.XtraTab.XtraTabPage();
            this.gridGecmis = new DevExpress.XtraGrid.GridControl();
            this.viewGecmis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHayvanAdiG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsiAdiG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarihG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurumG = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAsilar)).BeginInit();
            this.tabControlAsilar.SuspendLayout();
            this.tabAktif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAktif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAktif)).BeginInit();
            this.tabGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAsilar
            // 
            this.tabControlAsilar.AppearancePage.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControlAsilar.AppearancePage.Header.Options.UseFont = true;
            this.tabControlAsilar.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabControlAsilar.AppearancePage.HeaderActive.Options.UseFont = true;
            this.tabControlAsilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAsilar.Location = new System.Drawing.Point(0, 0);
            this.tabControlAsilar.Name = "tabControlAsilar";
            this.tabControlAsilar.SelectedTabPage = this.tabAktif;
            this.tabControlAsilar.Size = new System.Drawing.Size(900, 550);
            this.tabControlAsilar.TabIndex = 0;
            this.tabControlAsilar.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAktif,
            this.tabGecmis});
            // 
            // tabAktif
            // 
            this.tabAktif.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tabAktif.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabAktif.Appearance.Header.Options.UseBackColor = true;
            this.tabAktif.Appearance.Header.Options.UseForeColor = true;
            this.tabAktif.Appearance.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.tabAktif.Appearance.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.tabAktif.Appearance.HeaderActive.Options.UseBackColor = true;
            this.tabAktif.Appearance.HeaderActive.Options.UseForeColor = true;
            this.tabAktif.Controls.Add(this.gridAktif);
            this.tabAktif.Name = "tabAktif";
            this.tabAktif.Size = new System.Drawing.Size(898, 517);
            this.tabAktif.Text = "AKTİF / GELECEK AŞILAR";
            // 
            // gridAktif
            // 
            this.gridAktif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAktif.Location = new System.Drawing.Point(0, 0);
            this.gridAktif.MainView = this.viewAktif;
            this.gridAktif.Name = "gridAktif";
            this.gridAktif.Size = new System.Drawing.Size(898, 517);
            this.gridAktif.TabIndex = 0;
            this.gridAktif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAktif});
            // 
            // viewAktif
            // 
            this.viewAktif.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.viewAktif.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewAktif.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewAktif.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewAktif.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewAktif.Appearance.Row.Options.UseFont = true;
            this.viewAktif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHayvanAdiA,
            this.colAsiAdiA,
            this.colTarihA,
            this.colDurumA});
            this.viewAktif.GridControl = this.gridAktif;
            this.viewAktif.Name = "viewAktif";
            this.viewAktif.OptionsBehavior.Editable = false;
            this.viewAktif.OptionsView.ShowGroupPanel = false;
            this.viewAktif.OptionsView.ShowIndicator = false;
            // 
            // colHayvanAdiA
            // 
            this.colHayvanAdiA.Caption = "Hayvan Adı";
            this.colHayvanAdiA.FieldName = "HayvanAdi";
            this.colHayvanAdiA.Name = "colHayvanAdiA";
            this.colHayvanAdiA.Visible = true;
            this.colHayvanAdiA.VisibleIndex = 0;
            // 
            // colAsiAdiA
            // 
            this.colAsiAdiA.Caption = "Aşı Adı";
            this.colAsiAdiA.FieldName = "AsiAdi";
            this.colAsiAdiA.Name = "colAsiAdiA";
            this.colAsiAdiA.Visible = true;
            this.colAsiAdiA.VisibleIndex = 1;
            // 
            // colTarihA
            // 
            this.colTarihA.Caption = "Tarih";
            this.colTarihA.FieldName = "Tarih";
            this.colTarihA.Name = "colTarihA";
            this.colTarihA.Visible = true;
            this.colTarihA.VisibleIndex = 2;
            // 
            // colDurumA
            // 
            this.colDurumA.Caption = "Durum";
            this.colDurumA.FieldName = "Durum";
            this.colDurumA.Name = "colDurumA";
            this.colDurumA.Visible = true;
            this.colDurumA.VisibleIndex = 3;
            // 
            // tabGecmis
            // 
            this.tabGecmis.Appearance.Header.BackColor = System.Drawing.Color.Gray;
            this.tabGecmis.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabGecmis.Appearance.Header.Options.UseBackColor = true;
            this.tabGecmis.Appearance.Header.Options.UseForeColor = true;
            this.tabGecmis.Appearance.HeaderActive.BackColor = System.Drawing.Color.Gray;
            this.tabGecmis.Appearance.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.tabGecmis.Appearance.HeaderActive.Options.UseBackColor = true;
            this.tabGecmis.Appearance.HeaderActive.Options.UseForeColor = true;
            this.tabGecmis.Controls.Add(this.gridGecmis);
            this.tabGecmis.Name = "tabGecmis";
            this.tabGecmis.Size = new System.Drawing.Size(898, 517);
            this.tabGecmis.Text = "GEÇMİŞ AŞILAR";
            // 
            // gridGecmis
            // 
            this.gridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGecmis.Location = new System.Drawing.Point(0, 0);
            this.gridGecmis.MainView = this.viewGecmis;
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.Size = new System.Drawing.Size(898, 517);
            this.gridGecmis.TabIndex = 0;
            this.gridGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGecmis});
            // 
            // viewGecmis
            // 
            this.viewGecmis.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.viewGecmis.Appearance.HeaderPanel.Options.UseFont = true;
            this.viewGecmis.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.viewGecmis.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.viewGecmis.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewGecmis.Appearance.Row.Options.UseFont = true;
            this.viewGecmis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHayvanAdiG,
            this.colAsiAdiG,
            this.colTarihG,
            this.colDurumG});
            this.viewGecmis.GridControl = this.gridGecmis;
            this.viewGecmis.Name = "viewGecmis";
            this.viewGecmis.OptionsBehavior.Editable = false;
            this.viewGecmis.OptionsView.ShowGroupPanel = false;
            this.viewGecmis.OptionsView.ShowIndicator = false;
            // 
            // colHayvanAdiG
            // 
            this.colHayvanAdiG.Caption = "Hayvan Adı";
            this.colHayvanAdiG.FieldName = "HayvanAdi";
            this.colHayvanAdiG.Name = "colHayvanAdiG";
            this.colHayvanAdiG.Visible = true;
            this.colHayvanAdiG.VisibleIndex = 0;
            // 
            // colAsiAdiG
            // 
            this.colAsiAdiG.Caption = "Aşı Adı";
            this.colAsiAdiG.FieldName = "AsiAdi";
            this.colAsiAdiG.Name = "colAsiAdiG";
            this.colAsiAdiG.Visible = true;
            this.colAsiAdiG.VisibleIndex = 1;
            // 
            // colTarihG
            // 
            this.colTarihG.Caption = "Tarih";
            this.colTarihG.FieldName = "Tarih";
            this.colTarihG.Name = "colTarihG";
            this.colTarihG.Visible = true;
            this.colTarihG.VisibleIndex = 2;
            // 
            // colDurumG
            // 
            this.colDurumG.Caption = "Durum";
            this.colDurumG.FieldName = "Durum";
            this.colDurumG.Name = "colDurumG";
            this.colDurumG.Visible = true;
            this.colDurumG.VisibleIndex = 3;
            // 
            // AsilarimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.tabControlAsilar);
            this.Name = "AsilarimForm";
            this.Text = "Aşı Takvimi";
            this.Load += new System.EventHandler(this.AsilarimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAsilar)).EndInit();
            this.tabControlAsilar.ResumeLayout(false);
            this.tabAktif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAktif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAktif)).EndInit();
            this.tabGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabControlAsilar;
        private DevExpress.XtraTab.XtraTabPage tabAktif;
        private DevExpress.XtraTab.XtraTabPage tabGecmis;
        private DevExpress.XtraGrid.GridControl gridAktif;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAktif;
        private DevExpress.XtraGrid.GridControl gridGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView viewGecmis;
        private DevExpress.XtraGrid.Columns.GridColumn colHayvanAdiA;
        private DevExpress.XtraGrid.Columns.GridColumn colAsiAdiA;
        private DevExpress.XtraGrid.Columns.GridColumn colTarihA;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumA;
        private DevExpress.XtraGrid.Columns.GridColumn colHayvanAdiG;
        private DevExpress.XtraGrid.Columns.GridColumn colAsiAdiG;
        private DevExpress.XtraGrid.Columns.GridColumn colTarihG;
        private DevExpress.XtraGrid.Columns.GridColumn colDurumG;
    }
}
