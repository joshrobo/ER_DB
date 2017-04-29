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
            PrescribeMeds prescribemeds = new PrescribeMeds();
            prescribemeds.Show();
        }

        private void ordertest_Click(object sender, EventArgs e)
        {
            OrderTest ordertest = new OrderTest();
            ordertest.Show();
        }

        private void diagnose_Click(object sender, EventArgs e)
        {
            Diagnose diagnose = new Diagnose();
            diagnose.Show(); ;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
