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
            conn = new MySqlConnection("server=ID191774_6itngip22.db.webhosting.be;user id=ID191774_6itngip22;"+
                "password=dfb21Msf85; database=ID191774_6itngip22");
        }

        //alles wat met begeleiders te maken heeft
        public void addBegeleiderToDB(Begeleider item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into ID191774_6itngip22.begeleiders " +
                "(`BegeleiderVoornaam`, `BegeleiderAchternaam`, `GsmNummer`)" +
                "values('" + item.voornaam + "', '" + item.achternaam + "', '" +
                item.gsmNummer + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

		public void addLeerlingToDB(Leerling item)
		{
			MySqlCommand cmd = new MySqlCommand("insert into ID191774_6itngip22.leerlingen(`LeerlingVoornaam`, `LeerlingAchternaam`, `Klas`,`GsmNummer`)" +
                " values('"+item.voorNaam+"', '"+item.achterNaam+"', '"+item.klas+"', '"+item.gsmNummer+"')", conn);
			conn.Open();
			cmd.ExecuteNonQuery();
			conn.Close();
		}

		public List<Begeleider> GetBegeleidersFromDB()
        {
            List<Begeleider> lijst = new List<Begeleider>();

            MySqlCommand cmd = new MySqlCommand("select * from ID191774_6itngip22.begeleiders", conn);

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
        //Haalt gevraagde begeleiders uit de database gebaseerd bij de bijhoorende activiteit
        public List<Begeleider> GetWantedBegeleidersFromDB(string pstrNaam)
        {
            List<Begeleider> lijst = new List<Begeleider>();
            List<Begeleider> lijstIDBegeleider = new List<Begeleider>();
            List<int> lijstID = new List<int>();
            int intIDActiviteit = 0;

            MySqlCommand cmd = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDActiviteit += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("select begeleiders_idBegeleider from ID191774_6itngip22.activiteiten_begeleiders where activiteiten_idActiviteit=" + intIDActiviteit, conn);
            conn.Open();
            MySqlDataReader dataReaderID = cmd2.ExecuteReader();
            while (dataReaderID.Read())
            {
                Begeleider b = new Begeleider(Convert.ToInt32(dataReaderID["begeleiders_idBegeleider"]));
                lijstIDBegeleider.Add(b);
            }
            conn.Close();

            foreach(Begeleider item in lijstIDBegeleider)
            {
                lijstID.Add(item.AlleenID());
            }
            foreach(int id in lijstID)
            {
                MySqlCommand cmd3 = new MySqlCommand("select * from ID191774_6itngip22.begeleiders where idBegeleider=" + id, conn);
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
            }
            return lijst;
        }
        public List<Begeleider> getWantedBegeleiders2FromDB(string pstrNaam)
        {
            List<Begeleider> lijst = new List<Begeleider>();

            MySqlCommand cmd = new MySqlCommand("select * from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrNaam+"'", conn);

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
        public void updateBegeleiderInDB(string pstrOrigineleNaam, string pstrVoornaam, string pstrAchternaam, string pstrGsmNummer)
        {
            int intID=0;

            MySqlCommand cmd = new MySqlCommand("select idBegeleider from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrOrigineleNaam + "'", conn);
            conn.Open();
            intID += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd1 = new MySqlCommand("update ID191774_6itngip22.begeleiders set begeleiders.BegeleiderVoornaam ='"+pstrVoornaam+"' where idBegeleider="+intID, conn);
            MySqlCommand cmd2 = new MySqlCommand("update ID191774_6itngip22.begeleiders set begeleiders.BegeleiderAchternaam ='" + pstrAchternaam + "' where idBegeleider=" + intID, conn);
            MySqlCommand cmd3 = new MySqlCommand("update ID191774_6itngip22.begeleiders set begeleiders.GsmNummer ='" + pstrGsmNummer + "' where idBegeleider=" + intID, conn);

            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteBegeleiderInDB(string pstrNaam)
        {
            int intID = 0;

            MySqlCommand cmd = new MySqlCommand("select idBegeleider from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrNaam + "'", conn);
            conn.Open();
            intID += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd1 = new MySqlCommand("delete from ID191774_6itngip22.begeleiders where idBegeleider=" + intID, conn);
            MySqlCommand cmd2 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten_begeleiders where begeleiders_idBegeleider=" + intID, conn);
            conn.Open();
            cmd2.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteBegeleiderWantedActiviteit(string pstrBegeleiderNaam, string pstrActiviteitNaam)
        {
            int intIDBeg = 0;
            int intIDAc = 0;

            MySqlCommand cmd = new MySqlCommand("select idBegeleider from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrBegeleiderNaam + "'", conn);
            conn.Open();
            intIDBeg += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd1 = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrActiviteitNaam + "'", conn);
            conn.Open();
            intIDAc += Convert.ToInt32(cmd1.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten_begeleiders where begeleiders_idBegeleider= " + intIDBeg + " activiteiten_IDActiviteit= " + intIDAc ,conn);

        }

        //Alles wat met activiteiten te maken heeft
        public void addActiviteitToDB(Activiteit item)
        {
            string strDag, strMaand, strJaar, strDatum;
            strDag = item.datum.ToString().Substring(0,2);
            strMaand = item.datum.ToString().Substring(3, 2);
            strJaar = item.datum.ToString().Substring(6, 4);
            strDatum = strJaar + "-" + strMaand + "-" + strDag;

            MySqlCommand cmd = new MySqlCommand("insert into ID191774_6itngip22.activiteiten" +
                "(`ActiviteitNaam`,`Omschrijving`,`Kostprijs`,`AantalPlaatsen`,`AantalDeelnemers`,`ActiviteitDag`,`ActiviteitUUr`)" +
                "values('" + item.naam + "', '" + item.omschrijving + "'," + item.kostprijs + "," +item.plaatsen + ","+item.deelnemers+",'"+strDatum+"','"+item.uur+"')",conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
		public void ActiviteitPerDatum(Activiteit item)
		{
			MySqlCommand cmd = new MySqlCommand("select * from ID191774_6itngip22.activiteiten groupby CURDATE()", conn);
			string strDag, strMaand, strJaar, strDatum;
			strDag = item.datum.ToString().Substring(0, 2);
			strMaand = item.datum.ToString().Substring(3, 2);
			strJaar = item.datum.ToString().Substring(6, 4);
			strDatum = strJaar + "-" + strMaand + "-" + strDag;
		}

		public void connectActiviteitBegeleiderInDB(string pstrNaam, string pstrAcNaam)
        {
            int intIDBegeleider, intIDActiviteit;
            MySqlCommand cmd = new MySqlCommand("select idBegeleider from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDBegeleider = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrAcNaam + "'", conn);
            conn.Open();
            intIDActiviteit = Convert.ToInt32(cmd2.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd3 = new MySqlCommand("insert into ID191774_6itngip22.activiteiten_begeleiders(`activiteiten_idActiviteit`,`begeleiders_idBegeleider`) values(" + intIDActiviteit+","+intIDBegeleider+")", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteActiviteitBegeleiderConnectieInDB(string pstrNaam, string pstrAcNaam)
        {
            int intIDBegeleider, intIDActiviteit;
            MySqlCommand cmd = new MySqlCommand("select idBegeleider from ID191774_6itngip22.begeleiders where BegeleiderVoornaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDBegeleider = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrAcNaam + "'", conn);
            conn.Open();
            intIDActiviteit = Convert.ToInt32(cmd2.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd3 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten_begeleiders where activiteiten_idActiviteit=" + intIDActiviteit + " and begeleiders_idBegeleider=" + intIDBegeleider, conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteActiviteitLeerlingenConnectieInDB(string pstrAcNaam)
        {
            int intIDActiviteit;
            MySqlCommand cmd2 = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrAcNaam + "'", conn);
            conn.Open();
            intIDActiviteit = Convert.ToInt32(cmd2.ExecuteScalar());
            conn.Close();



        }

        public List<Activiteit> getActiviteitenFromDB()
        {
            List<Activiteit> lijst = new List<Activiteit>();

            MySqlCommand cmd = new MySqlCommand("select * from ID191774_6itngip22.activiteiten order by ActiviteitDag asc, ActiviteitUUr desc", conn);

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

            MySqlCommand cmd = new MySqlCommand("select * from ID191774_6itngip22.activiteiten where ActiviteitNaam = '" + pstrNaam+"'",conn);

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
        public void updateActiviteitenInDB(string pstrOrigineleNaam ,string pstrNaam, string pstrOmschrijving,
            double pdblKost, int pintPlaatsen, int pintDeelnemers, string pstrDatum, string pstrUUR)
        {
            int intID=0;
            string strDatum, strDag, strMaand, strJaar;
            strDag = pstrDatum.Substring(0, 2);
            strMaand = pstrDatum.Substring(3, 2);
            strJaar = pstrDatum.Substring(6, 4);
            strDatum = strJaar + "-" + strMaand + "-" + strDag;

            MySqlCommand cmd = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrOrigineleNaam + "'", conn);
            conn.Open();
            intID += Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd1 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.ActiviteitNaam='" + pstrNaam + "' where idActiviteit=" + intID, conn);
            MySqlCommand cmd2 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.Omschrijving='" + pstrOmschrijving+ "' where idActiviteit=" + intID, conn);
            MySqlCommand cmd3 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.Kostprijs=" + pdblKost+ " where idActiviteit=" + intID, conn);
            MySqlCommand cmd4 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.AantalPlaatsen=" + pintPlaatsen + " where idActiviteit=" + intID, conn);
            MySqlCommand cmd5 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.AantalDeelnemers=" + pintDeelnemers+ " where idActiviteit=" + intID, conn);
            MySqlCommand cmd6 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.ActiviteitDag='" + strDatum+ "' where idActiviteit=" + intID, conn);
            MySqlCommand cmd7 = new MySqlCommand("update ID191774_6itngip22.activiteiten set activiteiten.ActiviteitUUr='" + pstrUUR+ "' where idActiviteit=" + intID, conn);

            conn.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            cmd6.ExecuteNonQuery();
            cmd7.ExecuteNonQuery();
            conn.Close();
        }
        public void deleteActiviteitInDB(string pstrNaam)
        {
            int intIDActiviteit;
            MySqlCommand cmd = new MySqlCommand("select idActiviteit from ID191774_6itngip22.activiteiten where ActiviteitNaam='" + pstrNaam + "'", conn);
            conn.Open();
            intIDActiviteit = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            MySqlCommand cmd2 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten where idActiviteit=" + intIDActiviteit, conn);
            MySqlCommand cmd3 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten_begeleiders where activiteiten_idActiviteit=" + intIDActiviteit, conn);
            MySqlCommand cmd4 = new MySqlCommand("delete from ID191774_6itngip22.activiteiten_leerlingen where Activiteiten_idActiviteiten=" + intIDActiviteit, conn);
            conn.Open();
            cmd4.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
        }


    }
}
