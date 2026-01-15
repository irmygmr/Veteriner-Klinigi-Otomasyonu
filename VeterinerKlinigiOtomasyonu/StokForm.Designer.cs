namespace VeterinerKlinigiOtomasyonu
{
    partial class StokForm
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
            // Grid Components
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStokId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStokMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKritikSeviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSKT = new DevExpress.XtraGrid.Columns.GridColumn();

            // Panel components
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.cmbKategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.spinMiktar = new DevExpress.XtraEditors.SpinEdit();
            this.spinKritik = new DevExpress.XtraEditors.SpinEdit();
            this.dateSKT = new DevExpress.XtraEditors.DateEdit();
            
            // Buttons
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();

            // Labels
            this.lblUrun = new DevExpress.XtraEditors.LabelControl();
            this.lblKategori = new DevExpress.XtraEditors.LabelControl();
            this.lblMiktar = new DevExpress.XtraEditors.LabelControl();
            this.lblKritik = new DevExpress.XtraEditors.LabelControl();
            this.lblSKT = new DevExpress.XtraEditors.LabelControl();

            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMiktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKritik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).BeginInit();
            this.SuspendLayout();

            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Size = new System.Drawing.Size(1000, 160);
            this.panelControl1.Controls.Add(this.lblUrun);
            this.panelControl1.Controls.Add(this.txtUrunAdi);
            this.panelControl1.Controls.Add(this.lblKategori);
            this.panelControl1.Controls.Add(this.cmbKategori);
            this.panelControl1.Controls.Add(this.lblMiktar);
            this.panelControl1.Controls.Add(this.spinMiktar);
            this.panelControl1.Controls.Add(this.lblKritik);
            this.panelControl1.Controls.Add(this.spinKritik);
            this.panelControl1.Controls.Add(this.lblSKT);
            this.panelControl1.Controls.Add(this.dateSKT);
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.btnSil);
            
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(80, 20);
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 20);
            
            // 
            // cmbKategori
            // 
            this.cmbKategori.Location = new System.Drawing.Point(80, 50);
            this.cmbKategori.Size = new System.Drawing.Size(150, 20);
            this.cmbKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKategori.Properties.Items.AddRange(new object[] {
            "Mama",
            "Aşı/İlaç",
            "Aksesuar",
            "Diğer"});
            this.cmbKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;

            // 
            // spinMiktar
            // 
            this.spinMiktar.Location = new System.Drawing.Point(320, 20);
            this.spinMiktar.Size = new System.Drawing.Size(100, 20);
            this.spinMiktar.Properties.IsFloatValue = false;
            this.spinMiktar.Properties.Mask.EditMask = "N0";

            // 
            // spinKritik
            // 
            this.spinKritik.Location = new System.Drawing.Point(320, 50);
            this.spinKritik.Size = new System.Drawing.Size(100, 20);
            this.spinKritik.Properties.IsFloatValue = false;
            this.spinKritik.Properties.Mask.EditMask = "N0";

            // 
            // dateSKT
            // 
            this.dateSKT.Location = new System.Drawing.Point(80, 80);
            this.dateSKT.Size = new System.Drawing.Size(150, 20);
            this.dateSKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});

            // 
            // btnEkle
            // 
            this.btnEkle.Text = "EKLE";
            this.btnEkle.Location = new System.Drawing.Point(500, 20);
            this.btnEkle.Size = new System.Drawing.Size(120, 40);
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(46, 204, 113); // Emerald
            this.btnEkle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseForeColor = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Location = new System.Drawing.Point(630, 20);
            this.btnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(52, 152, 219); // Blue
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            // 
            // btnSil
            // 
            this.btnSil.Text = "SİL";
            this.btnSil.Location = new System.Drawing.Point(760, 20);
            this.btnSil.Size = new System.Drawing.Size(120, 40);
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(231, 76, 60); // Red
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // 
            // Labels
            // 
            this.lblUrun.Text = "Ürün Adı:";
            this.lblUrun.Location = new System.Drawing.Point(20, 23);
            
            this.lblKategori.Text = "Kategori:";
            this.lblKategori.Location = new System.Drawing.Point(20, 53);

            this.lblSKT.Text = "SKT:";
            this.lblSKT.Location = new System.Drawing.Point(20, 83);

            this.lblMiktar.Text = "Miktar:";
            this.lblMiktar.Location = new System.Drawing.Point(260, 23);

            this.lblKritik.Text = "Kritik:";
            this.lblKritik.Location = new System.Drawing.Point(260, 53);

            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridView1 });

            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.colStokId,
                this.colUrunAdi,
                this.colKategori,
                this.colStokMiktari,
                this.colKritikSeviye,
                this.colSKT
            });
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
             // Format Rule for Critical Stock
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            gridFormatRule1.Name = "FormatKritikStok";
            formatConditionRuleExpression1.Expression = "[StokMiktari] <= [KritikSeviye]";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.IndianRed;
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.White;
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule1.ApplyToRow = true;
            this.gridView1.FormatRules.Add(gridFormatRule1);

            // 
            // Columns
            // 
            this.colStokId.FieldName = "StokId";
            this.colStokId.Visible = false;

            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 0;

            this.colKategori.FieldName = "Kategori";
            this.colKategori.Caption = "Kategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 1;

            this.colStokMiktari.FieldName = "StokMiktari";
            this.colStokMiktari.Caption = "Miktar";
            this.colStokMiktari.Visible = true;
            this.colStokMiktari.VisibleIndex = 2;

            this.colKritikSeviye.FieldName = "KritikSeviye";
            this.colKritikSeviye.Caption = "Kritik Seviye";
            this.colKritikSeviye.Visible = true;
            this.colKritikSeviye.VisibleIndex = 3;

            this.colSKT.FieldName = "SonKullanmaTarihi";
            this.colSKT.Caption = "SKT";
            this.colSKT.Visible = true;
            this.colSKT.VisibleIndex = 4;

            // 
            // StokForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMiktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKritik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSKT.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colStokId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colStokMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colKritikSeviye;
        private DevExpress.XtraGrid.Columns.GridColumn colSKT;

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKategori;
        private DevExpress.XtraEditors.SpinEdit spinMiktar;
        private DevExpress.XtraEditors.SpinEdit spinKritik;
        private DevExpress.XtraEditors.DateEdit dateSKT;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LabelControl lblUrun;
        private DevExpress.XtraEditors.LabelControl lblKategori;
        private DevExpress.XtraEditors.LabelControl lblMiktar;
        private DevExpress.XtraEditors.LabelControl lblKritik;
        private DevExpress.XtraEditors.LabelControl lblSKT;
    }
}
