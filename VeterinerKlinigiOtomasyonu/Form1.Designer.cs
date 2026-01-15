using System;

namespace VeterinerKlinigiOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElementSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.PageKayit = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PageRandevu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControlRandevu = new DevExpress.XtraGrid.GridControl();
            this.gridViewRandevu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpHayvan = new DevExpress.XtraEditors.LookUpEdit();
            this.deRandevuTarihi = new DevExpress.XtraEditors.DateEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.PageAsi = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAsiKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.dateGelecek = new DevExpress.XtraEditors.DateEdit();
            this.dateYapilma = new DevExpress.XtraEditors.DateEdit();
            this.txtAsiAdi = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PageStok = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridViewStok = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.spinEdit2 = new DevExpress.XtraEditors.SpinEdit();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.PageKasa = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOdemeAl = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtOdemeTutar = new DevExpress.XtraEditors.TextEdit();
            this.PageMuayeneler = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridGecmis = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.gridViewMuayene = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PageKlinikAyarlari = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupKlinik = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblSaatlerBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtSaatler = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.lblEmailBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.lblTelBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtAdres = new DevExpress.XtraEditors.MemoEdit();
            this.lblAdresBaslik = new DevExpress.XtraEditors.LabelControl();
            this.txtKlinikAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblKlinikAdiBaslik = new DevExpress.XtraEditors.LabelControl();
            this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.PageKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.PageRandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRandevu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.PageAsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.PageStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.PageKasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).BeginInit();
            this.PageMuayeneler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMuayene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.PageKlinikAyarlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupKlinik)).BeginInit();
            this.groupKlinik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaatler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKlinikAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4,
            this.accordionControlElement5,
            this.accordionControlElement6,
            this.accordionControlElement7,
            this.accordionControlElementSettings});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(297, 713);
            this.accordionControl1.TabIndex = 4;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Panel";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Müşteri ve Hasta Kayıt";
            this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Expanded = true;
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Randevu Takvimi";
            this.accordionControlElement3.Click += new System.EventHandler(this.accordionControlElement3_Click);
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Expanded = true;
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Text = "Aşı Takibi";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Text = "Stok/Depo";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Expanded = true;
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Kasa/Muhasebe";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Muayeneler";
            // 
            // accordionControlElementSettings
            // 
            this.accordionControlElementSettings.Name = "accordionControlElementSettings";
            this.accordionControlElementSettings.Text = "Klinik Ayarları";
            this.accordionControlElementSettings.Click += new System.EventHandler(this.accordionControlElementSettings_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(297, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(150, 100, 150, 100);
            this.panelContainer.Size = new System.Drawing.Size(1351, 713);
            this.panelContainer.TabIndex = 6;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.PageKayit);
            this.navigationFrame1.Controls.Add(this.PageRandevu);
            this.navigationFrame1.Controls.Add(this.PageAsi);
            this.navigationFrame1.Controls.Add(this.PageStok);
            this.navigationFrame1.Controls.Add(this.PageKasa);
            this.navigationFrame1.Controls.Add(this.PageMuayeneler);
            this.navigationFrame1.Controls.Add(this.PageKlinikAyarlari);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(297, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PageKayit,
            this.PageRandevu,
            this.PageAsi,
            this.PageStok,
            this.PageKasa,
            this.PageMuayeneler,
            this.PageKlinikAyarlari});
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(1351, 713);
            this.navigationFrame1.TabIndex = 5;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // PageKayit
            // 
            this.PageKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageKayit.Caption = "PageKayit";
            this.PageKayit.Controls.Add(this.simpleButton4);
            this.PageKayit.Controls.Add(this.gridControl1);
            this.PageKayit.Name = "PageKayit";
            this.PageKayit.Size = new System.Drawing.Size(1351, 713);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(696, 16);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(79, 27);
            this.simpleButton4.TabIndex = 5;
            this.simpleButton4.Text = "Kayıt Sil";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1351, 713);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hayvan ID";
            this.gridColumn4.FieldName = "HayvanId";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 86;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Hayvanın Adı";
            this.gridColumn1.FieldName = "Ad";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 86;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Türü\\Cinsi";
            this.gridColumn2.FieldName = "Tur";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 86;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hasta Sahibi";
            this.gridColumn3.FieldName = "Sahibi";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 86;
            // 
            // PageRandevu
            // 
            this.PageRandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageRandevu.Caption = "PageRandevu";
            this.PageRandevu.Controls.Add(this.gridControlRandevu);
            this.PageRandevu.Controls.Add(this.panelControl5);
            this.PageRandevu.Name = "PageRandevu";
            this.PageRandevu.Size = new System.Drawing.Size(1351, 713);
            this.PageRandevu.Paint += new System.Windows.Forms.PaintEventHandler(this.PageRandevu_Paint);
            // 
            // gridControlRandevu
            // 
            this.gridControlRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRandevu.Location = new System.Drawing.Point(0, 84);
            this.gridControlRandevu.MainView = this.gridViewRandevu;
            this.gridControlRandevu.Name = "gridControlRandevu";
            this.gridControlRandevu.Size = new System.Drawing.Size(1351, 629);
            this.gridControlRandevu.TabIndex = 2;
            this.gridControlRandevu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRandevu});
            this.gridControlRandevu.Click += new System.EventHandler(this.gridControlRandevu_Click);
            // 
            // gridViewRandevu
            // 
            this.gridViewRandevu.GridControl = this.gridControlRandevu;
            this.gridViewRandevu.Name = "gridViewRandevu";
            // 
            // panelControl5
            // 
            this.panelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl5.Appearance.Options.UseBackColor = true;
            this.panelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl5.Controls.Add(this.simpleButton3);
            this.panelControl5.Controls.Add(this.lookUpHayvan);
            this.panelControl5.Controls.Add(this.deRandevuTarihi);
            this.panelControl5.Controls.Add(this.txtAciklama);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 0);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1351, 84);
            this.panelControl5.TabIndex = 7;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton3.Location = new System.Drawing.Point(937, 24);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(160, 36);
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Yeni Randevu";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // lookUpHayvan
            // 
            this.lookUpHayvan.Location = new System.Drawing.Point(23, 30);
            this.lookUpHayvan.Name = "lookUpHayvan";
            this.lookUpHayvan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lookUpHayvan.Properties.Appearance.Options.UseFont = true;
            this.lookUpHayvan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpHayvan.Properties.NullText = "Hayvan Seçiniz";
            this.lookUpHayvan.Size = new System.Drawing.Size(171, 30);
            this.lookUpHayvan.TabIndex = 5;
            // 
            // deRandevuTarihi
            // 
            this.deRandevuTarihi.EditValue = null;
            this.deRandevuTarihi.Location = new System.Drawing.Point(217, 30);
            this.deRandevuTarihi.Name = "deRandevuTarihi";
            this.deRandevuTarihi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deRandevuTarihi.Properties.Appearance.Options.UseFont = true;
            this.deRandevuTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRandevuTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deRandevuTarihi.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Fluent;
            this.deRandevuTarihi.Properties.Mask.EditMask = "g";
            this.deRandevuTarihi.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deRandevuTarihi.Properties.NullText = "Tarih ve Saat Seçiniz";
            this.deRandevuTarihi.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.deRandevuTarihi.Size = new System.Drawing.Size(251, 30);
            this.deRandevuTarihi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(491, 30);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAciklama.Properties.Appearance.Options.UseFont = true;
            this.txtAciklama.Properties.NullText = "Not / Açıklama";
            this.txtAciklama.Size = new System.Drawing.Size(400, 30);
            this.txtAciklama.TabIndex = 4;
            // 
            // PageAsi
            // 
            this.PageAsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageAsi.Caption = "PageAsi";
            this.PageAsi.Controls.Add(this.gridControl3);
            this.PageAsi.Controls.Add(this.btnAsiKaydet);
            this.PageAsi.Controls.Add(this.dateGelecek);
            this.PageAsi.Controls.Add(this.dateYapilma);
            this.PageAsi.Controls.Add(this.txtAsiAdi);
            this.PageAsi.Controls.Add(this.gridControl2);
            this.PageAsi.Name = "PageAsi";
            this.PageAsi.Size = new System.Drawing.Size(1351, 713);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.Location = new System.Drawing.Point(469, 0);
            this.gridControl3.MainView = this.gridView5;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(334, 713);
            this.gridControl3.TabIndex = 5;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView5.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView5.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView5.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView5.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView5.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView5.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView5.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView5.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView5.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView5.Appearance.Row.Options.UseFont = true;
            this.gridView5.Appearance.Row.Options.UseTextOptions = true;
            this.gridView5.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView5.GridControl = this.gridControl3;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView5.RowHeight = 40;
            // 
            // btnAsiKaydet
            // 
            this.btnAsiKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsiKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAsiKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAsiKaydet.Appearance.Options.UseBackColor = true;
            this.btnAsiKaydet.Appearance.Options.UseForeColor = true;
            this.btnAsiKaydet.Location = new System.Drawing.Point(848, 160);
            this.btnAsiKaydet.Name = "btnAsiKaydet";
            this.btnAsiKaydet.Size = new System.Drawing.Size(274, 40);
            this.btnAsiKaydet.TabIndex = 4;
            this.btnAsiKaydet.Text = "Aşıyı Kaydet";
            this.btnAsiKaydet.Click += new System.EventHandler(this.btnAsiKaydet_Click);
            // 
            // dateGelecek
            // 
            this.dateGelecek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateGelecek.EditValue = null;
            this.dateGelecek.Location = new System.Drawing.Point(848, 120);
            this.dateGelecek.Name = "dateGelecek";
            this.dateGelecek.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelecek.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGelecek.Size = new System.Drawing.Size(274, 22);
            this.dateGelecek.TabIndex = 3;
            // 
            // dateYapilma
            // 
            this.dateYapilma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateYapilma.EditValue = null;
            this.dateYapilma.Location = new System.Drawing.Point(848, 80);
            this.dateYapilma.Name = "dateYapilma";
            this.dateYapilma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateYapilma.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateYapilma.Size = new System.Drawing.Size(274, 22);
            this.dateYapilma.TabIndex = 2;
            // 
            // txtAsiAdi
            // 
            this.txtAsiAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsiAdi.Location = new System.Drawing.Point(848, 40);
            this.txtAsiAdi.Name = "txtAsiAdi";
            this.txtAsiAdi.Size = new System.Drawing.Size(274, 22);
            this.txtAsiAdi.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView4;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(457, 713);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView4.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView4.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView4.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView4.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView4.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView4.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView4.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView4.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView4.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView4.Appearance.Row.Options.UseFont = true;
            this.gridView4.Appearance.Row.Options.UseTextOptions = true;
            this.gridView4.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView4.GridControl = this.gridControl2;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView4.OptionsView.ShowIndicator = false;
            this.gridView4.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView4.RowHeight = 40;
            // 
            // PageStok
            // 
            this.PageStok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageStok.Caption = "PageStok";
            this.PageStok.Controls.Add(this.gridViewStok);
            this.PageStok.Controls.Add(this.simpleButton2);
            this.PageStok.Controls.Add(this.dateEdit1);
            this.PageStok.Controls.Add(this.spinEdit2);
            this.PageStok.Controls.Add(this.spinEdit1);
            this.PageStok.Controls.Add(this.textEdit1);
            this.PageStok.Name = "PageStok";
            this.PageStok.Size = new System.Drawing.Size(1351, 713);
            // 
            // gridViewStok
            // 
            this.gridViewStok.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridViewStok.Location = new System.Drawing.Point(0, 0);
            this.gridViewStok.MainView = this.gridView6;
            this.gridViewStok.Name = "gridViewStok";
            this.gridViewStok.Size = new System.Drawing.Size(571, 713);
            this.gridViewStok.TabIndex = 5;
            this.gridViewStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView6.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView6.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView6.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView6.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView6.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView6.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView6.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView6.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView6.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView6.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView6.Appearance.Row.Options.UseFont = true;
            this.gridView6.Appearance.Row.Options.UseTextOptions = true;
            this.gridView6.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView6.GridControl = this.gridViewStok;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            this.gridView6.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView6.OptionsView.ShowIndicator = false;
            this.gridView6.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView6.RowHeight = 40;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(688, 250);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(229, 40);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Stok Ekle / Güncelle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dateEdit1
            // 
            this.dateEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(688, 200);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(229, 22);
            this.dateEdit1.TabIndex = 3;
            // 
            // spinEdit2
            // 
            this.spinEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinEdit2.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit2.Location = new System.Drawing.Point(688, 150);
            this.spinEdit2.Name = "spinEdit2";
            this.spinEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit2.Size = new System.Drawing.Size(229, 22);
            this.spinEdit2.TabIndex = 2;
            // 
            // spinEdit1
            // 
            this.spinEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(688, 100);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(229, 22);
            this.spinEdit1.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.EditValue = "Ürün Adı";
            this.textEdit1.Location = new System.Drawing.Point(688, 50);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(229, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // PageKasa
            // 
            this.PageKasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageKasa.Caption = "PageKasa";
            this.PageKasa.Controls.Add(this.labelControl1);
            this.PageKasa.Controls.Add(this.btnOdemeAl);
            this.PageKasa.Controls.Add(this.gridControl4);
            this.PageKasa.Controls.Add(this.txtOdemeTutar);
            this.PageKasa.Name = "PageKasa";
            this.PageKasa.Size = new System.Drawing.Size(1351, 713);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 238);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "labelControl1";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdemeAl.Appearance.BackColor = System.Drawing.Color.Gold;
            this.btnOdemeAl.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOdemeAl.Appearance.Options.UseBackColor = true;
            this.btnOdemeAl.Appearance.Options.UseForeColor = true;
            this.btnOdemeAl.Location = new System.Drawing.Point(711, 100);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(229, 45);
            this.btnOdemeAl.TabIndex = 1;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // gridControl4
            // 
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView7;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(686, 713);
            this.gridControl4.TabIndex = 0;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView7.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView7.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView7.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView7.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView7.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView7.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView7.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView7.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView7.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView7.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView7.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView7.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView7.Appearance.Row.Options.UseFont = true;
            this.gridView7.Appearance.Row.Options.UseTextOptions = true;
            this.gridView7.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView7.GridControl = this.gridControl4;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            this.gridView7.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView7.OptionsView.ShowIndicator = false;
            this.gridView7.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView7.RowHeight = 40;
            // 
            // txtOdemeTutar
            // 
            this.txtOdemeTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdemeTutar.Location = new System.Drawing.Point(711, 50);
            this.txtOdemeTutar.Name = "txtOdemeTutar";
            this.txtOdemeTutar.Size = new System.Drawing.Size(229, 22);
            this.txtOdemeTutar.TabIndex = 2;
            // 
            // PageMuayeneler
            // 
            this.PageMuayeneler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PageMuayeneler.Caption = "PageMuayeneler";
            this.PageMuayeneler.Controls.Add(this.gridGecmis);
            this.PageMuayeneler.Controls.Add(this.simpleButton1);
            this.PageMuayeneler.Controls.Add(this.memoEdit2);
            this.PageMuayeneler.Controls.Add(this.memoEdit1);
            this.PageMuayeneler.Controls.Add(this.gridViewMuayene);
            this.PageMuayeneler.Name = "PageMuayeneler";
            this.PageMuayeneler.Size = new System.Drawing.Size(1351, 713);
            // 
            // gridGecmis
            // 
            this.gridGecmis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridGecmis.Location = new System.Drawing.Point(0, 191);
            this.gridGecmis.MainView = this.gridView3;
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.Size = new System.Drawing.Size(571, 522);
            this.gridGecmis.TabIndex = 4;
            this.gridGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView3.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView3.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView3.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView3.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView3.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView3.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView3.Appearance.Row.Options.UseFont = true;
            this.gridView3.Appearance.Row.Options.UseTextOptions = true;
            this.gridView3.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView3.GridControl = this.gridGecmis;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsView.ShowIndicator = false;
            this.gridView3.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView3.RowHeight = 40;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(597, 320);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(457, 50);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Muayeneyi Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // memoEdit2
            // 
            this.memoEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit2.Location = new System.Drawing.Point(597, 190);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(457, 100);
            this.memoEdit2.TabIndex = 2;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(597, 50);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(457, 100);
            this.memoEdit1.TabIndex = 1;
            // 
            // gridViewMuayene
            // 
            this.gridViewMuayene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridViewMuayene.Location = new System.Drawing.Point(0, 0);
            this.gridViewMuayene.MainView = this.gridView2;
            this.gridViewMuayene.Name = "gridViewMuayene";
            this.gridViewMuayene.Size = new System.Drawing.Size(1155, 707);
            this.gridViewMuayene.TabIndex = 0;
            this.gridViewMuayene.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.DimGray;
            this.gridView2.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView2.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView2.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridView2.Appearance.Row.Options.UseFont = true;
            this.gridView2.Appearance.Row.Options.UseTextOptions = true;
            this.gridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridView2.GridControl = this.gridViewMuayene;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowIndicator = false;
            this.gridView2.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.RowHeight = 40;
            // 
            // PageKlinikAyarlari
            // 
            this.PageKlinikAyarlari.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.PageKlinikAyarlari.Caption = "PageKlinikAyarlari";
            this.PageKlinikAyarlari.Controls.Add(this.groupKlinik);
            this.PageKlinikAyarlari.Name = "PageKlinikAyarlari";
            this.PageKlinikAyarlari.Size = new System.Drawing.Size(1351, 713);
            // 
            // groupKlinik
            // 
            this.groupKlinik.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupKlinik.Controls.Add(this.btnKaydet);
            this.groupKlinik.Controls.Add(this.lblSaatlerBaslik);
            this.groupKlinik.Controls.Add(this.txtSaatler);
            this.groupKlinik.Controls.Add(this.txtEmail);
            this.groupKlinik.Controls.Add(this.lblEmailBaslik);
            this.groupKlinik.Controls.Add(this.txtTel);
            this.groupKlinik.Controls.Add(this.lblTelBaslik);
            this.groupKlinik.Controls.Add(this.txtAdres);
            this.groupKlinik.Controls.Add(this.lblAdresBaslik);
            this.groupKlinik.Controls.Add(this.txtKlinikAdi);
            this.groupKlinik.Controls.Add(this.lblKlinikAdiBaslik);
            this.groupKlinik.Location = new System.Drawing.Point(375, 81);
            this.groupKlinik.Name = "groupKlinik";
            this.groupKlinik.Size = new System.Drawing.Size(600, 550);
            this.groupKlinik.TabIndex = 0;
            this.groupKlinik.Text = "Klinik Bilgilerini Düzenle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.Location = new System.Drawing.Point(360, 400);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 45);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblSaatlerBaslik
            // 
            this.lblSaatlerBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaatlerBaslik.Appearance.Options.UseFont = true;
            this.lblSaatlerBaslik.Location = new System.Drawing.Point(30, 280);
            this.lblSaatlerBaslik.Name = "lblSaatlerBaslik";
            this.lblSaatlerBaslik.Size = new System.Drawing.Size(133, 23);
            this.lblSaatlerBaslik.TabIndex = 8;
            this.lblSaatlerBaslik.Text = "Çalışma Saatleri:";
            // 
            // txtSaatler
            // 
            this.txtSaatler.Location = new System.Drawing.Point(30, 303);
            this.txtSaatler.Name = "txtSaatler";
            this.txtSaatler.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSaatler.Properties.Appearance.Options.UseFont = true;
            this.txtSaatler.Size = new System.Drawing.Size(500, 80);
            this.txtSaatler.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(290, 243);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.Properties.Appearance.Options.UseFont = true;
            this.txtEmail.Size = new System.Drawing.Size(240, 30);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmailBaslik
            // 
            this.lblEmailBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailBaslik.Appearance.Options.UseFont = true;
            this.lblEmailBaslik.Location = new System.Drawing.Point(290, 220);
            this.lblEmailBaslik.Name = "lblEmailBaslik";
            this.lblEmailBaslik.Size = new System.Drawing.Size(64, 23);
            this.lblEmailBaslik.TabIndex = 6;
            this.lblEmailBaslik.Text = "E-Posta:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(30, 243);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTel.Properties.Appearance.Options.UseFont = true;
            this.txtTel.Size = new System.Drawing.Size(240, 30);
            this.txtTel.TabIndex = 5;
            // 
            // lblTelBaslik
            // 
            this.lblTelBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelBaslik.Appearance.Options.UseFont = true;
            this.lblTelBaslik.Location = new System.Drawing.Point(30, 220);
            this.lblTelBaslik.Name = "lblTelBaslik";
            this.lblTelBaslik.Size = new System.Drawing.Size(65, 23);
            this.lblTelBaslik.TabIndex = 4;
            this.lblTelBaslik.Text = "Telefon:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(30, 128);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdres.Properties.Appearance.Options.UseFont = true;
            this.txtAdres.Size = new System.Drawing.Size(500, 80);
            this.txtAdres.TabIndex = 3;
            // 
            // lblAdresBaslik
            // 
            this.lblAdresBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdresBaslik.Appearance.Options.UseFont = true;
            this.lblAdresBaslik.Location = new System.Drawing.Point(30, 105);
            this.lblAdresBaslik.Name = "lblAdresBaslik";
            this.lblAdresBaslik.Size = new System.Drawing.Size(51, 23);
            this.lblAdresBaslik.TabIndex = 2;
            this.lblAdresBaslik.Text = "Adres:";
            // 
            // txtKlinikAdi
            // 
            this.txtKlinikAdi.Location = new System.Drawing.Point(30, 68);
            this.txtKlinikAdi.Name = "txtKlinikAdi";
            this.txtKlinikAdi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKlinikAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKlinikAdi.Size = new System.Drawing.Size(500, 30);
            this.txtKlinikAdi.TabIndex = 1;
            // 
            // lblKlinikAdiBaslik
            // 
            this.lblKlinikAdiBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKlinikAdiBaslik.Appearance.Options.UseFont = true;
            this.lblKlinikAdiBaslik.Location = new System.Drawing.Point(30, 45);
            this.lblKlinikAdiBaslik.Name = "lblKlinikAdiBaslik";
            this.lblKlinikAdiBaslik.Size = new System.Drawing.Size(84, 23);
            this.lblKlinikAdiBaslik.TabIndex = 0;
            this.lblKlinikAdiBaslik.Text = "Klinik Adı:";
            // 
            // schedulerDataStorage1
            // 
            this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
            this.schedulerDataStorage1.Labels.ColorSaving = DevExpress.XtraScheduler.DXColorSavingType.ArgbColor;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(1648, 713);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.accordionControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.PageKayit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.PageRandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRandevu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deRandevuTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.PageAsi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGelecek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateYapilma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.PageStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.PageKasa.ResumeLayout(false);
            this.PageKasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).EndInit();
            this.PageMuayeneler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMuayene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.PageKlinikAyarlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupKlinik)).EndInit();
            this.groupKlinik.ResumeLayout(false);
            this.groupKlinik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaatler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKlinikAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageKayit;
        private DevExpress.XtraBars.Navigation.NavigationPage PageRandevu;
        private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
        private DevExpress.XtraBars.Navigation.NavigationPage PageAsi;
        private DevExpress.XtraBars.Navigation.NavigationPage PageStok;
        private DevExpress.XtraBars.Navigation.NavigationPage PageKasa;
        private DevExpress.XtraBars.Navigation.NavigationPage PageMuayeneler;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraGrid.GridControl gridViewMuayene;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.SimpleButton btnAsiKaydet;
        private DevExpress.XtraEditors.DateEdit dateGelecek;
        private DevExpress.XtraEditors.DateEdit dateYapilma;
        private DevExpress.XtraEditors.TextEdit txtAsiAdi;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.GridControl gridViewStok;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SpinEdit spinEdit2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOdemeAl;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.TextEdit txtOdemeTutar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.DateEdit deRandevuTarihi;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraGrid.GridControl gridControlRandevu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRandevu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LookUpEdit lookUpHayvan;
        private DevExpress.XtraBars.Navigation.NavigationPage PageKlinikAyarlari;
        private DevExpress.XtraEditors.GroupControl groupKlinik;
        private DevExpress.XtraEditors.LabelControl lblKlinikAdiBaslik;
        private DevExpress.XtraEditors.TextEdit txtKlinikAdi;
        private DevExpress.XtraEditors.LabelControl lblAdresBaslik;
        private DevExpress.XtraEditors.MemoEdit txtAdres;
        private DevExpress.XtraEditors.LabelControl lblTelBaslik;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.LabelControl lblEmailBaslik;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl lblSaatlerBaslik;
        private DevExpress.XtraEditors.MemoEdit txtSaatler;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Panel panelContainer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElementSettings;
    }
}

