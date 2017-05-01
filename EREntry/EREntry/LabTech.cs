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
    public partial class LabTech : Form
    {
        public LabTech()
        {
            InitializeComponent();
        }

        private void performtest_Click(object sender, EventArgs e)
        {
            if (check_lab_tech_id())
            {
                PerformTest performtest = new PerformTest();
                performtest.techid.Text = this.idBox.Text;
                performtest.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool check_lab_tech_id()
        {
            //if employee not a labtech
            if (idBox.Text == "")
            {
                IDlabel.ForeColor = Color.Crimson;
                return false;
            }
            //return false
            //else
            return true;
        }

        private void viewtest_Click(object sender, EventArgs e)
        {
            //create new connection
            DatabaseConnect Dujeet_DB = new DatabaseConnect();
            //ouput all open tests to console
            if (Dujeet_DB.OpenConnection() == true)
            {
                Dujeet_DB.view_open_lab_tests();
            }
            //Close();
        }
    }
}
