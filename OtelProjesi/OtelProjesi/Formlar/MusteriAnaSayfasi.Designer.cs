
namespace OtelProjesi.Formlar
{
    partial class MusteriAnaSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriAnaSayfasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRYap = new System.Windows.Forms.Button();
            this.panelEkran = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelAD);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnRYap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 99);
            this.panel1.TabIndex = 5;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPHELIA\'S OASIS\'A  HOŞ GELDİNİZ";
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(134)))));
            this.labelAD.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAD.Location = new System.Drawing.Point(22, 42);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(52, 45);
            this.labelAD.TabIndex = 2;
            this.labelAD.Text = "isim";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(189)))), ((int)(((byte)(68)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(1066, 19);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(129, 56);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(68)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(916, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 56);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Rezervasyon \r\nGüncelle\r\n";
            this.btnUpdate.UseVisualStyleBackColor = false;
            
            // 
            // btnRYap
            // 
            this.btnRYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(68)))));
            this.btnRYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRYap.Location = new System.Drawing.Point(770, 19);
            this.btnRYap.Name = "btnRYap";
            this.btnRYap.Size = new System.Drawing.Size(129, 56);
            this.btnRYap.TabIndex = 0;
            this.btnRYap.Text = "Rezervasyon \r\nYap";
            this.btnRYap.UseVisualStyleBackColor = false;
           
            // 
            // panelEkran
            // 
            this.panelEkran.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelEkran.BackgroundImage")));
            this.panelEkran.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEkran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEkran.Location = new System.Drawing.Point(0, 99);
            this.panelEkran.Name = "panelEkran";
            this.panelEkran.Size = new System.Drawing.Size(1215, 629);
            this.panelEkran.TabIndex = 7;
            
            // 
            // MusteriAnaSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 728);
            this.Controls.Add(this.panelEkran);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MusteriAnaSayfasi";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.MusteriAnaSayfasi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRYap;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEkran;
        private System.Windows.Forms.Button btnUpdate;
    }
}