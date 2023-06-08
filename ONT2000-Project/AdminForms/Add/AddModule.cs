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
    public partial class AddModule : Form
    {
        public AddModule()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        Module module = new Module();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            module.ModuleName = txtModuleName.Text;
            module.ModuleDuration = cmbDuration.SelectedItem.ToString();
            module.MOduleTypeID = int.Parse(cmbModuleType.SelectedValue.ToString());
            int affected = bll.AddModule(module);

            if (affected > 0)
            {
                MessageBox.Show(affected + " Module Added");
            }
            else
            {
                MessageBox.Show("0 Module Added");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtModuleName.Clear();
            cmbModuleType.Text = "";
            cmbDuration.Text = "";
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard administratorDashboard = new AdministratorDashboard();
            administratorDashboard.Show();
            this.Hide();
        }

        private void AddModule_Load(object sender, EventArgs e)
        {
            cmbModuleType.DataSource = bll.GetAllModulesTypes();
            cmbModuleType.DisplayMember = "ModuleTypeDescription";
            cmbModuleType.ValueMember = "ModuleTypeID";
        }
    }
}
