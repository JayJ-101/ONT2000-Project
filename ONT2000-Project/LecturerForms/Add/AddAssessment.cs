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
    public partial class AddAssessment : Form
    {
        public AddAssessment()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        Assessment assessment = new Assessment();

        int userID = LoginInformation.UserID;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            assessment.StudLecturerModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            assessment.AssessmentDescription = txtAssessmentDescription.Text;
            assessment.DueDate = dteDueDate.Value.ToString();
            assessment.AssessmentTypeID = int.Parse(cmbAssessmentType.SelectedValue.ToString());

            if (bll.AddAssessment(assessment) < 0)
            {
                MessageBox.Show("Assessment successfully added");
                cmbModule.Text = "";
                txtAssessmentDescription.Clear();
                dteDueDate.Value = DateTime.Now;
                cmbAssessmentType.Text = "";
            }
        }

        private void AddAssessment_Load(object sender, EventArgs e)
        {
            cmbModule.DataSource = bll.GetAllLecturerMOdules(userID);
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.ValueMember = "LecturerModuleID";
            cmbModule.Text = "";

            cmbAssessmentType.DataSource = bll.GetAllAssessmentType();
            cmbAssessmentType.DisplayMember = "AssessmentTypeDesciption";
            cmbAssessmentType.ValueMember = "AssessmentTypeID";
            cmbModule.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LecturerDashboard lecturerDB = new LecturerDashboard();
            lecturerDB.Show();
            this.Hide();
        }

        
    }
}
