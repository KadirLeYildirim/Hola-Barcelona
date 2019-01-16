using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Barcelona
{
	class Persistence
    {
        private MySqlConnection conn;

        public Persistence()
        {
            conn = new MySqlConnection("server=localhost;user id=root;"+
                "password='1453istanbul1453';database=barcelona");
        }

        public void addBegeleiderToDB(Begeleider item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into barcelona.begeleiders " +
                "(`BegeleiderVoornaam`, `BegeleiderAchternaam`, `GsmNummer`)" +
                "values('" + item.voornaam + "', '" + item.achternaam + "', '" +
                item.gsmNummer + "0482576868')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

		public void addLeerlingToDB(Leerling item)
		{
			MySqlCommand cmd = new MySqlCommand("insert into barcelona.leerling " +
				"(`LeerlingVoornaam`, `AchternaamAchternaam`, `GsmNummer`)" +
				"values('" + item.voorNaam + "', '" + item.achterNaam + "', '" +
				item.gsmNummer + "0482576868')", conn);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public List<Begeleider> GetBegeleidersFromDB()
        {
            List<Begeleider> lijst = new List<Begeleider>();

            MySqlCommand cmd = new MySqlCommand("select * from barcelona.begeleiders", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Begeleider b = new Begeleider(Convert.ToInt32(dataReader["idBegeleider"]),
                    dataReader["BegeleiderVoornaam"].ToString(),
                    dataReader["BegeleiderAchternaam"].ToString(),
                    dataReader["GsmNummer"].ToString());
                lijst.Add(b);
            }
            conn.Close();

            return lijst;
        }
        public List<Begeleider> GetWantedBegeleidersFromDB(string pstrNaam)
        {
            List<Begeleider> lijst = new List<Begeleider>();
            int intIDActiviteit=0, intIDBegeleider=0;

            MySqlCommand cmd = new MySqlCommand("select idActiviteit from barcelona.activiteiten where ActiviteitNaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDActiviteit += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("select begeleiders_idBegeleider from barcelona.activiteiten_begeleiders where activiteiten_idActiviteit=" + intIDActiviteit, conn);
            conn.Open();
            intIDBegeleider = Convert.ToInt32(cmd2.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd3 = new MySqlCommand("select * from barcelona.begeleiders where idBegeleider=" + intIDBegeleider, conn);

            conn.Open();
            MySqlDataReader dataReader = cmd3.ExecuteReader();
            while (dataReader.Read())
            {
                Begeleider b = new Begeleider(Convert.ToInt32(dataReader["idBegeleider"]),
                    dataReader["BegeleiderVoornaam"].ToString(),
                    dataReader["BegeleiderAchternaam"].ToString(),
                    dataReader["GsmNummer"].ToString());
                lijst.Add(b);
            }
            conn.Close();

            return lijst;
        }

        public void addActiviteitToDB(Activiteit item)
        {
            string strDag, strMaand, strJaar, strDatum;
            strDag = item.datum.ToString().Substring(0,2);
            strMaand = item.datum.ToString().Substring(3, 2);
            strJaar = item.datum.ToString().Substring(6, 4);
            strDatum = strJaar + "-" + strMaand + "-" + strDag;

            MySqlCommand cmd = new MySqlCommand("insert into barcelona.activiteiten" +
                "(`ActiviteitNaam`,`Omschrijving`,`Kostprijs`,`AantalPlaatsen`,`AantalDeelnemers`,`ActiviteitDag`,`ActiviteitUUr`)" +
                "values('" + item.naam + "', '" + item.omschrijving + "'," + item.kostprijs + "," +item.plaatsen + ","+item.deelnemers+",'"+strDatum+"','"+item.uur+"')",conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
		public void ActiviteitPerDatum(Activiteit item)
		{
			MySqlCommand cmd = new MySqlCommand("select * from barcelona.activiteiten groupby CURDATE()", conn);
			string strDag, strMaand, strJaar, strDatum;
			strDag = item.datum.ToString().Substring(0, 2);
			strMaand = item.datum.ToString().Substring(3, 2);
			strJaar = item.datum.ToString().Substring(6, 4);
			strDatum = strJaar + "-" + strMaand + "-" + strDag;
		}

		public void connectActiviteitBegeleiderInDB(string pstrNaam, string pstrAcNaam)
        {
            int intIDBegeleider, intIDActiviteit;
            MySqlCommand cmd = new MySqlCommand("select idBegeleider from barcelona.begeleiders where BegeleiderVoornaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDBegeleider = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("select idActiviteit from barcelona.activiteiten where ActiviteitNaam='" + pstrAcNaam + "'", conn);
            conn.Open();
            intIDActiviteit = Convert.ToInt32(cmd2.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd3 = new MySqlCommand("insert into barcelona.activiteiten_begeleiders(`activiteiten_idActiviteit`,`begeleiders_idBegeleider`) values("+intIDActiviteit+","+intIDBegeleider+")", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public List<Activiteit> getActiviteitenFromDB()
        {
            List<Activiteit> lijst = new List<Activiteit>();

            MySqlCommand cmd = new MySqlCommand("select * from barcelona.activiteiten order by ActiviteitDag asc, ActiviteitUUr desc", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Activiteit a = new Activiteit(Convert.ToInt32(dataReader["idActiviteit"]),
                    dataReader["ActiviteitNaam"].ToString(),
                    dataReader["Omschrijving"].ToString(),
                    Convert.ToDouble(dataReader["Kostprijs"]),
                    Convert.ToInt32(dataReader["AantalPlaatsen"]),
                    Convert.ToInt32(dataReader["AantalDeelnemers"]),
                    Convert.ToDateTime(dataReader["ActiviteitDag"]),
                    dataReader["ActiviteitUUr"].ToString());
                lijst.Add(a);
            }
            conn.Close();
            
            return lijst;
        }
        public List<Activiteit> getWantedActiviteitenFromDB(string pstrNaam)
        {
            List<Activiteit> lijst = new List<Activiteit>();

            MySqlCommand cmd = new MySqlCommand("select * from barcelona.activiteiten where ActiviteitNaam = '"+pstrNaam+"'",conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Activiteit a = new Activiteit(Convert.ToInt32(dataReader["idActiviteit"]),
                    dataReader["ActiviteitNaam"].ToString(),
                    dataReader["Omschrijving"].ToString(),
                    Convert.ToDouble(dataReader["Kostprijs"]),
                    Convert.ToInt32(dataReader["AantalPlaatsen"]),
                    Convert.ToInt32(dataReader["AantalDeelnemers"]),
                    Convert.ToDateTime(dataReader["ActiviteitDag"]),
                    dataReader["ActiviteitUUr"].ToString());
                lijst.Add(a);
            }
            conn.Close();

            return lijst;
        }

    }
}
