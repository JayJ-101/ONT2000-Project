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
    public partial class ViewAssessmentSubmissions : Form
    {
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
                
        int assessmentID;
        public ViewAssessmentSubmissions(int assessmentID)
        {
            InitializeComponent();
            this.assessmentID = assessmentID;
        }
               
        private void ViewAssessmentSubmissions_Load(object sender, EventArgs e)
        {
            cmbSubmissionStatus.Items.Add("Completed");
            cmbSubmissionStatus.Items.Add("Missed");
            cmbSubmissionStatus.Items.Add("Rescheduled");

            dataGridView1.DataSource = bll.GetAssessmentSubmissions(assessmentID);
        }

        private void cmbSubmissionStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubmissionStatus.Focus() == true)
            {
                dataGridView1.DataSource = bll.GetAssessmentSubmissionByType(assessmentID,cmbSubmissionStatus.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetAssessmentSubmissions(assessmentID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewAssessments viewAssessments = new ViewAssessments();
            viewAssessments.Show();
            this.Hide();
        }
    }
}
