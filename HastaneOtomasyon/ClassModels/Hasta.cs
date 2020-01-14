using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.ClassModels
{
    
    class Hasta
    {
        private string TckimlikNo;
        private string DosyaNo;
        private string Ad;
        private string Soyad;
        private string DogumYeri;
        private DateTime DogumTarihi;
        private string BabaAdi;
        private string AnnneAdi;
        private string Cinsiyet;
        private string KanGrubu;
        private string MedeniHal;
        private string Adres;
        private string Tel;
        private string KurumSicilNo;
        private string KurumAdi;
        private string YakinTel;
        private string YakinKurumSicilNo;
        private string YakinKurumAdi;
        DBView view = new DBView();
        Common cm = new Common();
        public string TckimlikNo1 { get => TckimlikNo; set => TckimlikNo = value; }
        public string DosyaNo1 { get => DosyaNo; set => DosyaNo = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string DogumYeri1 { get => DogumYeri; set => DogumYeri = value; }
        public DateTime DogumTarihi1 { get => DogumTarihi; set => DogumTarihi = value; }
        public string BabaAdi1 { get => BabaAdi; set => BabaAdi = value; }
        public string AnnneAdi1 { get => AnnneAdi; set => AnnneAdi = value; }
        public string Cinsiyet1 { get => Cinsiyet; set => Cinsiyet = value; }
        public string KanGrubu1 { get => KanGrubu; set => KanGrubu = value; }
        public string MedeniHal1 { get => MedeniHal; set => MedeniHal = value; }
        public string Adres1 { get => Adres; set => Adres = value; }
        public string Tel1 { get => Tel; set => Tel = value; }
        public string KurumSicilNo1 { get => KurumSicilNo; set => KurumSicilNo = value; }
        public string KurumAdi1 { get => KurumAdi; set => KurumAdi = value; }
        public string YakinTel1 { get => YakinTel; set => YakinTel = value; }
        public string YakinKurumSicilNo1 { get => YakinKurumSicilNo; set => YakinKurumSicilNo = value; }
        public string YakinKurumAdi1 { get => YakinKurumAdi; set => YakinKurumAdi = value; }

        public int DosyaNoGetir()
        {
            string kod;
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("SELECT TOP 1 dosyano FROM hasta ORDER BY dosyano DESC");
            kod = data.Rows[0]["dosyano"].ToString();
            int dosyaNumarasi = Convert.ToInt32(kod);
            ++dosyaNumarasi;
            return dosyaNumarasi;
        }
        public void HastaEkle()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO hasta (tckimlikno, dosyano, ad, soyad, dogumyeri, dogumtarihi, babaadi, anneadi, cinsiyet, kangrubu, medenihal, adres, tel, kurumsicilno, kurumadi, yakintel, yakinkurumsicilno, yakinkurumadi ) VALUES ('" + TckimlikNo1 + "','" + DosyaNo1 + "','" + Ad1 + "','" + Soyad1 + "','" + DogumYeri1 + "','" + DogumTarihi1.ToString(cm.format) + "','" + BabaAdi1 + "','" + AnnneAdi1 + "','" + Cinsiyet1 + "','" + KanGrubu1 + "','" + MedeniHal1 + "','" + Adres1 + "','" + Tel1 + "','" + KurumSicilNo1 + "','" + KurumAdi1 + "','" + YakinTel1 + "','" + YakinKurumSicilNo1 + "','" + YakinKurumAdi1 + "')");
        }
        public DataTable PoliklinikleriGetir()
        {
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("SELECT poliklinikadi FROM poliklinik where durum='true' or durum='True'");
            return data;
        }
        public DataTable DoktorlariGetir()
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT kodu FROM kullanici where unvan='Doktor'");
            return table;
        }
        public DataTable IslemleriGetir()
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT islemadi FROM islem");
            return table;
        }
        public DataTable DataGridDosyaNoYukle(string dosyaNo)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT poliklinik, sira, saat, yapilanislem, drkod, miktar, birimfiyat FROM sevk where dosyano='" + dosyaNo + "'");
            return table;
        }
        public DataTable HastaBul(string dosyaNo)
        {
            view.Create(cm.serverAdres);
            DataTable dt = view.GetTable("select dosyano, ad, soyad, kurumadi from hasta where dosyano='" + dosyaNo + "'");
            return dt;
        }
        public DataTable OncekiIslemleriYukle(string dosyaNo)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT DISTINCT sevktarihi FROM sevk where dosyano='" + dosyaNo + "'");
            return table;
        }
        public DataTable DataGridOncekiIslemler(string sevkTarih, string dosyaNo)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT poliklinik, sira, saat, yapilanislem, drkod, miktar, birimfiyat FROM sevk where sevktarihi='" + sevkTarih +"' and dosyano='"+dosyaNo+"'");
            return table;
        }
        public DataTable IslemAdi(string yapilanIslem)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT * FROM islem where islemadi='" + yapilanIslem + "'");
            return table;
        }
        public DataTable RaporDoktorGetir(string kodu)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("select ad,soyad from kullanici where kodu='"+kodu+"' and unvan='Doktor'");
            return table;
        }

        internal void HastaGuncelle()
        {
            view.Create(cm.serverAdres);
            view.Exec("UPDATE hasta set tckimlikno='" + TckimlikNo1 + "', ad='" + Ad1 + "', soyad='" + Soyad1 + "', dogumyeri='" + DogumYeri1 + "', dogumtarihi='" + DogumTarihi1.ToString(cm.format) + "', babaadi='" + BabaAdi1 + "', anneadi='" + AnnneAdi1 + "', cinsiyet='" + Cinsiyet1 + "', kangrubu='" + KanGrubu1 + "', medenihal='" + MedeniHal1 + "', adres='" + Adres1 + "', tel='" + Tel1 + "', kurumsicilno='" + KurumSicilNo1 + "', kurumadi='" + KurumAdi1 + "', yakintel='" + YakinTel1 + "', yakinkurumsicilno='" + YakinKurumSicilNo1 + "', yakinkurumadi='" + YakinKurumAdi1 + "' where dosyano='"+DosyaNo1+"'");

        }
        public DataTable HastayiGetir(string dosyano)
        {
            view.Create(cm.serverAdres);
            DataTable dt = view.GetTable("SELECT * FROM hasta WHERE dosyano='" + dosyano + "'");
            return dt;
        }
    }
}
