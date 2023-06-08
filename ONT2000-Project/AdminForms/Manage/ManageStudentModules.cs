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
    public partial class ManageStudentModules : Form
    {
        public ManageStudentModules()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        StudentModule studentModule = new StudentModule();

        int userID = 0;
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                studentModule.StudentModuleID = int.Parse(lblStudentModuleID.Text);
                //studentModule.ModuleID = int.Parse(cmbLecturerModule.SelectedValue.ToString());

                if (bll.UpdateStudentModule(studentModule) > 0)
                {
                    MessageBox.Show("Data Successfully updated.");
                    dgvManageStudModules.DataSource = bll.GetAllStudentModules();
                }
                
            }
            catch
            {
                MessageBox.Show("Choose a student and lecturer module to be updated.");
            }
        }

        private void ManageStudentModules_Load(object sender, EventArgs e)
        {
            //cmbLecturerModule.DataSource = bll.GetAllLecturerMOdules();
            //cmbLecturerModule.ValueMember = "LecturerModuleID";
            //cmbLecturerModule.DisplayMember = "LecturerModule";
            //cmbLecturerModule.Text = "";

            dgvManageStudModules.DataSource = bll.GetAllStudentModules();
        }

        private void dgvManageStudModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDate.Text = "";
            lblModule.Text = "";
            //lblModuleDuration.Text = "";
            lblModuleType.Text = "";
            lblStudent.Text = "";
            lblStudentModuleID.Text = "";
            lblStudentModuleStatus.Text = "";
            //lblUserID.Text = "";

            //cmbLecturerModule.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard administratorDashboard = new AdministratorDashboard();
            administratorDashboard.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }

        private void dgvManageStudModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //userID = int.Parse(dgvManageStudModules.SelectedRows[0].Cells[0].Value.ToString());
            //lblUserID.Text = dgvManageStudModules.SelectedRows[0].Cells[1].Value.ToString();
            lblStudentModuleID.Text = dgvManageStudModules.SelectedRows[0].Cells[2].Value.ToString();
            lblStudent.Text = dgvManageStudModules.SelectedRows[0].Cells[3].Value.ToString();
            lblModule.Text = dgvManageStudModules.SelectedRows[0].Cells[2].Value.ToString();
            //cmbLecturerModule.SelectedItem = dgvManageStudModules.SelectedRows[0].Cells[5].Value.ToString();
            //lblModuleDuration.Text = dgvManageStudModules.SelectedRows[0].Cells[6].Value.ToString();
            lblModuleType.Text = dgvManageStudModules.SelectedRows[0].Cells[1].Value.ToString();
            lblDate.Text = dgvManageStudModules.SelectedRows[0].Cells[4].Value.ToString();
            lblStudentModuleStatus.Text = dgvManageStudModules.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
