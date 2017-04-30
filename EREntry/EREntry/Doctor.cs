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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void prescribemeds_Click(object sender, EventArgs e)
        {
            if (check_doctor_id())
            {
                PrescribeMeds prescribemeds = new PrescribeMeds();
                prescribemeds.doctorid.Text = idBox.Text;
                prescribemeds.Show();
            }
        }

        private void ordertest_Click(object sender, EventArgs e)
        {
            if (check_doctor_id())
            {
                OrderTest ordertest = new OrderTest();
                ordertest.doctorid.Text = idBox.Text;
                ordertest.Show();
            }
        }

        private void diagnose_Click(object sender, EventArgs e)
        {
            if (check_doctor_id())
            {
                Diagnose diagnose = new Diagnose();
                diagnose.Show();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool check_doctor_id()
        {
            //if employee not a doctor
            if(idBox.Text == "")
            {
                IDlabel.ForeColor = Color.Crimson;
                return false;
            }
            //return false
            //else
            return true;
        }
    }
}
