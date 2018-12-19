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


    }
}
