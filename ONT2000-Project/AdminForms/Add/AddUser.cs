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
using System.Text.RegularExpressions;

namespace ONT2000_Project
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        User user = new User();

        private void AddUser_Load(object sender, EventArgs e)
        {

            cmbTitle.Items.Add("Ms");
            cmbTitle.Items.Add("Mr");
            cmbTitle.Items.Add("Mrs");
            cmbTitle.Items.Add("Doctor");
            cmbTitle.Items.Add("Professor");

            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Administrator");

           
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
           
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Title = cmbTitle.SelectedItem.ToString();
                user.Position = cmbRole.SelectedItem.ToString();
                user.Username = txtEmail.Text;
                user.Password = txtPassword.Text;


                if (cmbRole.SelectedItem.ToString() == "Student")
                {
                   if (bll.AddStudentUser(user) < 0)
                   {
                    MessageBox.Show("Added Successfully:" + "\t" + txtName.Text + " " + txtSurname.Text);
                    txtName.Clear();
                    txtSurname.Clear();
                    cmbTitle.Text = "";
                    cmbRole.Text = "";
                    txtEmail.Clear();
                    txtPassword.Clear();
                   }
                    
                }
           
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Title = cmbTitle.SelectedItem.ToString();
                user.Position= cmbRole.SelectedItem.ToString();
                user.Username = txtEmail.Text;
                user.Password = txtPassword.Text;

                if (cmbRole.SelectedItem.ToString() == "Lecturer")
                {
                    if (bll.AddLecturerUser(user) < 0)
                    {
                        MessageBox.Show("Added Successfully:" + txtName.Text + "\t" + txtSurname.Text);
                        txtName.Clear();
                        txtSurname.Clear();
                        cmbTitle.Text = "";
                        cmbRole.Text = "";
                        txtEmail.Clear();
                        txtPassword.Clear();
                    }
                }
           
                user.Name = txtName.Text;
                user.Surname = txtSurname.Text;
                user.Title = cmbTitle.SelectedItem.ToString();
                user.Position= cmbRole.SelectedItem.ToString();
                user.Username= txtEmail.Text;
                user.Password = txtPassword.Text;

               
                if (cmbRole.SelectedItem.ToString() == "Administrator")
                {
                    if (bll.AddAdministratorUSer(user) < 0)
                    {
                        MessageBox.Show("Added Successfully:" + txtName.Text + "\t" + txtSurname.Text);
                        txtName.Clear();
                        txtSurname.Clear();
                        cmbTitle.Text = "";
                        cmbRole.Text = "";
                        txtEmail.Clear();
                        txtPassword.Clear();
                    }
                }
          
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cmbRole.Text = "";
            cmbTitle.Text = "";
        }

        private void lblAlreadyUser_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }
    }
}
