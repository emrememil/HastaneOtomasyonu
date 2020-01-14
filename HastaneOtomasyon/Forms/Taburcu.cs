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
    public partial class Taburcu : Form
    {
        public Taburcu()
        {
            InitializeComponent();
        }
        public static string dosyaNo = "";
        public static DateTime sevkTarihi;
        public static string tutar="";

        DBView view = new DBView();
        Common cm = new Common();
        Sevk sevk = new Sevk();
        Cikis cikis;

        private void btn_vazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Taburcu_Load(object sender, EventArgs e)
        {
            if (dosyaNo!="" && sevkTarihi != null && tutar!="")
            {
                HastaGetir();
            }
        }

        private void HastaGetir()
        {
            txt_dosyano.Text = dosyaNo;
            txt_toplama_tutar.Text = tutar;
            dt_sevktarihi.Value = Convert.ToDateTime(sevkTarihi);
            dt_cikis_tarihi.Value = Convert.ToDateTime(DateTime.Now.ToString());
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (cb_odeme_sekli.SelectedItem!=null)
            {
                TaburcuEt();
                if (DBView.state == true)
                {
                    MessageBox.Show("Hasta Taburcu Edildi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Taburcu işlemi başarısız oldu!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ödeme yöntemi seçiniz");
            }
        }

        private void TaburcuEt()
        {
            cikis = new Cikis();
            cikis.CikisTarihi = dt_cikis_tarihi.Value;
            cikis.Dosyano = txt_dosyano.Text;
            cikis.SevkTarihi = dt_sevktarihi.Value.ToString();
            cikis.Odeme = cb_odeme_sekli.SelectedItem.ToString();
            cikis.Toplamtutar = txt_toplama_tutar.Text.ToString();
            cikis.cikisGerceklestir();
            SevkUpdateEt();
        }

        private void SevkUpdateEt()
        {
            DataTable table = sevk.SevkDosyanoGetir(txt_dosyano.Text.ToString(), dt_sevktarihi.Text.ToString());
            sevk.SevkTarihi = dt_sevktarihi.Text.ToString();
            sevk.DosyaNo= table.Rows[0]["dosyano"].ToString();
            sevk.Poliklinik= table.Rows[0]["poliklinik"].ToString();
            sevk.Saat= table.Rows[0]["saat"].ToString();
            sevk.YapilanIslem= table.Rows[0]["yapilanislem"].ToString();
            sevk.DrKod= table.Rows[0]["drkod"].ToString();
            sevk.Miktar= table.Rows[0]["miktar"].ToString();
            sevk.BirimFiyat= table.Rows[0]["birimfiyat"].ToString();
            sevk.Sira= table.Rows[0]["sira"].ToString();
            sevk.ToplamTutar= table.Rows[0]["toplamtutar"].ToString();
            sevk.Taburcu= table.Rows[0]["taburcu"].ToString();
            sevk.HastaTaburcuUpdate(dt_cikis_tarihi.Value);

        }
    }
}
