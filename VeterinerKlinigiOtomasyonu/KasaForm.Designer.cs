namespace VeterinerKlinigiOtomasyonu
{
    partial class KasaForm
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
            // Layout Containers
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.groupOzet = new DevExpress.XtraEditors.GroupControl();
            this.lblNetKasa = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamGider = new DevExpress.XtraEditors.LabelControl();
            this.lblToplamGelir = new DevExpress.XtraEditors.LabelControl();
            this.groupIslem = new DevExpress.XtraEditors.GroupControl();
            
            // Input Controls
            this.radioIslemTipi = new DevExpress.XtraEditors.RadioGroup();
            this.lookUpMusteri = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAciklama = new DevExpress.XtraEditors.TextEdit();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.txtBirimFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtOdemeTutar = new DevExpress.XtraEditors.TextEdit();
            
            // Labels
            this.lblIslemTipi = new DevExpress.XtraEditors.LabelControl();
            this.lblMusteri = new DevExpress.XtraEditors.LabelControl();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            this.lblAdet = new DevExpress.XtraEditors.LabelControl();
            this.lblBirimFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblTutar = new DevExpress.XtraEditors.LabelControl();

            // Buttons
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();

            // Split Container & Grids
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupGelir = new DevExpress.XtraEditors.GroupControl();
            this.gridControlGelir = new DevExpress.XtraGrid.GridControl();
            this.gridViewGelir = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupGider = new DevExpress.XtraEditors.GroupControl();
            this.gridControlGider = new DevExpress.XtraGrid.GridControl();
            this.gridViewGider = new DevExpress.XtraGrid.Views.Grid.GridView();

            // Columns - Explicit Definition to avoid auto-gen issues
            // Common Columns
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn(); // IslemTipi
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            
            // Gelir Specific
            this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeDurumu = new DevExpress.XtraGrid.Columns.GridColumn();

            // Gider Specific Columns (reusing common where possible or creating new)
            this.colGiderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiderTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiderAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiderTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupOzet)).BeginInit();
            this.groupOzet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslem)).BeginInit();
            this.groupIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioIslemTipi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMusteri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupGelir)).BeginInit();
            this.groupGelir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGider)).BeginInit();
            this.groupGider.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGider)).BeginInit();
            this.SuspendLayout();

            // 
            // panelControlTop
            // 
            this.panelControlTop.Controls.Add(this.groupIslem);
            this.panelControlTop.Controls.Add(this.groupOzet);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 0);
            this.panelControlTop.Size = new System.Drawing.Size(1200, 230); // Increased height for better spacing

            // 
            // groupOzet
            // 
            this.groupOzet.Controls.Add(this.lblNetKasa);
            this.groupOzet.Controls.Add(this.lblToplamGider);
            this.groupOzet.Controls.Add(this.lblToplamGelir);
            this.groupOzet.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupOzet.Location = new System.Drawing.Point(900, 2);
            this.groupOzet.Size = new System.Drawing.Size(298, 226);
            this.groupOzet.Text = "Kasa Durumu";

            // 
            // lblNetKasa
            // 
            this.lblNetKasa.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNetKasa.Location = new System.Drawing.Point(20, 140);
            this.lblNetKasa.Text = "Net Kasa: 0.00 TL";

            this.lblToplamGelir.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamGelir.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblToplamGelir.Location = new System.Drawing.Point(20, 50);
            this.lblToplamGelir.Text = "Toplam Gelir: 0.00 TL";

            this.lblToplamGider.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamGider.Appearance.ForeColor = System.Drawing.Color.Firebrick;
            this.lblToplamGider.Location = new System.Drawing.Point(20, 90);
            this.lblToplamGider.Text = "Toplam Gider: 0.00 TL";


            // 
            // groupIslem
            // 
            this.groupIslem.Controls.Add(this.radioIslemTipi);
            this.groupIslem.Controls.Add(this.lblIslemTipi);
            this.groupIslem.Controls.Add(this.lookUpMusteri);
            this.groupIslem.Controls.Add(this.lblMusteri);
            this.groupIslem.Controls.Add(this.txtAciklama);
            this.groupIslem.Controls.Add(this.lblAciklama);
            this.groupIslem.Controls.Add(this.txtAdet);
            this.groupIslem.Controls.Add(this.lblAdet);
            this.groupIslem.Controls.Add(this.txtBirimFiyat);
            this.groupIslem.Controls.Add(this.lblBirimFiyat);
            this.groupIslem.Controls.Add(this.txtOdemeTutar);
            this.groupIslem.Controls.Add(this.lblTutar);
            this.groupIslem.Controls.Add(this.btnEkle);
            this.groupIslem.Controls.Add(this.btnGuncelle);
            this.groupIslem.Controls.Add(this.btnSil);
            this.groupIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupIslem.Text = "İşlem Detayları";

            // Controls Placement
            // Row 1: Islem Tipi (Radio)
            this.lblIslemTipi.Text = "İşlem Türü:";
            this.lblIslemTipi.Location = new System.Drawing.Point(20, 40);
            
            this.radioIslemTipi.Location = new System.Drawing.Point(100, 35);
            this.radioIslemTipi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Tahsilat", "Tahsilat (Gelir)"),
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Borc", "Hizmet (Borç)"),
                new DevExpress.XtraEditors.Controls.RadioGroupItem("Gider", "Gider (Satın Alım)")
            });
            this.radioIslemTipi.Size = new System.Drawing.Size(350, 30);
            this.radioIslemTipi.SelectedIndex = 0;
            this.radioIslemTipi.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioIslemTipi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;

            // Row 2: Musteri
            this.lblMusteri.Text = "Müşteri:";
            this.lblMusteri.Location = new System.Drawing.Point(20, 80);
            this.lookUpMusteri.Location = new System.Drawing.Point(100, 77);
            this.lookUpMusteri.Size = new System.Drawing.Size(350, 22);
            this.lookUpMusteri.Properties.NullText = "Müşteri Seçiniz";
            this.lookUpMusteri.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
                new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});

            // Row 3: Aciklama
            this.lblAciklama.Text = "Açıklama:";
            this.lblAciklama.Location = new System.Drawing.Point(20, 115);
            this.txtAciklama.Location = new System.Drawing.Point(100, 112);
            this.txtAciklama.Size = new System.Drawing.Size(350, 22);

            // Row 4: Adet | Birim | Tutar
            this.lblAdet.Text = "Adet:";
            this.lblAdet.Location = new System.Drawing.Point(480, 40);
            this.txtAdet.Location = new System.Drawing.Point(550, 37);
            this.txtAdet.Size = new System.Drawing.Size(60, 22);

            this.lblBirimFiyat.Text = "Birim Fiyat:";
            this.lblBirimFiyat.Location = new System.Drawing.Point(480, 75);
            this.txtBirimFiyat.Location = new System.Drawing.Point(550, 72);
            this.txtBirimFiyat.Size = new System.Drawing.Size(80, 22);

            this.lblTutar.Text = "TOPLAM:";
            this.lblTutar.Location = new System.Drawing.Point(480, 115);
            this.lblTutar.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtOdemeTutar.Location = new System.Drawing.Point(550, 112);
            this.txtOdemeTutar.Size = new System.Drawing.Size(100, 22);
            this.txtOdemeTutar.Properties.ReadOnly = true;

            // Buttons Area
            this.btnEkle.Text = "KAYDET";
            this.btnEkle.Location = new System.Drawing.Point(100, 150);
            this.btnEkle.Size = new System.Drawing.Size(110, 40);
            this.btnEkle.Appearance.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Appearance.Options.UseBackColor = true;
            this.btnEkle.Appearance.Options.UseForeColor = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Location = new System.Drawing.Point(220, 150);
            this.btnGuncelle.Size = new System.Drawing.Size(110, 40);
            this.btnGuncelle.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnGuncelle.Appearance.Options.UseBackColor = true;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnSil.Text = "SİL";
            this.btnSil.Location = new System.Drawing.Point(340, 150);
            this.btnSil.Size = new System.Drawing.Size(110, 40);
            this.btnSil.Appearance.BackColor = System.Drawing.Color.Firebrick;
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);


            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 230);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupGelir);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupGider);
            this.splitContainerControl1.SplitterPosition = 600;

            // 
            // groupGelir (LEFT GRID)
            // 
            this.groupGelir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGelir.Text = "GELİR LİSTESİ (Tahsilat & Borç)";
            this.groupGelir.Controls.Add(this.gridControlGelir);

            this.gridControlGelir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGelir.MainView = this.gridViewGelir;
            this.gridControlGelir.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewGelir });

            this.gridViewGelir.GridControl = this.gridControlGelir;
            this.gridViewGelir.OptionsBehavior.Editable = false;

            
            // Columns Gelir
            this.colId.FieldName = "KasaId";
            this.colId.Visible = false;

            this.colTarih.FieldName = "Tarih";
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Caption = "Tarih";

            this.colMusteri.FieldName = "MusteriAdi"; 
            this.colMusteri.Visible = true;
            this.colMusteri.VisibleIndex = 1;
            this.colMusteri.Caption = "Müşteri";

            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Caption = "Açıklama";

            this.colTutar.FieldName = "Tutar";
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 3;
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.DisplayFormat.FormatString = "c2";

            this.colOdemeDurumu.FieldName = "OdemeDurumu";
            this.colOdemeDurumu.Visible = true;
            this.colOdemeDurumu.VisibleIndex = 4;
            this.colOdemeDurumu.Caption = "Durum";

            this.gridViewGelir.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.colId, this.colTarih, this.colMusteri, this.colAciklama, this.colTutar, this.colOdemeDurumu
            });

            // Conditional Formatting Gelir
            DevExpress.XtraGrid.GridFormatRule rulePaid = new DevExpress.XtraGrid.GridFormatRule();
            rulePaid.Column = this.colOdemeDurumu;
            rulePaid.ApplyToRow = true;
            DevExpress.XtraEditors.FormatConditionRuleValue condPaid = new DevExpress.XtraEditors.FormatConditionRuleValue();
            condPaid.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            condPaid.Value1 = "Ödendi";
            condPaid.Appearance.BackColor = System.Drawing.Color.LightGreen;
            condPaid.Appearance.Options.UseBackColor = true;
            rulePaid.Rule = condPaid;
            this.gridViewGelir.FormatRules.Add(rulePaid);

            DevExpress.XtraGrid.GridFormatRule ruleUnpaid = new DevExpress.XtraGrid.GridFormatRule();
            ruleUnpaid.Column = this.colOdemeDurumu;
            ruleUnpaid.ApplyToRow = true;
            DevExpress.XtraEditors.FormatConditionRuleValue condUnpaid = new DevExpress.XtraEditors.FormatConditionRuleValue();
            condUnpaid.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            condUnpaid.Value1 = "Borç";
            condUnpaid.Appearance.BackColor = System.Drawing.Color.LightSalmon;
            condUnpaid.Appearance.Options.UseBackColor = true;
            ruleUnpaid.Rule = condUnpaid;
            this.gridViewGelir.FormatRules.Add(ruleUnpaid);


            // groupGider (RIGHT GRID)
            this.groupGider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGider.Text = "GİDER LİSTESİ (Masraflar)";
            this.groupGider.Controls.Add(this.gridControlGider);

            this.gridControlGider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGider.MainView = this.gridViewGider;
            this.gridControlGider.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { this.gridViewGider });

            this.gridViewGider.GridControl = this.gridControlGider;
            this.gridViewGider.OptionsBehavior.Editable = false;


            // Columns Gider
            this.colGiderId.FieldName = "KasaId";
            this.colGiderId.Visible = false;

            this.colGiderTarih.FieldName = "Tarih";
            this.colGiderTarih.Visible = true;
            this.colGiderTarih.VisibleIndex = 0;
            this.colGiderTarih.Caption = "Tarih";

            this.colGiderAciklama.FieldName = "Aciklama";
            this.colGiderAciklama.Visible = true;
            this.colGiderAciklama.VisibleIndex = 1;
            this.colGiderAciklama.Caption = "Açıklama";

            this.colGiderTutar.FieldName = "Tutar";
            this.colGiderTutar.Visible = true;
            this.colGiderTutar.VisibleIndex = 2;
            this.colGiderTutar.Caption = "Tutar";
            this.colGiderTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGiderTutar.DisplayFormat.FormatString = "c2";

            this.gridViewGider.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.colGiderId, this.colGiderTarih, this.colGiderAciklama, this.colGiderTutar
            });
            
            // Final Form Setup
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panelControlTop);
            this.Name = "KasaForm";
            this.Text = "Kasa ve Muhasebe Yönetimi";
            
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupOzet)).EndInit();
            this.groupOzet.ResumeLayout(false);
            this.groupOzet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslem)).EndInit();
            this.groupIslem.ResumeLayout(false);
            this.groupIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioIslemTipi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMusteri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupGelir)).EndInit();
            this.groupGelir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGelir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGider)).EndInit();
            this.groupGider.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGider)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private DevExpress.XtraEditors.GroupControl groupOzet;
        private DevExpress.XtraEditors.LabelControl lblNetKasa;
        private DevExpress.XtraEditors.LabelControl lblToplamGelir;
        private DevExpress.XtraEditors.LabelControl lblToplamGider;
        
        private DevExpress.XtraEditors.GroupControl groupIslem;
        private DevExpress.XtraEditors.RadioGroup radioIslemTipi;
        private DevExpress.XtraEditors.LabelControl lblIslemTipi;
        private DevExpress.XtraEditors.LookUpEdit lookUpMusteri;
        private DevExpress.XtraEditors.LabelControl lblMusteri;
        private DevExpress.XtraEditors.TextEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.LabelControl lblAdet;
        private DevExpress.XtraEditors.TextEdit txtBirimFiyat;
        private DevExpress.XtraEditors.LabelControl lblBirimFiyat;
        private DevExpress.XtraEditors.TextEdit txtOdemeTutar;
        private DevExpress.XtraEditors.LabelControl lblTutar;

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupGelir;
        private DevExpress.XtraGrid.GridControl gridControlGelir;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGelir;
        
        private DevExpress.XtraEditors.GroupControl groupGider;
        private DevExpress.XtraGrid.GridControl gridControlGider;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGider;

        // Columns Gelir
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeDurumu;
        // Col Islem for shared use if needed but simpler to duplicate logic for Gider
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;

        // Columns Gider
        private DevExpress.XtraGrid.Columns.GridColumn colGiderId;
        private DevExpress.XtraGrid.Columns.GridColumn colGiderTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colGiderAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colGiderTutar;

    }
}
