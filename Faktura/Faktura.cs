using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura
{
    class Faktura
    {
        private int _id = 0;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        private string _Data = "";
        public string Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
            }
        }
        private string _Klient_ID = "";
        public string Klient_ID
        {
            get { return _Klient_ID; }
            set
            {
                _Klient_ID = value;
            }
        }
        private string _Sprzedawca_ID = "";
        public string Sprzedawca_ID
        {
            get { return _Sprzedawca_ID; }
            set
            {
                _Sprzedawca_ID = value;
            }
        }
        private string _Usluga_ID = "";
        public string Usluga_ID
        {
            get { return _Usluga_ID; }
            set
            {
                _Usluga_ID = value;
            }
        }
    }
}
