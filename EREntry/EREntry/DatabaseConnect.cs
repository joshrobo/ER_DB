using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EREntry
{
    class DatabaseConnect
    {
        public MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DatabaseConnect()
        {
            Initialize();
        }

        //Initialize database creds
        private void Initialize()
        {
            //server = "132.160.49.90";
            server = "localhost";
            port = "3306";
            database = "Dujeet_DB";
            uid = "root";
            //password = "Bahaghari20$";
            password = "password";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Port=" + port + ";" + "Database=" +
            database + ";" + "Uid=" + uid + ";" + "Password=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                //Console.WriteLine("testing connection");
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                switch (ex.Number)
                {
                    default:
                        Console.WriteLine("Error: " + ex.Number);
                        break;
                    case 0:
                        //0: Cannot connect to server.
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //1045: Invalid user name and/or password.
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        static Random random = new Random();
        public string generateID( int digits)
        {
            byte[] buffer = new byte[digits / 2];
            random.NextBytes(buffer);
            string result = String.Concat(buffer.Select(x => x.ToString("X2")).ToArray());
            if (digits % 2 == 0)
                return result;
            return result + random.Next(16).ToString("X");
        }

        //this function returns a patients most recent record, which would be the the highest value record id of patient
        public int GetPatientRecordNum(string patient_id)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT MAX(record_id) FROM RECORDS WHERE patient_ID ='" + patient_id + "';", connection);

            return (Convert.ToInt32(cmd1.ExecuteScalar()));
        }

        //this function returns a patients most recent med take id, which would be the the highest value record id of patient
        public int GetPatientTakeId(string patient_id)
        {
            MySqlCommand cmd1 = new MySqlCommand("SELECT MAX(take_id) FROM TAKES WHERE patient_ID ='" + patient_id + "';", connection);

            return (Convert.ToInt32(cmd1.ExecuteScalar()));
        }

        public void prescribe_Meds(string medid, string patientid, string doctorid, string dosage)
        {
            //grab current date and time
            //string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            //Console.WriteLine(date);
            string time = String.Format("{0:HH:mm:ss}", DateTime.Now);
            //Console.WriteLine(time);

            //prescribe meds on patient from doctor
            //create a tranaction
            MySqlTransaction tr = null;
            try
            {
                tr = connection.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                //Create command to insert into TAKES table
                string take_string = "INSERT INTO `TAKES` (`take_id`, `dosage`, `prescibed_by`,`patient_id`, `t_date`, `t_time`) VALUES('" +
                                    medid + "','" + dosage + "','" + doctorid + "','" + patientid + "','" + date + "','" + time + "');";
                cmd.CommandText = take_string;
                cmd.ExecuteNonQuery();

                //retrive take_id for patient
                cmd.CommandText = "SELECT MAX(take_id) FROM TAKES WHERE patient_ID ='" + patientid + "';";
                int take_id = Convert.ToInt32(cmd.ExecuteScalar());
                //Console.WriteLine(take_id);

                //retrive record_id for patient
                cmd.CommandText = "SELECT MAX(records_id) FROM RECORDS WHERE patient_ID ='" + patientid + "';";
                int records_id = Convert.ToInt32(cmd.ExecuteScalar());
                //Console.WriteLine(records_id);

                //Create command to update MED_STORED table
                string med_stored_string = "INSERT INTO `MEDS_STORED` (`take_id`, `records_id`) VALUES(" + take_id + "," + records_id + ");";
                cmd.CommandText = med_stored_string;
                cmd.ExecuteNonQuery();

                //get doctor name
                //retrive record_id for patient
                cmd.CommandText = "SELECT l_name FROM EMPLOYEE WHERE employee_ID ='" + doctorid + "';";
                string doctor_name = cmd.ExecuteScalar().ToString();

                //get patient name
                cmd.CommandText = "SELECT l_name FROM PATIENT WHERE patient_ID ='" + patientid + "';";
                string patient_name = cmd.ExecuteScalar().ToString();

                //get medication name
                cmd.CommandText = "SELECT name FROM MEDICATION WHERE med_ID ='" + medid + "';";
                string med_name = cmd.ExecuteScalar().ToString();

                Console.WriteLine("Dr." + doctor_name + " precribed " + dosage + "mg of " + med_name + " to " + patient_name);
                tr.Commit();
            } catch (MySqlException ex)
            { try
                {
                    tr.Rollback();
                } catch (MySqlException ex1)
                {
                    Console.WriteLine("Error: {0}", ex1.ToString());
                }
                Console.WriteLine("Error: {0}", ex.ToString());
            } finally
            {
                if (connection != null)
                {
                    CloseConnection();
                }
            }
        }
        public void diagnose(string patientid, string diagnosis, string symptoms)
        {
            //grab current date and time
            //string time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            //Console.WriteLine(date);
            string time = String.Format("{0:HH:mm:ss}", DateTime.Now);
            //Console.WriteLine(time);

            //update record
            //create a tranaction
            MySqlTransaction tr = null;
            try
            {
                tr = connection.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                //retrive record_id for patient
                cmd.CommandText = "SELECT MAX(records_id) FROM RECORDS WHERE patient_ID ='" + patientid + "';";
                int records_id = Convert.ToInt32(cmd.ExecuteScalar());
                //Console.WriteLine(records_id);

                //Create command to update symptoms only in records
                if (diagnosis == "" && symptoms != "") {
                    string take_string = "UPDATE `RECORDS` SET `symptoms` = '" + symptoms + 
                                         "' WHERE patient_id ='" + patientid + "';";
                    cmd.CommandText = take_string;
                    cmd.ExecuteNonQuery();
                }

                //Create command to update dianosis only in records
                if (diagnosis != "" && symptoms == "")
                {
                    string take_string = "UPDATE `RECORDS` SET `diagnosis` = '" + diagnosis +
                                         "' WHERE patient_id ='" + patientid + "';";
                    cmd.CommandText = take_string;
                    cmd.ExecuteNonQuery();
                }

                //Create command to update both in records
                if (diagnosis != "" && symptoms != "")
                {
                    string take_string = "UPDATE `RECORDS` SET `symptoms` = '" + symptoms + "',`diagnosis` = '" + diagnosis +
                                         "' WHERE patient_id ='" + patientid + "';";
                    cmd.CommandText = take_string;
                    cmd.ExecuteNonQuery();
                }
                tr.Commit();
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    Console.WriteLine("Error: {0}", ex1.ToString());
                }
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    CloseConnection();
                }
            }
        }
    }
}
