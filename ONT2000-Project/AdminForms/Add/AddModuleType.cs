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
    public partial class AddModuleType : Form
    {
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        ModuleType moduleType = new ModuleType();

        public AddModuleType()
        {
            InitializeComponent();
        }
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            moduleType.ModuleTypeDescription = txtModuleType.Text;
            int affected = bll.AddModuleType(moduleType);
            if(affected > 0)
            {
                MessageBox.Show(affected + " Module Type Added"); 
            }
            else
            {
                MessageBox.Show("0 Module Type Added");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard administrator = new AdministratorDashboard();
            administrator.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtModuleType.Clear();
        }
    }
}
