using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura
{
    class Sprzedawca
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

        private string _imie = "";
        public string imie
        {
            get { return _imie; }
            set
            {
                _imie = value;
            }
        }
        private string _nazwisko = "";
        public string nazwisko
        {
            get { return _nazwisko; }
            set
            {
                _nazwisko = value;
            }
        }
        private string _nrtel = "";
        public string nrtel
        {
            get { return _nrtel; }
            set
            {
                _nrtel = value;
            }
        }
    }
}
