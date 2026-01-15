namespace VeterinerKlinigiOtomasyonu
{
    partial class AsiForm
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
            this.components = new System.ComponentModel.Container();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHayvanAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAsiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOnayla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtnOnayla = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAsiKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dateGelecek = new DevExpress.XtraEditors.DateEdit();
            this.dateYapilma = new DevExpress.XtraEditors.DateEdit();
            this.txtAsiAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();

            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnOnayla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();

            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtAsiAdi);
            this.panelControl1.Controls.Add(this.dateYapilma);
            this.panelControl1.Controls.Add(this.dateGelecek);
            this.panelControl1.Controls.Add(this.btnAsiKaydet);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(900, 200);
            this.panelControl1.TabIndex = 0;

            // 
            // gridControl4 (Hayvanlar Listesi - Sol Taraf)
            // 
            this.gridControl4.Location = new System.Drawing.Point(5, 5);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(300, 190);
            this.gridControl4.TabIndex = 7;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});

            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;

            // 
            // txtAsiAdi
            // 
            this.txtAsiAdi.Location = new System.Drawing.Point(380, 20);
            this.txtAsiAdi.Name = "txtAsiAdi";
            this.txtAsiAdi.Size = new System.Drawing.Size(150, 20);
            this.txtAsiAdi.TabIndex = 0;

            // 
            // dateYapilma
            // 
            this.dateYapilma.EditValue = null;
            this.dateYapilma.Location = new System.Drawing.Point(380, 50);
            this.dateYapilma.Name = "dateYapilma";
            this.dateYapilma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateYapilma.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateYapilma.Size = new System.Drawing.Size(150, 20);
            this.dateYapilma.TabIndex = 1;

            // 
            // dateGelecek
            // 
            this.dateGelecek.EditValue = null;
            this.dateGelecek.Location = new System.Drawing.Point(380, 80);
            this.dateGelecek.Name = "dateGelecek";
            this.dateGelecek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelecek.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelecek.Size = new System.Drawing.Size(150, 20);
            this.dateGelecek.TabIndex = 2;

            // 
            // btnAsiKaydet
            // 
            this.btnAsiKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAsiKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAsiKaydet.Appearance.Options.UseBackColor = true;
            this.btnAsiKaydet.Appearance.Options.UseForeColor = true;
            this.btnAsiKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAsiKaydet.Location = new System.Drawing.Point(380, 110);
            this.btnAsiKaydet.Name = "btnAsiKaydet";
            this.btnAsiKaydet.Size = new System.Drawing.Size(150, 36);
            this.btnAsiKaydet.TabIndex = 3;
            this.btnAsiKaydet.Text = "Aşı Ekle";
            this.btnAsiKaydet.Click += new System.EventHandler(this.btnAsiKaydet_Click);

             // Labels
            this.labelControl1.Location = new System.Drawing.Point(320, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Text = "Aşı Adı:";
            
            this.labelControl2.Location = new System.Drawing.Point(320, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Text = "Tarih:";

            this.labelControl3.Location = new System.Drawing.Point(320, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Text = "Sonraki:";

            // 
            // gridControl3 (Aşı Geçmişi)
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 200);
            this.gridControl3.MainView = this.gridView5;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnOnayla});
            this.gridControl3.Size = new System.Drawing.Size(900, 250);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});

            // 
            // gridView5
            // 

            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHayvanAdi,
            this.colAsiAdi,
            this.colTarih,
            this.colDurum,
            this.colOnayla});
            this.gridView5.GridControl = this.gridControl3;
            this.gridView5.Name = "gridView5";
            // allow editing only for button column
            this.gridView5.OptionsBehavior.Editable = true;
            this.gridView5.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView5_RowStyle);
            // 
            // colHayvanAdi
            // 
            this.colHayvanAdi.Caption = "Hayvan Adı";
            this.colHayvanAdi.FieldName = "HayvanAdi";
            this.colHayvanAdi.Name = "colHayvanAdi";
            this.colHayvanAdi.OptionsColumn.AllowEdit = false;
            this.colHayvanAdi.Visible = true;
            this.colHayvanAdi.VisibleIndex = 0;
            // 
            // colAsiAdi
            // 
            this.colAsiAdi.Caption = "Aşı Adı";
            this.colAsiAdi.FieldName = "AsiAdi";
            this.colAsiAdi.Name = "colAsiAdi";
            this.colAsiAdi.OptionsColumn.AllowEdit = false;
            this.colAsiAdi.Visible = true;
            this.colAsiAdi.VisibleIndex = 1;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Aşı Tarihi";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 2;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 3;
            // 
            // colOnayla
            // 
            this.colOnayla.Caption = "Onayla";
            this.colOnayla.ColumnEdit = this.repoBtnOnayla;
            this.colOnayla.Name = "colOnayla";
            this.colOnayla.Visible = true;
            this.colOnayla.VisibleIndex = 4;
            // 
            // repoBtnOnayla
            // 
            this.repoBtnOnayla.AutoHeight = false;
            DevExpress.XtraEditors.Controls.EditorButton btn = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph);
            btn.Caption = "ONAYLA";
            btn.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            btn.Appearance.BackColor = System.Drawing.Color.Orange;
            btn.Appearance.Options.UseBackColor = true;
            this.repoBtnOnayla.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { btn });
            this.repoBtnOnayla.Name = "repoBtnOnayla";
            this.repoBtnOnayla.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtnOnayla.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtnOnayla_ButtonClick);

            // 
            // AsiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.gridControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "AsiForm";
            this.Text = "Aşı Takibi";
            this.Load += new System.EventHandler(this.AsiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnOnayla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAsiKaydet;
        private DevExpress.XtraEditors.DateEdit dateGelecek;
        private DevExpress.XtraEditors.DateEdit dateYapilma;
        private DevExpress.XtraEditors.TextEdit txtAsiAdi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colHayvanAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAsiAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOnayla;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnOnayla;

    }
}
