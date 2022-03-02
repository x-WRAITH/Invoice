using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Faktura {
    public class Client {
        public delegate void Change();
        public event Change ValuesChanged;
        public Form1 form1 = new Form1();
        protected virtual void OnValuesChanged(){
            ValuesChanged.Invoke();}

        private int _id = 0;
        public int id 
        {
            get { return _id; }
            set {
                OnValuesChanged();
                _id = value;
            }
        }

        private string _imie = "";
        public string imie
        {
            get { return _imie; }
            set
            {
                OnValuesChanged();
                _imie = value;
            }
        }
        private string _nazwisko = "";
        public string nazwisko
        {
            get { return _nazwisko; }
            set
            {
                OnValuesChanged();
                _nazwisko = value;
            }
        }
        private string _nrtel = "";
        public string nrtel
        {
            get { return _nrtel; }
            set
            {
                OnValuesChanged();
                _nrtel = value;
            }
        }

        public string serialize(){
            return $"{id.ToString()}\n::{imie}::\n{nazwisko}::\n{nrtel}\n";}
        public static Client deserialize(string s){
            var arr = s.Split(new[] { "::" }, StringSplitOptions.None);
            var cl = new Client();
            cl.id = Convert.ToInt32(arr[0];
            cl.imie = arr[1];
            cl.nazwisko = arr[2];
            cl.nrtel = arr[3];
            return cl;}
    }
}
