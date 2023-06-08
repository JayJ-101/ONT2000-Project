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
    public partial class ManagerLecturerModules : Form
    {
        public ManagerLecturerModules()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        LecturerModule lecturerModule = new LecturerModule();

        private void ManagerLecturerModules_Load(object sender, EventArgs e)
        {
            cmbLecturer.DataSource = bll.GetAllLecturerUsers();
            cmbLecturer.DisplayMember = "Full Name";
            cmbLecturer.ValueMember = "UserID";
            cmbLecturer.Text = "";

            cmbModuleName.DataSource = bll.GetAllModules();
            cmbModuleName.DisplayMember = "ModuleName";
            cmbModuleName.ValueMember = "ModuleID";
            cmbModuleName.Text = "";
            dataGridView1.DataSource = bll.GetAllLecturerMOdules();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lecturerModule.LecturerModuleID = int.Parse(lblLecturerModuleID.Text);
                lecturerModule.UserID = int.Parse(cmbLecturer.SelectedValue.ToString());
                lecturerModule.ModuleID = int.Parse(cmbModuleName.SelectedValue.ToString());
               

                if (bll.UpdateLecturerModule(lecturerModule) < 0)
                {
                    MessageBox.Show("Data successfully updated.");
                    dataGridView1.DataSource = bll.GetAllLecturerMOdules();
                }
            }
            catch
            {
                MessageBox.Show("Choose a lecturer and module to update.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                lblLecturerModuleID.Text = dataGridView1.SelectedRows[0].Cells["LecturerModuleID"].Value.ToString();
                cmbLecturer.Text = dataGridView1.SelectedRows[0].Cells["Full Name"].Value.ToString();
                //lblModuleID.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cmbModuleName.Text = dataGridView1.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                lblDuration.Text = dataGridView1.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                //lblModuleType.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                lblDate.Text = dataGridView1.SelectedRows[0].Cells["Date"].Value.ToString();
                lblModuleLecturerStatus.Text = dataGridView1.SelectedRows[0].Cells["ModLecturerStatus"].Value.ToString();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //lblModuleID.Text = "";
            lblDuration.Text = "";
            lblDate.Text = "";
            lblLecturerModuleID.Text = "";
            lblModuleLecturerStatus.Text = "";
            //lblModuleType.Text = "";

            cmbLecturer.Text = "";
            cmbModuleName.Text = "";
        }
    }
}
