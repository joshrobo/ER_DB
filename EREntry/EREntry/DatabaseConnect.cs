using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EREntry
{
    class DatabaseConnect
    {
        public MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DatabaseConnect()
        {
            Initialize();
        }

        //Initialize database creds
        private void Initialize()
        {
            server = "132.160.49.90";
            port = "3306";
            database = "Dujeet_DB";
            uid = "root";
            password = "Bahaghari20$";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Port=" + port + ";" + "Database=" +
            database + ";" + "Uid=" + uid + ";" + "Password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                //Console.WriteLine("testing connection");
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                switch (ex.Number)
                {
                    default:
                        Console.WriteLine("Error: " + ex.Number);
                        break;
                    case 0:
                        //0: Cannot connect to server.
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //1045: Invalid user name and/or password.
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static Random random = new Random();
        public string generateID( int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }
    }
}
