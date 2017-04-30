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
    public partial class OrderTest : Form
    {
        public OrderTest()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
                    string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                    //order test on patient from doctor
                    string cmd_string = "INSERT INTO `LAB_TEST` (`test_name`, `doctor_id`, `patient_id`, `issue_time`, `issue_date`) VALUES('" +
                                        this.testname.Text + "','" + this.doctorid.Text + "','" + this.patientid.Text + "','" + time + "','" + date + "');";


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
            if (this.testname.Text == "")
            {
                return false;
            }
            //else
            return true;
        }
    }
}
