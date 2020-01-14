using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon.ClassModels
{
    class Islem
    {
        DBView view = new DBView();
        Common cm = new Common();

        private string islemAdi;
        private string birimFiyat;

        public string IslemAdi { get => islemAdi; set => islemAdi = value; }
        public string BirimFiyat { get => birimFiyat; set => birimFiyat = value; }

        internal void Kaydet()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO islem (islemadi, birimfiyat) VALUES ('" + IslemAdi + "','" + BirimFiyat + "')");
        }
    }
}
