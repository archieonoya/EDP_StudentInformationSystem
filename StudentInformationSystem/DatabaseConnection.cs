using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public static class DatabaseConnection
    {
        private static string connectionString = "Server=127.0.0.1;Port=3306;Database=studentinfosys;Uid=root;Pwd=archie;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to connect to the database: " + ex.Message);
            }
        }
    }
}
