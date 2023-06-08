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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            cmbPosition.Items.Add("Administrator");
            cmbPosition.Items.Add("Lecturer");
            cmbPosition.Items.Add("Student");

            dgvViewUsers.DataSource = bll.GetAllUSer();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvViewUsers.DataSource = bll.GetAllUSer();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.Focus() == true)
            {
                dgvViewUsers.DataSource = bll.GetUserByPosition(cmbPosition.SelectedItem.ToString());

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvViewUsers.DataSource = bll.GetUserBySearchingTerm(txtSearch.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard AdminDB = new AdministratorDashboard();
            AdminDB.Show();
            this.Hide();
        }

        private void dgvViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
