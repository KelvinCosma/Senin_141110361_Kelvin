using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Latihan_pos
{
    class Database
    {
        private static string connectionstring = "Server=localhost;Port=3306;User Id=root;Database=pos;Password=sphere";
        public static MySqlConnection conn = new MySqlConnection(connectionstring);

        public static void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        public static void closeConnection()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }
}
