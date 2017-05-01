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
    public partial class PerformTest : Form
    {
        public PerformTest()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            //create new connection
            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    //grab current date and time
                    string time = String.Format("{0:HH:mm:ss}", DateTime.Now);
                    string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;

                    //if id availble go ahead and insert patient into DB
                    string cmd_string = "UPDATE LAB_TEST SET results = '" + this.results.Text + "', perform_time = '"+
                                        time + "', perform_date = '" + date + "', labtech_id = '" + this.techid.Text + 
                                        "' WHERE lab_id = '" + this.labid.Text + "';";

                    Console.WriteLine(cmd_string);
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(cmd_string, Dujeet_DB.connection);
                    //Execute the command
                    cmd.ExecuteNonQuery();

                    //close Connection
                    Dujeet_DB.CloseConnection();
                }
            }
            Close();
        }
        // fucntion to validate input
        private bool isValid()
        {
            //check if all input is valid, if not output
            //must create regular expressions for certain ones
            //right now just checking if required fields are blank
            //application handles max length in box properties
            //labid
            if (this.labid.Text == "")
            {
                return false;
            }
            //techid
            if (this.techid.Text == "")
            {
                return false;
            }
            //results
            if (this.results.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
