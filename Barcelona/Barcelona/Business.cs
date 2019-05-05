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

		public void addLeerling(string pstrVoornaam, string pstrAchternaam, string pstrGsm, string pstrKlas)
		{
			Leerling item = new Leerling(pstrVoornaam, pstrAchternaam, pstrKlas, pstrGsm);
			pers.addLeerlingToDB(item);
		}

        public List<string> getKeuzeActiviteiten(string pstrTijd)
        {
            List<string> result = new List<string>();
            Activiteit a = new Activiteit();
            if (pstrTijd == "_")
            {

            }
            else
            {
                string strUUr;
                DateTime dteDatum;
                int intAantal;

                dteDatum = Convert.ToDateTime(pstrTijd.Substring(0, 10));
                intAantal = (pstrTijd.Length) - 13;
                strUUr = pstrTijd.Substring(pstrTijd.Length - (intAantal), intAantal);
                a.datum = dteDatum;
                a.uur = strUUr;
            }


            foreach (Activiteit item in pers.getKeuzeActiviteitenFromDB(a))
            {
                result.Add(item.alleenNaam());
            }

            return result;
        }

        public string getDatumKeuzeActiviteiten(string pstrTijd)
        {
            string result;
            Activiteit a = new Activiteit();
            if (pstrTijd == "_")
            {

            }
            else
            {
                string strUUr;
                DateTime dteDatum;
                int intAantal;

                dteDatum = Convert.ToDateTime(pstrTijd.Substring(0, 10));
                intAantal = (pstrTijd.Length) - 13;
                strUUr = pstrTijd.Substring(pstrTijd.Length - (intAantal), intAantal);
                a.datum = dteDatum;
                a.uur = strUUr;
            }

            result = pers.getDatumKeuzeActiviteitenFromDB(a).alleenTijd();

            return result;
        }

        public void AddAutoActiviteitLeerlingConnectie(string strLeerlingVoor, string strLeerlingAchter)
        {
            pers.AddAutoActiviteitLeerlingConnectieToDB(strLeerlingVoor, strLeerlingAchter);
        }

        public void addKeuzeActivteitLeerlingConnectie(List<string> lijst, string strLeerlingVoor, string strLeerlingAchter)
        {
            List<Activiteit> activiteiten = new List<Activiteit>();
            foreach(string item in lijst)
            {
                if (item != "")
                {
                    Activiteit a = new Activiteit(item);
                    activiteiten.Add(a);
                }
                else { }
            }

            pers.addKeuzeActivteitLeerlingConnectieToDB(activiteiten,strLeerlingVoor,strLeerlingAchter);
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
        
        //Is nodig om begeleiders up te daten
        public string getWantedBegeleiderVoornaam(string pstrNaam)
        {
            string result="";

            foreach (Begeleider item in pers.getWantedBegeleiders2FromDB(pstrNaam))
            {
                result=item.AlleenVoornaam();
            }

            return result;
        }

        public string getWantedBegeleiderAchternaam(string pstrNaam)
        {
            string result = "";

            foreach (Begeleider item in pers.getWantedBegeleiders2FromDB(pstrNaam))
            {
                result = item.AlleenAchternaam();
            }

            return result;
        }

        public string getWantedBegeleiderGsmNummer(string pstrNaam)
        {
            string result = "";

            foreach (Begeleider item in pers.getWantedBegeleiders2FromDB(pstrNaam))
            {
                result = item.AlleenGsmNummer();
            }

            return result;
        }

        public void updateBegeleider(string pstrOrigineleNaam, string pstrVoornaam, string pstrAchternaam, string pstrGsmNummer)
        {
            pers.updateBegeleiderInDB(pstrOrigineleNaam, pstrVoornaam, pstrAchternaam, pstrGsmNummer);
        }
        public void deleteBegeleider(string pstrNaam)
        {
            pers.deleteBegeleiderInDB(pstrNaam);
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
        public void deleteActiviteitBegeleiderConnectie(string pstrBegeleider, string pstrActiviteit)
        {
            pers.deleteActiviteitBegeleiderConnectieInDB(pstrBegeleider, pstrActiviteit);
        }
        //Om activiteiten te weergeven

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
        
        //Nodig om activiteiten aan te passen
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
        //Gekozen activiteit aanpassen
        public void updateActiviteit(string pstrOrigineleNaam, string pstrNaam, string pstrOmschrijving,
            double pdblKost, int pintPlaatsen, int pintDeelnemers, string pstrDatum, string pstrUUR)
        {
            pers.updateActiviteitenInDB(pstrOrigineleNaam, pstrNaam, pstrOmschrijving, pdblKost,
                pintPlaatsen, pintDeelnemers, pstrDatum, pstrUUR);
        }
        public void deleteActiviteit(string pstrNaam)
        {
            pers.deleteActiviteitInDB(pstrNaam);
        }
	}
}
