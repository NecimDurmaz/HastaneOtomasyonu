namespace HastaneProje
{
    partial class frmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruOlustur = new System.Windows.Forms.Button();
            this.rchtxtDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cmbRBrans = new System.Windows.Forms.ComboBox();
            this.cmbRDoktor = new System.Windows.Forms.ComboBox();
            this.mskRSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskRTarih = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBrnasPanel = new System.Windows.Forms.Button();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.btnDoktorPanel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Size = new System.Drawing.Size(340, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(158, 95);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(124, 29);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "NULL NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(158, 47);
            this.lblTC.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(145, 29);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.rchtxtDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(97, 217);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(167, 51);
            this.btnDuyuruOlustur.TabIndex = 1;
            this.btnDuyuruOlustur.Text = "Duyuru Oluştur";
            this.btnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // rchtxtDuyuru
            // 
            this.rchtxtDuyuru.Location = new System.Drawing.Point(14, 36);
            this.rchtxtDuyuru.Name = "rchtxtDuyuru";
            this.rchtxtDuyuru.Size = new System.Drawing.Size(312, 175);
            this.rchtxtDuyuru.TabIndex = 0;
            this.rchtxtDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.cmbRBrans);
            this.groupBox3.Controls.Add(this.cmbRDoktor);
            this.groupBox3.Controls.Add(this.mskRSaat);
            this.groupBox3.Controls.Add(this.mskRTarih);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(364, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 487);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(102, 285);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 51);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbRBrans
            // 
            this.cmbRBrans.FormattingEnabled = true;
            this.cmbRBrans.Location = new System.Drawing.Point(123, 170);
            this.cmbRBrans.Name = "cmbRBrans";
            this.cmbRBrans.Size = new System.Drawing.Size(186, 37);
            this.cmbRBrans.TabIndex = 15;
            this.cmbRBrans.SelectedIndexChanged += new System.EventHandler(this.cmbRBrans_SelectedIndexChanged);
            // 
            // cmbRDoktor
            // 
            this.cmbRDoktor.FormattingEnabled = true;
            this.cmbRDoktor.Location = new System.Drawing.Point(123, 217);
            this.cmbRDoktor.Name = "cmbRDoktor";
            this.cmbRDoktor.Size = new System.Drawing.Size(186, 37);
            this.cmbRDoktor.TabIndex = 11;
            // 
            // mskRSaat
            // 
            this.mskRSaat.Location = new System.Drawing.Point(123, 127);
            this.mskRSaat.Mask = "00:00";
            this.mskRSaat.Name = "mskRSaat";
            this.mskRSaat.Size = new System.Drawing.Size(186, 37);
            this.mskRSaat.TabIndex = 10;
            this.mskRSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskRTarih
            // 
            this.mskRTarih.Location = new System.Drawing.Point(123, 84);
            this.mskRTarih.Mask = "00/00/0000";
            this.mskRTarih.Name = "mskRTarih";
            this.mskRTarih.Size = new System.Drawing.Size(186, 37);
            this.mskRTarih.TabIndex = 9;
            this.mskRTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = "Doktor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branş:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(742, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 298);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(742, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 288);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(434, 252);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.btnBrnasPanel);
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Controls.Add(this.btnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 507);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(727, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erisim";
            // 
            // btnBrnasPanel
            // 
            this.btnBrnasPanel.Location = new System.Drawing.Point(199, 36);
            this.btnBrnasPanel.Name = "btnBrnasPanel";
            this.btnBrnasPanel.Size = new System.Drawing.Size(168, 53);
            this.btnBrnasPanel.TabIndex = 2;
            this.btnBrnasPanel.Text = "Branş Panel";
            this.btnBrnasPanel.UseVisualStyleBackColor = true;
            this.btnBrnasPanel.Click += new System.EventHandler(this.btnBrnasPanel_Click);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(373, 36);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(168, 53);
            this.btnRandevuListe.TabIndex = 1;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // btnDoktorPanel
            // 
            this.btnDoktorPanel.Location = new System.Drawing.Point(14, 36);
            this.btnDoktorPanel.Name = "btnDoktorPanel";
            this.btnDoktorPanel.Size = new System.Drawing.Size(168, 53);
            this.btnDoktorPanel.TabIndex = 0;
            this.btnDoktorPanel.Text = "Doktor Paneli";
            this.btnDoktorPanel.UseVisualStyleBackColor = true;
            this.btnDoktorPanel.Click += new System.EventHandler(this.btnDoktorPanel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1194, 611);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox rchtxtDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbRBrans;
        private System.Windows.Forms.ComboBox cmbRDoktor;
        private System.Windows.Forms.MaskedTextBox mskRSaat;
        private System.Windows.Forms.MaskedTextBox mskRTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBrnasPanel;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.Button btnDoktorPanel;
        private System.Windows.Forms.Button button1;
    }
}