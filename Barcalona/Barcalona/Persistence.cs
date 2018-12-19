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
        private MySqlConnection conn;

        public Persistence()
        {
            ConnectionString = "server=localhost; userid=conn1; password=Test123; databse=mydb";
            conn = new MySqlConnection(ConnectionString);
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
            conn.Open();
            Toevoegen.ExecuteNonQuery();
            conn.Close();
        }
    }
}
