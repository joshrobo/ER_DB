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
    public partial class PrescribeMeds : Form
    {
        public PrescribeMeds()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string doctor_id = doctorid.Text;
            string p_dosage = dosage.Text;
            string patient_id = patientid.Text;
            string med_id = medid.Text;
            //run query

            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid()) //check if all fields are valid
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    //grab current date and time
                    string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                    //order test on patient from doctor
                    string cmd_string = "INSERT INTO `TAKES` (`med_id`, `dosage`, `doctor_id`,'patient_id', `taken_date`, `taken_time') VALUES('" +
                                        this.medid.Text + "','" + this.dosage.Text + "','" + this.doctorid.Text + "','" + this.patientid.Text + "','" + time + "','" + date + "');";

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
            if (this.doctorid.Text == "")
            {
                return false;
            }
            if (this.dosage.Text == "")
            {
                return false;
            }
            if (this.medid.Text == "")
            {
                return false;
            }
            //else
            return true;
        }
    }
}
