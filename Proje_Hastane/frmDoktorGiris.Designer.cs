namespace Proje_Hastane
{
    partial class frmDoktorGiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.mtbxTcNo = new System.Windows.Forms.MaskedTextBox();
            this.tbxSıfre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 55);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doktor Giriş Paneli";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(163, 154);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(113, 32);
            this.btnGirisYap.TabIndex = 11;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // mtbxTcNo
            // 
            this.mtbxTcNo.Location = new System.Drawing.Point(165, 83);
            this.mtbxTcNo.Mask = "00000000000";
            this.mtbxTcNo.Name = "mtbxTcNo";
            this.mtbxTcNo.Size = new System.Drawing.Size(111, 20);
            this.mtbxTcNo.TabIndex = 8;
            this.mtbxTcNo.ValidatingType = typeof(int);
            // 
            // tbxSıfre
            // 
            this.tbxSıfre.Location = new System.Drawing.Point(165, 122);
            this.tbxSıfre.Name = "tbxSıfre";
            this.tbxSıfre.Size = new System.Drawing.Size(111, 20);
            this.tbxSıfre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Kimlik No:";
            // 
            // frmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(384, 208);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.mtbxTcNo);
            this.Controls.Add(this.tbxSıfre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoktorGiris";
            this.Text = "frmDoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.MaskedTextBox mtbxTcNo;
        private System.Windows.Forms.TextBox tbxSıfre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}