using HastaneOtomasyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static ToolStripMenuItem ms = new ToolStripMenuItem();

        private void Form1_Load(object sender, EventArgs e)
        {
            ms = menu_referanslar;
            menu_referanslar.Visible = false;
            FormAc(new Login());

        }

        private void kullanıcıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new KullaniciTanitma());
        }

        public  void FormAc(Form AcılacakForm)
        {
            AcılacakForm.MdiParent = this;
            AcılacakForm.Show();
        }
        public void TumFormlariKapat()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session ss = new Session();
            ss.SessionDestroy();
            TumFormlariKapat();
            FormAc(new Login());
        }

        private void poliklinikTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new PoliklinikTanitma());
        }

        private void hastaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new HastaIslemleri());
        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new Sorgula());
        }
    }
}
