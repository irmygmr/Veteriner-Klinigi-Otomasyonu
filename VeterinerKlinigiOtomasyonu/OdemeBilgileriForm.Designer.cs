namespace VeterinerKlinigiOtomasyonu
{
    partial class OdemeBilgileriForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupOdeme = new DevExpress.XtraEditors.GroupControl();
            this.lblNot = new DevExpress.XtraEditors.LabelControl();
            this.lblAlici = new DevExpress.XtraEditors.LabelControl();
            this.lblIban = new DevExpress.XtraEditors.LabelControl();
            this.lblIbanBaslik = new DevExpress.XtraEditors.LabelControl();
            this.lblBanka = new DevExpress.XtraEditors.LabelControl();
            this.lblBorcDurumu = new DevExpress.XtraEditors.LabelControl();
            this.gridGecmis = new DevExpress.XtraGrid.GridControl();
            this.viewGecmis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtnOde = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelUst = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupOdeme)).BeginInit();
            this.groupOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnOde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).BeginInit();
            this.panelUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupOdeme
            // 
            this.groupOdeme.Controls.Add(this.lblNot);
            this.groupOdeme.Controls.Add(this.lblAlici);
            this.groupOdeme.Controls.Add(this.lblIban);
            this.groupOdeme.Controls.Add(this.lblIbanBaslik);
            this.groupOdeme.Controls.Add(this.lblBanka);
            this.groupOdeme.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupOdeme.Location = new System.Drawing.Point(0, 0);
            this.groupOdeme.Margin = new System.Windows.Forms.Padding(4);
            this.groupOdeme.Name = "groupOdeme";
            this.groupOdeme.Size = new System.Drawing.Size(613, 320);
            this.groupOdeme.TabIndex = 0;
            this.groupOdeme.Text = "Banka Hesap Bilgileri";
            // 
            // lblNot
            // 
            this.lblNot.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblNot.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lblNot.Appearance.Options.UseFont = true;
            this.lblNot.Appearance.Options.UseForeColor = true;
            this.lblNot.Location = new System.Drawing.Point(40, 234);
            this.lblNot.Margin = new System.Windows.Forms.Padding(4);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(359, 40);
            this.lblNot.TabIndex = 4;
            this.lblNot.Text = "* Lütfen açıklama kısmına Ad Soyad ve Randevu Tarihini \r\nyazmayı unutmayınız. Öde" +
    "meniz 15 dk içinde onaylanır.";
            // 
            // lblAlici
            // 
            this.lblAlici.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAlici.Appearance.Options.UseFont = true;
            this.lblAlici.Location = new System.Drawing.Point(40, 98);
            this.lblAlici.Margin = new System.Windows.Forms.Padding(4);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(242, 28);
            this.lblAlici.TabIndex = 1;
            this.lblAlici.Text = "Alıcı: Tarçın Veteriner Kliniği";
            // 
            // lblIban
            // 
            this.lblIban.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIban.Appearance.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblIban.Appearance.Options.UseBackColor = true;
            this.lblIban.Appearance.Options.UseFont = true;
            this.lblIban.Location = new System.Drawing.Point(40, 178);
            this.lblIban.Margin = new System.Windows.Forms.Padding(4);
            this.lblIban.Name = "lblIban";
            this.lblIban.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblIban.Size = new System.Drawing.Size(430, 39);
            this.lblIban.TabIndex = 3;
            this.lblIban.Text = "TR12 0001 0002 0003 0004 0005 06";
            // 
            // lblIbanBaslik
            // 
            this.lblIbanBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
            this.lblIbanBaslik.Appearance.Options.UseFont = true;
            this.lblIbanBaslik.Location = new System.Drawing.Point(40, 148);
            this.lblIbanBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.lblIbanBaslik.Name = "lblIbanBaslik";
            this.lblIbanBaslik.Size = new System.Drawing.Size(43, 23);
            this.lblIbanBaslik.TabIndex = 2;
            this.lblIbanBaslik.Text = "IBAN:";
            // 
            // lblBanka
            // 
            this.lblBanka.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBanka.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBanka.Appearance.Options.UseFont = true;
            this.lblBanka.Appearance.Options.UseForeColor = true;
            this.lblBanka.Location = new System.Drawing.Point(40, 49);
            this.lblBanka.Margin = new System.Windows.Forms.Padding(4);
            this.lblBanka.Name = "lblBanka";
            this.lblBanka.Size = new System.Drawing.Size(152, 31);
            this.lblBanka.TabIndex = 0;
            this.lblBanka.Text = "Ziraat Bankası";
            // 
            // lblBorcDurumu
            // 
            this.lblBorcDurumu.Appearance.BackColor = System.Drawing.Color.Salmon;
            this.lblBorcDurumu.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBorcDurumu.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblBorcDurumu.Appearance.Options.UseBackColor = true;
            this.lblBorcDurumu.Appearance.Options.UseFont = true;
            this.lblBorcDurumu.Appearance.Options.UseForeColor = true;
            this.lblBorcDurumu.Appearance.Options.UseTextOptions = true;
            this.lblBorcDurumu.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBorcDurumu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBorcDurumu.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBorcDurumu.Location = new System.Drawing.Point(640, 0);
            this.lblBorcDurumu.Margin = new System.Windows.Forms.Padding(4);
            this.lblBorcDurumu.Name = "lblBorcDurumu";
            this.lblBorcDurumu.Size = new System.Drawing.Size(373, 320);
            this.lblBorcDurumu.TabIndex = 1;
            this.lblBorcDurumu.Text = "GÜNCEL BORÇ:\r\n250.00 TL";
            // 
            // gridGecmis
            // 
            this.gridGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGecmis.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridGecmis.Location = new System.Drawing.Point(27, 345);
            this.gridGecmis.MainView = this.viewGecmis;
            this.gridGecmis.Margin = new System.Windows.Forms.Padding(4);
            this.gridGecmis.Name = "gridGecmis";
            this.gridGecmis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnOde});
            this.gridGecmis.Size = new System.Drawing.Size(1013, 368);
            this.gridGecmis.TabIndex = 1;
            this.gridGecmis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewGecmis});
            this.gridGecmis.Click += new System.EventHandler(this.gridGecmis_Click);
            // 
            // viewGecmis
            // 
            this.viewGecmis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colAciklama,
            this.colTutar,
            this.colDurum,
            this.colOde});
            this.viewGecmis.DetailHeight = 431;
            this.viewGecmis.GridControl = this.gridGecmis;
            this.viewGecmis.Name = "viewGecmis";
            this.viewGecmis.OptionsView.ShowGroupPanel = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 27;
            this.colTarih.Name = "colTarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 100;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 27;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 200;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 27;
            this.colTutar.Name = "colTutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 2;
            this.colTutar.Width = 100;
            // 
            // colDurum
            // 
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.MinWidth = 27;
            this.colDurum.Name = "colDurum";
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 3;
            this.colDurum.Width = 100;
            // 
            // colOde
            // 
            this.colOde.Caption = "Ödeme Yap";
            this.colOde.ColumnEdit = this.repoBtnOde;
            this.colOde.Name = "colOde";
            this.colOde.Visible = true;
            this.colOde.VisibleIndex = 4;
            this.colOde.Width = 100;
            // 
            // repoBtnOde
            // 
            this.repoBtnOde.AutoHeight = false;
            this.repoBtnOde.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Ödedim", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoBtnOde.Name = "repoBtnOde";
            this.repoBtnOde.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtnOde.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtnOde_ButtonClick);
            // 
            // panelUst
            // 
            this.panelUst.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelUst.Controls.Add(this.lblBorcDurumu);
            this.panelUst.Controls.Add(this.groupOdeme);
            this.panelUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUst.Location = new System.Drawing.Point(27, 25);
            this.panelUst.Margin = new System.Windows.Forms.Padding(4);
            this.panelUst.Name = "panelUst";
            this.panelUst.Size = new System.Drawing.Size(1013, 320);
            this.panelUst.TabIndex = 0;
            // 
            // OdemeBilgileriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.gridGecmis);
            this.Controls.Add(this.panelUst);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdemeBilgileriForm";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme Bilgileri ve Geçmişi";
            ((System.ComponentModel.ISupportInitialize)(this.groupOdeme)).EndInit();
            this.groupOdeme.ResumeLayout(false);
            this.groupOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnOde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelUst)).EndInit();
            this.panelUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelUst;
        private DevExpress.XtraEditors.GroupControl groupOdeme;
        private DevExpress.XtraEditors.LabelControl lblBanka;
        private DevExpress.XtraEditors.LabelControl lblIbanBaslik;
        private DevExpress.XtraEditors.LabelControl lblIban;
        private DevExpress.XtraEditors.LabelControl lblAlici;
        private DevExpress.XtraEditors.LabelControl lblNot;
        private DevExpress.XtraEditors.LabelControl lblBorcDurumu;
        
        private DevExpress.XtraGrid.GridControl gridGecmis;
        private DevExpress.XtraGrid.Views.Grid.GridView viewGecmis;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOde;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnOde;
    }
}
