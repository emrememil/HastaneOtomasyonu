using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    class Kullanici
    {
        DBView view = new DBView();
        Common cm = new Common();
        private string Kodu;
        private string Ad;
        private string Soyad;
        private string Sifre;
        private Boolean Yetki;
        private string EvTel;
        private string CepTel;
        private string KullaniciAdres;
        private string Unvan;
        private DateTime IseBaslama;
        private DateTime DogumTarihi;
        private string Maas;
        private string DogumYeri;
        private string AnneAd;
        private string BabaAd;
        private string Cinsiyet;
        private string KanGrubu;


        private string MedeniHal;
        private string TcKimlikNo;
        private string UserName;

        public string kodu
        {
            get
            {
                return Kodu;
            }
            set
            {
                Kodu = value;
            }
        }
        public string ad
        {
            get
            {
                return Ad;
            }
            set
            {
                Ad = value;
            }
        }
        public string soyad
        {
            get
            {
                return Soyad;
            }
            set
            {
                Soyad = value;
            }
        }
        public string sifre
        {
            get
            {
                return Sifre;
            }
            set
            {
                Sifre = value;
            }
        }
        public Boolean yetki
        {
            get
            {
                return Yetki;
            }
            set
            {
                Yetki = value;
            }
        }

        public string evTel
        {
            get
            {
                return EvTel;
            }
            set
            {
                EvTel = value;
            }
        }
        public string cepTel
        {
            get
            {
                return CepTel;
            }
            set
            {
                CepTel = value;
            }
        }
        public string adres
        {
            get
            {
                return KullaniciAdres;
            }
            set
            {
                KullaniciAdres = value;
            }
        }
        public string unvan
        {
            get
            {
                return Unvan;
            }
            set
            {
                Unvan = value;
            }
        }
        public DateTime iseBaslama
        {
            get
            {
                return IseBaslama;
            }
            set
            {
                IseBaslama = value;
            }
        }
        public string maas
        {
            get
            {
                return Maas;
            }
            set
            {
                Maas = value;
            }
        }
        public string dogumYeri
        {
            get
            {
                return DogumYeri;
            }
            set
            {
                DogumYeri = value;
            }
        }
        public string anneAd
        {
            get
            {
                return AnneAd;
            }
            set
            {
                AnneAd = value;
            }
        }
        public string babaAd
        {
            get
            {
                return BabaAd;
            }
            set
            {
                BabaAd = value;
            }
        }
        public string cinsiyet
        {
            get
            {
                return Cinsiyet;
            }
            set
            {
                Cinsiyet = value;
            }
        }
        public string kanGrubu
        {
            get
            {
                return KanGrubu;
            }
            set
            {
                KanGrubu = value;
            }
        }
        public string medeniHal
        {
            get
            {
                return MedeniHal;
            }
            set
            {
                MedeniHal = value;
            }
        }
        public DateTime dogumTarihi
        {
            get
            {
                return DogumTarihi;
            }
            set
            {
                DogumTarihi = value;
            }
        }
        public string tckimlikNo
        {
            get
            {
                return TcKimlikNo;
            }
            set
            {
                TcKimlikNo = value;
            }
        }
        public string userName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }

        public void KullaniciSil(string kno)
        {
            view.Create(cm.serverAdres);
            view.Exec("DELETE FROM kullanici where kodu='" + kno + "'");
        }

        public void KullaniciGuncelle()
        {
            view.Create(cm.serverAdres);
            view.Exec("UPDATE kullanici set ad='" + ad + "', soyad='" + soyad + "', sifre='" + sifre + "', yetki='" + yetki + "', evtel='" + evTel + "', ceptel='" + cepTel + "', adres='" + adres + "', unvan='" + unvan + "', isebaslama='" + iseBaslama.ToString(cm.format) + "', maas='" + maas + "', dogumyeri='" + dogumYeri + "', annead='" + anneAd + "', babaad='" + babaAd + "', cinsiyet='" + cinsiyet + "', kangrubu='" + kanGrubu + "', medenihal='" + medeniHal + "', dogumtarihi='" + dogumTarihi.ToString(cm.format) + "', tckimlikno='" + tckimlikNo + "', username='" + userName + "' where kodu='" + kodu + "'");

        }

        public void KullaniciEkle()
        {
            view.Create(cm.serverAdres);
            view.Exec("INSERT INTO kullanici (kodu, ad, soyad, sifre, yetki, evtel, ceptel, adres, unvan, isebaslama, maas, dogumyeri, annead, babaad, cinsiyet, kangrubu, medenihal, dogumtarihi, tckimlikno, username) VALUES ('" + kodu + "','" + ad + "','" + soyad + "','" + sifre + "', '" + yetki + "','" + evTel + "','" + cepTel + "','" + adres + "','" + unvan + "','" + iseBaslama.ToString(cm.format) + "','" + maas + "','" + dogumYeri + "','" + anneAd + "','" + babaAd + "','" + cinsiyet + "','" + kanGrubu + "','" + medeniHal + "','" + dogumTarihi.ToString(cm.format) + "','" + tckimlikNo + "','" + userName + "')");
        }

        public DataTable GirisKontrol(string kadi, string sifre)
        {
            view.Create(cm.serverAdres);
            DataTable gelen = view.GetTable("SELECT * FROM kullanici WHERE username='" + kadi + "' AND sifre='" + sifre + "'");

            return gelen;
        }
        internal DataTable UsernameGetir()
        {
            view.Create(cm.serverAdres);
            DataTable table = view.GetTable("SELECT username FROM kullanici");
            return table;
        }
        public DataTable KullaniciKoduGetir()
        {
            view.Create(cm.serverAdres);
            DataTable data = view.GetTable("SELECT TOP 1 kodu FROM kullanici ORDER BY kodu DESC");
            return data;
        }


    }
}
