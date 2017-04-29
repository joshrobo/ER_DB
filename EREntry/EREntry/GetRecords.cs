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
    public partial class GetRecords : Form
    {
        string ERConnectionString = "Server=http://132.160.49.90:7012;Database=Dujeet_DB;Uid=root;Pwd=Bahaghari20$;";
        public GetRecords()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            string patient_id = patientid.Text;
            DatabaseConnect ER = new DatabaseConnect();
            MySqlConnection connection = new MySqlConnection(ERConnectionString);
            MySqlCommand cmd;
            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "Select * FROM PATIENT WHERE patient_ID ='00000000'";
                cmd.ExecuteNonQuery();
            
            }
            catch (Exception)
            {
               
                throw;
            }
            connection.Close();
            Close();
        }
    }
}
