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
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        private void submitAssessmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitAssessment submitAssessment = new SubmitAssessment();
            submitAssessment.Show();
            this.Hide();
        }

        private void manageAssessmentSubmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSubmissions manageSub = new ManageSubmissions();
            manageSub.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void StudentDashBoard_Load(object sender, EventArgs e)
        {
            lblName.Text = LoginInformation.Name;
            lblSurname.Text = LoginInformation.Surname;
        }
    }
}
