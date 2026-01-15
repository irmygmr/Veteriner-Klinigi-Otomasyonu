namespace VeterinerKlinigiOtomasyonu
{
    partial class RandevuForm
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
            this.panelInput = new DevExpress.XtraEditors.PanelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton(); // New Cancel Button
            this.deRandevuTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.lookUpHayvan = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabControlRandevular = new DevExpress.XtraTab.XtraTabControl();
            this.tabGelecek = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlGelecek = new DevExpress.XtraGrid.GridControl();
            this.gridViewGelecek = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGelecekId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekHayvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekSahip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGelecekDurum = new DevExpress.XtraGrid.Columns.GridColumn(); // New Status Column
            this.tabGecmis = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlGecmis = new DevExpress.XtraGrid.GridControl();
            this.gridViewGecmis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGecmisId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmisTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmisHayvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmisSahip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmisAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGecmisDurum = new DevExpress.XtraGrid.Columns.GridColumn(); // New Status Column

            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).BeginInit();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRandevular)).BeginInit();
            this.tabControlRandevular.SuspendLayout();
            this.tabGelecek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelecek)).BeginInit();
            this.tabGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.Appearance.BackColor = System.Drawing.Color.White;
            this.panelInput.Appearance.Options.UseBackColor = true;
            this.panelInput.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelInput.Controls.Add(this.btnEkle);
            this.panelInput.Controls.Add(this.btnGuncelle);
            this.panelInput.Controls.Add(this.btnSil);
            this.panelInput.Controls.Add(this.btnIptal); 
            this.panelInput.Controls.Add(this.deRandevuTarihi);
            this.panelInput.Controls.Add(this.txtAciklama);
            this.panelInput.Controls.Add(this.lookUpHayvan);
            this.panelInput.Controls.Add(this.labelControl3);
            this.panelInput.Controls.Add(this.labelControl2);
            this.panelInput.Controls.Add(this.labelControl1);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1000, 160);
            this.panelInput.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.Appearance.Options.UseForeColor = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(120, 110);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 40);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "RANDEVU EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(260, 110);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 40);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(380, 110);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 40);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34))))); // Orange
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Appearance.Options.UseBackColor = true;
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.Appearance.Options.UseForeColor = true;
            this.btnIptal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.Enabled = false;
            this.btnIptal.Location = new System.Drawing.Point(500, 110);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(110, 40);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İPTAL ET";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);


            // 
            // deRandevuTarihi
            // 
            this.deRandevuTarihi.EditValue = null;
            this.deRandevuTarihi.Location = new System.Drawing.Point(120, 70);
            this.deRandevuTarihi.Name = "deRandevuTarihi";
            this.deRandevuTarihi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deRandevuTarihi.Properties.Appearance.Options.UseFont = true;
            this.deRandevuTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRandevuTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRandevuTarihi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.deRandevuTarihi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deRandevuTarihi.Size = new System.Drawing.Size(250, 24);
            this.deRandevuTarihi.TabIndex = 3;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(480, 25);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAciklama.Properties.Appearance.Options.UseFont = true;
            this.txtAciklama.Size = new System.Drawing.Size(350, 24);
            this.txtAciklama.TabIndex = 5;
            // 
            // lookUpHayvan
            // 
            this.lookUpHayvan.Location = new System.Drawing.Point(120, 25);
            this.lookUpHayvan.Name = "lookUpHayvan";
            this.lookUpHayvan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lookUpHayvan.Properties.Appearance.Options.UseFont = true;
            this.lookUpHayvan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpHayvan.Properties.NullText = "Hayvan Seçiniz";
            this.lookUpHayvan.Size = new System.Drawing.Size(250, 24);
            this.lookUpHayvan.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(30, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Tarih/Saat:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(410, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Açıklama:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hayvan:";

            // 
            // tabControlRandevular
            // 
            this.tabControlRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRandevular.Location = new System.Drawing.Point(0, 160);
            this.tabControlRandevular.Name = "tabControlRandevular";
            this.tabControlRandevular.SelectedTabPage = this.tabGelecek;
            this.tabControlRandevular.Size = new System.Drawing.Size(1000, 540);
            this.tabControlRandevular.TabIndex = 1;
            this.tabControlRandevular.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabGelecek,
            this.tabGecmis});
            // 
            // tabGelecek
            // 
            this.tabGelecek.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96))))); // Green
            this.tabGelecek.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabGelecek.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabGelecek.Appearance.Header.Options.UseBackColor = true;
            this.tabGelecek.Appearance.Header.Options.UseFont = true;
            this.tabGelecek.Appearance.Header.Options.UseForeColor = true;
            this.tabGelecek.Controls.Add(this.gridControlGelecek);
            this.tabGelecek.Name = "tabGelecek";
            this.tabGelecek.Size = new System.Drawing.Size(994, 506);
            this.tabGelecek.Text = "AKTİF / GELECEK RANDEVULAR";
            // 
            // gridControlGelecek
            // 
            this.gridControlGelecek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGelecek.Location = new System.Drawing.Point(0, 0);
            this.gridControlGelecek.MainView = this.gridViewGelecek;
            this.gridControlGelecek.Name = "gridControlGelecek";
            this.gridControlGelecek.Size = new System.Drawing.Size(994, 508);
            this.gridControlGelecek.TabIndex = 0;
            this.gridControlGelecek.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGelecek});
            // 
            // gridViewGelecek
            // 
            this.gridViewGelecek.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewGelecek.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewGelecek.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridViewGelecek.Appearance.Row.Options.UseFont = true;
            this.gridViewGelecek.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGelecekId,
            this.colGelecekTarih,
            this.colGelecekHayvan,
            this.colGelecekSahip,
            this.colGelecekAciklama,
            this.colGelecekDurum});
            this.gridViewGelecek.GridControl = this.gridControlGelecek;
            this.gridViewGelecek.Name = "gridViewGelecek";
            this.gridViewGelecek.OptionsBehavior.Editable = false;
            this.gridViewGelecek.OptionsView.ShowGroupPanel = false;
            this.gridViewGelecek.OptionsView.ShowIndicator = false;
            this.gridViewGelecek.RowHeight = 30;
            // 
            // colGelecekId
            // 
            this.colGelecekId.FieldName = "RandevuId";
            this.colGelecekId.Name = "colGelecekId";
            // 
            // colGelecekTarih
            // 
            this.colGelecekTarih.Caption = "Randevu Tarihi";
            this.colGelecekTarih.FieldName = "BaslangicTarihi";
            this.colGelecekTarih.Name = "colGelecekTarih";
            this.colGelecekTarih.Visible = true;
            this.colGelecekTarih.VisibleIndex = 0;
            this.colGelecekTarih.Width = 150;
            // 
            // colGelecekHayvan
            // 
            this.colGelecekHayvan.Caption = "Hasta (Hayvan)";
            this.colGelecekHayvan.FieldName = "HayvanAdi";
            this.colGelecekHayvan.Name = "colGelecekHayvan";
            this.colGelecekHayvan.Visible = true;
            this.colGelecekHayvan.VisibleIndex = 1;
            this.colGelecekHayvan.Width = 150;
            // 
            // colGelecekSahip
            // 
            this.colGelecekSahip.Caption = "Hasta Sahibi";
            this.colGelecekSahip.FieldName = "SahipAdi";
            // 
            // tabGecmis
            // 
            this.tabGecmis.Appearance.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141))))); // Gray
            this.tabGecmis.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabGecmis.Appearance.Header.ForeColor = System.Drawing.Color.White;
            this.tabGecmis.Appearance.Header.Options.UseBackColor = true;
            this.tabGecmis.Appearance.Header.Options.UseFont = true;
            this.tabGecmis.Appearance.Header.Options.UseForeColor = true;
            this.tabGecmis.Controls.Add(this.gridControlGecmis);
            this.tabGecmis.Name = "tabGecmis";
            this.tabGecmis.Size = new System.Drawing.Size(1000, 265);
            this.tabGecmis.Text = "GEÇMİŞ RANDEVULAR";
            // 
            // gridControlGecmis
            // 
            this.gridControlGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGecmis.Location = new System.Drawing.Point(2, 23);
            this.gridControlGecmis.MainView = this.gridViewGecmis;
            this.gridControlGecmis.Name = "gridControlGecmis";
            this.gridControlGecmis.Size = new System.Drawing.Size(996, 240);
            this.gridControlGecmis.TabIndex = 0;
            this.gridControlGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGecmis});
            // 
            // gridViewGecmis
            // 
            this.gridViewGecmis.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gridViewGecmis.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewGecmis.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridViewGecmis.Appearance.Row.ForeColor = System.Drawing.Color.Gray;
            this.gridViewGecmis.Appearance.Row.Options.UseFont = true;
            this.gridViewGecmis.Appearance.Row.Options.UseForeColor = true;
            this.gridViewGecmis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGecmisId,
            this.colGecmisTarih,
            this.colGecmisHayvan,
            this.colGecmisSahip,
            this.colGecmisAciklama,
            this.colGecmisDurum});
            this.gridViewGecmis.GridControl = this.gridControlGecmis;
            this.gridViewGecmis.Name = "gridViewGecmis";
            this.gridViewGecmis.OptionsBehavior.Editable = false;
            this.gridViewGecmis.OptionsView.ShowGroupPanel = false;
            this.gridViewGecmis.OptionsView.ShowIndicator = false;
            this.gridViewGecmis.RowHeight = 30;
            // 
            // colGecmisId
            // 
            this.colGecmisId.FieldName = "RandevuId";
            this.colGecmisId.Name = "colGecmisId";
            // 
            // colGecmisTarih
            // 
            this.colGecmisTarih.Caption = "Tarih";
            this.colGecmisTarih.FieldName = "BaslangicTarihi";
            this.colGecmisTarih.Name = "colGecmisTarih";
            this.colGecmisTarih.Visible = true;
            this.colGecmisTarih.VisibleIndex = 0;
            this.colGecmisTarih.Width = 150;
            // 
            // colGecmisHayvan
            // 
            this.colGecmisHayvan.Caption = "Hasta";
            this.colGecmisHayvan.FieldName = "HayvanAdi";
            this.colGecmisHayvan.Name = "colGecmisHayvan";
            this.colGecmisHayvan.Visible = true;
            this.colGecmisHayvan.VisibleIndex = 1;
            this.colGecmisHayvan.Width = 150;
            // 
            // colGecmisSahip
            // 
            this.colGecmisSahip.Caption = "Sahip";
            this.colGecmisSahip.FieldName = "SahipAdi";
            this.colGecmisSahip.Name = "colGecmisSahip";
            this.colGecmisSahip.Visible = true;
            this.colGecmisSahip.VisibleIndex = 2;
            this.colGecmisSahip.Width = 150;
            // 
            // colGecmisAciklama
            // 
            this.colGecmisAciklama.Caption = "Açıklama";
            this.colGecmisAciklama.FieldName = "Aciklama";
            this.colGecmisAciklama.Name = "colGecmisAciklama";
            this.colGecmisAciklama.Visible = true;
            this.colGecmisAciklama.VisibleIndex = 3;
            // colGecmisDurum
            this.colGecmisDurum.Caption = "Durum";
            this.colGecmisDurum.FieldName = "Durum";
            this.colGecmisDurum.Name = "colGecmisDurum";
            this.colGecmisDurum.Visible = true;
            this.colGecmisDurum.VisibleIndex = 4;

            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tabControlRandevular);
            this.Controls.Add(this.panelInput);
            this.Name = "RandevuForm";
            this.Text = "Randevu Yönetimi";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelInput)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRandevular)).EndInit();
            this.tabControlRandevular.ResumeLayout(false);
            this.tabGelecek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelecek)).EndInit();
            this.tabGecmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGecmis)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelInput;
        private DevExpress.XtraEditors.LookUpEdit lookUpHayvan;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.DateEdit deRandevuTarihi;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnIptal; // Defined here
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        
        private DevExpress.XtraTab.XtraTabControl tabControlRandevular;
        private DevExpress.XtraTab.XtraTabPage tabGelecek; // Aktif/Gelecek
        private DevExpress.XtraGrid.GridControl gridControlGelecek;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGelecek;
        private DevExpress.XtraTab.XtraTabPage tabGecmis; // Geçmiş
        private DevExpress.XtraGrid.GridControl gridControlGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGecmis;

        // Kolonlar Gelecek
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekId;
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekHayvan;
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekSahip;
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGelecekDurum; // Defined here

        // Kolonlar Gecmis
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisId;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisHayvan;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisSahip;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGecmisDurum; // Defined here
    }
}
