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
                    Dujeet_DB.prescribe_Meds(this.medid.Text, this.patientid.Text, this.doctorid.Text, this.dosage.Text);
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
