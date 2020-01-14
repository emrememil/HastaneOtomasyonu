namespace HastaneOtomasyon.Forms
{
    partial class DosyaBul
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
            this.cb_arama_kriteri = new System.Windows.Forms.ComboBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyadı = new System.Windows.Forms.TextBox();
            this.cb_ve = new System.Windows.Forms.CheckBox();
            this.btn_bul = new System.Windows.Forms.Button();
            this.dgv_arama = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arama)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // cb_arama_kriteri
            // 
            this.cb_arama_kriteri.FormattingEnabled = true;
            this.cb_arama_kriteri.Items.AddRange(new object[] {
            "Hasta Adı ve Soyadı",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cb_arama_kriteri.Location = new System.Drawing.Point(76, 10);
            this.cb_arama_kriteri.Name = "cb_arama_kriteri";
            this.cb_arama_kriteri.Size = new System.Drawing.Size(118, 21);
            this.cb_arama_kriteri.TabIndex = 1;
            this.cb_arama_kriteri.SelectedIndexChanged += new System.EventHandler(this.cb_arama_kriteri_SelectedIndexChanged);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(200, 10);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(130, 20);
            this.txt_ad.TabIndex = 2;
            // 
            // txt_soyadı
            // 
            this.txt_soyadı.Location = new System.Drawing.Point(379, 10);
            this.txt_soyadı.Name = "txt_soyadı";
            this.txt_soyadı.Size = new System.Drawing.Size(142, 20);
            this.txt_soyadı.TabIndex = 3;
            // 
            // cb_ve
            // 
            this.cb_ve.AutoSize = true;
            this.cb_ve.Location = new System.Drawing.Point(339, 12);
            this.cb_ve.Name = "cb_ve";
            this.cb_ve.Size = new System.Drawing.Size(38, 17);
            this.cb_ve.TabIndex = 4;
            this.cb_ve.Text = "ve";
            this.cb_ve.UseVisualStyleBackColor = true;
            // 
            // btn_bul
            // 
            this.btn_bul.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bul.Location = new System.Drawing.Point(527, 10);
            this.btn_bul.Name = "btn_bul";
            this.btn_bul.Size = new System.Drawing.Size(62, 21);
            this.btn_bul.TabIndex = 6;
            this.btn_bul.Text = "Bul";
            this.btn_bul.UseVisualStyleBackColor = false;
            this.btn_bul.Click += new System.EventHandler(this.btn_bul_Click);
            // 
            // dgv_arama
            // 
            this.dgv_arama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arama.Location = new System.Drawing.Point(12, 48);
            this.dgv_arama.Name = "dgv_arama";
            this.dgv_arama.Size = new System.Drawing.Size(566, 305);
            this.dgv_arama.TabIndex = 7;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(200, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(321, 20);
            this.txt_search.TabIndex = 8;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(590, 365);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_arama);
            this.Controls.Add(this.btn_bul);
            this.Controls.Add(this.cb_ve);
            this.Controls.Add(this.txt_soyadı);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.cb_arama_kriteri);
            this.Controls.Add(this.label1);
            this.Name = "DosyaBul";
            this.Text = "DosyaBul";
            this.Load += new System.EventHandler(this.DosyaBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_arama_kriteri;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyadı;
        private System.Windows.Forms.CheckBox cb_ve;
        private System.Windows.Forms.Button btn_bul;
        private System.Windows.Forms.DataGridView dgv_arama;
        private System.Windows.Forms.TextBox txt_search;
    }
}