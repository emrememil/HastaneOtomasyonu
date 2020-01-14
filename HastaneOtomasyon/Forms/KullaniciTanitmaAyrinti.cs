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
    public partial class KullaniciTanitmaAyrinti : Form
    {
        DBView view = new DBView();
        Common cm = new Common();
        Kullanici kullanici;
        public KullaniciTanitmaAyrinti()
        {
            InitializeComponent();
        }
        public static string username="";
        public static int kullanici_kod = 0;
        private void KullaniciTanitmaAyrinti_Load(object sender, EventArgs e)
        {
            if (!username.Equals(""))
            {
                try
                {
                    KullaniciyiGetir();

                }catch(Exception ee)
                {
                    MessageBox.Show("Kullanıcı Getirilemedi ve bir hata ile karşılaşıldı: " + ee.Message);
                }
                btn_kaydet.Visible = false;
            }
            else
            {
                btn_guncelle.Visible = false;
                btn_sil.Visible = false;
                txt_kullanici_kodu.Text = kullanici_kod.ToString();
            }
            
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if(txt_kullanici_adi.Text!="" && txt_sifre.Text !="" && txt_adi.Text!="" && txt_soyadi.Text !=""
                && cb_unvani.SelectedItem != null)
            {
               kullaniciKaydet();
                if (DBView.state == true)
                {
                    MessageBox.Show("Kullanıcı Başarıyla Kaydedildi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı kaydedilemedi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen ad, soyad, ünvan, kullanıcı adı ve şifre bilgilerini doldurunuz!");
            }

           
        }

        private void kullaniciKaydet()
        {
            kullanici = new Kullanici();
            kullanici.kodu = txt_kullanici_kodu.Text;
            kullanici.ad = txt_adi.Text;
            kullanici.soyad = txt_soyadi.Text;
            kullanici.sifre = txt_sifre.Text;
            kullanici.yetki = cb_yetkili_kullanici.Checked;
            kullanici.evTel = txt_tel_no.Text;
            kullanici.cepTel = txt_gsm.Text;
            kullanici.adres = txt_adres.Text;
            kullanici.unvan = cb_unvani.Text;
            kullanici.iseBaslama = dt_ise_baslama.Value;
            kullanici.maas = txt_maasi.Text;
            kullanici.dogumYeri = txt_dogum_yeri.Text;
            kullanici.anneAd = txt_ana_adi.Text;
            kullanici.babaAd = txt_baba_adi.Text;
            kullanici.cinsiyet = cb_cinsiyeti.Text;
            kullanici.kanGrubu = cb_kan_grubu.Text;
            kullanici.medeniHal = cb_medeni_hali.Text;
            kullanici.dogumTarihi = dt_dogum_tarihi.Value;
            kullanici.tckimlikNo = txt_tcno.Text;
            kullanici.userName = txt_kullanici_adi.Text;

            kullanici.KullaniciEkle();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            inputlariTemizle();
           
        }

        private void inputlariTemizle()
        {
            txt_kullanici_kodu.Clear();
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_sifre.Clear();
            cb_yetkili_kullanici.Checked = false;
            txt_tel_no.Clear();
            txt_gsm.Clear();
            txt_adres.Clear();
            cb_unvani.SelectedItem = null;
            txt_maasi.Clear();
            txt_dogum_yeri.Clear();
            txt_ana_adi.Clear();
            txt_baba_adi.Clear();
            cb_cinsiyeti.SelectedItem = null;
            cb_kan_grubu.SelectedItem = null;
            cb_medeni_hali.SelectedItem = null;
            txt_tcno.Clear();
            txt_kullanici_adi.Clear();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            kullaniciGuncelle();
            if (DBView.state == true)
            {
                MessageBox.Show("Kullanıcı Başarıyla Güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı verileri güncellemesi başarısız oldu!");
            }

        }

        private void kullaniciGuncelle()
        {
            kullanici = new Kullanici();
            kullanici.kodu = txt_kullanici_kodu.Text;
            kullanici.ad = txt_adi.Text;
            kullanici.soyad = txt_soyadi.Text;
            kullanici.sifre = txt_sifre.Text;
            kullanici.yetki = cb_yetkili_kullanici.Checked;
            kullanici.evTel = txt_tel_no.Text;
            kullanici.cepTel = txt_gsm.Text;
            kullanici.adres = txt_adres.Text;
            kullanici.unvan = cb_unvani.Text;
            kullanici.iseBaslama = dt_ise_baslama.Value;
            kullanici.maas = txt_maasi.Text;
            kullanici.dogumYeri = txt_dogum_yeri.Text;
            kullanici.anneAd = txt_ana_adi.Text;
            kullanici.babaAd = txt_baba_adi.Text;
            kullanici.cinsiyet = cb_cinsiyeti.Text;
            kullanici.medeniHal = cb_medeni_hali.Text;
            kullanici.kanGrubu = cb_kan_grubu.Text;
            kullanici.dogumTarihi = dt_dogum_tarihi.Value;
            kullanici.tckimlikNo = txt_tcno.Text;
            kullanici.userName = txt_kullanici_adi.Text;

            kullanici.KullaniciGuncelle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            kullaniciSil();
            if (DBView.state == true)
            {
                MessageBox.Show("Kullanıcı Başarıyla Silindi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı silme işlemi başarısız oldu!");
            }
        }

        private void kullaniciSil()
        {
            kullanici = new Kullanici();
            kullanici.KullaniciSil(txt_kullanici_kodu.Text);
        }

        private void KullaniciyiGetir()
        {
            view.Create(cm.serverAdres);
            DataTable dt = view.GetTable("SELECT * FROM kullanici WHERE username='" + username.ToString() + "'");
            txt_adi.Text = dt.Rows[0]["ad"].ToString();
            txt_soyadi.Text = dt.Rows[0]["soyad"].ToString();
            txt_kullanici_kodu.Text = dt.Rows[0]["kodu"].ToString();
            txt_sifre.Text = dt.Rows[0]["sifre"].ToString();
            if (dt.Rows[0]["yetki"].ToString() == "true")
            {
                cb_yetkili_kullanici.Checked = true;
            }
            else
            {
                cb_yetkili_kullanici.Checked = false;
            }
            txt_tel_no.Text = dt.Rows[0]["evtel"].ToString();
            txt_gsm.Text = dt.Rows[0]["ceptel"].ToString();
            txt_adres.Text = dt.Rows[0]["adres"].ToString();
            cb_unvani.SelectedItem = dt.Rows[0]["unvan"].ToString();
            if (dt.Rows[0]["isebaslama"] == DBNull.Value)
            {
                dt_ise_baslama.Value = DateTime.Parse(DateTime.Now.ToString());
            }
            else
            {
                dt_ise_baslama.Value = Convert.ToDateTime(dt.Rows[0]["isebaslama"]);
            }
            txt_maasi.Text = dt.Rows[0]["maas"].ToString();
            txt_dogum_yeri.Text = dt.Rows[0]["dogumyeri"].ToString();
            txt_ana_adi.Text = dt.Rows[0]["annead"].ToString();
            txt_baba_adi.Text = dt.Rows[0]["babaad"].ToString();
            cb_cinsiyeti.SelectedItem = dt.Rows[0]["cinsiyet"].ToString();
            cb_kan_grubu.SelectedItem = dt.Rows[0]["kangrubu"].ToString();
            cb_medeni_hali.SelectedItem = dt.Rows[0]["medenihal"].ToString();

            if (dt.Rows[0]["dogumtarihi"] == DBNull.Value)
            {
                dt_dogum_tarihi.Value = DateTime.Parse(DateTime.Now.ToString());
            }
            else
            {
                dt_dogum_tarihi.Value = Convert.ToDateTime(dt.Rows[0]["dogumtarihi"]);
            }
            txt_tcno.Text = dt.Rows[0]["tckimlikno"].ToString();
            txt_kullanici_adi.Text = dt.Rows[0]["username"].ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
