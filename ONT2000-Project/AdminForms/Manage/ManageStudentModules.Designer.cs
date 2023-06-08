namespace ONT2000_Project
{
    partial class ManageStudentModules
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvManageStudModules = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblStudentModuleID = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.lblModuleType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStudentModuleStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudModules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(387, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvManageStudModules
            // 
            this.dgvManageStudModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageStudModules.Location = new System.Drawing.Point(12, 115);
            this.dgvManageStudModules.MultiSelect = false;
            this.dgvManageStudModules.Name = "dgvManageStudModules";
            this.dgvManageStudModules.ReadOnly = true;
            this.dgvManageStudModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageStudModules.Size = new System.Drawing.Size(603, 289);
            this.dgvManageStudModules.TabIndex = 6;
            this.dgvManageStudModules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageStudModules_CellClick);
            this.dgvManageStudModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageStudModules_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Student Module ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Module:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Module Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Student Module Status:";
            // 
            // lblStudentModuleID
            // 
            this.lblStudentModuleID.AutoSize = true;
            this.lblStudentModuleID.Location = new System.Drawing.Point(187, 17);
            this.lblStudentModuleID.Name = "lblStudentModuleID";
            this.lblStudentModuleID.Size = new System.Drawing.Size(70, 13);
            this.lblStudentModuleID.TabIndex = 18;
            this.lblStudentModuleID.Text = "---------------------";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(479, 17);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(70, 13);
            this.lblStudent.TabIndex = 19;
            this.lblStudent.Text = "---------------------";
            this.lblStudent.Click += new System.EventHandler(this.lblStudent_Click);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(189, 79);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(70, 13);
            this.lblModule.TabIndex = 20;
            this.lblModule.Text = "---------------------";
            // 
            // lblModuleType
            // 
            this.lblModuleType.AutoSize = true;
            this.lblModuleType.Location = new System.Drawing.Point(187, 45);
            this.lblModuleType.Name = "lblModuleType";
            this.lblModuleType.Size = new System.Drawing.Size(70, 13);
            this.lblModuleType.TabIndex = 23;
            this.lblModuleType.Text = "---------------------";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(225, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(306, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(479, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 13);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "---------------------";
            // 
            // lblStudentModuleStatus
            // 
            this.lblStudentModuleStatus.AutoSize = true;
            this.lblStudentModuleStatus.Location = new System.Drawing.Point(479, 79);
            this.lblStudentModuleStatus.Name = "lblStudentModuleStatus";
            this.lblStudentModuleStatus.Size = new System.Drawing.Size(70, 13);
            this.lblStudentModuleStatus.TabIndex = 27;
            this.lblStudentModuleStatus.Text = "---------------------";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(144, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageStudentModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStudentModuleStatus);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblModuleType);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblStudentModuleID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvManageStudModules);
            this.Controls.Add(this.btnDelete);
            this.Name = "ManageStudentModules";
            this.Text = "ManageStudentModules";
            this.Load += new System.EventHandler(this.ManageStudentModules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageStudModules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvManageStudModules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStudentModuleID;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label lblModuleType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStudentModuleStatus;
        private System.Windows.Forms.Button btnBack;
    }
}