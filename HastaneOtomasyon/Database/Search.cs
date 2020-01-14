using HastaneOtomasyon.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.Database
{
    class Search
    {
        DBView view = new DBView();
        Common cm = new Common();
        DosyaBul dosyaBul;

        public DataTable isimArama(string isim, string soyisim)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where ad='" + isim + "' and soyad='" + soyisim + "'");
            return data;
            
        }
        public DataTable isimArama(string isim)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where ad='" + isim + "'");
            return data;
        }
        public DataTable SoyIsimArama(string soyisim)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where soyad='" + soyisim + "'");
            return data;
        }
        public DataTable KimlikNoArama(string no)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where tckimlikno='" + no + "'");
            return data;
        }
        public DataTable KurumSicilNoArama(string no)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where kurumsicilno='" + no + "'");
            return data;
        }
        public DataTable DosyaNoArama(string no)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("Select * from hasta where dosyano='" + no + "'");
            return data;
        }
        public DataTable TaburcuOlmusHastalar(DateTime baslangic, DateTime bitis)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("select * from sevk s inner join cikis c on c.dosyano = s.dosyano where c.cikissaati is not null and c.cikissaati between  '"+baslangic.ToString(cm.format)+ "' and  '" + bitis.ToString(cm.format) + "'");
            return data;
        }
        public DataTable TaburcuOlmamisHastalar(DateTime baslangic, DateTime bitis)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("select * from sevk where (taburcu is null or taburcu = '') "); //and sevktarihi between '" + baslangic.ToString(cm.format2) + "' and '" + bitis.ToString(cm.format2) + "'
            return data;
        }
        public DataTable TumHastalar(DateTime baslangic, DateTime bitis)
        {
            dosyaBul = new DosyaBul();
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("select * from sevk"); 
            return data;
        }
    }
}
