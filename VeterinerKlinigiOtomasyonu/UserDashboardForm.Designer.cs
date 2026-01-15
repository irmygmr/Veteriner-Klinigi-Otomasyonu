namespace VeterinerKlinigiOtomasyonu
{
    partial class UserDashboardForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupRandevu = new DevExpress.XtraEditors.GroupControl();
            this.lblRandevuDetay = new DevExpress.XtraEditors.LabelControl();
            this.lblRandevuTarih = new DevExpress.XtraEditors.LabelControl();
            this.groupBorc = new DevExpress.XtraEditors.GroupControl();
            this.lblBorcTutar = new DevExpress.XtraEditors.LabelControl();
            this.lblBorcBaslik = new DevExpress.XtraEditors.LabelControl();
            this.panelContainer = new DevExpress.XtraEditors.PanelControl();
            
            ((System.ComponentModel.ISupportInitialize)(this.groupRandevu)).BeginInit();
            this.groupRandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBorc)).BeginInit();
            this.groupBorc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.tableLayoutPanel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupRandevu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBorc, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 446);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupRandevu
            // 
            this.groupRandevu.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupRandevu.AppearanceCaption.Options.UseFont = true;
            this.groupRandevu.Controls.Add(this.lblRandevuDetay);
            this.groupRandevu.Controls.Add(this.lblRandevuTarih);
            this.groupRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRandevu.Location = new System.Drawing.Point(23, 23);
            this.groupRandevu.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.groupRandevu.Name = "groupRandevu";
            this.groupRandevu.Size = new System.Drawing.Size(355, 400);
            this.groupRandevu.TabIndex = 0;
            this.groupRandevu.Text = "Sıradaki Randevunuz";
            // 
            // lblRandevuTarih
            // 
            this.lblRandevuTarih.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblRandevuTarih.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblRandevuTarih.Appearance.Options.UseFont = true;
            this.lblRandevuTarih.Appearance.Options.UseForeColor = true;
            this.lblRandevuTarih.Appearance.Options.UseTextOptions = true;
            this.lblRandevuTarih.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRandevuTarih.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRandevuTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRandevuTarih.Location = new System.Drawing.Point(2, 29);
            this.lblRandevuTarih.Name = "lblRandevuTarih";
            this.lblRandevuTarih.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lblRandevuTarih.Size = new System.Drawing.Size(351, 100);
            this.lblRandevuTarih.TabIndex = 0;
            this.lblRandevuTarih.Text = "-";
            // 
            // lblRandevuDetay
            // 
            this.lblRandevuDetay.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRandevuDetay.Appearance.Options.UseFont = true;
            this.lblRandevuDetay.Appearance.Options.UseTextOptions = true;
            this.lblRandevuDetay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRandevuDetay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRandevuDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRandevuDetay.Location = new System.Drawing.Point(2, 129);
            this.lblRandevuDetay.Name = "lblRandevuDetay";
            this.lblRandevuDetay.Size = new System.Drawing.Size(351, 269);
            this.lblRandevuDetay.TabIndex = 1;
            this.lblRandevuDetay.Text = "Planlanmış randevunuz bulunmamaktadır.";
            // 
            // groupBorc
            // 
            this.groupBorc.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBorc.AppearanceCaption.Options.UseFont = true;
            this.groupBorc.Controls.Add(this.lblBorcTutar);
            this.groupBorc.Controls.Add(this.lblBorcBaslik);
            this.groupBorc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBorc.Location = new System.Drawing.Point(418, 23);
            this.groupBorc.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.groupBorc.Name = "groupBorc";
            this.groupBorc.Size = new System.Drawing.Size(355, 400);
            this.groupBorc.TabIndex = 1;
            this.groupBorc.Text = "Ödeme Durumu";
            // 
            // lblBorcBaslik
            // 
            this.lblBorcBaslik.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBorcBaslik.Appearance.Options.UseFont = true;
            this.lblBorcBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBorcBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBorcBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBorcBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBorcBaslik.Location = new System.Drawing.Point(2, 29);
            this.lblBorcBaslik.Name = "lblBorcBaslik";
            this.lblBorcBaslik.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lblBorcBaslik.Size = new System.Drawing.Size(351, 80);
            this.lblBorcBaslik.TabIndex = 0;
            this.lblBorcBaslik.Text = "Toplam Güncel Borç";
            // 
            // lblBorcTutar
            // 
            this.lblBorcTutar.Appearance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBorcTutar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblBorcTutar.Appearance.Options.UseFont = true;
            this.lblBorcTutar.Appearance.Options.UseForeColor = true;
            this.lblBorcTutar.Appearance.Options.UseTextOptions = true;
            this.lblBorcTutar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBorcTutar.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBorcTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorcTutar.Location = new System.Drawing.Point(2, 109);
            this.lblBorcTutar.Name = "lblBorcTutar";
            this.lblBorcTutar.Size = new System.Drawing.Size(351, 289);
            this.lblBorcTutar.TabIndex = 1;
            this.lblBorcTutar.Text = "0,00 ₺";
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainer);
            this.Name = "UserDashboardForm";
            this.Text = "UserDashboardForm";
            this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupRandevu)).EndInit();
            this.groupRandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBorc)).EndInit();
            this.groupBorc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelContainer)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupRandevu;
        private DevExpress.XtraEditors.GroupControl groupBorc;
        private DevExpress.XtraEditors.LabelControl lblRandevuTarih;
        private DevExpress.XtraEditors.LabelControl lblRandevuDetay;
        private DevExpress.XtraEditors.LabelControl lblBorcBaslik;
        private DevExpress.XtraEditors.LabelControl lblBorcTutar;
    }
}
