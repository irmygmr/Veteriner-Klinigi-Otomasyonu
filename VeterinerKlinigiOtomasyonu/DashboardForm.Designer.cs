namespace VeterinerKlinigiOtomasyonu
{
    partial class DashboardForm
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
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.lblBrand = new DevExpress.XtraEditors.LabelControl();
            this.layoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.BackColor = System.Drawing.Color.Transparent;
            this.layoutTable.ColumnCount = 3;
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layoutTable.Controls.Add(this.lblWelcome, 1, 0);
            this.layoutTable.Controls.Add(this.lblDate, 1, 1);
            this.layoutTable.Controls.Add(this.lblBrand, 1, 2);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowCount = 3;
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.layoutTable.Size = new System.Drawing.Size(1792, 862);
            this.layoutTable.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcome.Appearance.Options.UseBackColor = true;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.Appearance.Options.UseTextOptions = true;
            this.lblWelcome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblWelcome.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblWelcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Location = new System.Drawing.Point(182, 4);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1427, 423);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hoş Geldiniz";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblDate
            // 
            this.lblDate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Appearance.Options.UseBackColor = true;
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Appearance.Options.UseTextOptions = true;
            this.lblDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(182, 435);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(1427, 121);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Tarih";
            // 
            // lblBrand
            // 
            this.lblBrand.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Appearance.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBrand.Appearance.Options.UseBackColor = true;
            this.lblBrand.Appearance.Options.UseFont = true;
            this.lblBrand.Appearance.Options.UseForeColor = true;
            this.lblBrand.Appearance.Options.UseTextOptions = true;
            this.lblBrand.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblBrand.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lblBrand.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBrand.Location = new System.Drawing.Point(182, 564);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblBrand.Size = new System.Drawing.Size(1427, 294);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Tarçın Veteriner Kliniği";
            this.lblBrand.Click += new System.EventHandler(this.lblBrand_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::VeterinerKlinigiOtomasyonu.Properties.Resources.肉球パープル背景イラスト;
            this.ClientSize = new System.Drawing.Size(1792, 862);
            this.Controls.Add(this.layoutTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DashboardForm";
            this.Text = "Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.LabelControl lblBrand;
    }
}
