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
    public partial class ManageModules : Form
    {
        public ManageModules()
        {
            InitializeComponent();
        }
        DataAccessLayer.DataAccessLayer dal = new DataAccessLayer.DataAccessLayer();
        BusinessLogicLayer.BusinessLogicLayer bll = new BusinessLogicLayer.BusinessLogicLayer();
        Module module = new Module();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageModules_Load(object sender, EventArgs e)
        {
            cmbDuration.Items.Add("Semester 1");
            cmbDuration.Items.Add("Semester 2");
            cmbDuration.Items.Add("Year");

            cmbModuleType.DataSource = bll.GetAllModulesTypes();
            cmbModuleType.DisplayMember = "ModuleTypeDescription";
            cmbModuleType.ValueMember = "ModuleTypeID";

            dataGridView1.DataSource = bll.GetAllModules();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                module.ModuleID = int.Parse(lblModuleID.Text);
                module.ModuleName = txtModuleName.Text;
                module.ModuleDuration = cmbDuration.SelectedItem.ToString();
                module.MOduleTypeID = int.Parse(cmbModuleType.SelectedValue.ToString());

                if (bll.UpdateModule(module) < 0)
                {
                    MessageBox.Show("Data Succesfully Updated");
                    dataGridView1.DataSource = bll.GetAllModules();
                }
            }
            catch
            {
                MessageBox.Show("Choose a module to update.");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add the code for transferring from a grid to controls
            if (dataGridView1.Rows.Count > 0)
            {
                lblModuleID.Text = dataGridView1.SelectedRows[0].Cells["ModuleID"].Value.ToString();
                txtModuleName.Text = dataGridView1.SelectedRows[0].Cells["ModuleName"].Value.ToString();
                cmbDuration.Text = dataGridView1.SelectedRows[0].Cells["ModuleDuration"].Value.ToString();
                cmbModuleType.Text = dataGridView1.SelectedRows[0].Cells["ModuleTypeDescription"].Value.ToString();
               // lblModuleStatus.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdministratorDashboard adminDB = new AdministratorDashboard();
            adminDB.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblModuleID.Text = "";
            //lblModuleStatus.Text = "";
            txtModuleName.Clear();
            cmbDuration.Text = "";
            cmbModuleType.Text = "";
        }
    }
}
