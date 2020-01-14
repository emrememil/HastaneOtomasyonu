namespace HastaneOtomasyon
{
    partial class PoliklinikTanitma
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
            this.cb_poliklik_adi = new System.Windows.Forms.ComboBox();
            this.cbox_gecerli_gecersiz = new System.Windows.Forms.CheckBox();
            this.btn_yeni_pol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // cb_poliklik_adi
            // 
            this.cb_poliklik_adi.FormattingEnabled = true;
            this.cb_poliklik_adi.Location = new System.Drawing.Point(87, 12);
            this.cb_poliklik_adi.Name = "cb_poliklik_adi";
            this.cb_poliklik_adi.Size = new System.Drawing.Size(121, 21);
            this.cb_poliklik_adi.TabIndex = 1;
            this.cb_poliklik_adi.SelectedIndexChanged += new System.EventHandler(this.cb_poliklik_adi_SelectedIndexChanged);
            this.cb_poliklik_adi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_poliklik_adi_KeyDown);
            // 
            // cbox_gecerli_gecersiz
            // 
            this.cbox_gecerli_gecersiz.AutoSize = true;
            this.cbox_gecerli_gecersiz.Location = new System.Drawing.Point(91, 39);
            this.cbox_gecerli_gecersiz.Name = "cbox_gecerli_gecersiz";
            this.cbox_gecerli_gecersiz.Size = new System.Drawing.Size(111, 17);
            this.cbox_gecerli_gecersiz.TabIndex = 2;
            this.cbox_gecerli_gecersiz.Text = "Geçerli / Geçersiz";
            this.cbox_gecerli_gecersiz.UseVisualStyleBackColor = true;
            this.cbox_gecerli_gecersiz.CheckedChanged += new System.EventHandler(this.cbox_gecerli_gecersiz_CheckedChanged);
            // 
            // btn_yeni_pol
            // 
            this.btn_yeni_pol.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_yeni_pol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_pol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_yeni_pol.Location = new System.Drawing.Point(48, 62);
            this.btn_yeni_pol.Name = "btn_yeni_pol";
            this.btn_yeni_pol.Size = new System.Drawing.Size(132, 23);
            this.btn_yeni_pol.TabIndex = 5;
            this.btn_yeni_pol.Text = "Yeni Poliklinik Ekle";
            this.btn_yeni_pol.UseVisualStyleBackColor = false;
            this.btn_yeni_pol.Click += new System.EventHandler(this.btn_yeni_pol_Click);
            // 
            // PoliklinikTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(235, 90);
            this.Controls.Add(this.btn_yeni_pol);
            this.Controls.Add(this.cbox_gecerli_gecersiz);
            this.Controls.Add(this.cb_poliklik_adi);
            this.Controls.Add(this.label1);
            this.Name = "PoliklinikTanitma";
            this.Text = "SOHATS - Poliklinik Adı";
            this.Load += new System.EventHandler(this.PoliklinikTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_poliklik_adi;
        private System.Windows.Forms.CheckBox cbox_gecerli_gecersiz;
        private System.Windows.Forms.Button btn_yeni_pol;
    }
}