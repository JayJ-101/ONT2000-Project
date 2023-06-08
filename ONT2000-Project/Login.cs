/*
 * 
 * Matome Sebali - 220312117
 * Tontsi Sixolise - 217967825
 * Thembelani Kuhlana -  219998183
 *   
 * 
 */
  

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();

        private void Login_Load(object sender, EventArgs e)
        {
            cmbUserType.Items.Add("Administrator");
            cmbUserType.Items.Add("Lecturer");
            cmbUserType.Items.Add("Student");
            lblWrongLoginDetails.Visible = false;
        }
      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = bll.GetLoginInformation(txtUsername.Text, txtPassword.Text);
            bool found = false;
            bool choose = false;
            string position = "";

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Username"].ToString() == txtUsername.Text && row["Password"].ToString() == txtPassword.Text)
                {
                    LoginInformation.UserID = int.Parse(row["UserID"].ToString());
                    LoginInformation.Name = row["Name"].ToString();
                    LoginInformation.Surname = row["Surname"].ToString();
                    LoginInformation.Position = row["Position"].ToString();
                    LoginInformation.Username = row["Username"].ToString();
                    LoginInformation.Password = row["Password"].ToString();
                    found = true;
                    position = row["position"].ToString();

                }
                if (found == true)
                {
                    if (position == "Lecturer" && cmbUserType.SelectedItem.ToString() == "Lecturer")
                    {
                        choose = true;

                        LecturerDashboard lecturerDB = new LecturerDashboard();
                        lecturerDB.Show();
                        this.Hide();
                    }

                    if (position == "Student" && cmbUserType.SelectedItem.ToString() == "Student")
                    {
                        choose = true;

                        StudentDashBoard studentDB = new StudentDashBoard();

                        studentDB.Show();
                        this.Hide();
                    }

                    if (position == "Administrator" && cmbUserType.SelectedItem.ToString() == "Administrator")
                    {
                        choose = true;

                        AdministratorDashboard adminDB = new AdministratorDashboard();
                        adminDB.Show();
                        this.Hide();
                    }
                }
                if (found == false || choose == false)
                {
                    lblWrongLoginDetails.Visible = true;
                    lblWrongLoginDetails.Text = "Invalid details provided. \nPlease select again";
                    cmbUserType.Text = "";
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //AddUser addUser = new AddUser();
            //addUser.Show();
            //this.Hide();
            Application.Exit();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbUserType.Text = "";
        }
    }
}
