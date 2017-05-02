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
    public partial class EmployeeCreate : Form
    {
        public EmployeeCreate()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //create new connection
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            
            //builds date string
            string DOB = this.DOB.SelectionStart.Year + "/" + this.DOB.SelectionStart.Month + "/" + this.DOB.SelectionStart.Day;

            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    bool ID_available = false; //set employee with id to one
                    string employeeID = "";
                    //check id patient id is available
                    while (!ID_available) //will break if not patients in db have id
                    {
                        employeeID = Dujeet_DB.generateID(4); //generate a new 8 length hexadecimal id
                        Console.WriteLine("Created employeeID: " + employeeID);
                        //Check to see if patient_ID is avaliable
                        MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM EMPLOYEE WHERE employee_ID ='" + employeeID + "';", Dujeet_DB.connection);

                        if (Convert.ToInt32(cmd1.ExecuteScalar()) == 0)
                        {
                            ID_available = true;
                        }
                    }

                    //if id availble go ahead and insert patient into DB
                    string query = "INSERT INTO `EMPLOYEE` (`employee_ID`, `f_name`, `m_name`, `l_name`)" +
                                "VALUES('" + employeeID + "','" + this.firstBox.Text + "','" + this.middleBox.Text + "','" + this.lastBox.Text + "');";
                    //Create Command
                    MySqlCommand cmd2 = new MySqlCommand(query, Dujeet_DB.connection);
                    //Execute the command
                    cmd2.ExecuteNonQuery();


                    if (this.specialty.Text == "Doctor") //insert new doctor table
                    {
                        query = "INSERT INTO `DOCTOR` (`employee_ID`)" +
                                "VALUES('" + employeeID  + "');";
                        //Create Command
                        MySqlCommand cmd3 = new MySqlCommand(query, Dujeet_DB.connection);
                        //Execute the command
                        cmd3.ExecuteNonQuery();
                        if (this.docspeciality.Text != "") //add speciality to doctor
                        {
                            query = "INSERT INTO `SPECIALIZES` (`doctor_id`, `specialization`)" +
                                "VALUES('" + employeeID + "','" + this.docspeciality.Text + "');";
                            //Create Command
                            MySqlCommand cmd4 = new MySqlCommand(query, Dujeet_DB.connection);
                            //Execute the command
                            cmd4.ExecuteNonQuery();
                        }
                    }
                    if (this.specialty.Text == "Nurse") //insert new doctor table
                    {
                        query = "INSERT INTO `NURSE` (`nurse_ID`)" +
                                "VALUES('" + employeeID + "');";
                        //Create Command
                        MySqlCommand cmd5 = new MySqlCommand(query, Dujeet_DB.connection);
                        //Execute the command
                        cmd5.ExecuteNonQuery();
                    }
                    if (this.specialty.Text == "Lab tech") //insert new doctor table
                    {
                        query = "INSERT INTO `LAB_TECH` (`labtech_ID`)" +
                                "VALUES('" + employeeID + "');";
                        //Create Command
                        MySqlCommand cmd6 = new MySqlCommand(query, Dujeet_DB.connection);
                        //Execute the command
                        cmd6.ExecuteNonQuery();
                    }
                    //close Connection
                    Dujeet_DB.CloseConnection();
                }


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
                return false;
            }
            //m_name
            //l_name
            if (this.lastBox.Text == "")
            {
                return false;
            }

            return true;
        }
    }
}
