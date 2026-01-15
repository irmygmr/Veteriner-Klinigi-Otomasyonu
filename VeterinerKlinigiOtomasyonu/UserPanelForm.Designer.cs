using System;

namespace VeterinerKlinigiOtomasyonu
{
    partial class UserPanelForm
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accAnaSayfa = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accProfil = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accHayvanlarim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accRandevularim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accRandevuOlustur = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accOdeme = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accKlinik = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accAsilarim = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.flowStats = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGelecekRandevu = new DevExpress.XtraEditors.PanelControl();
            this.lblGelecekRandevuTarih = new DevExpress.XtraEditors.LabelControl();
            this.lblGelecekRandevuBaslik = new DevExpress.XtraEditors.LabelControl();
            this.panelToplamBorc = new DevExpress.XtraEditors.PanelControl();
            this.lblToplamBorcTutar = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamBorcBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.tableLayoutPanelDashboard.SuspendLayout();
            this.flowStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelGelecekRandevu)).BeginInit();
            this.panelGelecekRandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelToplamBorc)).BeginInit();
            this.panelToplamBorc.SuspendLayout();
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
            this.accAnaSayfa,
            this.accProfil,
            this.accHayvanlarim,
            this.accRandevularim,
            this.accRandevuOlustur,
            this.accOdeme,
            this.accKlinik,
            this.accAsilarim});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(4);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(396, 878);
            this.accordionControl1.TabIndex = 4;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accAnaSayfa
            // 
            this.accAnaSayfa.Name = "accAnaSayfa";
            this.accAnaSayfa.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accAnaSayfa.Text = "Ana Sayfa";
            this.accAnaSayfa.Click += new System.EventHandler(this.accAnaSayfa_Click);
            // 
            // accProfil
            // 
            this.accProfil.Name = "accProfil";
            this.accProfil.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accProfil.Text = "Profilim";
            this.accProfil.Click += new System.EventHandler(this.accProfil_Click);
            // 
            // accHayvanlarim
            // 
            this.accHayvanlarim.Name = "accHayvanlarim";
            this.accHayvanlarim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accHayvanlarim.Text = "Hayvanlarım";
            this.accHayvanlarim.Click += new System.EventHandler(this.accHayvanlarim_Click);
            // 
            // accRandevularim
            // 
            this.accRandevularim.Name = "accRandevularim";
            this.accRandevularim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accRandevularim.Text = "Randevularım";
            this.accRandevularim.Click += new System.EventHandler(this.accRandevularim_Click);
            // 
            // accRandevuOlustur
            // 
            this.accRandevuOlustur.Name = "accRandevuOlustur";
            this.accRandevuOlustur.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accRandevuOlustur.Text = "Randevu Al";
            this.accRandevuOlustur.Click += new System.EventHandler(this.accRandevuOlustur_Click);
            // 
            // accOdeme
            // 
            this.accOdeme.Name = "accOdeme";
            this.accOdeme.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accOdeme.Text = "Ödemelerim";
            this.accOdeme.Click += new System.EventHandler(this.accOdeme_Click);
            // 
            // accKlinik
            // 
            this.accKlinik.Name = "accKlinik";
            this.accKlinik.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accKlinik.Text = "Klinik Bilgileri";
            this.accKlinik.Click += new System.EventHandler(this.accKlinik_Click);
            // 
            // accAsilarim
            // 
            this.accAsilarim.Name = "accAsilarim";
            this.accAsilarim.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accAsilarim.Text = "Aşı Takvimi";
            this.accAsilarim.Click += new System.EventHandler(this.accAsilarim_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.panelContainer.Controls.Add(this.tableLayoutPanelDashboard);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(396, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(50);
            this.panelContainer.Size = new System.Drawing.Size(1185, 878);
            this.panelContainer.TabIndex = 5;
            // 
            // tableLayoutPanelDashboard
            // 
            this.tableLayoutPanelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelDashboard.ColumnCount = 1;
            this.tableLayoutPanelDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDashboard.Controls.Add(this.lblWelcome, 0, 0);
            this.tableLayoutPanelDashboard.Controls.Add(this.flowStats, 0, 1);
            this.tableLayoutPanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDashboard.Location = new System.Drawing.Point(50, 50);
            this.tableLayoutPanelDashboard.Name = "tableLayoutPanelDashboard";
            this.tableLayoutPanelDashboard.RowCount = 2;
            this.tableLayoutPanelDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelDashboard.Size = new System.Drawing.Size(1085, 778);
            this.tableLayoutPanelDashboard.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Appearance.Options.UseBackColor = true;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.Appearance.Options.UseTextOptions = true;
            this.lblWelcome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWelcome.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Location = new System.Drawing.Point(4, 4);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1077, 458);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Tarçın Veteriner Kliniğine\r\nHoşgeldiniz";
            // 
            // flowStats
            // 
            this.flowStats.AutoSize = true;
            this.flowStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowStats.Controls.Add(this.panelGelecekRandevu);
            this.flowStats.Controls.Add(this.panelToplamBorc);
            this.flowStats.Dock = System.Windows.Forms.DockStyle.None;
            this.flowStats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowStats.Location = new System.Drawing.Point(232, 469);
            this.flowStats.Name = "flowStats";
            this.flowStats.Size = new System.Drawing.Size(600, 190);
            this.flowStats.TabIndex = 1;
            // 
            // panelGelecekRandevu
            // 
            this.panelGelecekRandevu.Appearance.BackColor = System.Drawing.Color.White;
            this.panelGelecekRandevu.Appearance.Options.UseBackColor = true;
            this.panelGelecekRandevu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelGelecekRandevu.Controls.Add(this.lblGelecekRandevuTarih);
            this.panelGelecekRandevu.Controls.Add(this.lblGelecekRandevuBaslik);
            this.panelGelecekRandevu.Location = new System.Drawing.Point(20, 20);
            this.panelGelecekRandevu.Margin = new System.Windows.Forms.Padding(20);
            this.panelGelecekRandevu.Name = "panelGelecekRandevu";
            this.panelGelecekRandevu.Size = new System.Drawing.Size(300, 150);
            this.panelGelecekRandevu.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelGelecekRandevu.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelGelecekRandevu.TabIndex = 0;
            // 
            // lblGelecekRandevuTarih
            // 
            this.lblGelecekRandevuTarih.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGelecekRandevuTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblGelecekRandevuTarih.Appearance.Options.UseFont = true;
            this.lblGelecekRandevuTarih.Appearance.Options.UseForeColor = true;
            this.lblGelecekRandevuTarih.Appearance.Options.UseTextOptions = true;
            this.lblGelecekRandevuTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblGelecekRandevuTarih.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGelecekRandevuTarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGelecekRandevuTarih.Location = new System.Drawing.Point(0, 75);
            this.lblGelecekRandevuTarih.Name = "lblGelecekRandevuTarih";
            this.lblGelecekRandevuTarih.Size = new System.Drawing.Size(300, 75);
            this.lblGelecekRandevuTarih.TabIndex = 1;
            this.lblGelecekRandevuTarih.Text = "-";
            // 
            // lblGelecekRandevuBaslik
            // 
            this.lblGelecekRandevuBaslik.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.lblGelecekRandevuBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGelecekRandevuBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblGelecekRandevuBaslik.Appearance.Options.UseBackColor = true;
            this.lblGelecekRandevuBaslik.Appearance.Options.UseFont = true;
            this.lblGelecekRandevuBaslik.Appearance.Options.UseForeColor = true;
            this.lblGelecekRandevuBaslik.Appearance.Options.UseTextOptions = true;
            this.lblGelecekRandevuBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblGelecekRandevuBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblGelecekRandevuBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGelecekRandevuBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblGelecekRandevuBaslik.Name = "lblGelecekRandevuBaslik";
            this.lblGelecekRandevuBaslik.Size = new System.Drawing.Size(300, 50);
            this.lblGelecekRandevuBaslik.TabIndex = 0;
            this.lblGelecekRandevuBaslik.Text = "Gelecek Randevu";
            // 
            // panelToplamBorc
            // 
            this.panelToplamBorc.Appearance.BackColor = System.Drawing.Color.White;
            this.panelToplamBorc.Appearance.Options.UseBackColor = true;
            this.panelToplamBorc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelToplamBorc.Controls.Add(this.lblToplamBorcTutar);
            this.panelToplamBorc.Controls.Add(this.lblToplamBorcBaslik);
            this.panelToplamBorc.Location = new System.Drawing.Point(360, 20);
            this.panelToplamBorc.Margin = new System.Windows.Forms.Padding(20);
            this.panelToplamBorc.Name = "panelToplamBorc";
            this.panelToplamBorc.Size = new System.Drawing.Size(300, 150);
            this.panelToplamBorc.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelToplamBorc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelToplamBorc.TabIndex = 1;
            // 
            // lblToplamBorcTutar
            // 
            this.lblToplamBorcTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblToplamBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblToplamBorcTutar.Appearance.Options.UseFont = true;
            this.lblToplamBorcTutar.Appearance.Options.UseForeColor = true;
            this.lblToplamBorcTutar.Appearance.Options.UseTextOptions = true;
            this.lblToplamBorcTutar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblToplamBorcTutar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblToplamBorcTutar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblToplamBorcTutar.Location = new System.Drawing.Point(0, 75);
            this.lblToplamBorcTutar.Name = "lblToplamBorcTutar";
            this.lblToplamBorcTutar.Size = new System.Drawing.Size(300, 75);
            this.lblToplamBorcTutar.TabIndex = 1;
            this.lblToplamBorcTutar.Text = "0,00 TL";
            // 
            // lblToplamBorcBaslik
            // 
            this.lblToplamBorcBaslik.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.lblToplamBorcBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamBorcBaslik.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblToplamBorcBaslik.Appearance.Options.UseBackColor = true;
            this.lblToplamBorcBaslik.Appearance.Options.UseFont = true;
            this.lblToplamBorcBaslik.Appearance.Options.UseForeColor = true;
            this.lblToplamBorcBaslik.Appearance.Options.UseTextOptions = true;
            this.lblToplamBorcBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblToplamBorcBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblToplamBorcBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblToplamBorcBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblToplamBorcBaslik.Name = "lblToplamBorcBaslik";
            this.lblToplamBorcBaslik.Size = new System.Drawing.Size(300, 50);
            this.lblToplamBorcBaslik.TabIndex = 0;
            this.lblToplamBorcBaslik.Text = "Toplam Borç";
            // 
            // UserPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1581, 878);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.accordionControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPanelForm";
            this.Text = "Veteriner Bilgi Sistemi - Kullanıcı Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.tableLayoutPanelDashboard.ResumeLayout(false);
            this.flowStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelGelecekRandevu)).EndInit();
            this.panelGelecekRandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelToplamBorc)).EndInit();
            this.panelToplamBorc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accAnaSayfa;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accProfil;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accHayvanlarim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accRandevularim;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accRandevuOlustur;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accOdeme;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accKlinik;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accAsilarim;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDashboard;
        private System.Windows.Forms.FlowLayoutPanel flowStats;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.PanelControl panelGelecekRandevu;
        private DevExpress.XtraEditors.LabelControl lblGelecekRandevuTarih;
        private DevExpress.XtraEditors.LabelControl lblGelecekRandevuBaslik;
        private DevExpress.XtraEditors.PanelControl panelToplamBorc;
        private DevExpress.XtraEditors.LabelControl lblToplamBorcTutar;
        private DevExpress.XtraEditors.LabelControl lblToplamBorcBaslik;
    }
}
