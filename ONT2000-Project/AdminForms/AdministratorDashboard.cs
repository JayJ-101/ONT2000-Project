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
    public partial class AdministratorDashboard : Form
    {
        public AdministratorDashboard()
        {
            InitializeComponent();
        }

        #region Login
        private void AdministratorDashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = LoginInformation.Name;
            lblSurname.Text = LoginInformation.Surname;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        #endregion

        #region Add
        private void modulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddModule addModule = new AddModule();
            addModule.Show();
        }

        private void modulesTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddModuleType AddModuleType = new AddModuleType();
            AddModuleType.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void studentModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AddStudentModule addStudentModule = new AddStudentModule();
            addStudentModule.Show();
            this.Hide();
        }

        private void lecturerModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLecturerModule addLecturerModule = new AddLecturerModule();
            addLecturerModule.Show();
            this.Hide();
        }

        #endregion

        #region Manage
        private void modulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageModules manageModules = new ManageModules();
            manageModules.Show();
            this.Hide();
        }

        private void modulesTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageModuleTypes manageModuleTypes = new ManageModuleTypes();
            manageModuleTypes.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
            this.Hide();
        }

        private void studentModulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManageStudentModules manageStudentModules = new ManageStudentModules();
            manageStudentModules.Show();
            this.Hide();
        }

        private void lecturerModulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManagerLecturerModules managerLecturerModules = new ManagerLecturerModules();
            managerLecturerModules.Show();
            this.Hide();
        }
        #endregion

        #region Reports

        private void usersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.Show();
            this.Hide();
        }

        private void modulesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ViewModules viewModules = new ViewModules();
            viewModules.Show();
            this.Hide();
        }
        #endregion

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
