using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    class DataBase
    {
        private static string connectionString = "server=localhost; port=3306; username=root; password=root;";
        MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        public void openConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                mySqlConnection.Open();
            }
        }
        public void closeConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
            {
                mySqlConnection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }
    }
}
