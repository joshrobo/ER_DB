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
    public partial class Diagnose : Form
    {
        public Diagnose()
        {
            InitializeComponent();
            //get patients most recent record
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            DatabaseConnect Dujeet_DB = new DatabaseConnect();

            //Open connection
            if (isValid()) //check if all fields are valid
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    Dujeet_DB.diagnose(this.patientid.Text, this.diagnosis.Text, this.symptoms.Text);
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
            //else
            return true;
        } 
    }
}
