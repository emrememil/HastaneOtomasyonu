using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.ClassModels
{
    class Cikis
    {
        private string dosyano;
        private string sevkTarihi;
        private DateTime cikisTarihi;
        private string odeme;
        private string toplamtutar;
        DBView view = new DBView();
        Common cm = new Common();


        public string Dosyano { get => dosyano; set => dosyano = value; }
        public string SevkTarihi { get => sevkTarihi; set => sevkTarihi = value; }
        public DateTime CikisTarihi { get => cikisTarihi; set => cikisTarihi = value; }
        public string Odeme { get => odeme; set => odeme = value; }
        public string Toplamtutar { get => toplamtutar; set => toplamtutar = value; }

        public void cikisGerceklestir()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO cikis (dosyano, sevktarihi, cikissaati, odeme, toplamtutar) VALUES ('" + Dosyano + "','" + SevkTarihi + "','" + CikisTarihi.ToString(cm.format) + "','" + Odeme + "','" + Toplamtutar + "')");
        }

        public Boolean TaburcuKontrol(string dosyaNum, string sevkTarih)
        {
            /*
            view.GetTable("select * from sevk where dosyano = @dosyaNo and sevktarihi = @sevkTarih and(taburcu is null or taburcu = '')", 
                new SqlParameter("dosyaNo", dosyaNum), 
                new SqlParameter("sevkTarih", sevkTarih));
                */
            view.Create(cm.serverAdres);
           // DataTable gelen = view.GetTable("select * from cikis c inner join hasta h on c.dosyano = h.dosyano where c.dosyano='" + dosyaNum + "'");
            DataTable gelen = view.GetTable("select * from sevk where dosyano='"+dosyaNum+"' and sevktarihi = '"+sevkTarih+"' and (taburcu is null or taburcu='')");
            if (gelen.Rows.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public Boolean TaburcuKontrol(string dosyaNum)
        {
            view.Create(cm.serverAdres);
            DataTable gelen = view.GetTable("select * from cikis c inner join hasta h on c.dosyano = h.dosyano where c.dosyano='" + dosyaNum + "'");
            if (gelen.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
