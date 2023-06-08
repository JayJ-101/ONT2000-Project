using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace ONT2000_Project
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        User user = new User();

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            dgvManageUsers.DataSource = bll.GetAllUSer();

            cmbPosition.Items.Add("Student");
            cmbPosition.Items.Add("Lecturer");
            cmbPosition.Items.Add("Administrator");

            cmbTitle.Items.Add("Ms");
            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Doctor");
            cmbTitle.Items.Add("Professor");
                      
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                user.UserID = int.Parse(lblUserID.Text);
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Title = cmbTitle.SelectedItem.ToString();
                user.Position = cmbPosition.SelectedItem.ToString();
                user.Username= txtEmail.Text;
                user.Password = txtPassword.Text;

                if (bll.UpdateUser(user) < 0)
                {
                    MessageBox.Show("Data successfully updated:"+ " " + txtName.Text + " " + txtSurname.Text);
                    dgvManageUsers.DataSource = bll.GetAllUSer();
                }
            }
            catch
            {
                MessageBox.Show("Choose a user to update.");
            }
            
        }

        private void dgvManageUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvManageUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvManageUsers.Rows.Count > 0)
            {
                lblUserID.Text = dgvManageUsers.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvManageUsers.SelectedRows[0].Cells[1].Value.ToString();
                txtSurname.Text = dgvManageUsers.SelectedRows[0].Cells[2].Value.ToString();
                cmbTitle.SelectedItem = dgvManageUsers.SelectedRows[0].Cells[3].Value.ToString();
                cmbPosition.SelectedItem = dgvManageUsers.SelectedRows[0].Cells[4].Value.ToString();
                txtEmail.Text = dgvManageUsers.SelectedRows[0].Cells[5].Value.ToString();
                txtPassword.Text = dgvManageUsers.SelectedRows[0].Cells[6].Value.ToString();
                lblUserStatus.Text = dgvManageUsers.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblUserID.Text = "";
            lblUserStatus.Text = "";
            txtEmail.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtSurname.Clear();
            cmbPosition.Text = "";
            cmbTitle.Text = "";
        }
    }
}
