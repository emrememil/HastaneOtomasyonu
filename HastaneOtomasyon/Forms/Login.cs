using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Kullanici kullanici = new Kullanici();
        Session session;
        int kullanici_kodu;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            girisKontrolu();
        }

        private void girisKontrolu()
        {
            DataTable gelen = kullanici.GirisKontrol(txt_kullaniciadi.Text.ToString(), txt_sifre.Text.ToString());
            if (gelen.Rows.Count == 1 && (gelen.Rows[0]["yetki"].ToString() == "True" || gelen.Rows[0]["yetki"].ToString() == "true"))
            {
                kullanici_kodu = Convert.ToInt32(gelen.Rows[0]["kodu"]);
                session = new Session(kullanici_kodu);
                Form1.ms.Visible = true;
                this.Close();


            }
            else if (gelen.Rows.Count == 1 && (gelen.Rows[0]["yetki"].ToString() == "False" || gelen.Rows[0]["yetki"].ToString() == "false"))
            {
                kullanici_kodu = Convert.ToInt32(gelen.Rows[0]["kodu"]);
                session = new Session(kullanici_kodu);
                Form1.ms.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı ve/veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullaniciadi.Text = "";
            txt_sifre.Text = "";
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
