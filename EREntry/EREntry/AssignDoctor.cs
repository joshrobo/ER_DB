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
    public partial class AssignDoctor : Form
    {
        public AssignDoctor()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            string output;
            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {

                    string doctor_available = "";
                    string patientID = patientid.Text;

                    //now: just any availble
                    //later: find available nurse with least amount of patients
                    //retrieve nurse id
                    string cmd_string = "SELECT employee_id FROM DOCTOR WHERE on_call = 1 AND employee_id NOT IN (SELECT T.doctor_id FROM TREATS AS T WHERE T.patient_ID = '" + patientID + "') LIMIT 1";


                    //Check to see if nurse is avaliable and is helping the less amount of patients
                    MySqlCommand cmd1 = new MySqlCommand(cmd_string, Dujeet_DB.connection);
                    doctor_available = cmd1.ExecuteScalar().ToString();

                    //assign nurse to patient
                    string cmd2_string = "INSERT INTO `TREATS` (`doctor_id`, `patient_id`) VALUES ('" +
                                            doctor_available + "','" + this.patientid.Text + "');";

                    MySqlCommand cmd = new MySqlCommand(cmd2_string, Dujeet_DB.connection);
                    //Execute the command
                    cmd.ExecuteNonQuery();


                    //get nurse name
                    string nurse_name_cmd = "Select l_name FROM EMPLOYEE WHERE `employee_id` = '" +
                                            doctor_available + "';";

                    MySqlCommand cmd3 = new MySqlCommand(nurse_name_cmd, Dujeet_DB.connection);
                    //Execute the command
                    string doctor_name = cmd3.ExecuteScalar().ToString();

                    //get patinet name
                    string patient_name_cmd = "Select l_name FROM PATIENT WHERE `patient_id` = '" +
                                            patientID + "';";

                    MySqlCommand cmd4 = new MySqlCommand(patient_name_cmd, Dujeet_DB.connection);
                    //Execute the command
                    string patient_name = cmd4.ExecuteScalar().ToString();

                    Console.WriteLine("Doctor " + doctor_name + " assigned to help " + patient_name);
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
