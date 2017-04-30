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
            //check id patient id is available


            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            //sets gender input
            string gender = "O";
            if (this.comboBox2.Text == "Male") gender = "M";
            if (this.comboBox2.Text == "Female") gender = "F";
            if (this.comboBox2.Text == "Both") gender = "B";
            if (this.comboBox2.Text == "Neither") gender = "N";
            if (this.comboBox2.Text == "Helicopter") gender = "H";
            if (this.comboBox2.Text == "Other") gender = "O";

            //builds date string
            string DOB = this.DOB.SelectionStart.Year + "/" + this.DOB.SelectionStart.Month + "/" + this.DOB.SelectionStart.Day;

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    bool ID_available = false; //set patients with id to one
                    string patientID = "";
                    while (!ID_available) //will break if not patients in db have id
                    {
                        patientID = Dujeet_DB.generateID(8); //generate a new 8 length hexadecimal id
                        Console.WriteLine("Created patientID: " + patientID);
                        //Check to see if patient_ID is avaliable
                        MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM PATIENT WHERE patient_ID ='" + patientID + "';", Dujeet_DB.connection);
                     
                        if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0)
                        {
                            ID_available = true;
                        }
                    }

                    //if id availble go ahead and insert patient into DB
                    string query = "INSERT INTO `PATIENT` (`patient_ID`, `DOB`, `email`, `phone`, `street`, `city`, `state`, `zip_code`," +
                               "`gender`, `allergies`, `policy_num`, `group_num`, `f_name`, `m_name`, `l_name`)" +
                                "VALUES('" + patientID + "','" + DOB + "','" + this.emailBox.Text + "','" +
                                this.phoneBox.Text + "','" + this.streetBox.Text + "','" + this.cityBox.Text + "','" + this.comboBox1.Text + "','" +
                                this.zipBox.Text + "','" + gender + "','" + this.allergyBox.Text + "','" + this.policyBox.Text + "','" +
                                this.groupBox.Text + "','" + this.firstBox.Text + "','" + this.middleBox.Text + "','" + this.lastBox.Text + "');";
                    //Create Command
                    MySqlCommand cmd2 = new MySqlCommand(query, Dujeet_DB.connection);
                    //Execute the command
                    cmd2.ExecuteNonQuery();
                    label16.Text = "Created new patient, ID = " + patientID;
                    //close Connection
                    Dujeet_DB.CloseConnection();
                }

                //Close(); //manual closes form
            }
        }
        // fucntion to validate input
        private bool isValid()
        {
            //check if all input is valid, if not output
            //must create regular expressions for certain ones
            //right now just checking if required fields are blank
            //application handles max length in box properties
            //f_name
            if (this.firstBox.Text == "")
            {
                label16.Text = "* Please input your first name";
                return false;
            }
            //m_name
            //l_name
            if (this.lastBox.Text == "")
            {
                label16.Text = "* Please input your last name";
                return false;
            }
            //street
            if (this.streetBox.Text == "")
            {
                label16.Text = "* Please input your street";
                return false;
            }
            //city
            if (this.cityBox.Text == "")
            {
                label16.Text = "* Please input your city";
                return false;
            }
            //state
            if (this.firstBox.Text == "")
            {
                label16.Text = "* Please input your state";
                return false;
            }
            //zip
            if (this.firstBox.Text == "")
            {
                label16.Text = "* Please input your zipcode";
                return false;
            }
            //phone
            if (this.firstBox.Text == "")
            {
                label16.Text = "* Please input phone number \neg. 8085551234";
                return false;
            }
            //email
            //group_num
            //policy_num
            //allergies
            return true;
        }
    }
}
