using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Barcalona
{
    class PersistenceGebruiker
    {
        private string ConnectionString = "server = localhost; userid=root; database=classicmodels;password=Test123";

        MySqlConnection Connection = new MySqlConnection();
    }

    //public void AddLeerling(Leerling item)
    //{

    //}
}
