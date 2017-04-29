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
            PerformTest performtest = new PerformTest();
            performtest.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
