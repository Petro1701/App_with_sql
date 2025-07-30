using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
        string connectionString = "server=localhost;user=root;database=it;port=3306;password=root";
        MySqlConnection mysql_connection = new MySqlConnection(connectionString);
        MySqlCommand mysql_command = mysql_connection.CreateCommand();
        mysql_command.CommandText = "Select * from user;";
            mysql_connection.Open();
            MySqlDataReader mysql_result;
            mysql_result = mysql_command.ExecuteReader();

            while (mysql_result.Read())
            {
                Console.WriteLine("{0}",mysql_result.GetString(0));

            }

            mysql_connection.Close();

        }

       
    }
}

