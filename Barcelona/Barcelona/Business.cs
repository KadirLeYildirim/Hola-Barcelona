using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcelona
{
    class Business
    {
        private Persistence pers;
        private List<Activiteit> _activiteiten;
        private List<Leerling> _leerlingen;
        private List<Begeleider> _begeleiders;

        public List<Activiteit> activiteiten
        {
            get { return _activiteiten; }
            set { _activiteiten = value; }
        }
        public List<Leerling> leerlingen
        {
            get { return _leerlingen; }
            set { _leerlingen = value; }
        }
        public List<Begeleider> begeleiders
        {
            get { return _begeleiders; }
            set { _begeleiders = value; }
        }

        public Business()
        {
            pers = new Persistence();
        }

        public void addBegeleider(string pstrVoornaam, string pstrAchternaam, string pstrGsm)
        {
            Begeleider item = new Begeleider(pstrVoornaam,pstrAchternaam,pstrGsm);
            pers.addBegeleiderToDB(item);
        }
        public List<string> getBegeleiders()
        {
            List<string> result = new List<string>();

            foreach(Begeleider item in pers.GetBegeleidersFromDB())
            {
                result.Add(item.ToString());
            }

            return result;
        }
        public List<string> getBegeleidersNamen()
        {
            List<string> result = new List<string>();

            foreach (Begeleider item in pers.GetBegeleidersFromDB())
            {
                result.Add(item.AlleenNaam());
            }

            return result;
        }
        public List<string> getWantedBegeleiders(string pstrNaam)
        {
            List<string> result = new List<string>();

            foreach (Begeleider item in pers.GetWantedBegeleidersFromDB(pstrNaam))
            {
                result.Add(item.AlleenNaam());
            }

            return result;
        }

        public void addActiviteit(string pstrNaam, string pstrOmschrijving, double pdblKost,
            int pintPlaatsen, DateTime pdteDatum, string pstrUur)
        {
            Activiteit item = new Activiteit(pstrNaam, pstrOmschrijving, pdblKost, pintPlaatsen,
                0, pdteDatum, pstrUur);
            pers.addActiviteitToDB(item);
        }
        public void connectActiviteitBegeleider(string pstrBegeleider, string pstrActiviteit)
        {
            pers.connectActiviteitBegeleiderInDB(pstrBegeleider, pstrActiviteit);
        }
        public List<string> getActiviteiten()
        {
            List<string> result = new List<string>();

            foreach(Activiteit item in pers.getActiviteitenFromDB())
            {
                result.Add(item.ToString());
            }

            return result;
        }
        public List<string> getNaamActiviteiten()
        {
            List<string> result = new List<string>();

            foreach (Activiteit item in pers.getActiviteitenFromDB())
            {
                result.Add(item.alleenNaam());
            }

            return result;
        }
        public string getWantedNaamActiviteiten(string pstrNaam)
        {
            string result="";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenNaam();
            }

            return result;
        }
        public string getWantedOmschrijvingActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenOmschrijving();
            }

            return result;
        }
        public string getWantedKostprijsActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenKostprijs();
            }

            return result;
        }
        public string getWantedPlaatsenActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenPlaatsen();
            }

            return result;
        }
        public string getWantedDeelnemersActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenDeelnemers();
            }

            return result;
        }
        public string getWantedDatumActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenDatum();
            }

            return result;
        }
        public string getWantedUUrActiviteiten(string pstrNaam)
        {
            string result = "";

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(pstrNaam))
            {
                result = item.alleenUUr();
            }

            return result;
        }

    }
}
