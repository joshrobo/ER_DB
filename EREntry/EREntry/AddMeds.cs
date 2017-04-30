using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EREntry
{
    public partial class AddMeds : Form
    {
        public AddMeds()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //create new connection
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    bool ID_available = false; //set patients with id to one
                    string medID = "";
                    while (!ID_available) //will break if not patients in db have id
                    {
                        medID = Dujeet_DB.generateID(8); //generate a new 8 length hexadecimal id
                        Console.WriteLine("Created medID: " + medID);
                        //Check to see if med_ID is avaliable
                        MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM MEDICATION WHERE med_ID ='" + medID + "';", Dujeet_DB.connection);

                        if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0)
                        {
                            ID_available = true;
                        }
                    }

                    //if id availble go ahead and insert patient into DB
                    string query = "INSERT INTO `MEDICATION` (`med_id`, `exp_date`, `name`)" +
                                "VALUES('" + medID + "','" + this.expdate.Text + "','" + this.name.Text + "');";
                    //Create Command
                    MySqlCommand cmd2 = new MySqlCommand(query, Dujeet_DB.connection);
                    //Execute the command
                    cmd2.ExecuteNonQuery();
                    //close Connection
                    Dujeet_DB.CloseConnection();
                }
                Close();
            }
        }
        // fucntion to validate input
        private bool isValid()
        {
            //check if all input is valid, if not output error
            //must create regular expressions for certain ones
            //right now just checking if required fields are blank
            //application handles max length in box properties
            //input
            if (this.name.Text == "")
            {
                return false;
            }
            if (this.expdate.Text == "")
            {
                return false;
            }
            //else
            return true;
        }
    }
}
