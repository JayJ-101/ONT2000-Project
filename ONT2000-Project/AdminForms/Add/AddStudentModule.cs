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
    public partial class AddStudentModule : Form
    {
        public AddStudentModule()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        StudentModule studentModule = new StudentModule();

        private void button2_Click(object sender, EventArgs e)
        {
            studentModule.ModuleID = int.Parse(cmbLecturerModule.SelectedValue.ToString());
            studentModule.UserID = int.Parse(cmbStudent.SelectedValue.ToString());
            studentModule.StudModStatus = cmbxStudModStatus.SelectedItem.ToString();
            studentModule.Date = dtpStudMod.Text;
            int affected = bll.AddStudentModule(studentModule);

            if (affected > 0)
            {
                MessageBox.Show(affected + " Student Module Added");
            }
            else
            {
                MessageBox.Show("0 Student Module Added");
            }
        }

        private void AddStudentModule_Load(object sender, EventArgs e)
        {

            cmbStudent.DataSource = bll.GetAllStudentUsers();
            cmbStudent.ValueMember = "UserID";
            cmbStudent.DisplayMember = "Full Name";
            cmbStudent.SelectedItem = null; 

            cmbLecturerModule.DataSource = bll.GetAllModules();
            cmbLecturerModule.ValueMember = "ModuleID";
            cmbLecturerModule.DisplayMember = "ModuleName";
            cmbLecturerModule.SelectedItem = null;

            

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard administrator = new AdministratorDashboard();
            administrator.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbLecturerModule.Text = "";
            cmbStudent.Text = "";
        }
    }
}
