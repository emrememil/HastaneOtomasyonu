using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.ClassModels
{
    class Poliklinik
    {
        DBView view = new DBView();
        Common cm = new Common();

        private string PoliklinikAdi;
        private Boolean PoliklinikDurum;
        private string PoliklinikAciklama;

        public string poliklinikAdi
        {
            get
            {
                return PoliklinikAdi;
            }
            set
            {
                PoliklinikAdi = value;
            }
        }
        public Boolean poliklinikDurum
        {
            get
            {
                return PoliklinikDurum;
            }
            set
            {
                PoliklinikDurum = value;
            }
        }
        public string poliklinikAciklama
        {
            get
            {
                return PoliklinikAciklama;
            }
            set
            {
                PoliklinikAciklama = value;
            }
        }

        internal void PoliklinikSil(string ad)
        {
            view.Create(cm.serverAdres);
            view.Exec("DELETE FROM poliklinik where poliklinikadi='" + ad+ "'");
        }
        public void PoliklinikGuncelle()
        {
            view.Create(cm.serverAdres);
            view.Exec("UPDATE poliklinik set poliklinikadi='" + poliklinikAdi + "', durum='" + poliklinikDurum + "', aciklama='" + poliklinikAciklama + "' where poliklinikadi='" + poliklinikAdi + "'");
        }
        public void PoliklinikEkle()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO poliklinik (poliklinikadi, durum, aciklama) VALUES ('" + poliklinikAdi + "','" + poliklinikDurum + "','" + poliklinikAciklama + "')");
        }
        public DataTable PoliklinikGetir(string poliAdi)
        {
            view.Create(cm.serverAdres);
            DataTable dt = view.GetTable("SELECT * FROM poliklinik WHERE poliklinikadi='" + poliAdi + "'");
            return dt;
        }

        public DataTable TumPoliklinikler()
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT poliklinikadi FROM poliklinik");
            return table;
        }
        public DataTable GecerliGecersizPoliklinikler(Boolean gelen)
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT * FROM poliklinik WHERE durum='"+gelen+"'");
            return table;
        }
    }
}
