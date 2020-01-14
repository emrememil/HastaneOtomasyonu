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

namespace HastaneOtomasyon
{
    public partial class HastaBilgileri : Form
    {
        public HastaBilgileri()
        {
            InitializeComponent();
        }
        DBView view = new DBView();
        Common cm = new Common();
        Hasta hasta = new Hasta();
        Sevk sevk = new Sevk();
        public static int dosyaNo=0;
        private void HastaBilgileri_Load(object sender, EventArgs e)
        {
            if (dosyaNo==0)
            {
                txt_dosya_no.Text = hasta.DosyaNoGetir().ToString();
            }
            else
            {
                try
                {
                    HastayiGetir();

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Hasta Getirilemedi ve bir hata ile karşılaşıldı: " + ee.Message);
                }
            }
        }

        private void HastayiGetir()
        {
            DataTable dt = hasta.HastayiGetir(dosyaNo.ToString());
            txt_tcno.Text = dt.Rows[0]["tckimlikno"].ToString();
            txt_dosya_no.Text = dt.Rows[0]["dosyano"].ToString();
            txt_adi.Text = dt.Rows[0]["ad"].ToString();
            txt_soyadi.Text = dt.Rows[0]["soyad"].ToString();
            txt_dogum_yeri.Text = dt.Rows[0]["dogumyeri"].ToString();
            if (dt.Rows[0]["dogumtarihi"] == DBNull.Value)
            {
                dt_dogum_tarihi.Value = DateTime.Parse(DateTime.Now.ToString());
            }
            else
            {
                dt_dogum_tarihi.Value = Convert.ToDateTime(dt.Rows[0]["dogumtarihi"]);
            }
            txt_ana_adi.Text = dt.Rows[0]["anneadi"].ToString();
            txt_baba_adi.Text = dt.Rows[0]["babaadi"].ToString();
            cb_cinsiyeti.SelectedItem = dt.Rows[0]["cinsiyet"].ToString();
            cb_kan_grubu.SelectedItem = dt.Rows[0]["kangrubu"].ToString();
            cb_medeni_hali.SelectedItem = dt.Rows[0]["medenihal"].ToString();
            txt_adres.Text = dt.Rows[0]["adres"].ToString();
            txt_tel_no.Text = dt.Rows[0]["tel"].ToString();
            txt_kurum_sicilno.Text = dt.Rows[0]["kurumsicilno"].ToString();
            txt_kurum_adi.Text = dt.Rows[0]["kurumadi"].ToString();
            txt_yakinin_tel.Text = dt.Rows[0]["yakintel"].ToString();
            txt_yakinin_kurum_sicilno.Text = dt.Rows[0]["yakinkurumsicilno"].ToString();
            txt_yakinin_kurum_adi.Text = dt.Rows[0]["yakinkurumadi"].ToString();
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            inputlariTemizle();
        }

        private void inputlariTemizle()
        {
            txt_tcno.Clear();
            txt_dosya_no.Clear();
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_dogum_yeri.Clear();
            dt_dogum_tarihi.Value = DateTime.Parse(DateTime.Now.ToString());
            txt_baba_adi.Clear();
            txt_ana_adi.Clear();
            cb_cinsiyeti.SelectedItem = null;
            cb_kan_grubu.SelectedItem = null;
            cb_medeni_hali.SelectedItem = null;
            txt_adres.Clear();
            txt_tel_no.Clear();
            txt_kurum_sicilno.Clear();
            txt_kurum_adi.Clear();
            txt_yakinin_tel.Clear();
            txt_yakinin_kurum_sicilno.Clear();
            txt_yakinin_kurum_adi.Clear();
            lbl_durum.Visible = false;
            txt_dosya_no.Text = hasta.DosyaNoGetir().ToString();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_tcno.Text != "" && txt_adi.Text != "" && txt_soyadi.Text != ""
                && txt_adres.Text != "")
            {
                if (txt_dosya_no.Text.ToString()!=hasta.DosyaNoGetir().ToString())
                {
                    hastaGuncelle();
                    if (DBView.state == true)
                    {
                        lbl_durum.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Hasta Güncelleme İşlemi Başarısız Oldu");
                    }
                }
                else
                {
                    hastaKaydet();
                    if (DBView.state == true)
                    {
                        lbl_durum.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Hasta kaydedilemedi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ad, soyad, Tc No ve adres bilgilerini doldurunuz!");
            }
        }

        private void hastaGuncelle()
        {
            hasta.TckimlikNo1 = txt_tcno.Text;
            hasta.DosyaNo1 = txt_dosya_no.Text;
            hasta.Ad1 = txt_adi.Text;
            hasta.Soyad1 = txt_soyadi.Text;
            hasta.DogumYeri1 = txt_dogum_yeri.Text;
            hasta.DogumTarihi1 = dt_dogum_tarihi.Value;
            hasta.BabaAdi1 = txt_baba_adi.Text;
            hasta.AnnneAdi1 = txt_ana_adi.Text;
            hasta.Cinsiyet1 = cb_cinsiyeti.Text;
            hasta.KanGrubu1 = cb_kan_grubu.Text;
            hasta.MedeniHal1 = cb_medeni_hali.Text;
            hasta.Adres1 = txt_adres.Text;
            hasta.Tel1 = txt_tel_no.Text;
            hasta.KurumSicilNo1 = txt_kurum_sicilno.Text;
            hasta.KurumAdi1 = txt_kurum_adi.Text;
            hasta.YakinTel1 = txt_yakinin_tel.Text;
            hasta.YakinKurumSicilNo1 = txt_yakinin_kurum_sicilno.Text;
            hasta.YakinKurumAdi1 = txt_yakinin_kurum_adi.Text;

            hasta.HastaGuncelle();
        }

        private void hastaKaydet()
        {
            hasta.TckimlikNo1 = txt_tcno.Text;
            hasta.DosyaNo1 = txt_dosya_no.Text;
            hasta.Ad1 = txt_adi.Text;
            hasta.Soyad1 = txt_soyadi.Text;
            hasta.DogumYeri1 = txt_dogum_yeri.Text;
            hasta.DogumTarihi1 = dt_dogum_tarihi.Value;
            hasta.BabaAdi1 = txt_baba_adi.Text;
            hasta.AnnneAdi1 = txt_ana_adi.Text;
            hasta.Cinsiyet1 = cb_cinsiyeti.Text;
            hasta.KanGrubu1 = cb_kan_grubu.Text;
            hasta.MedeniHal1 = cb_medeni_hali.Text;
            hasta.Adres1 = txt_adres.Text;
            hasta.Tel1 = txt_tel_no.Text;
            hasta.KurumSicilNo1 = txt_kurum_sicilno.Text;
            hasta.KurumAdi1 = txt_kurum_adi.Text;
            hasta.YakinTel1 = txt_yakinin_tel.Text;
            hasta.YakinKurumSicilNo1 = txt_yakinin_kurum_sicilno.Text;
            hasta.YakinKurumAdi1 = txt_yakinin_kurum_adi.Text;

            hasta.HastaEkle();
        }
    }
}
