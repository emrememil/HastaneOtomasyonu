using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    class Session
    {
        private int kullanici_kodu=0;
        
        public Session()
        {

        }
        public Session(int kod)
        {
            kullanici_kodu = kod;
        }

        public void SessionDestroy()
        {
            kullanici_kodu = 0;
            Form1.ms.Visible = false;
        }
    }
}
