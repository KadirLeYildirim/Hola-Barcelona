using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcelona
{
    class Begeleider
    {
        private int _id;
        private string _voornaam;
        private string _achternaam;
        private string _gsmNummer;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }
        public string gsmNummer
        {
            get { return _gsmNummer; }
            set { _gsmNummer = value; }
        }

        public Begeleider(string pstrVoornaam)
        {
            _voornaam = pstrVoornaam;
        }
        public Begeleider(int pintID,string pstrVoornaam, string pstrAchternaam, string pstrGsmNummer)
        {
            _id = pintID;
            _voornaam = pstrVoornaam;
            _achternaam = pstrAchternaam;
            _gsmNummer = pstrGsmNummer;
        }
        public Begeleider(string pstrVoornaam, string pstrAchternaam, string pstrGsmnummer)
        {
            _voornaam = pstrVoornaam;
            _achternaam = pstrAchternaam;
            _gsmNummer = pstrGsmnummer;
        }
        public Begeleider(int pintID)
        {
            _id = pintID;
        }

        public override string ToString()
        {
            return _id + " = Naam: " + _voornaam + " " + _achternaam + " gsm nummer: " + _gsmNummer;
        }
        public string AlleenNaam()
        {
            return _voornaam + " " + _achternaam;
        }
        public string AlleenVoornaam()
        {
            return _voornaam;
        }
        public string AlleenAchternaam()
        {
            return _achternaam;
        }
        public string AlleenGsmNummer()
        {
            return _gsmNummer;
        }
        public int AlleenID()
        {
            return _id;
        }
    

    }
}
