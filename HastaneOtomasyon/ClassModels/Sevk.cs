using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.ClassModels
{
    class Sevk
    {
        private string sevkTarihi;
        private string dosyaNo;
        private string poliklinik;
        private string saat;
        private string yapilanIslem;
        private string drKod;
        private string miktar;
        private string birimFiyat;
        private string sira;
        private string toplamTutar;
        private string taburcu;

        DBView view = new DBView();
        Common cm = new Common();
        public string SevkTarihi { get => sevkTarihi; set => sevkTarihi = value; }
        public string DosyaNo { get => dosyaNo; set => dosyaNo = value; }
        public string Poliklinik { get => poliklinik; set => poliklinik = value; }
        public string Saat { get => saat; set => saat = value; }
        public string YapilanIslem { get => yapilanIslem; set => yapilanIslem = value; }
        public string DrKod { get => drKod; set => drKod = value; }
        public string Miktar { get => miktar; set => miktar = value; }
        public string BirimFiyat { get => birimFiyat; set => birimFiyat = value; }
        public string Sira { get => sira; set => sira = value; }
        public string ToplamTutar { get => toplamTutar; set => toplamTutar = value; }
        public string Taburcu { get => taburcu; set => taburcu = value; }

        public void SevkEkle()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO sevk (sevktarihi, dosyano, poliklinik, saat, yapilanislem, drkod, miktar, birimfiyat, sira, toplamtutar, taburcu) VALUES ('" + SevkTarihi + "','" + DosyaNo + "','" + Poliklinik + "','" + Saat + "','" + YapilanIslem + "','" + DrKod + "','" + Miktar + "','" + BirimFiyat + "','" + Sira + "','" + ToplamTutar + "','" + Taburcu + "')");
        }
        public void IslemSil(string saat, string islemadi)
        {
            view.Create(cm.serverAdres);
            view.Exec("DELETE FROM sevk where saat='" + saat + "' and yapilanislem='" + islemadi + "'");
        }
        public void HastaTaburcuUpdate(DateTime cikisTarihi)
        {
            view.Create(cm.serverAdres);
            view.Exec("UPDATE sevk set sevktarihi = '"+SevkTarihi+"', dosyano='"+DosyaNo+"', poliklinik='"+Poliklinik+"', saat ='"+Saat+"', yapilanislem ='"+YapilanIslem+"', drkod='"+DrKod+"', miktar='"+Miktar + "', birimfiyat = '" + BirimFiyat + "', sira = '" + Sira + "', toplamtutar = '" + ToplamTutar + "', taburcu ='"+SevkTarihi+"' where dosyano='"+DosyaNo+"' and sevktarihi='"+SevkTarihi+"'");
        }
        public DataTable SevkDosyanoGetir(string dosyano, string date)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("select * from sevk where dosyano = '" + dosyano + "' and sevktarihi='" + date + "'");
            return table;
        }

    }
}
