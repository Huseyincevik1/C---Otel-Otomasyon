namespace OtelProjesi.Formlar
{
    partial class RezervasyonYap
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
            this.checkedListBoxRtip = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbxRezervasyonBilgi = new System.Windows.Forms.GroupBox();
            this.labelRbilgilendirme = new System.Windows.Forms.Label();
            this.dateTimePickerGelis = new System.Windows.Forms.DateTimePicker();
            this.groupBoxRYap = new System.Windows.Forms.GroupBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerDonus = new System.Windows.Forms.DateTimePicker();
            this.grpBxKrediKart = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuvenlikKod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerKrediKart = new System.Windows.Forms.DateTimePicker();
            this.txtKrediKart = new System.Windows.Forms.TextBox();
            this.grpbxRezervasyonBilgi.SuspendLayout();
            this.groupBoxRYap.SuspendLayout();
            this.grpBxKrediKart.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "REZERVASYON ÇEŞİTLERİMİZ";
            // 
            // checkedListBoxRtip
            // 
            this.checkedListBoxRtip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(136)))));
            this.checkedListBoxRtip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxRtip.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBoxRtip.FormattingEnabled = true;
            this.checkedListBoxRtip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBoxRtip.Items.AddRange(new object[] {
            "Ön ödemeli rezervasyon",
            "60 gün önceden rezervasyon",
            "Standart(klasik) rezervasyon",
            "Teşvik rezervasyonu"});
            this.checkedListBoxRtip.Location = new System.Drawing.Point(32, 136);
            this.checkedListBoxRtip.Name = "checkedListBoxRtip";
            this.checkedListBoxRtip.Size = new System.Drawing.Size(285, 168);
            this.checkedListBoxRtip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(629, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 42);
            this.label2.TabIndex = 2;
            // 
            // grpbxRezervasyonBilgi
            // 
            this.grpbxRezervasyonBilgi.Controls.Add(this.labelRbilgilendirme);
            this.grpbxRezervasyonBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpbxRezervasyonBilgi.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpbxRezervasyonBilgi.Location = new System.Drawing.Point(32, 316);
            this.grpbxRezervasyonBilgi.Name = "grpbxRezervasyonBilgi";
            this.grpbxRezervasyonBilgi.Size = new System.Drawing.Size(289, 253);
            this.grpbxRezervasyonBilgi.TabIndex = 3;
            this.grpbxRezervasyonBilgi.TabStop = false;
            this.grpbxRezervasyonBilgi.Text = "Rezervasyon Bilgilendirme";
            // 
            // labelRbilgilendirme
            // 
            this.labelRbilgilendirme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRbilgilendirme.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRbilgilendirme.Location = new System.Drawing.Point(3, 43);
            this.labelRbilgilendirme.Name = "labelRbilgilendirme";
            this.labelRbilgilendirme.Size = new System.Drawing.Size(283, 207);
            this.labelRbilgilendirme.TabIndex = 0;
            this.labelRbilgilendirme.Text = "Rezervasyon bilgilendirme";
            // 
            // dateTimePickerGelis
            // 
            this.dateTimePickerGelis.CalendarFont = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerGelis.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerGelis.Location = new System.Drawing.Point(134, 138);
            this.dateTimePickerGelis.Name = "dateTimePickerGelis";
            this.dateTimePickerGelis.Size = new System.Drawing.Size(244, 38);
            this.dateTimePickerGelis.TabIndex = 5;
            this.dateTimePickerGelis.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBoxRYap
            // 
            this.groupBoxRYap.Controls.Add(this.btnRezervasyonYap);
            this.groupBoxRYap.Controls.Add(this.label4);
            this.groupBoxRYap.Controls.Add(this.label3);
            this.groupBoxRYap.Controls.Add(this.dateTimePickerDonus);
            this.groupBoxRYap.Controls.Add(this.dateTimePickerGelis);
            this.groupBoxRYap.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRYap.Location = new System.Drawing.Point(349, 101);
            this.groupBoxRYap.Name = "groupBoxRYap";
            this.groupBoxRYap.Size = new System.Drawing.Size(431, 468);
            this.groupBoxRYap.TabIndex = 1;
            this.groupBoxRYap.TabStop = false;
            this.groupBoxRYap.Text = "REZERVASYON";
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(72, 327);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(306, 66);
            this.btnRezervasyonYap.TabIndex = 7;
            this.btnRezervasyonYap.Text = "REZERVASYON YAP\r\n";
            this.btnRezervasyonYap.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dönüş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Geliş Tarihi";
            // 
            // dateTimePickerDonus
            // 
            this.dateTimePickerDonus.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerDonus.Location = new System.Drawing.Point(134, 224);
            this.dateTimePickerDonus.Name = "dateTimePickerDonus";
            this.dateTimePickerDonus.Size = new System.Drawing.Size(244, 38);
            this.dateTimePickerDonus.TabIndex = 5;
            this.dateTimePickerDonus.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // grpBxKrediKart
            // 
            this.grpBxKrediKart.Controls.Add(this.btnKaydet);
            this.grpBxKrediKart.Controls.Add(this.label7);
            this.grpBxKrediKart.Controls.Add(this.label6);
            this.grpBxKrediKart.Controls.Add(this.txtGuvenlikKod);
            this.grpBxKrediKart.Controls.Add(this.label5);
            this.grpBxKrediKart.Controls.Add(this.dateTimePickerKrediKart);
            this.grpBxKrediKart.Controls.Add(this.txtKrediKart);
            this.grpBxKrediKart.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBxKrediKart.Location = new System.Drawing.Point(807, 101);
            this.grpBxKrediKart.Name = "grpBxKrediKart";
            this.grpBxKrediKart.Size = new System.Drawing.Size(402, 465);
            this.grpBxKrediKart.TabIndex = 1;
            this.grpBxKrediKart.TabStop = false;
            this.grpBxKrediKart.Text = "Kredi Kartı Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(152, 349);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(144, 60);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "Güvenlik Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Son Kullanma Tarihi";
            // 
            // txtGuvenlikKod
            // 
            this.txtGuvenlikKod.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuvenlikKod.Location = new System.Drawing.Point(177, 281);
            this.txtGuvenlikKod.Name = "txtGuvenlikKod";
            this.txtGuvenlikKod.Size = new System.Drawing.Size(70, 33);
            this.txtGuvenlikKod.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 33);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kredi Kartı NO";
            // 
            // dateTimePickerKrediKart
            // 
            this.dateTimePickerKrediKart.CalendarFont = new System.Drawing.Font("Gabriola", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerKrediKart.Font = new System.Drawing.Font("Gabriola", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerKrediKart.Location = new System.Drawing.Point(177, 192);
            this.dateTimePickerKrediKart.Name = "dateTimePickerKrediKart";
            this.dateTimePickerKrediKart.Size = new System.Drawing.Size(206, 36);
            this.dateTimePickerKrediKart.TabIndex = 5;
            this.dateTimePickerKrediKart.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtKrediKart
            // 
            this.txtKrediKart.Font = new System.Drawing.Font("Gabriola", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKrediKart.Location = new System.Drawing.Point(177, 112);
            this.txtKrediKart.Name = "txtKrediKart";
            this.txtKrediKart.Size = new System.Drawing.Size(219, 33);
            this.txtKrediKart.TabIndex = 0;
            // 
            // RezervasyonYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(234)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1215, 629);
            this.Controls.Add(this.grpBxKrediKart);
            this.Controls.Add(this.groupBoxRYap);
            this.Controls.Add(this.grpbxRezervasyonBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxRtip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervasyonYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RezervasyonYap";
            this.Load += new System.EventHandler(this.RezervasyonYap_Load);
            this.grpbxRezervasyonBilgi.ResumeLayout(false);
            this.groupBoxRYap.ResumeLayout(false);
            this.groupBoxRYap.PerformLayout();
            this.grpBxKrediKart.ResumeLayout(false);
            this.grpBxKrediKart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxRtip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbxRezervasyonBilgi;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelis;
        private System.Windows.Forms.GroupBox groupBoxRYap;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonus;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpBxKrediKart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKrediKart;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuvenlikKod;
        private System.Windows.Forms.DateTimePicker dateTimePickerKrediKart;
        private System.Windows.Forms.Label labelRbilgilendirme;
    }
}