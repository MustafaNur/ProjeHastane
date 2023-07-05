namespace ProjeHastane
{
    partial class DoktorBilgiDuzenle
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.mskdtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtbxDoktorSoyad = new System.Windows.Forms.TextBox();
            this.txtbxDoktorAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBrans = new System.Windows.Forms.ComboBox();
            this.txtbxDoktorSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(159, 229);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(121, 32);
            this.btnKayit.TabIndex = 25;
            this.btnKayit.Text = "Güncelle";
            this.btnKayit.UseVisualStyleBackColor = true;
            // 
            // mskdtxtTcNo
            // 
            this.mskdtxtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtxtTcNo.Location = new System.Drawing.Point(159, 114);
            this.mskdtxtTcNo.Mask = "00000000000";
            this.mskdtxtTcNo.Name = "mskdtxtTcNo";
            this.mskdtxtTcNo.Size = new System.Drawing.Size(121, 26);
            this.mskdtxtTcNo.TabIndex = 21;
            this.mskdtxtTcNo.ValidatingType = typeof(int);
            // 
            // txtbxDoktorSoyad
            // 
            this.txtbxDoktorSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxDoktorSoyad.Location = new System.Drawing.Point(159, 82);
            this.txtbxDoktorSoyad.Name = "txtbxDoktorSoyad";
            this.txtbxDoktorSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtbxDoktorSoyad.TabIndex = 20;
            // 
            // txtbxDoktorAd
            // 
            this.txtbxDoktorAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxDoktorAd.Location = new System.Drawing.Point(159, 50);
            this.txtbxDoktorAd.Name = "txtbxDoktorAd";
            this.txtbxDoktorAd.Size = new System.Drawing.Size(121, 26);
            this.txtbxDoktorAd.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(101, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Branş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad:";
            // 
            // cmboBrans
            // 
            this.cmboBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmboBrans.FormattingEnabled = true;
            this.cmboBrans.Location = new System.Drawing.Point(159, 146);
            this.cmboBrans.Name = "cmboBrans";
            this.cmboBrans.Size = new System.Drawing.Size(121, 28);
            this.cmboBrans.TabIndex = 26;
            // 
            // txtbxDoktorSifre
            // 
            this.txtbxDoktorSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxDoktorSifre.Location = new System.Drawing.Point(159, 180);
            this.txtbxDoktorSifre.Name = "txtbxDoktorSifre";
            this.txtbxDoktorSifre.Size = new System.Drawing.Size(121, 26);
            this.txtbxDoktorSifre.TabIndex = 27;
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 316);
            this.Controls.Add(this.txtbxDoktorSifre);
            this.Controls.Add(this.cmboBrans);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.mskdtxtTcNo);
            this.Controls.Add(this.txtbxDoktorSoyad);
            this.Controls.Add(this.txtbxDoktorAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoktorBilgiDuzenle";
            this.Text = "DoktorBilgiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.MaskedTextBox mskdtxtTcNo;
        private System.Windows.Forms.TextBox txtbxDoktorSoyad;
        private System.Windows.Forms.TextBox txtbxDoktorAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBrans;
        private System.Windows.Forms.TextBox txtbxDoktorSifre;
    }
}