using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            private string connectionString = GetConnectionString;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                OpenConnection(myConnection);
                CloseConnection(myConnection);
            }  
        }
        private static void OpenConnection(SqlConnection connection)
        {
            Person Hans = new Person();
            try
            {
                SqlCommand myCommand = new SqlCommand("select * from table", connection);
                connection.Open();
                SqlDataReader myReader = null;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    Console.WriteLine("ServerVersion: {0}", connection.ServerVersion);
                    Console.WriteLine("State: {0}", connection.State);
                    Hans.Name = myReader["Name"].ToString();
                    Console.WriteLine("{0}", Hans.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static string GetConnectionString()
        {
            return "Data Source=(LocalDB)\\v11.0;" + "AttachDbFilename=|DataDirectory|\\Database1.mdf;" + "Integrated Security=True"; //Informationen findes i Settings.settings
        }

        private static void CloseConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
