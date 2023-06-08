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
    public partial class ManageSubmissions : Form
    {
        public ManageSubmissions()
        {
            InitializeComponent();
        }

        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        AssessmentSubmission asb = new AssessmentSubmission();

        int userID= LoginInformation.UserID;

        int lecturerModuleID;


        private void ManageSubmissions_Load(object sender, EventArgs e)
        {
            cmbSubmit.Items.Add("Completed");
            cmbSubmit.Items.Add("Missed");
            cmbSubmit.Items.Add("Rescheduled");

            dteReschedule.Visible = false;

            cmbModule.DataSource = bll.GetStudentModules(userID);
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.ValueMember = "LecturerModuleID";
            cmbModule.Text = "";

        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.Focused == true)
            {
                dgvAssessments.DataSource = bll.GetStudentAssessments(userID, int.Parse(cmbModule.SelectedValue.ToString()));
               lecturerModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            }

        }

        private void cmbSubmit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubmit.SelectedItem.ToString() == "Rescheduled")
                dteReschedule.Visible = true;
            else
                dteReschedule.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                asb.AssessmentSubmissionID = int.Parse(lblAssessmentID.Text);

                if (cmbSubmit.SelectedItem.ToString() == "Rescheduled")
                {
                    asb.DateReschedule = dteReschedule.Value.ToString();
                }
                else
                    asb.DateReschedule = "none";

                if (bll.UpdateAssessmentSubmission(asb) < 0)
                {
                    dgvAssessments.DataSource = bll.GetStudentAssessments(userID, lecturerModuleID);

                    MessageBox.Show("Data successfully updated.");
                    dteReschedule.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Choose an assessment to update.");
            }
        }

        private void dgvAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
            lblAssessmentID.Text = dgvAssessments.SelectedRows[0].Cells[0].Value.ToString();
            lblModule.Text = dgvAssessments.SelectedRows[0].Cells[1].Value.ToString();
            lblAssessmentDescription.Text = dgvAssessments.SelectedRows[2].Cells[3].Value.ToString();
            lblDueDate.Text = dgvAssessments.SelectedRows[0].Cells[3].Value.ToString();
            lblDateRescheduled.Text = dgvAssessments.SelectedRows[0].Cells[4].Value.ToString();
            lblAssessmentType.Text = dgvAssessments.SelectedRows[0].Cells[5].Value.ToString();
            lblAssessmentStatus.Text = dgvAssessments.SelectedRows[0].Cells[6].Value.ToString();
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
            lblDateRescheduled.Text = "";
            lblDueDate.Text = "";
            lblModule.Text = "";
            cmbModule.Text = "";
        }
    }
}
