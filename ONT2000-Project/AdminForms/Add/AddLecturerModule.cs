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
    public partial class AddLecturerModule : Form
    {
        public AddLecturerModule()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        LecturerModule lecturer = new LecturerModule();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lecturer.UserID = int.Parse(cmbLecturer.SelectedValue.ToString());
            lecturer.ModuleID = int.Parse(cmbModule.SelectedValue.ToString());
            lecturer.Date = dtpLecMod.Text;
            lecturer.ModLecturerStatus = cmbLecStatus.SelectedItem.ToString();
            
            int affected = bll.AddLecturerModule(lecturer);
            if (affected > 0)
            {
                MessageBox.Show(affected + " Lecturer Module Added");
            }
            else
            {
                MessageBox.Show("0 Lecturer Module Added");
            }

        }

        private void AddLecturerModule_Load(object sender, EventArgs e)
        {
            cmbLecturer.DataSource = bll.GetAllLecturerUsers();
            cmbLecturer.DisplayMember = "Full Name";
            cmbLecturer.ValueMember = "UserID";
            cmbLecturer.Text = "";

            cmbModule.DataSource = bll.GetAllModules();
            cmbModule.DisplayMember = "ModuleName";
            cmbModule.ValueMember = "ModuleID";
            cmbModule.Text = "";

            cmbLecStatus.SelectedItem = null;
            cmbLecturer.SelectedItem = null;
            cmbModule.SelectedItem = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard administrator = new AdministratorDashboard();
            administrator.Show();
            this.Hide();
        }
    }
}
