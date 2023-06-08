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
    public partial class ManageAssessments : Form
    {
        public ManageAssessments()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        Assessment assessment = new Assessment();

        int userID = LoginInformation.UserID;
        string date = "";
        string dueDate;
        int lecturerModuleID;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                assessment.AssessmentID = int.Parse(lblAssessmentID.Text);
                assessment.StudLecturerModuleID = lecturerModuleID;
                assessment.AssessmentDescription = txtAssessmentDescription.Text;

               if (date == "")
                
                    assessment.DueDate = dueDate;
                
                else
                    assessment.DueDate = dteDueDate.Value.ToString();

                assessment.AssessmentTypeID = int.Parse(cmbAssessmentType.SelectedValue.ToString());

                if (bll.UpdateAssessment(assessment) < 0)
                {
                    dgvManageAssessments.DataSource = bll.GetLecturerAssessments(userID);
                    MessageBox.Show("Successufully updated assessment:{0}", txtAssessmentDescription.Text);
                    txtAssessmentDescription.Clear();
                    dteDueDate.Value = DateTime.Now;
                    cmbAssessmentType.Text = "";
                    date = "";
                }
            }
            catch
            {
                MessageBox.Show("Choose an assessment to update");
            }
        }

        private void ManageAssessments_Load(object sender, EventArgs e)
        {
            cmbAssessmentType.DataSource = bll.GetAllAssessmentType();
            cmbAssessmentType.DisplayMember = "AssessmentTypeDescription";
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbAssessmentType.Text = "";

            dgvManageAssessments.DataSource = bll.GetLecturerAssessments(userID);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dteDueDate.Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard lecturerDB = new LecturerDashboard();
            lecturerDB.Show();
            this.Hide();
        }

        private void dgvManageAssessments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dueDate = dgvManageAssessments.SelectedRows[0].Cells[0].Value.ToString();
            lecturerModuleID = int.Parse(dgvManageAssessments.SelectedRows[0].Cells[1].Value.ToString());
            lblAssessmentID.Text = dgvManageAssessments.SelectedRows[0].Cells[2].Value.ToString();
            lblModule.Text = dgvManageAssessments.SelectedRows[0].Cells[3].Value.ToString();
            txtAssessmentDescription.Text = dgvManageAssessments.SelectedRows[0].Cells[4].Value.ToString();
            cmbAssessmentType.SelectedItem = dgvManageAssessments.SelectedRows[0].Cells[5].Value.ToString();
           lblAssessmentStatus.Text = dgvManageAssessments.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
