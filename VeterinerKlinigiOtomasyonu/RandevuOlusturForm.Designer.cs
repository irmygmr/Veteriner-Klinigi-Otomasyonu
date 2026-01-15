namespace VeterinerKlinigiOtomasyonu
{
    partial class RandevuOlusturForm
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
            this.groupTarih = new DevExpress.XtraEditors.GroupControl();
            this.dtTarih = new DevExpress.XtraEditors.DateEdit();
            this.groupHayvan = new DevExpress.XtraEditors.GroupControl();
            this.lookUpHayvan = new DevExpress.XtraEditors.LookUpEdit();
            this.groupAciklama = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupSaatler = new DevExpress.XtraEditors.GroupControl();
            this.flowSaatler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaat0900 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat0930 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1000 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1030 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1100 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1130 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1200 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1230 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1300 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1330 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1400 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1430 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1500 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1530 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1600 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaat1630 = new DevExpress.XtraEditors.SimpleButton();
            this.btnRandevuOlustur = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupTarih)).BeginInit();
            this.groupTarih.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHayvan)).BeginInit();
            this.groupHayvan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAciklama)).BeginInit();
            this.groupAciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSaatler)).BeginInit();
            this.groupSaatler.SuspendLayout();
            this.flowSaatler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTarih
            // 
            this.groupTarih.Controls.Add(this.dtTarih);
            this.groupTarih.Location = new System.Drawing.Point(27, 25);
            this.groupTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupTarih.Name = "groupTarih";
            this.groupTarih.Size = new System.Drawing.Size(400, 98);
            this.groupTarih.TabIndex = 0;
            this.groupTarih.Text = "1. Tarih Seçiniz";
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.Location = new System.Drawing.Point(27, 49);
            this.dtTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Size = new System.Drawing.Size(347, 22);
            this.dtTarih.TabIndex = 0;
            // 
            // groupHayvan
            // 
            this.groupHayvan.Controls.Add(this.lookUpHayvan);
            this.groupHayvan.Location = new System.Drawing.Point(27, 148);
            this.groupHayvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupHayvan.Name = "groupHayvan";
            this.groupHayvan.Size = new System.Drawing.Size(400, 98);
            this.groupHayvan.TabIndex = 1;
            this.groupHayvan.Text = "2. Hayvan Seçiniz";
            // 
            // lookUpHayvan
            // 
            this.lookUpHayvan.Location = new System.Drawing.Point(27, 49);
            this.lookUpHayvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lookUpHayvan.Name = "lookUpHayvan";
            this.lookUpHayvan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpHayvan.Properties.NullText = "Hayvan Seçiniz...";
            this.lookUpHayvan.Size = new System.Drawing.Size(347, 22);
            this.lookUpHayvan.TabIndex = 0;
            // 
            // groupAciklama
            // 
            this.groupAciklama.Controls.Add(this.txtAciklama);
            this.groupAciklama.Location = new System.Drawing.Point(27, 271);
            this.groupAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupAciklama.Name = "groupAciklama";
            this.groupAciklama.Size = new System.Drawing.Size(400, 185);
            this.groupAciklama.TabIndex = 2;
            this.groupAciklama.Text = "3. Açıklama (İsteğe Bağlı)";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAciklama.Location = new System.Drawing.Point(2, 25);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(396, 158);
            this.txtAciklama.TabIndex = 0;
            // 
            // groupSaatler
            // 
            this.groupSaatler.Controls.Add(this.flowSaatler);
            this.groupSaatler.Location = new System.Drawing.Point(453, 25);
            this.groupSaatler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupSaatler.Name = "groupSaatler";
            this.groupSaatler.Size = new System.Drawing.Size(560, 431);
            this.groupSaatler.TabIndex = 3;
            this.groupSaatler.Text = "4. Saat Seçiniz (Müsaitlik Durumu)";
            // 
            // flowSaatler
            // 
            this.flowSaatler.Controls.Add(this.btnSaat0900);
            this.flowSaatler.Controls.Add(this.btnSaat0930);
            this.flowSaatler.Controls.Add(this.btnSaat1000);
            this.flowSaatler.Controls.Add(this.btnSaat1030);
            this.flowSaatler.Controls.Add(this.btnSaat1100);
            this.flowSaatler.Controls.Add(this.btnSaat1130);
            this.flowSaatler.Controls.Add(this.btnSaat1200);
            this.flowSaatler.Controls.Add(this.btnSaat1230);
            this.flowSaatler.Controls.Add(this.btnSaat1300);
            this.flowSaatler.Controls.Add(this.btnSaat1330);
            this.flowSaatler.Controls.Add(this.btnSaat1400);
            this.flowSaatler.Controls.Add(this.btnSaat1430);
            this.flowSaatler.Controls.Add(this.btnSaat1500);
            this.flowSaatler.Controls.Add(this.btnSaat1530);
            this.flowSaatler.Controls.Add(this.btnSaat1600);
            this.flowSaatler.Controls.Add(this.btnSaat1630);
            this.flowSaatler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSaatler.Location = new System.Drawing.Point(2, 25);
            this.flowSaatler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowSaatler.Name = "flowSaatler";
            this.flowSaatler.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowSaatler.Size = new System.Drawing.Size(556, 404);
            this.flowSaatler.TabIndex = 0;
            // 
            // btnSaat0900
            // 
            this.btnSaat0900.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat0900.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat0900.Appearance.Options.UseBackColor = true;
            this.btnSaat0900.Appearance.Options.UseFont = true;
            this.btnSaat0900.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat0900.Location = new System.Drawing.Point(17, 16);
            this.btnSaat0900.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat0900.Name = "btnSaat0900";
            this.btnSaat0900.Size = new System.Drawing.Size(100, 37);
            this.btnSaat0900.TabIndex = 0;
            this.btnSaat0900.Text = "09:00";
            // 
            // btnSaat0930
            // 
            this.btnSaat0930.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat0930.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat0930.Appearance.Options.UseBackColor = true;
            this.btnSaat0930.Appearance.Options.UseFont = true;
            this.btnSaat0930.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat0930.Location = new System.Drawing.Point(125, 16);
            this.btnSaat0930.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat0930.Name = "btnSaat0930";
            this.btnSaat0930.Size = new System.Drawing.Size(100, 37);
            this.btnSaat0930.TabIndex = 1;
            this.btnSaat0930.Text = "09:30";
            // 
            // btnSaat1000
            // 
            this.btnSaat1000.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1000.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1000.Appearance.Options.UseBackColor = true;
            this.btnSaat1000.Appearance.Options.UseFont = true;
            this.btnSaat1000.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1000.Location = new System.Drawing.Point(233, 16);
            this.btnSaat1000.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1000.Name = "btnSaat1000";
            this.btnSaat1000.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1000.TabIndex = 2;
            this.btnSaat1000.Text = "10:00";
            // 
            // btnSaat1030
            // 
            this.btnSaat1030.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1030.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1030.Appearance.Options.UseBackColor = true;
            this.btnSaat1030.Appearance.Options.UseFont = true;
            this.btnSaat1030.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1030.Location = new System.Drawing.Point(341, 16);
            this.btnSaat1030.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1030.Name = "btnSaat1030";
            this.btnSaat1030.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1030.TabIndex = 3;
            this.btnSaat1030.Text = "10:30";
            // 
            // btnSaat1100
            // 
            this.btnSaat1100.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1100.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1100.Appearance.Options.UseBackColor = true;
            this.btnSaat1100.Appearance.Options.UseFont = true;
            this.btnSaat1100.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1100.Location = new System.Drawing.Point(17, 61);
            this.btnSaat1100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1100.Name = "btnSaat1100";
            this.btnSaat1100.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1100.TabIndex = 4;
            this.btnSaat1100.Text = "11:00";
            // 
            // btnSaat1130
            // 
            this.btnSaat1130.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1130.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1130.Appearance.Options.UseBackColor = true;
            this.btnSaat1130.Appearance.Options.UseFont = true;
            this.btnSaat1130.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1130.Location = new System.Drawing.Point(125, 61);
            this.btnSaat1130.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1130.Name = "btnSaat1130";
            this.btnSaat1130.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1130.TabIndex = 5;
            this.btnSaat1130.Text = "11:30";
            // 
            // btnSaat1200
            // 
            this.btnSaat1200.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1200.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1200.Appearance.Options.UseBackColor = true;
            this.btnSaat1200.Appearance.Options.UseFont = true;
            this.btnSaat1200.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1200.Location = new System.Drawing.Point(233, 61);
            this.btnSaat1200.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1200.Name = "btnSaat1200";
            this.btnSaat1200.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1200.TabIndex = 6;
            this.btnSaat1200.Text = "12:00";
            // 
            // btnSaat1230
            // 
            this.btnSaat1230.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1230.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1230.Appearance.Options.UseBackColor = true;
            this.btnSaat1230.Appearance.Options.UseFont = true;
            this.btnSaat1230.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1230.Location = new System.Drawing.Point(341, 61);
            this.btnSaat1230.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1230.Name = "btnSaat1230";
            this.btnSaat1230.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1230.TabIndex = 7;
            this.btnSaat1230.Text = "12:30";
            // 
            // btnSaat1300
            // 
            this.btnSaat1300.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1300.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1300.Appearance.Options.UseBackColor = true;
            this.btnSaat1300.Appearance.Options.UseFont = true;
            this.btnSaat1300.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1300.Location = new System.Drawing.Point(17, 106);
            this.btnSaat1300.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1300.Name = "btnSaat1300";
            this.btnSaat1300.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1300.TabIndex = 8;
            this.btnSaat1300.Text = "13:00";
            // 
            // btnSaat1330
            // 
            this.btnSaat1330.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1330.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1330.Appearance.Options.UseBackColor = true;
            this.btnSaat1330.Appearance.Options.UseFont = true;
            this.btnSaat1330.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1330.Location = new System.Drawing.Point(125, 106);
            this.btnSaat1330.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1330.Name = "btnSaat1330";
            this.btnSaat1330.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1330.TabIndex = 9;
            this.btnSaat1330.Text = "13:30";
            // 
            // btnSaat1400
            // 
            this.btnSaat1400.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1400.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1400.Appearance.Options.UseBackColor = true;
            this.btnSaat1400.Appearance.Options.UseFont = true;
            this.btnSaat1400.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1400.Location = new System.Drawing.Point(233, 106);
            this.btnSaat1400.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1400.Name = "btnSaat1400";
            this.btnSaat1400.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1400.TabIndex = 10;
            this.btnSaat1400.Text = "14:00";
            // 
            // btnSaat1430
            // 
            this.btnSaat1430.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1430.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1430.Appearance.Options.UseBackColor = true;
            this.btnSaat1430.Appearance.Options.UseFont = true;
            this.btnSaat1430.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1430.Location = new System.Drawing.Point(341, 106);
            this.btnSaat1430.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1430.Name = "btnSaat1430";
            this.btnSaat1430.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1430.TabIndex = 11;
            this.btnSaat1430.Text = "14:30";
            // 
            // btnSaat1500
            // 
            this.btnSaat1500.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1500.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1500.Appearance.Options.UseBackColor = true;
            this.btnSaat1500.Appearance.Options.UseFont = true;
            this.btnSaat1500.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1500.Location = new System.Drawing.Point(17, 151);
            this.btnSaat1500.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1500.Name = "btnSaat1500";
            this.btnSaat1500.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1500.TabIndex = 12;
            this.btnSaat1500.Text = "15:00";
            // 
            // btnSaat1530
            // 
            this.btnSaat1530.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1530.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1530.Appearance.Options.UseBackColor = true;
            this.btnSaat1530.Appearance.Options.UseFont = true;
            this.btnSaat1530.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1530.Location = new System.Drawing.Point(125, 151);
            this.btnSaat1530.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1530.Name = "btnSaat1530";
            this.btnSaat1530.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1530.TabIndex = 13;
            this.btnSaat1530.Text = "15:30";
            // 
            // btnSaat1600
            // 
            this.btnSaat1600.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1600.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1600.Appearance.Options.UseBackColor = true;
            this.btnSaat1600.Appearance.Options.UseFont = true;
            this.btnSaat1600.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1600.Location = new System.Drawing.Point(233, 151);
            this.btnSaat1600.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1600.Name = "btnSaat1600";
            this.btnSaat1600.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1600.TabIndex = 14;
            this.btnSaat1600.Text = "16:00";
            // 
            // btnSaat1630
            // 
            this.btnSaat1630.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.btnSaat1630.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaat1630.Appearance.Options.UseBackColor = true;
            this.btnSaat1630.Appearance.Options.UseFont = true;
            this.btnSaat1630.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnSaat1630.Location = new System.Drawing.Point(341, 151);
            this.btnSaat1630.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaat1630.Name = "btnSaat1630";
            this.btnSaat1630.Size = new System.Drawing.Size(100, 37);
            this.btnSaat1630.TabIndex = 15;
            this.btnSaat1630.Text = "16:30";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRandevuOlustur.Appearance.Options.UseFont = true;
            this.btnRandevuOlustur.Location = new System.Drawing.Point(27, 492);
            this.btnRandevuOlustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(987, 62);
            this.btnRandevuOlustur.TabIndex = 4;
            this.btnRandevuOlustur.Text = "Randevu Oluştur";
            // 
            // RandevuOlusturForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VeterinerKlinigiOtomasyonu.Properties.Resources.veterinario;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.groupSaatler);
            this.Controls.Add(this.groupAciklama);
            this.Controls.Add(this.groupHayvan);
            this.Controls.Add(this.groupTarih);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RandevuOlusturForm";
            this.Text = "Randevu Al";
            ((System.ComponentModel.ISupportInitialize)(this.groupTarih)).EndInit();
            this.groupTarih.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupHayvan)).EndInit();
            this.groupHayvan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpHayvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupAciklama)).EndInit();
            this.groupAciklama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSaatler)).EndInit();
            this.groupSaatler.ResumeLayout(false);
            this.flowSaatler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupTarih;
        private DevExpress.XtraEditors.DateEdit dtTarih;
        private DevExpress.XtraEditors.GroupControl groupHayvan;
        private DevExpress.XtraEditors.LookUpEdit lookUpHayvan;
        private DevExpress.XtraEditors.GroupControl groupAciklama;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.GroupControl groupSaatler;
        private System.Windows.Forms.FlowLayoutPanel flowSaatler;
        private DevExpress.XtraEditors.SimpleButton btnRandevuOlustur;

        private DevExpress.XtraEditors.SimpleButton btnSaat0900;
        private DevExpress.XtraEditors.SimpleButton btnSaat0930;
        private DevExpress.XtraEditors.SimpleButton btnSaat1000;
        private DevExpress.XtraEditors.SimpleButton btnSaat1030;
        private DevExpress.XtraEditors.SimpleButton btnSaat1100;
        private DevExpress.XtraEditors.SimpleButton btnSaat1130;
        private DevExpress.XtraEditors.SimpleButton btnSaat1200;
        private DevExpress.XtraEditors.SimpleButton btnSaat1230;
        private DevExpress.XtraEditors.SimpleButton btnSaat1300;
        private DevExpress.XtraEditors.SimpleButton btnSaat1330;
        private DevExpress.XtraEditors.SimpleButton btnSaat1400;
        private DevExpress.XtraEditors.SimpleButton btnSaat1430;
        private DevExpress.XtraEditors.SimpleButton btnSaat1500;
        private DevExpress.XtraEditors.SimpleButton btnSaat1530;
        private DevExpress.XtraEditors.SimpleButton btnSaat1600;
        private DevExpress.XtraEditors.SimpleButton btnSaat1630;
    }
}
