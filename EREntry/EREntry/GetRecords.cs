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
  
        public GetRecords()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            ///create new connection
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            //Open connection
            if (isValid())
            {
                if (Dujeet_DB.OpenConnection() == true)
                {
                    Dujeet_DB.get_records(this.patientid.Text);

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
