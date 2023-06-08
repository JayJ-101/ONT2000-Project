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
    public partial class ManageModuleTypes : Form
    {
        public ManageModuleTypes()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        ModuleType moduleType = new ModuleType();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                moduleType.ModuleTypeID = int.Parse(lblModuleTypeID.Text);
                moduleType.ModuleTypeDescription = cmbTypeDesc.SelectedItem.ToString();
                if (bll.UpdateModuleType(moduleType) > 0)
                {
                    MessageBox.Show("Data successfully updated.");
                    dgvManageModuleTypes.DataSource = bll.GetAllModulesTypes();
                }
            }
            catch
            {
                MessageBox.Show("Choose a module to update.");
            }
        }

        private void dgvManageModuleTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add the code for transferring from a grid to controls
            lblModuleTypeID.Text = dgvManageModuleTypes.SelectedRows[0].Cells["ModuleTypeID"].Value.ToString();
            cmbTypeDesc.Text = dgvManageModuleTypes.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblModuleTypeID.Text = "";
            cmbTypeDesc.SelectedItem = null;

        }

        private void ManageModuleTypes_Load(object sender, EventArgs e)
        {
            dgvManageModuleTypes.DataSource = bll.GetAllModulesTypes();
            cmbTypeDesc.DataSource = bll.GetAllModulesTypes();
            cmbTypeDesc.DisplayMember = "ModuleTypeDescription";
            cmbTypeDesc.ValueMember = "ModuleTypeID";
            cmbTypeDesc.SelectedItem = null;
        }
    }
}
