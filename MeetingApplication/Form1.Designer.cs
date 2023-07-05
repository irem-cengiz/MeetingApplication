namespace MeetingApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMeeting = new DataGridView();
            btnMeetingEkle = new Button();
            label2 = new Label();
            txtmName = new TextBox();
            btnGuncelle = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            cmbtopic = new ComboBox();
            label6 = new Label();
            cmbSiralameeting = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            cmbPlatform = new ComboBox();
            btnSil = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            cmbSirallamaReport = new ComboBox();
            btnRaporSil = new Button();
            txtrId = new TextBox();
            btnRaporGuncelle = new Button();
            label3 = new Label();
            txtRc = new TextBox();
            dgvReport = new DataGridView();
            btnRaporEkle = new Button();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtSoyad = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cmbmeeting = new ComboBox();
            btnİnsanGuncelle = new Button();
            btnİnsanSil = new Button();
            btnİnsanEkle = new Button();
            dgvKisiler = new DataGridView();
            txtAd = new TextBox();
            txtTcNo = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).BeginInit();
            SuspendLayout();
            // 
            // dgvMeeting
            // 
            dgvMeeting.AllowUserToDeleteRows = false;
            dgvMeeting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeeting.Location = new Point(0, 154);
            dgvMeeting.Name = "dgvMeeting";
            dgvMeeting.RowTemplate.Height = 25;
            dgvMeeting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMeeting.Size = new Size(613, 391);
            dgvMeeting.TabIndex = 1;
            dgvMeeting.CellContentClick += dgvMeeting_CellContentClick;
            // 
            // btnMeetingEkle
            // 
            btnMeetingEkle.Location = new Point(488, 37);
            btnMeetingEkle.Name = "btnMeetingEkle";
            btnMeetingEkle.Size = new Size(119, 57);
            btnMeetingEkle.TabIndex = 2;
            btnMeetingEkle.Text = "Meeting Ekle";
            btnMeetingEkle.UseVisualStyleBackColor = true;
            btnMeetingEkle.Click += btnMeetingEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Meeting Name:";
            // 
            // txtmName
            // 
            txtmName.Location = new Point(149, 37);
            txtmName.Name = "txtmName";
            txtmName.Size = new Size(197, 23);
            txtmName.TabIndex = 5;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(0, 551);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(119, 33);
            btnGuncelle.TabIndex = 6;
            btnGuncelle.Text = "Meeting Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cmbtopic);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbSiralameeting);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbPlatform);
            groupBox1.Controls.Add(btnSil);
            groupBox1.Controls.Add(btnGuncelle);
            groupBox1.Controls.Add(txtmName);
            groupBox1.Controls.Add(dgvMeeting);
            groupBox1.Controls.Add(btnMeetingEkle);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 584);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "MEETİNG";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 615);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 14;
            // 
            // cmbtopic
            // 
            cmbtopic.FormattingEnabled = true;
            cmbtopic.Items.AddRange(new object[] { "İşleyiş", "Kar-zarar durumları", "Araştırma-geliştirme faaliyetleri", "Personel çalışma programı", "Alım-satım faaliyetleri", "Eğitim", "Yetki-verme", "Fikir alışverisi" });
            cmbtopic.Location = new Point(147, 109);
            cmbtopic.Name = "cmbtopic";
            cmbtopic.Size = new Size(199, 23);
            cmbtopic.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 114);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Topic selection:";
            // 
            // cmbSiralameeting
            // 
            cmbSiralameeting.FormattingEnabled = true;
            cmbSiralameeting.Items.AddRange(new object[] { "Id(Artan)", "Id(Azalan)", "MeetingName" });
            cmbSiralameeting.Location = new Point(486, 125);
            cmbSiralameeting.Name = "cmbSiralameeting";
            cmbSiralameeting.Size = new Size(121, 23);
            cmbSiralameeting.TabIndex = 11;
            cmbSiralameeting.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 133);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 10;
            label5.Text = "Sort by:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 79);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 9;
            label1.Text = "Platform selection:";
            // 
            // cmbPlatform
            // 
            cmbPlatform.FormattingEnabled = true;
            cmbPlatform.Items.AddRange(new object[] { "Zoom", "Skype", "Microsoft Teams" });
            cmbPlatform.Location = new Point(149, 71);
            cmbPlatform.Name = "cmbPlatform";
            cmbPlatform.Size = new Size(197, 23);
            cmbPlatform.TabIndex = 8;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(497, 551);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(116, 33);
            btnSil.TabIndex = 7;
            btnSil.Text = "Meeting Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbSirallamaReport);
            groupBox2.Controls.Add(btnRaporSil);
            groupBox2.Controls.Add(txtrId);
            groupBox2.Controls.Add(btnRaporGuncelle);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtRc);
            groupBox2.Controls.Add(dgvReport);
            groupBox2.Controls.Add(btnRaporEkle);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(659, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 584);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "MEETİNG REPORT";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 133);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 17;
            label7.Text = "Sort by:";
            // 
            // cmbSirallamaReport
            // 
            cmbSirallamaReport.FormattingEnabled = true;
            cmbSirallamaReport.Items.AddRange(new object[] { "Id", "Content", "Meeting" });
            cmbSirallamaReport.Location = new Point(482, 125);
            cmbSirallamaReport.Name = "cmbSirallamaReport";
            cmbSirallamaReport.Size = new Size(121, 23);
            cmbSirallamaReport.TabIndex = 16;
            cmbSirallamaReport.SelectedIndexChanged += cmbSirallamaReport_SelectedIndexChanged;
            // 
            // btnRaporSil
            // 
            btnRaporSil.Location = new Point(511, 551);
            btnRaporSil.Name = "btnRaporSil";
            btnRaporSil.Size = new Size(98, 33);
            btnRaporSil.TabIndex = 15;
            btnRaporSil.Text = "Report Sil";
            btnRaporSil.UseVisualStyleBackColor = true;
            btnRaporSil.Click += btnRaporSil_Click;
            // 
            // txtrId
            // 
            txtrId.Location = new Point(114, 22);
            txtrId.Name = "txtrId";
            txtrId.Size = new Size(39, 23);
            txtrId.TabIndex = 12;
            // 
            // btnRaporGuncelle
            // 
            btnRaporGuncelle.Location = new Point(0, 551);
            btnRaporGuncelle.Name = "btnRaporGuncelle";
            btnRaporGuncelle.Size = new Size(119, 33);
            btnRaporGuncelle.TabIndex = 14;
            btnRaporGuncelle.Text = "Report Güncelle";
            btnRaporGuncelle.UseVisualStyleBackColor = true;
            btnRaporGuncelle.Click += btnRaporGuncelle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 25);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 8;
            label3.Text = "Report Id:";
            // 
            // txtRc
            // 
            txtRc.Location = new Point(114, 68);
            txtRc.Name = "txtRc";
            txtRc.Size = new Size(276, 23);
            txtRc.TabIndex = 13;
            // 
            // dgvReport
            // 
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(0, 154);
            dgvReport.Name = "dgvReport";
            dgvReport.RowTemplate.Height = 25;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(609, 391);
            dgvReport.TabIndex = 9;
            // 
            // btnRaporEkle
            // 
            btnRaporEkle.Location = new Point(482, 39);
            btnRaporEkle.Name = "btnRaporEkle";
            btnRaporEkle.Size = new Size(119, 52);
            btnRaporEkle.TabIndex = 10;
            btnRaporEkle.Text = "Report Ekle";
            btnRaporEkle.UseVisualStyleBackColor = true;
            btnRaporEkle.Click += btnRaporEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 71);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 11;
            label4.Text = "Report Content:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSoyad);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(cmbmeeting);
            groupBox3.Controls.Add(btnİnsanGuncelle);
            groupBox3.Controls.Add(btnİnsanSil);
            groupBox3.Controls.Add(btnİnsanEkle);
            groupBox3.Controls.Add(dgvKisiler);
            groupBox3.Controls.Add(txtAd);
            groupBox3.Controls.Add(txtTcNo);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(12, 627);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1257, 190);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "ADD PEOPLE";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(90, 119);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(162, 23);
            txtSoyad.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 127);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 12;
            label11.Text = "LastName:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(317, 47);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 11;
            label12.Text = "Select meeting:";
            // 
            // cmbmeeting
            // 
            cmbmeeting.FormattingEnabled = true;
            cmbmeeting.Location = new Point(411, 39);
            cmbmeeting.Name = "cmbmeeting";
            cmbmeeting.Size = new Size(197, 23);
            cmbmeeting.TabIndex = 10;
            // 
            // btnİnsanGuncelle
            // 
            btnİnsanGuncelle.Location = new Point(411, 127);
            btnİnsanGuncelle.Name = "btnİnsanGuncelle";
            btnİnsanGuncelle.Size = new Size(102, 37);
            btnİnsanGuncelle.TabIndex = 9;
            btnİnsanGuncelle.Text = "Kişi Güncelle";
            btnİnsanGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnİnsanSil
            // 
            btnİnsanSil.Location = new Point(519, 127);
            btnİnsanSil.Name = "btnİnsanSil";
            btnİnsanSil.Size = new Size(94, 36);
            btnİnsanSil.TabIndex = 8;
            btnİnsanSil.Text = "Kişi Sil";
            btnİnsanSil.UseVisualStyleBackColor = true;
            btnİnsanSil.Click += btnİnsanSil_Click;
            // 
            // btnİnsanEkle
            // 
            btnİnsanEkle.Location = new Point(314, 127);
            btnİnsanEkle.Name = "btnİnsanEkle";
            btnİnsanEkle.Size = new Size(91, 37);
            btnİnsanEkle.TabIndex = 7;
            btnİnsanEkle.Text = "Kişi Ekle";
            btnİnsanEkle.UseVisualStyleBackColor = true;
            btnİnsanEkle.Click += btnİnsanEkle_Click;
            // 
            // dgvKisiler
            // 
            dgvKisiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisiler.Location = new Point(627, 12);
            dgvKisiler.Name = "dgvKisiler";
            dgvKisiler.RowTemplate.Height = 25;
            dgvKisiler.Size = new Size(630, 172);
            dgvKisiler.TabIndex = 6;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(90, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(162, 23);
            txtAd.TabIndex = 5;
            // 
            // txtTcNo
            // 
            txtTcNo.Location = new Point(87, 27);
            txtTcNo.Name = "txtTcNo";
            txtTcNo.Size = new Size(165, 23);
            txtTcNo.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 77);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 1;
            label10.Text = "FirstName:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 35);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 0;
            label9.Text = "TC No:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 846);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "MeetingApplication";
            ((System.ComponentModel.ISupportInitialize)dgvMeeting).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMeeting;
        private Button btnMeetingEkle;
        private Label label2;
        private TextBox txtmName;
        private Button btnGuncelle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSil;
        private Button btnRaporSil;
        private TextBox txtrId;
        private Button btnRaporGuncelle;
        private Label label3;
        private TextBox txtRc;
        private DataGridView dgvReport;
        private Button btnRaporEkle;
        private Label label4;
        private ComboBox cmbPlatform;
        private ComboBox cmbSirallamaReport;
        private Label label1;
        private ComboBox cmbSiralameeting;
        private Label label5;
        private ComboBox cmbtopic;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox3;
        private Label label12;
        private ComboBox cmbmeeting;
        private Button btnİnsanGuncelle;
        private Button btnİnsanSil;
        private Button btnİnsanEkle;
        private DataGridView dgvKisiler;
        private TextBox txtAd;
        private TextBox txtTcNo;
        private Label label10;
        private Label label9;
        private TextBox txtSoyad;
        private Label label11;
    }
}