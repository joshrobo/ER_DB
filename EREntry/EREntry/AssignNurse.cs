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
    public partial class AssignNurse : Form
    {
        public AssignNurse()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string output;
            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    //now: just any availble
                    //later: find available nurse with least amount of patients
                    //retrieve nurse id
                    string cmd_string = "SELECT nurse_id FROM NURSE WHERE availble = true";
                    
                    string nurse_available = "";
                    string patientID = patientid.Text;
                    
                    //Check to see if nurse is avaliable
                    MySqlCommand cmd1 = new MySqlCommand(cmd_string, Dujeet_DB.connection);
                    nurse_available = cmd1.ExecuteScalar().ToString();

                    //assign nurse to patient
                    string cmd2_string = "INSERT INTO `HELPS` (`nurse_id`, `patient_id`) VALUES ('"+
                                            nurse_available + "','" + this.patientid.Text + "');";

                    MySqlCommand cmd = new MySqlCommand(cmd2_string, Dujeet_DB.connection);
                    //Execute the command
                    cmd.ExecuteNonQuery();

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
            if (this.patientid.Text == "")
            { 
                return false;
            }

            //else
            return true;
        }
    }
}
