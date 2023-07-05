namespace ProjeHastane
{
    partial class UyeKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxUyeAd = new System.Windows.Forms.TextBox();
            this.txtbxUyeSoyad = new System.Windows.Forms.TextBox();
            this.mskdtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mskdtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtbxSifre = new System.Windows.Forms.TextBox();
            this.cmbbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(87, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(103, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(81, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cinsiyet:";
            // 
            // txtbxUyeAd
            // 
            this.txtbxUyeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxUyeAd.Location = new System.Drawing.Point(173, 61);
            this.txtbxUyeAd.Name = "txtbxUyeAd";
            this.txtbxUyeAd.Size = new System.Drawing.Size(121, 26);
            this.txtbxUyeAd.TabIndex = 1;
            // 
            // txtbxUyeSoyad
            // 
            this.txtbxUyeSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxUyeSoyad.Location = new System.Drawing.Point(173, 93);
            this.txtbxUyeSoyad.Name = "txtbxUyeSoyad";
            this.txtbxUyeSoyad.Size = new System.Drawing.Size(121, 26);
            this.txtbxUyeSoyad.TabIndex = 2;
            // 
            // mskdtxtTcNo
            // 
            this.mskdtxtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtxtTcNo.Location = new System.Drawing.Point(173, 125);
            this.mskdtxtTcNo.Mask = "00000000000";
            this.mskdtxtTcNo.Name = "mskdtxtTcNo";
            this.mskdtxtTcNo.Size = new System.Drawing.Size(121, 26);
            this.mskdtxtTcNo.TabIndex = 3;
            this.mskdtxtTcNo.ValidatingType = typeof(int);
            // 
            // mskdtxtTelefon
            // 
            this.mskdtxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtxtTelefon.Location = new System.Drawing.Point(173, 157);
            this.mskdtxtTelefon.Mask = "000-0000000";
            this.mskdtxtTelefon.Name = "mskdtxtTelefon";
            this.mskdtxtTelefon.Size = new System.Drawing.Size(121, 26);
            this.mskdtxtTelefon.TabIndex = 4;
            // 
            // txtbxSifre
            // 
            this.txtbxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxSifre.Location = new System.Drawing.Point(173, 189);
            this.txtbxSifre.Name = "txtbxSifre";
            this.txtbxSifre.Size = new System.Drawing.Size(121, 26);
            this.txtbxSifre.TabIndex = 5;
            // 
            // cmbbxCinsiyet
            // 
            this.cmbbxCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbxCinsiyet.FormattingEnabled = true;
            this.cmbbxCinsiyet.Location = new System.Drawing.Point(173, 221);
            this.cmbbxCinsiyet.Name = "cmbbxCinsiyet";
            this.cmbbxCinsiyet.Size = new System.Drawing.Size(121, 28);
            this.cmbbxCinsiyet.TabIndex = 6;
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(173, 255);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(121, 32);
            this.btnKayit.TabIndex = 12;
            this.btnKayit.Text = "Kayıt Yap";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // UyeKayıt
            // 
            this.AcceptButton = this.btnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.cmbbxCinsiyet);
            this.Controls.Add(this.txtbxSifre);
            this.Controls.Add(this.mskdtxtTelefon);
            this.Controls.Add(this.mskdtxtTcNo);
            this.Controls.Add(this.txtbxUyeSoyad);
            this.Controls.Add(this.txtbxUyeAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UyeKayıt";
            this.Text = "UyeKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxUyeAd;
        private System.Windows.Forms.TextBox txtbxUyeSoyad;
        private System.Windows.Forms.MaskedTextBox mskdtxtTcNo;
        private System.Windows.Forms.MaskedTextBox mskdtxtTelefon;
        private System.Windows.Forms.TextBox txtbxSifre;
        private System.Windows.Forms.ComboBox cmbbxCinsiyet;
        private System.Windows.Forms.Button btnKayit;
    }
}