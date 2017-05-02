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
            server = "132.160.49.90";
            //server = "localhost";
            port = "3306";
            database = "Dujeet_DB";
            uid = "root";
            password = "Bahaghari20$";
            //password = "password";
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
                string take_string = "INSERT INTO `TAKES` (`dosage`, `prescibed_by`,`patient_id`, `t_date`, `t_time`) VALUES('" +
                                    dosage + "','" + doctorid + "','" + patientid + "','" + date + "','" + time + "');";
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

                string OutputText = "Dr." + doctor_name + " prescribed " + dosage + "mg of " + med_name + " to patient" + patient_name;
                Console.WriteLine(OutputText);
                Output output = new EREntry.Output();
                output.label1.Text = OutputText;
                output.Show();
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
            //update record
            //create a tranaction
            MySqlTransaction tr = null;
            try
            {
                tr = connection.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                string OutputText = "";
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
                    OutputText = "Updated patient's symptoms.";
                }

                //Create command to update dianosis only in records
                if (diagnosis != "" && symptoms == "")
                {
                    string take_string = "UPDATE `RECORDS` SET `diagnosis` = '" + diagnosis +
                                         "' WHERE patient_id ='" + patientid + "';";
                    cmd.CommandText = take_string;
                    cmd.ExecuteNonQuery();
                    OutputText = "Updated patient's diagnosis.";
                }

                //Create command to update both in records
                if (diagnosis != "" && symptoms != "")
                {
                    string take_string = "UPDATE `RECORDS` SET `symptoms` = '" + symptoms + "',`diagnosis` = '" + diagnosis +
                                         "' WHERE patient_id ='" + patientid + "';";
                    cmd.CommandText = take_string;
                    cmd.ExecuteNonQuery();
                    OutputText = "Updated patient's symptoms and diagnosis.";
                }
                tr.Commit();
                
                Console.WriteLine(OutputText);
                Output output = new EREntry.Output();
                output.label1.Text = OutputText;
                output.Show();
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
        public void view_open_lab_tests()
        {
            string OutputText = "";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT `lab_id`, `test_name`, `patient_id` FROM LAB_TEST WHERE `labtech_id` IS NULL";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) //output open tests
            {
                string s = reader.GetInt32(0) + ": " + reader.GetString(1) + " on " + reader.GetString(2) + "\n";
                Console.WriteLine(s);
                OutputText += s;
            }
            Output output = new EREntry.Output();
            output.label1.Text = OutputText;
        }
        public void check_in(string patientid)
        {
            //update record
            //create a tranaction
            MySqlTransaction tr = null;
            try
            {
                //get current date and time 
                string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                //Console.WriteLine(date);
                string time = String.Format("{0:HH:mm:ss}", DateTime.Now);
                //Console.WriteLine(time);
                tr = connection.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                //check to see if there is a room available
                string room_num_avail = "";
                string room_num_cmd = "SELECT room_num FROM ROOM WHERE (`max_occ`-`occupied`) > 0 LIMIT 1";

                cmd.CommandText = room_num_cmd;
                room_num_avail = cmd.ExecuteScalar().ToString();

                //if so increase room count, assign patient to room and create a new record
                cmd.CommandText = "UPDATE `ROOM` SET `occupied` = `occupied` + 1 WHERE room_num = '" + room_num_avail + "';";
                cmd.ExecuteNonQuery();

                //Update satys in table
                cmd.CommandText = "INSERT INTO `STAYS_IN` (`room_num`, `patient_id`, `c_in_time`, `c_in_date`)"+
                    "VALUES('" + room_num_avail + "','" + patientid + "','" + time + "','" + date +  "');";
                cmd.ExecuteNonQuery();

                //create new record
                cmd.CommandText = "INSERT INTO `RECORDS` (`records_id`, `patient_ID`,  `r_date`, `r_time`)" +
                    "VALUES (NULL, '" + patientid + "','" + date + "','" + time + "');";
                cmd.ExecuteNonQuery();

                //get patient name
                string patient_name_cmd = "Select l_name FROM PATIENT WHERE `patient_id` = '" +
                                        patientid + "';";
                MySqlCommand cmd4 = new MySqlCommand(patient_name_cmd, connection);
                //Execute the command
                string patient_name = cmd4.ExecuteScalar().ToString();

                tr.Commit();
                string OutputText = "Assigned " + patient_name + " to room " + room_num_avail;
                Output output = new EREntry.Output();
                output.label1.Text = OutputText;
                Console.WriteLine(OutputText);
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
        public void check_out(string patientid)
        {
            //update record
            //create a tranaction
            MySqlTransaction tr = null;
            try
            {
                //get current date and time 
                string date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
                //Console.WriteLine(date);
                string time = String.Format("{0:HH:mm:ss}", DateTime.Now);
                //Console.WriteLine(time);
                tr = connection.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                string patient_stays_in = "";
                //find out where patient is staying 
                string room_num_cmd = "SELECT `room_num` FROM STAYS_IN WHERE `patient_id` = '" + patientid + "' ORDER BY `c_in_date` DESC LIMIT 1;";
                cmd.CommandText = room_num_cmd;
                patient_stays_in = cmd.ExecuteScalar().ToString();

                //decrease room count that patient is staying in
                cmd.CommandText = "UPDATE `ROOM` SET `occupied` = (`occupied` - 1) WHERE `room_num` = '" + patient_stays_in + "';";
                cmd.ExecuteNonQuery();

                //update check out time in stays in
                cmd.CommandText = "UPDATE `STAYS_IN` SET `c_out_time` = '" + time + "', `c_out_date` = '" + date +"' WHERE `patient_id` = '" 
                                  + patientid+ "' AND `room_num` = '" + patient_stays_in + "' ORDER BY `c_in_date` DESC LIMIT 1;";
                cmd.ExecuteNonQuery();

                //remove any nurses helping patient
                cmd.CommandText = "DELETE FROM HELPS WHERE `patient_id` = '" + patientid + "';";
                cmd.ExecuteNonQuery();

                //remove any doctors helping patient
                cmd.CommandText = "DELETE FROM HELPS WHERE `patient_id` = '" + patientid + "';";
                cmd.ExecuteNonQuery();

                //get patient name
                string patient_name_cmd = "Select l_name FROM PATIENT WHERE `patient_id` = '" +
                                        patientid + "';";
                MySqlCommand cmd4 = new MySqlCommand(patient_name_cmd, connection);
                //Execute the command
                string patient_name = cmd4.ExecuteScalar().ToString();

                tr.Commit();
                
                string OutputText = "Checked out " + patient_name;
                Output output = new EREntry.Output();
                output.label1.Text = OutputText;
                Console.WriteLine(OutputText);

                // ****************************************
                // sends the output to a form
                Output toForm = new Output();
                toForm.label1.Text = OutputText;
                toForm.Text = "Check Out Patient";
                toForm.Show();
                // ****************************************
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
        public void find(string patientid)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;

            string patient_stays_in = "";
            //find out where patient is staying 
            string room_num_cmd = "SELECT `room_num` FROM STAYS_IN WHERE `patient_id` = '" + patientid + "' ORDER BY `c_in_date` DESC LIMIT 1;";
            cmd.CommandText = room_num_cmd;
            patient_stays_in = cmd.ExecuteScalar().ToString();

            string OutputText = "Patient is in room " + patient_stays_in;
            Output output = new EREntry.Output();
            output.label1.Text = OutputText;
            Console.WriteLine(OutputText);
        }

        public void get_records(string patientid)
        {
            string OutputText = "";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT `l_name`, `f_name`, `symptoms`, `diagnosis`, `r_date`, `r_time` FROM PATIENT P, RECORDS R WHERE P.patient_id = R.patient_id AND P.patient_id = '" + patientid + "';";
            MySqlDataReader reader = cmd.ExecuteReader();
            int col = 0;
            string sym = "";
            string diag = "";
            while (reader.Read()) //output open tests
            {
                if (!reader.IsDBNull(2))
                    diag = reader.GetString(2);
                else
                    diag = "";
                if (!reader.IsDBNull(3))
                    diag = reader.GetString(3);
                else
                    diag = "";

                string s = reader.GetString(0) + reader.GetString(1) + ":\nDiagnosis: " + diag + "\nSymptoms: " + sym +
                                                  "\nDate: " + reader.GetString(4) + "\nTime: " + reader.GetString(5) + "\n";
                Console.WriteLine(s);
                OutputText += s;
                col++;
            }
           
            Output output = new EREntry.Output();
            output.label1.Text = OutputText;
            Console.WriteLine(OutputText);

            // ****************************************
            // sends the output to a form
            Output toForm = new Output();
            toForm.label1.Text = OutputText;
            toForm.Text = "Patient's Record";
            toForm.Show();
            // ****************************************
        }
    }
}
