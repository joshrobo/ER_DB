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
    public partial class CheckVitals : Form
    {
        public CheckVitals()
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
                    //grab current date and time
                    string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;

                    //if id availble go ahead and insert patient into DB
                    string cmd_string = "INSERT INTO VITALS (patient_id, heart_rate, blood_pressure, v_date, v_time) VALUES ('" +
                        this.patientid.Text + "','" + this.heartrate.Text + "','" + this.bloodpressure.Text + "','" + date + "','" + time + "');";
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(cmd_string, Dujeet_DB.connection);
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
            if (this.heartrate.Text == "")
            {
                return false;
            }
            if (this.bloodpressure.Text == "")
            {
                return false;
            }
            //else
            return true;
        }
    }
}
