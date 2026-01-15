namespace VeterinerKlinigiOtomasyonu
{
    partial class HayvanlarimForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridHayvanlar = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colAd = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colAd = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colFotograf = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.layoutViewField_colFotograf = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.repoBtnSil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupYeniKayit = new DevExpress.XtraEditors.GroupControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.memoNot = new DevExpress.XtraEditors.MemoEdit();
            this.lblNot = new DevExpress.XtraEditors.LabelControl();
            this.txtYas = new DevExpress.XtraEditors.SpinEdit();
            this.lblYas = new DevExpress.XtraEditors.LabelControl();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblCinsiyet = new DevExpress.XtraEditors.LabelControl();
            this.txtCinsi = new DevExpress.XtraEditors.TextEdit();
            this.lblCinsi = new DevExpress.XtraEditors.LabelControl();
            this.cmbTur = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTur = new DevExpress.XtraEditors.LabelControl();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.lblAd = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupYeniKayit)).BeginInit();
            this.groupYeniKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCinsi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHayvanlar
            // 
            this.gridHayvanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHayvanlar.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.gridHayvanlar.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
            this.gridHayvanlar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridHayvanlar.Location = new System.Drawing.Point(401, 0);
            this.gridHayvanlar.MainView = this.layoutView1;
            this.gridHayvanlar.Margin = new System.Windows.Forms.Padding(4);
            this.gridHayvanlar.Name = "gridHayvanlar";
            this.gridHayvanlar.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnSil,
            this.repositoryItemPictureEdit1});
            this.gridHayvanlar.Size = new System.Drawing.Size(992, 770);
            this.gridHayvanlar.TabIndex = 1;
            this.gridHayvanlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            this.gridHayvanlar.Click += new System.EventHandler(this.gridHayvanlar_Click);
            // 
            // layoutView1
            // 
            this.layoutView1.CardMinSize = new System.Drawing.Size(250, 300);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colAd,
            this.colFotograf});
            this.layoutView1.GridControl = this.gridHayvanlar;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ShowCardCaption = false;
            this.layoutView1.OptionsView.ShowHeaderPanel = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
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
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colAd,
            this.layoutViewField_colFotograf});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // repoBtnSil
            // 
            this.repoBtnSil.AutoHeight = false;
            this.repoBtnSil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Sil", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoBtnSil.Name = "repoBtnSil";
            this.repoBtnSil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoBtnSil.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtnSil_ButtonClick);
            // 
            // groupYeniKayit
            // 
            this.groupYeniKayit.Controls.Add(this.btnGuncelle);
            this.groupYeniKayit.Controls.Add(this.btnResimSec);
            this.groupYeniKayit.Controls.Add(this.btnKaydet);
            this.groupYeniKayit.Controls.Add(this.memoNot);
            this.groupYeniKayit.Controls.Add(this.lblNot);
            this.groupYeniKayit.Controls.Add(this.txtYas);
            this.groupYeniKayit.Controls.Add(this.lblYas);
            this.groupYeniKayit.Controls.Add(this.cmbCinsiyet);
            this.groupYeniKayit.Controls.Add(this.lblCinsiyet);
            this.groupYeniKayit.Controls.Add(this.txtCinsi);
            this.groupYeniKayit.Controls.Add(this.lblCinsi);
            this.groupYeniKayit.Controls.Add(this.cmbTur);
            this.groupYeniKayit.Controls.Add(this.lblTur);
            this.groupYeniKayit.Controls.Add(this.pbResim);
            this.groupYeniKayit.Controls.Add(this.txtAd);
            this.groupYeniKayit.Controls.Add(this.lblAd);
            this.groupYeniKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupYeniKayit.Location = new System.Drawing.Point(0, 0);
            this.groupYeniKayit.Margin = new System.Windows.Forms.Padding(4);
            this.groupYeniKayit.Name = "groupYeniKayit";
            this.groupYeniKayit.Size = new System.Drawing.Size(401, 770);
            this.groupYeniKayit.TabIndex = 0;
            this.groupYeniKayit.Text = "Yeni Hayvan Ekle";
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
            this.btnGuncelle.Location = new System.Drawing.Point(202, 697);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(165, 49);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnResimSec.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResimSec.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnResimSec.Appearance.Options.UseBackColor = true;
            this.btnResimSec.Appearance.Options.UseFont = true;
            this.btnResimSec.Appearance.Options.UseForeColor = true;
            this.btnResimSec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnResimSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResimSec.Location = new System.Drawing.Point(37, 212);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnResimSec.Size = new System.Drawing.Size(148, 47);
            this.btnResimSec.TabIndex = 13;
            this.btnResimSec.Text = "Fotoğraf Seç";
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Appearance.Options.UseForeColor = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Location = new System.Drawing.Point(20, 697);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 49);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            // 
            // memoNot
            // 
            this.memoNot.Location = new System.Drawing.Point(20, 591);
            this.memoNot.Margin = new System.Windows.Forms.Padding(4);
            this.memoNot.Name = "memoNot";
            this.memoNot.Size = new System.Drawing.Size(347, 98);
            this.memoNot.TabIndex = 9;
            // 
            // lblNot
            // 
            this.lblNot.Location = new System.Drawing.Point(20, 567);
            this.lblNot.Margin = new System.Windows.Forms.Padding(4);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(58, 16);
            this.lblNot.TabIndex = 8;
            this.lblNot.Text = "Bilgi Notu:";
            // 
            // txtYas
            // 
            this.txtYas.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtYas.Location = new System.Drawing.Point(20, 537);
            this.txtYas.Margin = new System.Windows.Forms.Padding(4);
            this.txtYas.Name = "txtYas";
            this.txtYas.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtYas.Size = new System.Drawing.Size(347, 22);
            this.txtYas.TabIndex = 7;
            // 
            // lblYas
            // 
            this.lblYas.Location = new System.Drawing.Point(20, 513);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(28, 16);
            this.lblYas.TabIndex = 6;
            this.lblYas.Text = "Yaşı:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(20, 483);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Dişi",
            "Erkek"});
            this.cmbCinsiyet.Size = new System.Drawing.Size(347, 22);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.Location = new System.Drawing.Point(20, 459);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(52, 16);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "Cinsiyeti:";
            // 
            // txtCinsi
            // 
            this.txtCinsi.Location = new System.Drawing.Point(20, 429);
            this.txtCinsi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCinsi.Name = "txtCinsi";
            this.txtCinsi.Size = new System.Drawing.Size(347, 22);
            this.txtCinsi.TabIndex = 4;
            // 
            // lblCinsi
            // 
            this.lblCinsi.Location = new System.Drawing.Point(20, 405);
            this.lblCinsi.Margin = new System.Windows.Forms.Padding(4);
            this.lblCinsi.Name = "lblCinsi";
            this.lblCinsi.Size = new System.Drawing.Size(32, 16);
            this.lblCinsi.TabIndex = 42;
            this.lblCinsi.Text = "Cinsi:";
            // 
            // cmbTur
            // 
            this.cmbTur.Location = new System.Drawing.Point(20, 375);
            this.cmbTur.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTur.Properties.Items.AddRange(new object[] {
            "Kedi",
            "Köpek",
            "Kuş",
            "Hamster",
            "Diğer"});
            this.cmbTur.Size = new System.Drawing.Size(347, 22);
            this.cmbTur.TabIndex = 3;
            // 
            // lblTur
            // 
            this.lblTur.Location = new System.Drawing.Point(20, 351);
            this.lblTur.Margin = new System.Windows.Forms.Padding(4);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(32, 16);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Türü:";
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Location = new System.Drawing.Point(217, 109);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(150, 150);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResim.TabIndex = 12;
            this.pbResim.TabStop = false;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(20, 321);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(347, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.Location = new System.Drawing.Point(20, 297);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(68, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Hayvan Adı:";
            // 
            // HayvanlarimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(1393, 770);
            this.Controls.Add(this.gridHayvanlar);
            this.Controls.Add(this.groupYeniKayit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HayvanlarimForm";
            this.Text = "Hayvanlarım";
            ((System.ComponentModel.ISupportInitialize)(this.gridHayvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupYeniKayit)).EndInit();
            this.groupYeniKayit.ResumeLayout(false);
            this.groupYeniKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCinsi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHayvanlar;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colAd;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colAd;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colFotograf;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colFotograf;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnSil;

        private DevExpress.XtraEditors.GroupControl groupYeniKayit;
        private DevExpress.XtraEditors.LabelControl lblAd;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl lblTur;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTur;
        private DevExpress.XtraEditors.LabelControl lblCinsi;
        private DevExpress.XtraEditors.TextEdit txtCinsi;
        private DevExpress.XtraEditors.LabelControl lblCinsiyet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private DevExpress.XtraEditors.LabelControl lblYas;
        private DevExpress.XtraEditors.SpinEdit txtYas;
        private DevExpress.XtraEditors.LabelControl lblNot;
        private DevExpress.XtraEditors.MemoEdit memoNot;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;

        private System.Windows.Forms.PictureBox pbResim;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
