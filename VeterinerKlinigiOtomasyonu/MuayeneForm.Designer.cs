namespace VeterinerKlinigiOtomasyonu
{
    partial class MuayeneForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            
            // Left Grid (Patients)
            this.gridControlHastaListesi = new DevExpress.XtraGrid.GridControl();
            this.gridViewHastaListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHastaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaTur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaSahip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHastaCinsiyet = new DevExpress.XtraGrid.Columns.GridColumn();

            // Right Panel (Details)
            this.panelControlSag = new DevExpress.XtraEditors.PanelControl();
            this.groupControlYeni = new DevExpress.XtraEditors.GroupControl(); 
            this.groupControlGecmis = new DevExpress.XtraEditors.GroupControl(); 
            
            // Input Controls
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.memoSikayet = new DevExpress.XtraEditors.MemoEdit();
            this.memoTeshis = new DevExpress.XtraEditors.MemoEdit();
            this.btnMuayeneKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnMuayeneGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnMuayeneSil = new DevExpress.XtraEditors.SimpleButton();

            // History Grid
            this.gridControlGecmis = new DevExpress.XtraGrid.GridControl();
            this.gridViewGecmis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMuayeneId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSikayet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTeshis = new DevExpress.XtraGrid.Columns.GridColumn();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHastaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHastaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSag)).BeginInit();
            this.panelControlSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYeni)).BeginInit();
            this.groupControlYeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTeshis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGecmis)).BeginInit();
            this.groupControlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGecmis)).BeginInit();
            this.SuspendLayout();

            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.SplitterPosition = 350; // Fixed width
            
            // 
            // Panel 1: Patient List
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControlHastaListesi);
            this.splitContainerControl1.Panel1.Text = "Panel1";

            // gridControlHastaListesi
            this.gridControlHastaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHastaListesi.Location = new System.Drawing.Point(0, 0);
            this.gridControlHastaListesi.MainView = this.gridViewHastaListesi;
            this.gridControlHastaListesi.Name = "gridControlHastaListesi";
            this.gridControlHastaListesi.Size = new System.Drawing.Size(350, 700);
            this.gridControlHastaListesi.TabIndex = 0;
            this.gridControlHastaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewHastaListesi });

            // gridViewHastaListesi
            this.gridViewHastaListesi.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewHastaListesi.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewHastaListesi.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridViewHastaListesi.Appearance.Row.Options.UseFont = true;
            this.gridViewHastaListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.colHastaId, 
                this.colHastaAd, 
                this.colHastaTur, 
                this.colHastaCinsiyet,
                this.colHastaSahip});
            this.gridViewHastaListesi.GridControl = this.gridControlHastaListesi;
            this.gridViewHastaListesi.Name = "gridViewHastaListesi";
            this.gridViewHastaListesi.OptionsBehavior.Editable = false;
            this.gridViewHastaListesi.OptionsFind.AlwaysVisible = true;
            this.gridViewHastaListesi.OptionsView.ShowGroupPanel = false;
            this.gridViewHastaListesi.OptionsView.ShowIndicator = false;
            this.gridViewHastaListesi.RowHeight = 30;
            this.gridViewHastaListesi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewHastaListesi_FocusedRowChanged);
             
            // Columns
            this.colHastaId.FieldName = "HayvanId";
            this.colHastaId.Name = "colHastaId";
            
            this.colHastaAd.Caption = "Hasta Adı";
            this.colHastaAd.FieldName = "Ad";
            this.colHastaAd.Name = "colHastaAd";
            this.colHastaAd.Visible = true;
            this.colHastaAd.VisibleIndex = 0;
            this.colHastaAd.Width = 100;

            this.colHastaTur.Caption = "Tür";
            this.colHastaTur.FieldName = "Tur";
            this.colHastaTur.Name = "colHastaTur";
            this.colHastaTur.Visible = true;
            this.colHastaTur.VisibleIndex = 1;

            this.colHastaCinsiyet.Caption = "Cinsiyet";
            this.colHastaCinsiyet.FieldName = "Cinsiyet";
            this.colHastaCinsiyet.Name = "colHastaCinsiyet";
            
            this.colHastaSahip.Caption = "Sahip";
            this.colHastaSahip.FieldName = "Sahibi";
            this.colHastaSahip.Name = "colHastaSahip";
            this.colHastaSahip.Visible = true;
            this.colHastaSahip.VisibleIndex = 2;


            // 
            // Panel 2: Right Details
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.panelControlSag);
            this.splitContainerControl1.Panel2.Text = "Panel2";

            this.panelControlSag.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControlSag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlSag.Location = new System.Drawing.Point(0, 0);
            this.panelControlSag.Name = "panelControlSag";
            this.panelControlSag.Size = new System.Drawing.Size(845, 700);
            this.panelControlSag.TabIndex = 0;
            this.panelControlSag.Controls.Add(this.groupControlGecmis);
            this.panelControlSag.Controls.Add(this.groupControlYeni);

            // groupControlYeni (Top)
            this.groupControlYeni.Appearance.BackColor = System.Drawing.Color.White;
            this.groupControlYeni.Appearance.Options.UseBackColor = true;
            this.groupControlYeni.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControlYeni.AppearanceCaption.Options.UseFont = true;
            this.groupControlYeni.Controls.Add(this.labelControl1);
            this.groupControlYeni.Controls.Add(this.memoSikayet);
            this.groupControlYeni.Controls.Add(this.labelControl2);
            this.groupControlYeni.Controls.Add(this.memoTeshis);
            this.groupControlYeni.Controls.Add(this.btnMuayeneKaydet);
            this.groupControlYeni.Controls.Add(this.btnMuayeneGuncelle);
            this.groupControlYeni.Controls.Add(this.btnMuayeneSil);
            this.groupControlYeni.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlYeni.Location = new System.Drawing.Point(0, 0);
            this.groupControlYeni.Name = "groupControlYeni";
            this.groupControlYeni.Size = new System.Drawing.Size(845, 380);
            this.groupControlYeni.TabIndex = 0;
            this.groupControlYeni.Text = "Muayene Girişi";
            
            // labelControl1 (Şikayet)
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Şikayet:";

            // memoSikayet
            this.memoSikayet.Location = new System.Drawing.Point(90, 42);
            this.memoSikayet.Name = "memoSikayet";
            this.memoSikayet.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoSikayet.Properties.Appearance.Options.UseFont = true;
            this.memoSikayet.Size = new System.Drawing.Size(700, 80);
            this.memoSikayet.TabIndex = 1;

            // labelControl2 (Teşhis)
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 145);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Teşhis:";

            // memoTeshis
            this.memoTeshis.Location = new System.Drawing.Point(90, 142);
            this.memoTeshis.Name = "memoTeshis";
            this.memoTeshis.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoTeshis.Properties.Appearance.Options.UseFont = true;
            this.memoTeshis.Size = new System.Drawing.Size(700, 150); // Daha büyük
            this.memoTeshis.TabIndex = 3;

            // btnMuayeneKaydet
            this.btnMuayeneKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnMuayeneKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMuayeneKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMuayeneKaydet.Appearance.Options.UseBackColor = true;
            this.btnMuayeneKaydet.Appearance.Options.UseFont = true;
            this.btnMuayeneKaydet.Appearance.Options.UseForeColor = true;
            this.btnMuayeneKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMuayeneKaydet.Location = new System.Drawing.Point(90, 310);
            this.btnMuayeneKaydet.Name = "btnMuayeneKaydet";
            this.btnMuayeneKaydet.Size = new System.Drawing.Size(130, 45);
            this.btnMuayeneKaydet.TabIndex = 4;
            this.btnMuayeneKaydet.Text = "KAYDET";
            this.btnMuayeneKaydet.Click += new System.EventHandler(this.btnMuayeneKaydet_Click);

            // btnMuayeneGuncelle
            this.btnMuayeneGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnMuayeneGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMuayeneGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMuayeneGuncelle.Appearance.Options.UseBackColor = true;
            this.btnMuayeneGuncelle.Appearance.Options.UseFont = true;
            this.btnMuayeneGuncelle.Appearance.Options.UseForeColor = true;
            this.btnMuayeneGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMuayeneGuncelle.Enabled = false;
            this.btnMuayeneGuncelle.Location = new System.Drawing.Point(230, 310);
            this.btnMuayeneGuncelle.Name = "btnMuayeneGuncelle";
            this.btnMuayeneGuncelle.Size = new System.Drawing.Size(130, 45);
            this.btnMuayeneGuncelle.TabIndex = 5;
            this.btnMuayeneGuncelle.Text = "GÜNCELLE";
            this.btnMuayeneGuncelle.Click += new System.EventHandler(this.btnMuayeneGuncelle_Click);

            // btnMuayeneSil
            this.btnMuayeneSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnMuayeneSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMuayeneSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnMuayeneSil.Appearance.Options.UseBackColor = true;
            this.btnMuayeneSil.Appearance.Options.UseFont = true;
            this.btnMuayeneSil.Appearance.Options.UseForeColor = true;
            this.btnMuayeneSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnMuayeneSil.Enabled = false;
            this.btnMuayeneSil.Location = new System.Drawing.Point(370, 310);
            this.btnMuayeneSil.Name = "btnMuayeneSil";
            this.btnMuayeneSil.Size = new System.Drawing.Size(130, 45);
            this.btnMuayeneSil.TabIndex = 6;
            this.btnMuayeneSil.Text = "SİL";
            this.btnMuayeneSil.Click += new System.EventHandler(this.btnMuayeneSil_Click);


            // groupControlGecmis (Bottom)
            this.groupControlGecmis.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControlGecmis.AppearanceCaption.Options.UseFont = true;
            this.groupControlGecmis.Controls.Add(this.gridControlGecmis);
            this.groupControlGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlGecmis.Location = new System.Drawing.Point(0, 380);
            this.groupControlGecmis.Name = "groupControlGecmis";
            this.groupControlGecmis.Size = new System.Drawing.Size(845, 320);
            this.groupControlGecmis.TabIndex = 1;
            this.groupControlGecmis.Text = "Geçmiş Muayeneler";

            // gridControlGecmis
            this.gridControlGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGecmis.Location = new System.Drawing.Point(2, 23);
            this.gridControlGecmis.MainView = this.gridViewGecmis;
            this.gridControlGecmis.Name = "gridControlGecmis";
            this.gridControlGecmis.Size = new System.Drawing.Size(841, 295);
            this.gridControlGecmis.TabIndex = 0;
            this.gridControlGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewGecmis });

            // gridViewGecmis
            this.gridViewGecmis.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewGecmis.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewGecmis.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridViewGecmis.Appearance.Row.Options.UseFont = true;
            
            this.gridViewGecmis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.colMuayeneId, 
                this.colTarih, 
                this.colSikayet, 
                this.colTeshis});
            this.gridViewGecmis.GridControl = this.gridControlGecmis;
            this.gridViewGecmis.Name = "gridViewGecmis";
            this.gridViewGecmis.OptionsBehavior.Editable = false;
            this.gridViewGecmis.OptionsView.ShowGroupPanel = false;
            this.gridViewGecmis.OptionsView.ShowIndicator = false;
            this.gridViewGecmis.RowHeight = 30;
            this.gridViewGecmis.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewGecmis_FocusedRowChanged);

            // Columns Gecmis
            this.colMuayeneId.FieldName = "MuayeneId";
            this.colMuayeneId.Name = "colMuayeneId";
            this.colMuayeneId.Visible = false;

            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 120;
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";

            this.colTeshis.Caption = "Teşhis";
            this.colTeshis.FieldName = "Teshis";
            this.colTeshis.Name = "colTeshis";
            this.colTeshis.Visible = true;
            this.colTeshis.VisibleIndex = 1;
            this.colTeshis.Width = 300;

            this.colSikayet.Caption = "Şikayet";
            this.colSikayet.FieldName = "Sikayet";
            this.colSikayet.Name = "colSikayet";
            this.colSikayet.Visible = true;
            this.colSikayet.VisibleIndex = 2;
            this.colSikayet.Width = 300;

            
            // Final
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MuayeneForm";
            this.Text = "Muayene ve Teşhis Yönetimi";
            this.Load += new System.EventHandler(this.MuayeneForm_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHastaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHastaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlSag)).EndInit();
            this.panelControlSag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlYeni)).EndInit();
            this.groupControlYeni.ResumeLayout(false);
            this.groupControlYeni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTeshis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlGecmis)).EndInit();
            this.groupControlGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGecmis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControlHastaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHastaListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaId;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaAd;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaTur;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaSahip;
        private DevExpress.XtraGrid.Columns.GridColumn colHastaCinsiyet;

        private DevExpress.XtraEditors.PanelControl panelControlSag;
        private DevExpress.XtraEditors.GroupControl groupControlYeni;
        private DevExpress.XtraEditors.GroupControl groupControlGecmis;

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.MemoEdit memoSikayet;
        private DevExpress.XtraEditors.MemoEdit memoTeshis;
        
        private DevExpress.XtraEditors.SimpleButton btnMuayeneKaydet;
        private DevExpress.XtraEditors.SimpleButton btnMuayeneGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnMuayeneSil;

        private DevExpress.XtraGrid.GridControl gridControlGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGecmis;
        private DevExpress.XtraGrid.Columns.GridColumn colMuayeneId;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSikayet;
        private DevExpress.XtraGrid.Columns.GridColumn colTeshis;
    }
}
