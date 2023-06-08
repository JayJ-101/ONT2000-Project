using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLogicLayer;

namespace ONT2000_Project
{
    public partial class LecturerDashboard : Form
    {
        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void addAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAssessment addAssessment = new AddAssessment();
            addAssessment.Show();
            this.Hide();
        }

        private void manageAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAssessments manageAssessments = new ManageAssessments();
            manageAssessments.Show();
            this.Hide();
        }

        private void assessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAssessments viewAssessments = new ViewAssessments();
            viewAssessments.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = LoginInformation.Name;
            lblSurname.Text = LoginInformation.Surname;
        }
    }
}
