namespace HastaneOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_referanslar = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poliklinikTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_hastakabul = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_raporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_referanslar,
            this.menu_hastakabul,
            this.menu_raporlar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_referanslar
            // 
            this.menu_referanslar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.poliklinikTanımlamaToolStripMenuItem,
            this.kullanıcıTanımlamaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menu_referanslar.Name = "menu_referanslar";
            this.menu_referanslar.Size = new System.Drawing.Size(77, 20);
            this.menu_referanslar.Text = "Referanslar";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // poliklinikTanımlamaToolStripMenuItem
            // 
            this.poliklinikTanımlamaToolStripMenuItem.Name = "poliklinikTanımlamaToolStripMenuItem";
            this.poliklinikTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.poliklinikTanımlamaToolStripMenuItem.Text = "Poliklinik Tanıtma";
            this.poliklinikTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.poliklinikTanımlamaToolStripMenuItem_Click);
            // 
            // kullanıcıTanımlamaToolStripMenuItem
            // 
            this.kullanıcıTanımlamaToolStripMenuItem.Name = "kullanıcıTanımlamaToolStripMenuItem";
            this.kullanıcıTanımlamaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.kullanıcıTanımlamaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanımlamaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanımlamaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // menu_hastakabul
            // 
            this.menu_hastakabul.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriToolStripMenuItem});
            this.menu_hastakabul.Name = "menu_hastakabul";
            this.menu_hastakabul.Size = new System.Drawing.Size(82, 20);
            this.menu_hastakabul.Text = "Hasta Kabul";
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.hastaİşlemleriToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hastaİşlemleriToolStripMenuItem.Text = "Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // menu_raporlar
            // 
            this.menu_raporlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istatistiklerToolStripMenuItem});
            this.menu_raporlar.Name = "menu_raporlar";
            this.menu_raporlar.Size = new System.Drawing.Size(63, 20);
            this.menu_raporlar.Text = "Raporlar";
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            this.istatistiklerToolStripMenuItem.Click += new System.EventHandler(this.istatistiklerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_referanslar;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poliklinikTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_hastakabul;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_raporlar;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
    }
}

