using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcelona
{
    class Activiteit
    {
        private int _id;
        private string _activiteitNaam;
        private string _omschrijving;
        private double _kostprijs;
        private int _plaatsen;
        private int _deelnemers;
        private DateTime _datum;
        private string _uur;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string naam
        {
            get { return _activiteitNaam; }
            set { _activiteitNaam = value; }
        }
        public string omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        public double kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }
        public int plaatsen
        {
            get { return _plaatsen; }
            set { _plaatsen = value; }
        }
        public int deelnemers
        {
            get { return _deelnemers; }
            set { _deelnemers = value; }
        }
        public DateTime datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public string uur
        {
            get { return _uur; }
            set { _uur = value; }
        }

        public Activiteit(int pintID ,string pstrNaam, string pstrOmschrijving, double pdblKost,
    int pintPlaatsen, int pintDeelnemers, DateTime pdteDatum, string pstrUur)
        {
            _id = pintID;
            _activiteitNaam = pstrNaam;
            _omschrijving = pstrOmschrijving;
            _kostprijs = pdblKost;
            _plaatsen = pintPlaatsen;
            _deelnemers = pintDeelnemers;
            _datum = pdteDatum;
            _uur = pstrUur;
        }
        public Activiteit(string pstrNaam, string pstrOmschrijving, double pdblKost,
            int pintPlaatsen, int pintDeelnemers, DateTime pdteDatum, string pstrUur)
        {
            _activiteitNaam = pstrNaam;
            _omschrijving = pstrOmschrijving;
            _kostprijs = pdblKost;
            _plaatsen = pintPlaatsen;
            _deelnemers = pintDeelnemers;
            _datum = pdteDatum;
            _uur = pstrUur;
        }
        public Activiteit(DateTime pdteDatum, string pstrUUr)
        {
            _datum = pdteDatum;
            _uur = pstrUUr;
        }

        public override string ToString()
        {
            return "Activiteit ID: " + _id + " is " + _activiteitNaam + ": " +
                _omschrijving + Environment.NewLine + "Prijs per persoon: " + _kostprijs +
                Environment.NewLine + "Heeft " + _deelnemers + " deelnemers en er zijn nog " +
                _plaatsen + Environment.NewLine + "De activiteit neemt op " + _datum.ToString().Substring(0,10) +
                " plaats en is tijdens de " + _uur;
        }
        public string alleenTijd()
        {
            return Convert.ToString(_datum).Substring(0, 10) + " - " + _uur;
        }
        public string zonderTijd()
        {
            return "Activiteit ID: " + _id + " is " + _activiteitNaam + ": " +
                _omschrijving + Environment.NewLine + "Prijs per persoon: " + _kostprijs +
                Environment.NewLine + "Heeft " + _deelnemers + " deelnemers en er zijn nog " +
                _plaatsen;
        }
        public string alleenNaam()
        {
            return _activiteitNaam;
        }

    }
}
