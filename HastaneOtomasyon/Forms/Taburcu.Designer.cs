namespace HastaneOtomasyon
{
    partial class Taburcu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_cikis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.dt_sevktarihi = new System.Windows.Forms.DateTimePicker();
            this.cb_odeme_sekli = new System.Windows.Forms.ComboBox();
            this.txt_toplama_tutar = new System.Windows.Forms.TextBox();
            this.txt_dosyano = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_vazgeç = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_cikis_tarihi);
            this.groupBox1.Controls.Add(this.dt_sevktarihi);
            this.groupBox1.Controls.Add(this.cb_odeme_sekli);
            this.groupBox1.Controls.Add(this.txt_toplama_tutar);
            this.groupBox1.Controls.Add(this.txt_dosyano);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dt_cikis_tarihi
            // 
            this.dt_cikis_tarihi.Enabled = false;
            this.dt_cikis_tarihi.Location = new System.Drawing.Point(99, 65);
            this.dt_cikis_tarihi.Name = "dt_cikis_tarihi";
            this.dt_cikis_tarihi.Size = new System.Drawing.Size(162, 20);
            this.dt_cikis_tarihi.TabIndex = 3;
            // 
            // dt_sevktarihi
            // 
            this.dt_sevktarihi.Enabled = false;
            this.dt_sevktarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sevktarihi.Location = new System.Drawing.Point(99, 39);
            this.dt_sevktarihi.Name = "dt_sevktarihi";
            this.dt_sevktarihi.Size = new System.Drawing.Size(162, 20);
            this.dt_sevktarihi.TabIndex = 3;
            this.dt_sevktarihi.Value = new System.DateTime(2019, 12, 25, 10, 38, 20, 0);
            // 
            // cb_odeme_sekli
            // 
            this.cb_odeme_sekli.FormattingEnabled = true;
            this.cb_odeme_sekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı - Tek Çekim",
            "Kredi Kartı - Taksitli",
            "Çek",
            "Senet"});
            this.cb_odeme_sekli.Location = new System.Drawing.Point(99, 88);
            this.cb_odeme_sekli.Name = "cb_odeme_sekli";
            this.cb_odeme_sekli.Size = new System.Drawing.Size(162, 21);
            this.cb_odeme_sekli.TabIndex = 2;
            // 
            // txt_toplama_tutar
            // 
            this.txt_toplama_tutar.Enabled = false;
            this.txt_toplama_tutar.Location = new System.Drawing.Point(99, 113);
            this.txt_toplama_tutar.Name = "txt_toplama_tutar";
            this.txt_toplama_tutar.Size = new System.Drawing.Size(162, 20);
            this.txt_toplama_tutar.TabIndex = 1;
            // 
            // txt_dosyano
            // 
            this.txt_dosyano.Enabled = false;
            this.txt_dosyano.Location = new System.Drawing.Point(99, 13);
            this.txt_dosyano.Name = "txt_dosyano";
            this.txt_dosyano.Size = new System.Drawing.Size(162, 20);
            this.txt_dosyano.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplama Tutarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Şekli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sevk Tarihi";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(181, 151);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(101, 30);
            this.btn_kaydet.TabIndex = 3;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_vazgeç
            // 
            this.btn_vazgeç.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vazgeç.Location = new System.Drawing.Point(7, 151);
            this.btn_vazgeç.Name = "btn_vazgeç";
            this.btn_vazgeç.Size = new System.Drawing.Size(106, 30);
            this.btn_vazgeç.TabIndex = 2;
            this.btn_vazgeç.Text = "Vazgeç";
            this.btn_vazgeç.UseVisualStyleBackColor = false;
            this.btn_vazgeç.Click += new System.EventHandler(this.btn_vazgeç_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(294, 185);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_vazgeç);
            this.Controls.Add(this.groupBox1);
            this.Name = "Taburcu";
            this.Text = "SOHATS - Taburcu";
            this.Load += new System.EventHandler(this.Taburcu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_cikis_tarihi;
        private System.Windows.Forms.DateTimePicker dt_sevktarihi;
        private System.Windows.Forms.ComboBox cb_odeme_sekli;
        private System.Windows.Forms.TextBox txt_toplama_tutar;
        private System.Windows.Forms.TextBox txt_dosyano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_vazgeç;
    }
}