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
    public partial class KullaniciTanitma : Form
    {
        public KullaniciTanitma()
        {
            InitializeComponent();
        }
        Common cm = new Common();
        Kullanici kullanici = new Kullanici();
       
        int kul_kod = 0;
        private void KullaniciTanitma_Load(object sender, EventArgs e)
        {
            DataTable table = kullanici.UsernameGetir();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_kullanici_kodu.Items.Add(table.Rows[i]["username"].ToString());
            }
        }

        private void cb_kullanici_kodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_yeni_kullanici_Click(object sender, EventArgs e)
        {
            KullaniciTanitmaAyrinti.username = "";
            string kod;
            DataTable data = kullanici.KullaniciKoduGetir();
            kod = data.Rows[0]["kodu"].ToString();
            kul_kod = Convert.ToInt32(kod);
            ++kul_kod;
            KullaniciTanitmaAyrinti.kullanici_kod = kul_kod;
            ((Form1)this.MdiParent).FormAc(new KullaniciTanitmaAyrinti());
            this.Close();
        }

        private void cb_kullanici_kodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                KullaniciTanitmaAyrinti.username = cb_kullanici_kodu.SelectedItem.ToString();
                ((Form1)this.MdiParent).FormAc(new KullaniciTanitmaAyrinti());
            }
        }
    }
}
