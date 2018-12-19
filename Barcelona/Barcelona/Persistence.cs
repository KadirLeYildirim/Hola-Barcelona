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

    }
}
