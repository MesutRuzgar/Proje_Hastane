namespace Proje_Hastane
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.mskTcNo = new System.Windows.Forms.MaskedTextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(144, 174);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(116, 29);
            this.tbxSifre.TabIndex = 5;
            // 
            // mskTcNo
            // 
            this.mskTcNo.Location = new System.Drawing.Point(144, 100);
            this.mskTcNo.Mask = "00000000000";
            this.mskTcNo.Name = "mskTcNo";
            this.mskTcNo.Size = new System.Drawing.Size(116, 29);
            this.mskTcNo.TabIndex = 3;
            this.mskTcNo.ValidatingType = typeof(int);
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(144, 25);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(116, 29);
            this.tbxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad:";
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(144, 63);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(116, 29);
            this.tbxSoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyad:";
            // 
            // mskTelNo
            // 
            this.mskTelNo.Location = new System.Drawing.Point(144, 135);
            this.mskTelNo.Mask = "(999) 000-0000";
            this.mskTelNo.Name = "mskTelNo";
            this.mskTelNo.Size = new System.Drawing.Size(116, 29);
            this.mskTelNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefon:";
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cbxCinsiyet.Location = new System.Drawing.Point(144, 209);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(116, 32);
            this.cbxCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(144, 247);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(116, 41);
            this.btnKayitOl.TabIndex = 7;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            // 
            // frmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(327, 313);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.mskTelNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTcNo);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmHastaKayit";
            this.Text = "frmHastaKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.MaskedTextBox mskTcNo;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayitOl;
    }
}