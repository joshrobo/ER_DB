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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void patient_Click(object sender, EventArgs e)
        {
            PatientCreate patientcreate = new PatientCreate();
            patientcreate.Show();
        }

        private void doctor_Click(object sender, EventArgs e)
        {
            Doctor doctor = new EREntry.Doctor();
            doctor.Show();
        }

        private void nurse_Click(object sender, EventArgs e)
        {
            Nurse nurse = new EREntry.Nurse();
            nurse.Show();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
        }

        private void labtech_Click(object sender, EventArgs e)
        {
            LabTech labtech = new EREntry.LabTech();
            labtech.Show();
        }
    }
}
