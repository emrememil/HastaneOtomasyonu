using HastaneOtomasyon.ClassModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Forms
{
    public partial class PoliklinikTanitmaAyrinti : Form
    {
        
        public PoliklinikTanitmaAyrinti()
        {
            InitializeComponent();
        }
        Poliklinik poliklinik = new Poliklinik();
        public static string polAdi = "";
        DBView view = new DBView();
        Common cm = new Common(); 

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            poliklinikSil();
            if (DBView.state == true)
            {
                MessageBox.Show("Poliklinik Başarıyla Silindi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Poliklinik silme işlemi başarısız oldu!");
            }
        }

        private void poliklinikSil()
        {
            poliklinik.PoliklinikSil(txt_poliklinik_adi.Text);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            polikinikGuncelle();
            if (DBView.state == true)
            {
                MessageBox.Show("Poliklinik Başarıyla Güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Poliklinik verileri güncellemesi başarısız oldu!");
            }
        }

        private void polikinikGuncelle()
        {
            poliklinik.poliklinikAdi = txt_poliklinik_adi.Text;
            poliklinik.poliklinikDurum = cbox_gecerli_gecersiz.Checked;
            poliklinik.poliklinikAciklama = txt_aciklama.Text;

            poliklinik.PoliklinikGuncelle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            poliklinikEkle();
            if (DBView.state == true)
            {
                MessageBox.Show("Poliklinik Başarıyla Eklendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Poliklinik ekleme işlemi başarısız oldu!");
            }
        }

        private void poliklinikEkle()
        {
            poliklinik.poliklinikAdi = txt_poliklinik_adi.Text;
            poliklinik.poliklinikDurum = cbox_gecerli_gecersiz.Checked;
            poliklinik.poliklinikAciklama = txt_aciklama.Text;

            poliklinik.PoliklinikEkle();
        }

        private void PoliklinikTanitmaAyrinti_Load(object sender, EventArgs e)
        {
            if (!polAdi.Equals(""))
            {
                try
                {
                    poliklinikGetir();

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Poliklinik Getirilemedi ve bir hata ile karşılaşıldı: " + ee.Message);
                }
                btn_kaydet.Visible = false;
            }
            else
            {
                btn_guncelle.Visible = false;
                btn_sil.Visible = false;
            }

        }

        private void poliklinikGetir()
        {
            //view.Create(cm.serverAdres);
            //DataTable dt = view.GetTable("SELECT * FROM poliklinik WHERE poliklinikadi='" + polAdi.ToString() + "'");
            DataTable dt = poliklinik.PoliklinikGetir(polAdi.ToString());
            txt_poliklinik_adi.Text = dt.Rows[0]["poliklinikadi"].ToString();
            txt_aciklama.Text = dt.Rows[0]["aciklama"].ToString();
            if (dt.Rows[0]["durum"].ToString() == "True" || dt.Rows[0]["durum"].ToString() == "true")
            {
                cbox_gecerli_gecersiz.Checked = true;
            }
            else
            {
                cbox_gecerli_gecersiz.Checked = false;
            }

        }
    }
}
