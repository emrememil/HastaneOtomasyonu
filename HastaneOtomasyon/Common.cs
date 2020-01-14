using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    class Common
    {//DESKTOP-6EL0V7Q
        private const string SERVER_ADRES = @"server=.\; Initial Catalog=HastaneOtomasyon; Integrated Security = SSPI";
        private const string FORMAT = "yyyy-MM-dd HH:mm:ss";
        private const string FORMAT2 = "yyyy-MM-dd";
        private const string FORMAT3 = "dd-MM-yyyy";
        public string serverAdres
        {
            get
            {
                return SERVER_ADRES;
            }
        }
        public string format
        {
            get
            {
                return FORMAT;
            }
        }
        public string format2
        {
            get
            {
                return FORMAT2;
            }
        }
        public string format3
        {
            get
            {
                return FORMAT3;
            }
        }


    }
}
