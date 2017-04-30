using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EREntry
{
    public partial class PatientCreate : Form
    {

        public PatientCreate()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string name = "";
            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            string query = "Select f_name FROM PATIENT WHERE patient_ID ='00000000'";

            //Open connection
            if (Dujeet_DB.OpenConnection() == true)
            {
                Console.WriteLine("test2");
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, Dujeet_DB.connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    name = dataReader["f_name"].ToString();
                }

                //close Data Reader
                dataReader.Close();
                Console.WriteLine(name);
                //close Connection
                Dujeet_DB.CloseConnection();
            }

            Close();
        }
    }
}
