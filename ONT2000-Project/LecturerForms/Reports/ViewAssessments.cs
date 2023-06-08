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
    public partial class ViewAssessments : Form
    {
        public ViewAssessments()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();

        private void dgvViewAssessments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewAssessments viewAssessments = new ViewAssessments();
            viewAssessments.Show();
            this.Hide();
        }

        private void ViewAssessments_Load(object sender, EventArgs e)
        {
            cmbModule.DataSource = bll.GetAllLecturerMOdules(LoginInformation.UserID);
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.ValueMember = "LecturerModuleID";
            cmbModule.Text = "";

            dgvViewAssessments.DataSource = bll.GetLecturerAssessments(LoginInformation.UserID);
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.Focus() == true)
            {
                dgvViewAssessments.DataSource = bll.GetLecturerModuleAssessments(LoginInformation.UserID,int.Parse(cmbModule.SelectedValue.ToString()));
            }
        }

        private void dtDueDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtIssueDate.Value != null)
            {
                dgvViewAssessments.DataSource = bll.GetLecturerModuleAssessmentsInDates(LoginInformation.UserID,int.Parse(cmbModule.SelectedValue.ToString()),dtIssueDate.Value.ToString(),dtDueDate.Value.ToString());
            }
            else
                MessageBox.Show("Select an issue and due date");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard lectuererDB = new LecturerDashboard();
            lectuererDB.Show();
            this.Hide();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvViewAssessments.DataSource = bll.GetLecturerModuleAssessments(LoginInformation.UserID, int.Parse(cmbModule.SelectedValue.ToString()));
        }
    }
}
