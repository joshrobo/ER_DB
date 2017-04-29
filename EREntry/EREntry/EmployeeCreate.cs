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
    public partial class EmployeeCreate : Form
    {
        public EmployeeCreate()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //run query
            Close();
        }
    }
}
