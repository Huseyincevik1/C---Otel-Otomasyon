
namespace OtelProjesi.Formlar
{
    partial class GirisYap
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
            this.lblePosta = new System.Windows.Forms.Label();
            this.txbxePosta = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txbxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklUyeOl = new System.Windows.Forms.LinkLabel();
            this.lnklSifreUnutma = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbtnCalisan = new System.Windows.Forms.RadioButton();
            this.rdbtnYonetici = new System.Windows.Forms.RadioButton();
            this.rdbtnMusteri = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblePosta
            // 
            this.lblePosta.AutoSize = true;
            this.lblePosta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblePosta.Location = new System.Drawing.Point(150, 231);
            this.lblePosta.Name = "lblePosta";
            this.lblePosta.Size = new System.Drawing.Size(69, 20);
            this.lblePosta.TabIndex = 0;
            this.lblePosta.Text = "E-Posta";
            // 
            // txbxePosta
            // 
            this.txbxePosta.Location = new System.Drawing.Point(154, 254);
            this.txbxePosta.Name = "txbxePosta";
            this.txbxePosta.Size = new System.Drawing.Size(191, 22);
            this.txbxePosta.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(68)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGiris.Location = new System.Drawing.Point(196, 534);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(113, 30);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSifre.Location = new System.Drawing.Point(160, 319);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 20);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre";
            // 
            // txbxSifre
            // 
            this.txbxSifre.Location = new System.Drawing.Point(154, 342);
            this.txbxSifre.Name = "txbxSifre";
            this.txbxSifre.Size = new System.Drawing.Size(191, 22);
            this.txbxSifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hesabın yok mu?";
            // 
            // lnklUyeOl
            // 
            this.lnklUyeOl.AutoSize = true;
            this.lnklUyeOl.Location = new System.Drawing.Point(264, 579);
            this.lnklUyeOl.Name = "lnklUyeOl";
            this.lnklUyeOl.Size = new System.Drawing.Size(98, 17);
            this.lnklUyeOl.TabIndex = 6;
            this.lnklUyeOl.TabStop = true;
            this.lnklUyeOl.Text = "Hemen üye ol!";
            this.lnklUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklUyeOl_LinkClicked);
            // 
            // lnklSifreUnutma
            // 
            this.lnklSifreUnutma.AutoSize = true;
            this.lnklSifreUnutma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lnklSifreUnutma.Location = new System.Drawing.Point(237, 367);
            this.lnklSifreUnutma.Name = "lnklSifreUnutma";
            this.lnklSifreUnutma.Size = new System.Drawing.Size(108, 17);
            this.lnklSifreUnutma.TabIndex = 7;
            this.lnklSifreUnutma.TabStop = true;
            this.lnklSifreUnutma.Text = "Şifremi Unuttum";
            this.lnklSifreUnutma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklSifreUnutma_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giriş Yap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(308, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "OTEL ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(83, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = " OTOMASYONU\'na hoşgeldiniz!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(111, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "OPHELIA\'S OASIS  ";
            // 
            // rdbtnCalisan
            // 
            this.rdbtnCalisan.AutoSize = true;
            this.rdbtnCalisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbtnCalisan.Location = new System.Drawing.Point(330, 478);
            this.rdbtnCalisan.Name = "rdbtnCalisan";
            this.rdbtnCalisan.Size = new System.Drawing.Size(86, 24);
            this.rdbtnCalisan.TabIndex = 14;
            this.rdbtnCalisan.TabStop = true;
            this.rdbtnCalisan.Text = "Çalışan";
            this.rdbtnCalisan.UseVisualStyleBackColor = true;
            // 
            // rdbtnYonetici
            // 
            this.rdbtnYonetici.AutoSize = true;
            this.rdbtnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbtnYonetici.Location = new System.Drawing.Point(213, 479);
            this.rdbtnYonetici.Name = "rdbtnYonetici";
            this.rdbtnYonetici.Size = new System.Drawing.Size(89, 24);
            this.rdbtnYonetici.TabIndex = 13;
            this.rdbtnYonetici.TabStop = true;
            this.rdbtnYonetici.Text = "Yönetici";
            this.rdbtnYonetici.UseVisualStyleBackColor = true;
            // 
            // rdbtnMusteri
            // 
            this.rdbtnMusteri.AutoSize = true;
            this.rdbtnMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rdbtnMusteri.Location = new System.Drawing.Point(100, 478);
            this.rdbtnMusteri.Name = "rdbtnMusteri";
            this.rdbtnMusteri.Size = new System.Drawing.Size(91, 24);
            this.rdbtnMusteri.TabIndex = 12;
            this.rdbtnMusteri.TabStop = true;
            this.rdbtnMusteri.Text = "Müşteri ";
            this.rdbtnMusteri.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(137, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lütfen giriş türünüzü seçiniz.";
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(134)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(497, 676);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbtnCalisan);
            this.Controls.Add(this.rdbtnYonetici);
            this.Controls.Add(this.rdbtnMusteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnklSifreUnutma);
            this.Controls.Add(this.lnklUyeOl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txbxePosta);
            this.Controls.Add(this.lblePosta);
            this.Name = "GirisYap";
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.GirisYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblePosta;
        private System.Windows.Forms.TextBox txbxePosta;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txbxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklUyeOl;
        private System.Windows.Forms.LinkLabel lnklSifreUnutma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbtnCalisan;
        private System.Windows.Forms.RadioButton rdbtnYonetici;
        private System.Windows.Forms.RadioButton rdbtnMusteri;
        private System.Windows.Forms.Label label6;
    }
}