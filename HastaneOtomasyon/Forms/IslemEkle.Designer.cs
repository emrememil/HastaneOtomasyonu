namespace HastaneOtomasyon.Forms
{
    partial class IslemEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_islemadi = new System.Windows.Forms.TextBox();
            this.txt_birimfiyat = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_vazgeç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Fiyat";
            // 
            // txt_islemadi
            // 
            this.txt_islemadi.Location = new System.Drawing.Point(77, 6);
            this.txt_islemadi.Name = "txt_islemadi";
            this.txt_islemadi.Size = new System.Drawing.Size(180, 20);
            this.txt_islemadi.TabIndex = 2;
            // 
            // txt_birimfiyat
            // 
            this.txt_birimfiyat.Location = new System.Drawing.Point(77, 36);
            this.txt_birimfiyat.Name = "txt_birimfiyat";
            this.txt_birimfiyat.Size = new System.Drawing.Size(180, 20);
            this.txt_birimfiyat.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(160, 62);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(101, 30);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = false;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_vazgeç
            // 
            this.btn_vazgeç.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_vazgeç.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_vazgeç.Location = new System.Drawing.Point(15, 62);
            this.btn_vazgeç.Name = "btn_vazgeç";
            this.btn_vazgeç.Size = new System.Drawing.Size(106, 30);
            this.btn_vazgeç.TabIndex = 4;
            this.btn_vazgeç.Text = "Vazgeç";
            this.btn_vazgeç.UseVisualStyleBackColor = false;
            this.btn_vazgeç.Click += new System.EventHandler(this.btn_vazgeç_Click);
            // 
            // IslemEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(273, 103);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_vazgeç);
            this.Controls.Add(this.txt_birimfiyat);
            this.Controls.Add(this.txt_islemadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IslemEkle";
            this.Text = "IslemEkle";
            this.Load += new System.EventHandler(this.IslemEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_islemadi;
        private System.Windows.Forms.TextBox txt_birimfiyat;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_vazgeç;
    }
}