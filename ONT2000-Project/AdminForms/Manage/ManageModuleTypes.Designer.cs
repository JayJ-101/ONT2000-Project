namespace ONT2000_Project
{
    partial class ManageModuleTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvManageModuleTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModuleTypeID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbTypeDesc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageModuleTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageModuleTypes
            // 
            this.dgvManageModuleTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageModuleTypes.Location = new System.Drawing.Point(12, 131);
            this.dgvManageModuleTypes.MultiSelect = false;
            this.dgvManageModuleTypes.Name = "dgvManageModuleTypes";
            this.dgvManageModuleTypes.ReadOnly = true;
            this.dgvManageModuleTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageModuleTypes.Size = new System.Drawing.Size(448, 296);
            this.dgvManageModuleTypes.TabIndex = 0;
            this.dgvManageModuleTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageModuleTypes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module Type ID:";
            // 
            // lblModuleTypeID
            // 
            this.lblModuleTypeID.AutoSize = true;
            this.lblModuleTypeID.Location = new System.Drawing.Point(275, 30);
            this.lblModuleTypeID.Name = "lblModuleTypeID";
            this.lblModuleTypeID.Size = new System.Drawing.Size(73, 13);
            this.lblModuleTypeID.TabIndex = 2;
            this.lblModuleTypeID.Text = "----------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Module Type Description";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(69, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbTypeDesc
            // 
            this.cmbTypeDesc.FormattingEnabled = true;
            this.cmbTypeDesc.Location = new System.Drawing.Point(278, 51);
            this.cmbTypeDesc.Name = "cmbTypeDesc";
            this.cmbTypeDesc.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeDesc.TabIndex = 11;
            // 
            // ManageModuleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.cmbTypeDesc);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblModuleTypeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManageModuleTypes);
            this.Name = "ManageModuleTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageModuleTypes";
            this.Load += new System.EventHandler(this.ManageModuleTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageModuleTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageModuleTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblModuleTypeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbTypeDesc;
    }
}