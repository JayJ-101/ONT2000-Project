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
    public partial class ViewModules : Form
    {
        public ViewModules()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();

        private void ViewModules_Load(object sender, EventArgs e)
        {
            dgvViewModules.DataSource = bll.GetAllModules();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvViewModules.DataSource = bll.GetAllModules();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvViewModules.DataSource = bll.GetModuleBySearchingTerm(txtSearch.Text);
        }
    }
}
