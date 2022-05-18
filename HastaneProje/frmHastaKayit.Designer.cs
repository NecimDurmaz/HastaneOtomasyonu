namespace HastaneProje
{
    partial class frmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKayit));
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskdTC = new System.Windows.Forms.MaskedTextBox();
            this.mskdTel = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(194, 105);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(152, 33);
            this.txtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "Hasta Soyadi:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(194, 50);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(152, 33);
            this.txtAd.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 34);
            this.label7.TabIndex = 19;
            this.label7.Text = "Hasta Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "TC Kimlik No:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(194, 293);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(152, 33);
            this.txtSifre.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Telefon No:";
            // 
            // mskdTC
            // 
            this.mskdTC.Location = new System.Drawing.Point(194, 164);
            this.mskdTC.Mask = "00000000000";
            this.mskdTC.Name = "mskdTC";
            this.mskdTC.Size = new System.Drawing.Size(152, 33);
            this.mskdTC.TabIndex = 3;
            // 
            // mskdTel
            // 
            this.mskdTel.Location = new System.Drawing.Point(194, 229);
            this.mskdTel.Mask = "(999) 000-0000";
            this.mskdTel.Name = "mskdTel";
            this.mskdTel.Size = new System.Drawing.Size(152, 33);
            this.mskdTel.TabIndex = 4;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(194, 354);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(152, 34);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 34);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cinsiyet:";
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnKayit.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayit.Location = new System.Drawing.Point(194, 420);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(152, 42);
            this.btnKayit.TabIndex = 30;
            this.btnKayit.Text = "Kayıt Yap";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // frmHastaKayit
            // 
            this.AcceptButton = this.btnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(387, 490);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskdTel);
            this.Controls.Add(this.mskdTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Corbel Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "frmHastaKayit";
            this.Text = "FrmHastakayit";
            this.Load += new System.EventHandler(this.frmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskdTC;
        private System.Windows.Forms.MaskedTextBox mskdTel;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKayit;
    }
}