namespace Proje_Hastane
{
    partial class frmHastaGiris
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
            this.tbxSıfre = new System.Windows.Forms.TextBox();
            this.mtbxTcNo = new System.Windows.Forms.MaskedTextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // tbxSıfre
            // 
            this.tbxSıfre.Location = new System.Drawing.Point(168, 137);
            this.tbxSıfre.Name = "tbxSıfre";
            this.tbxSıfre.Size = new System.Drawing.Size(111, 26);
            this.tbxSıfre.TabIndex = 2;
            // 
            // mtbxTcNo
            // 
            this.mtbxTcNo.Location = new System.Drawing.Point(168, 98);
            this.mtbxTcNo.Mask = "00000000000";
            this.mtbxTcNo.Name = "mtbxTcNo";
            this.mtbxTcNo.Size = new System.Drawing.Size(111, 26);
            this.mtbxTcNo.TabIndex = 1;
            this.mtbxTcNo.ValidatingType = typeof(int);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(166, 169);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(113, 32);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.AutoSize = true;
            this.lnkUyeOl.Location = new System.Drawing.Point(194, 214);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(56, 20);
            this.lnkUyeOl.TabIndex = 4;
            this.lnkUyeOl.TabStop = true;
            this.lnkUyeOl.Text = "Üye Ol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta Giriş Paneli";
            // 
            // frmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(400, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.mtbxTcNo);
            this.Controls.Add(this.tbxSıfre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHastaGiris";
            this.Text = "frmHastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSıfre;
        private System.Windows.Forms.MaskedTextBox mtbxTcNo;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.LinkLabel lnkUyeOl;
        private System.Windows.Forms.Label label3;
    }
}