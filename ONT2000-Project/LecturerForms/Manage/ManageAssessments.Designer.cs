namespace ONT2000_Project
{
    partial class ManageAssessments
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
            this.lblAssessmentID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAssessmentStatus = new System.Windows.Forms.Label();
            this.dteDueDate = new System.Windows.Forms.DateTimePicker();
            this.dgvManageAssessments = new System.Windows.Forms.DataGridView();
            this.cmbAssessmentType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAssessmentDescription = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAssessments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssessmentID
            // 
            this.lblAssessmentID.AutoSize = true;
            this.lblAssessmentID.Location = new System.Drawing.Point(181, 40);
            this.lblAssessmentID.Name = "lblAssessmentID";
            this.lblAssessmentID.Size = new System.Drawing.Size(76, 13);
            this.lblAssessmentID.TabIndex = 0;
            this.lblAssessmentID.Text = "-----------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assessment ID:";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(181, 86);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(76, 13);
            this.lblModule.TabIndex = 2;
            this.lblModule.Text = "-----------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Assessment Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Due Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Assessment Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Assessment Status:";
            // 
            // lblAssessmentStatus
            // 
            this.lblAssessmentStatus.AutoSize = true;
            this.lblAssessmentStatus.Location = new System.Drawing.Point(181, 287);
            this.lblAssessmentStatus.Name = "lblAssessmentStatus";
            this.lblAssessmentStatus.Size = new System.Drawing.Size(76, 13);
            this.lblAssessmentStatus.TabIndex = 8;
            this.lblAssessmentStatus.Text = "-----------------------";
            // 
            // dteDueDate
            // 
            this.dteDueDate.Location = new System.Drawing.Point(184, 164);
            this.dteDueDate.Name = "dteDueDate";
            this.dteDueDate.Size = new System.Drawing.Size(183, 20);
            this.dteDueDate.TabIndex = 9;
            this.dteDueDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvManageAssessments
            // 
            this.dgvManageAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageAssessments.Location = new System.Drawing.Point(410, 40);
            this.dgvManageAssessments.Name = "dgvManageAssessments";
            this.dgvManageAssessments.Size = new System.Drawing.Size(239, 382);
            this.dgvManageAssessments.TabIndex = 10;
            this.dgvManageAssessments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageAssessments_CellClick);
            // 
            // cmbAssessmentType
            // 
            this.cmbAssessmentType.FormattingEnabled = true;
            this.cmbAssessmentType.Location = new System.Drawing.Point(184, 220);
            this.cmbAssessmentType.Name = "cmbAssessmentType";
            this.cmbAssessmentType.Size = new System.Drawing.Size(178, 21);
            this.cmbAssessmentType.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtAssessmentDescription
            // 
            this.txtAssessmentDescription.Location = new System.Drawing.Point(184, 123);
            this.txtAssessmentDescription.Name = "txtAssessmentDescription";
            this.txtAssessmentDescription.Size = new System.Drawing.Size(178, 20);
            this.txtAssessmentDescription.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(223, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(316, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(23, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ManageAssessments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAssessmentDescription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbAssessmentType);
            this.Controls.Add(this.dgvManageAssessments);
            this.Controls.Add(this.dteDueDate);
            this.Controls.Add(this.lblAssessmentStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAssessmentID);
            this.Name = "ManageAssessments";
            this.Text = "ManageAssessments";
            this.Load += new System.EventHandler(this.ManageAssessments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAssessments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssessmentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAssessmentStatus;
        private System.Windows.Forms.DateTimePicker dteDueDate;
        private System.Windows.Forms.DataGridView dgvManageAssessments;
        private System.Windows.Forms.ComboBox cmbAssessmentType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAssessmentDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}