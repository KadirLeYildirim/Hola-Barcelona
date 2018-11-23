using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcalona
{
    class Leerling
    {
        private string _voornaam;
        public string voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        private string _achternaam;
        public string achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }

        private int _klasnummer;
        public int klasnummer
        {
            get { return _klasnummer; }
            set { _klasnummer = value; }
        }

        private string _gsm;
        public string gsm
        {
            get { return _gsm; }
            set { _gsm = value; }
        }

        private string _klas;
        public string klas
        {
            get { return _klas; }
            set { _klas = value; }
        }

        private string _activiteit;
        public string activiteit
        {
            get { return _activiteit; }
            set { _activiteit = value; }
        }

        public Leerling (string first, string family, int number, string phone, string clas, string activity)
        {
            _voornaam = first;
            _achternaam = family;
            _klasnummer = number;
            _gsm = phone;
            _klas = clas;
            _activiteit = activity;
        }
    }
}
