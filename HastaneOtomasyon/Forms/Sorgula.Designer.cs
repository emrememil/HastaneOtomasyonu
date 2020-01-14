namespace HastaneOtomasyon.Forms
{
    partial class Sorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorgula));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_sevk_tarihi = new System.Windows.Forms.DateTimePicker();
            this.dt_bitis_tarihi = new System.Windows.Forms.DateTimePicker();
            this.rb_tb_olmus = new System.Windows.Forms.RadioButton();
            this.rb_tb_olmamis = new System.Windows.Forms.RadioButton();
            this.rb_hepsi = new System.Windows.Forms.RadioButton();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_yazdir = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgv_islemler = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_islemler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dt_sevk_tarihi
            // 
            this.dt_sevk_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sevk_tarihi.Location = new System.Drawing.Point(92, 16);
            this.dt_sevk_tarihi.Name = "dt_sevk_tarihi";
            this.dt_sevk_tarihi.Size = new System.Drawing.Size(138, 20);
            this.dt_sevk_tarihi.TabIndex = 5;
            this.dt_sevk_tarihi.Value = new System.DateTime(2019, 12, 23, 0, 0, 0, 0);
            // 
            // dt_bitis_tarihi
            // 
            this.dt_bitis_tarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_bitis_tarihi.Location = new System.Drawing.Point(92, 53);
            this.dt_bitis_tarihi.Name = "dt_bitis_tarihi";
            this.dt_bitis_tarihi.Size = new System.Drawing.Size(138, 20);
            this.dt_bitis_tarihi.TabIndex = 5;
            this.dt_bitis_tarihi.Value = new System.DateTime(2019, 12, 23, 0, 0, 0, 0);
            // 
            // rb_tb_olmus
            // 
            this.rb_tb_olmus.AutoSize = true;
            this.rb_tb_olmus.Location = new System.Drawing.Point(283, 16);
            this.rb_tb_olmus.Name = "rb_tb_olmus";
            this.rb_tb_olmus.Size = new System.Drawing.Size(97, 17);
            this.rb_tb_olmus.TabIndex = 6;
            this.rb_tb_olmus.TabStop = true;
            this.rb_tb_olmus.Text = "Taburcu Olmuş";
            this.rb_tb_olmus.UseVisualStyleBackColor = true;
            // 
            // rb_tb_olmamis
            // 
            this.rb_tb_olmamis.AutoSize = true;
            this.rb_tb_olmamis.Location = new System.Drawing.Point(283, 39);
            this.rb_tb_olmamis.Name = "rb_tb_olmamis";
            this.rb_tb_olmamis.Size = new System.Drawing.Size(107, 17);
            this.rb_tb_olmamis.TabIndex = 6;
            this.rb_tb_olmamis.TabStop = true;
            this.rb_tb_olmamis.Text = "Taburcu Olmamış";
            this.rb_tb_olmamis.UseVisualStyleBackColor = true;
            // 
            // rb_hepsi
            // 
            this.rb_hepsi.AutoSize = true;
            this.rb_hepsi.Location = new System.Drawing.Point(283, 62);
            this.rb_hepsi.Name = "rb_hepsi";
            this.rb_hepsi.Size = new System.Drawing.Size(52, 17);
            this.rb_hepsi.TabIndex = 6;
            this.rb_hepsi.TabStop = true;
            this.rb_hepsi.Text = "Hepsi";
            this.rb_hepsi.UseVisualStyleBackColor = true;
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgula.Location = new System.Drawing.Point(418, 19);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(71, 68);
            this.btn_sorgula.TabIndex = 13;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = false;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Location = new System.Drawing.Point(495, 19);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(71, 68);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yazdir.Location = new System.Drawing.Point(572, 19);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(71, 68);
            this.btn_yazdir.TabIndex = 15;
            this.btn_yazdir.Text = "Yazdır";
            this.btn_yazdir.UseVisualStyleBackColor = false;
            this.btn_yazdir.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(672, 19);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(71, 68);
            this.btn_cikis.TabIndex = 16;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sorgula);
            this.groupBox1.Controls.Add(this.btn_cikis);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_yazdir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.dt_sevk_tarihi);
            this.groupBox1.Controls.Add(this.dt_bitis_tarihi);
            this.groupBox1.Controls.Add(this.rb_hepsi);
            this.groupBox1.Controls.Add(this.rb_tb_olmus);
            this.groupBox1.Controls.Add(this.rb_tb_olmamis);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 96);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // dgv_islemler
            // 
            this.dgv_islemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_islemler.Location = new System.Drawing.Point(12, 104);
            this.dgv_islemler.Name = "dgv_islemler";
            this.dgv_islemler.Size = new System.Drawing.Size(749, 309);
            this.dgv_islemler.TabIndex = 18;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // Sorgula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 425);
            this.Controls.Add(this.dgv_islemler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sorgula";
            this.Text = "Sorgula";
            this.Load += new System.EventHandler(this.Sorgula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_islemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_sevk_tarihi;
        private System.Windows.Forms.DateTimePicker dt_bitis_tarihi;
        private System.Windows.Forms.RadioButton rb_tb_olmus;
        private System.Windows.Forms.RadioButton rb_tb_olmamis;
        private System.Windows.Forms.RadioButton rb_hepsi;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_yazdir;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dgv_islemler;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}