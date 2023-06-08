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
    public partial class SubmitAssessment : Form
    {
        public SubmitAssessment()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        AssessmentSubmission assessmentSubmission = new AssessmentSubmission();
        DataTable dataTable = new DataTable();

        int userID = LoginInformation.UserID;
        int studentModuleID;



        private void SubmitAssessment_Load(object sender, EventArgs e)
        {
            cmbSubmit.Items.Add("Completed");
            cmbSubmit.Items.Add("Missed");
            cmbSubmit.Items.Add("Changed");

            dteReschedule.Visible = false;

            cmbModule.DataSource = bll.GetStudentModules(userID);
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.ValueMember = "LecturerModuleID";
            cmbModule.Text = "";

        }

        private void cmbSubmit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubmit.SelectedItem.ToString() == "Reschuduled")
                dteReschedule.Visible = true;
            else
                dteReschedule.Visible = false;
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbModule.Focused == true)
            {
                dgvAssessments.DataSource = bll.GetModuleAssessments(int.Parse(cmbModule.SelectedValue.ToString()));
                DataTable dt = new DataTable();
                dt = bll.GetStudentModuleID(userID, int.Parse(cmbModule.SelectedValue.ToString()));
                foreach (DataRow row in dt.Rows)
                {
                    studentModuleID = int.Parse(row["StudentModuleID"].ToString());
                }
            }
                                   
        }

    private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            dataTable = bll.GetStudentModuleID(userID, int.Parse(cmbModule.SelectedValue.ToString()));
            assessmentSubmission.StudentModuleID = int.Parse(lblAssessmentID.Text);

            foreach(DataRow row in dataTable.Rows)
            {
                assessmentSubmission.StudentModuleID = int.Parse(row["StudentModuleID"].ToString());


            }
            if (cmbSubmit.SelectedText == "Rescheduled")
                assessmentSubmission.DateReschedule = dteReschedule.Value.ToString();
            else
                assessmentSubmission.DateReschedule = "None";
            assessmentSubmission.SubmissionStatus = cmbSubmit.SelectedItem.ToString();

            if (bll.AddAssessmentSubmission(assessmentSubmission) < 0)
            {
                MessageBox.Show("Assessment submitted.");
                dteReschedule.Visible = false;
            }
        
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataTable = bll.GetAssessementID(studentModuleID);
            int assessmentID;
            bool found = false;

            foreach(DataRow row in dataTable.Rows)
            {
                assessmentID = int.Parse(row["AssessmentID"].ToString());
               
                if(assessmentID==int.Parse(dgvAssessments.SelectedRows[0].Cells[0].Value.ToString()))
                found = true;

                if (found == true)
                {
                    string message = "The assessment has been submitted. Do you wish to view your submission? ";
                    string title = "Assessments Submission";

                    MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, messageBoxButtons);

                    if (result == DialogResult.Yes)
                    {
                        ManageSubmissions manageSubmissions = new ManageSubmissions();
                        manageSubmissions.Show();
                    }
                    else
                        this.Show();
                }
                else if (found == false)
                {
                    lblAssessmentID.Text = dgvAssessments.SelectedRows[0].Cells[0].Value.ToString();
                    lblModule.Text= dgvAssessments.SelectedRows[0].Cells[1].Value.ToString();
                    lblAssessmentDescription.Text= dgvAssessments.SelectedRows[0].Cells[2].Value.ToString();
                    lblDueDate.Text= dgvAssessments.SelectedRows[0].Cells[3].Value.ToString();
                    lblAssessmentType.Text= dgvAssessments.SelectedRows[0].Cells[4].Value.ToString();
                    lblAssessmentStatus.Text= dgvAssessments.SelectedRows[0].Cells[5].Value.ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentDashBoard studentDB = new StudentDashBoard();
            studentDB.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAssessmentDescription.Text = "";
            lblAssessmentID.Text = "";
            lblAssessmentStatus.Text = "";
            lblAssessmentType.Text = "";
            lblModule.Text = "";
            cmbModule.Text = "";

        }
    }
}
