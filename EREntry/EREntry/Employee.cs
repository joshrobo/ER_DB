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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void addmeds_Click(object sender, EventArgs e)
        {
            AddMeds addmeds = new EREntry.AddMeds();
            addmeds.Show();
        }

        private void assignnurse_Click(object sender, EventArgs e)
        {
            AssignNurse assignnurse = new AssignNurse();
            assignnurse.Show();
        }

        private void assigndoctor_Click(object sender, EventArgs e)
        {
            AssignDoctor assigndoctor = new AssignDoctor();
            assigndoctor.Show();
        }

        private void checkinpatient_Click(object sender, EventArgs e)
        {
            CheckInPatient checkinpatient = new CheckInPatient();
            checkinpatient.Show();
            //assign patient to first available room
        }

        private void checkoutpatient_Click(object sender, EventArgs e)
        {
            CheckOutPatient checkoutpatient = new CheckOutPatient();
            checkoutpatient.Show();
            //de-assign patient from room and from all doctors and nurses associated with them
        }

        private void getrecords_Click(object sender, EventArgs e)
        {
            GetRecords getrecords = new GetRecords();
            getrecords.Show();
            //get records, lab results, vitals, and meds being taken by the patient
        }

        private void findpatient_Click(object sender, EventArgs e)
        {
            FindPatient findpatient = new FindPatient();
            findpatient.Show();
            //query which room the patient is in, who their doctors are, and who their nurses are
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createemployee_Click(object sender, EventArgs e)
        {
            EmployeeCreate employeecreate = new EmployeeCreate();
            employeecreate.Show();
        }
    }
}
