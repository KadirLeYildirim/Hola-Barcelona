using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcelona
{
    class Leerling
    {
        private int _id;
        private string _voorNaam;
        private string _achterNaam;
        private string _klas;
        private int _gsmNummer;
		private string pstrVoornaam;
		private string pstrAchternaam;
		private string pstrGsm;
		private string pstrKlas;

		public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string voorNaam
        {
            get { return _voorNaam; }
            set { _voorNaam = value; }
        }
        public string achterNaam
        {
            get { return _achterNaam; }
            set { _achterNaam = value; }
        }
        public string klas
        {
            get { return _klas; }
            set { _klas = value; }
        }
        public int gsmNummer
        {
            get { return _gsmNummer; }
            set { _gsmNummer = value; }
        }

        public Leerling(int pintID ,string pstrVoornaam, string pstrAchternaam, string pstrKlas,
            int pintGsmNummer)
        {
            _id = pintID;
            _voorNaam = pstrVoornaam;
            _achterNaam = pstrAchternaam;
            _klas = pstrKlas;
            _gsmNummer = pintGsmNummer;
        }
        public Leerling(string pstrVoornaam, string pstrAchternaam, string pstrKlas,
            int pintGsmNummer)
        {
            _voorNaam = pstrVoornaam;
            _achterNaam = pstrAchternaam;
            _klas = pstrKlas;
            _gsmNummer = pintGsmNummer;
        }

		public Leerling(string pstrVoornaam, string pstrAchternaam, string pstrGsm, string pstrKlas)
		{
			this.pstrVoornaam = pstrVoornaam;
			this.pstrAchternaam = pstrAchternaam;
			this.pstrGsm = pstrGsm;
			this.pstrKlas = pstrKlas;
		}
	}
}
