using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Barcalona
{
    class Persistence
    {
        private string ConnectionString;
        private MySqlConnection Connect;

        public Persistence()
        {
            ConnectionString = "server=localhost; userid=conn1; password=Test123; databse=mydb";
        }

        public List<Leerling> GetKlassen()
        {
            List<Leerling> AlleKlassen = new List<Leerling>;

            MySqlCommand cmd = new MySqlCommand("Select * from ", Connect);

            Connect.Open();
            MySqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read())
            {
                Leerling Klassen = new Leerling(
                    Reader["first"].ToString(),
                    Reader["family"].ToString(),
                    Reader["number"].ToInt16(),
                    Reader["phone"].ToString(),
                    Reader["clas"].ToString(),
                    Reader["activity"].ToString());
            }
        }

        public void AddLeerling(Leerling item)
        {
        string strVoornaam = "";
        string strAchternaam = "";
        string strGSM = "";
        string strKlas = "";
        int intKlasnummer;

        List<Leerling> LeerlingToevoegen = new List<Leerling>();

        MySqlCommand Toevoegen = new MySqlCommand("INSERT INTO `mydb`.`leerling` (`idLeerling`, `LeerlingNaam`, `LeerlingAchternaam`, `Klas`) VALUES ('1', '" + strVoornaam + "', '" + strAchternaam + "', '" + strKlas + "');");
        Connect.Open();
        }
    }
}
