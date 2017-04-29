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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void checkvitals_Click(object sender, EventArgs e)
        {
            CheckVitals checkvitals = new EREntry.CheckVitals();
            checkvitals.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
