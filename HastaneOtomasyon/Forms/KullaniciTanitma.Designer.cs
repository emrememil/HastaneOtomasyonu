namespace HastaneOtomasyon
{
    partial class KullaniciTanitma
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
            this.cb_kullanici_kodu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yeni_kullanici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_kullanici_kodu
            // 
            this.cb_kullanici_kodu.FormattingEnabled = true;
            this.cb_kullanici_kodu.Location = new System.Drawing.Point(101, 12);
            this.cb_kullanici_kodu.Name = "cb_kullanici_kodu";
            this.cb_kullanici_kodu.Size = new System.Drawing.Size(121, 21);
            this.cb_kullanici_kodu.TabIndex = 3;
            this.cb_kullanici_kodu.SelectedIndexChanged += new System.EventHandler(this.cb_kullanici_kodu_SelectedIndexChanged);
            this.cb_kullanici_kodu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_kullanici_kodu_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // btn_yeni_kullanici
            // 
            this.btn_yeni_kullanici.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_yeni_kullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yeni_kullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_yeni_kullanici.Location = new System.Drawing.Point(53, 39);
            this.btn_yeni_kullanici.Name = "btn_yeni_kullanici";
            this.btn_yeni_kullanici.Size = new System.Drawing.Size(132, 23);
            this.btn_yeni_kullanici.TabIndex = 4;
            this.btn_yeni_kullanici.Text = "Yeni Kullanıcı Ekle";
            this.btn_yeni_kullanici.UseVisualStyleBackColor = false;
            this.btn_yeni_kullanici.Click += new System.EventHandler(this.btn_yeni_kullanici_Click);
            // 
            // KullaniciTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(254, 70);
            this.Controls.Add(this.btn_yeni_kullanici);
            this.Controls.Add(this.cb_kullanici_kodu);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciTanitma";
            this.Text = "SOHATS - Kullanıcı Tanıtma";
            this.Load += new System.EventHandler(this.KullaniciTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_kullanici_kodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_yeni_kullanici;
    }
}