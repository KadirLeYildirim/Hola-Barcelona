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
        public List<string> getWantedActiviteiten(string pstrTijd)
        {
            List<string> result = new List<string>();
            string strDatum, strUUr="", strLetter;

            strDatum = pstrTijd.Substring(0, 10);

            for(int i=0; i<pstrTijd.Length; i++)
            {
                if(i > 12)
                {
                    strLetter = pstrTijd.Substring(i, 1);
                    strUUr += strLetter;
                }
                else
                {
                }
            }

            foreach (Activiteit item in pers.getWantedActiviteitenFromDB(strDatum,strUUr))
            {
                result.Add(item.alleenNaam());
            }

            return result;
        }

        

    }
}
