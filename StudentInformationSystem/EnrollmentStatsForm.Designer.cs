namespace StudentInformationSystem
{
    partial class EnrollmentStatsForm
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
            this.dgvStats = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnManageProfessor = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.btnManageDepartments = new System.Windows.Forms.Button();
            this.btnViewEnrollments = new System.Windows.Forms.Button();
            this.btnManageClassrooms = new System.Windows.Forms.Button();
            this.btnManageSchedules = new System.Windows.Forms.Button();
            this.btnManageSubjects = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnFilterByDepartment = new System.Windows.Forms.Button();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStats
            // 
            this.dgvStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStats.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStats.Location = new System.Drawing.Point(294, 132);
            this.dgvStats.Name = "dgvStats";
            this.dgvStats.RowHeadersWidth = 51;
            this.dgvStats.RowTemplate.Height = 24;
            this.dgvStats.Size = new System.Drawing.Size(971, 553);
            this.dgvStats.TabIndex = 154;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(288, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 33);
            this.lblTitle.TabIndex = 153;
            this.lblTitle.Text = "Enrollment Statistics";
            // 
            // pnlSide
            // 
            this.pnlSide.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Controls.Add(this.btnManageStudents);
            this.pnlSide.Controls.Add(this.btnViewLogs);
            this.pnlSide.Controls.Add(this.btnManageProfessor);
            this.pnlSide.Controls.Add(this.btnViewStats);
            this.pnlSide.Controls.Add(this.btnManageDepartments);
            this.pnlSide.Controls.Add(this.btnViewEnrollments);
            this.pnlSide.Controls.Add(this.btnManageClassrooms);
            this.pnlSide.Controls.Add(this.btnManageSchedules);
            this.pnlSide.Controls.Add(this.btnManageSubjects);
            this.pnlSide.Location = new System.Drawing.Point(1, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(249, 749);
            this.pnlSide.TabIndex = 152;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(22, 60);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(205, 40);
            this.btnDashboard.TabIndex = 22;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(22, 651);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(205, 40);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudents.ForeColor = System.Drawing.Color.White;
            this.btnManageStudents.Location = new System.Drawing.Point(22, 114);
            this.btnManageStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(205, 40);
            this.btnManageStudents.TabIndex = 12;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = false;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLogs.ForeColor = System.Drawing.Color.White;
            this.btnViewLogs.Location = new System.Drawing.Point(22, 525);
            this.btnViewLogs.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(205, 40);
            this.btnViewLogs.TabIndex = 20;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = false;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnManageProfessor
            // 
            this.btnManageProfessor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProfessor.ForeColor = System.Drawing.Color.White;
            this.btnManageProfessor.Location = new System.Drawing.Point(22, 167);
            this.btnManageProfessor.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageProfessor.Name = "btnManageProfessor";
            this.btnManageProfessor.Size = new System.Drawing.Size(205, 40);
            this.btnManageProfessor.TabIndex = 13;
            this.btnManageProfessor.Text = "Manage Professors";
            this.btnManageProfessor.UseVisualStyleBackColor = false;
            this.btnManageProfessor.Click += new System.EventHandler(this.btnManageProfessor_Click);
            // 
            // btnViewStats
            // 
            this.btnViewStats.BackColor = System.Drawing.Color.SkyBlue;
            this.btnViewStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStats.ForeColor = System.Drawing.Color.White;
            this.btnViewStats.Location = new System.Drawing.Point(22, 474);
            this.btnViewStats.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(205, 40);
            this.btnViewStats.TabIndex = 19;
            this.btnViewStats.Text = "View Enrollment Stats";
            this.btnViewStats.UseVisualStyleBackColor = false;
            this.btnViewStats.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // btnManageDepartments
            // 
            this.btnManageDepartments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageDepartments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDepartments.ForeColor = System.Drawing.Color.White;
            this.btnManageDepartments.Location = new System.Drawing.Point(22, 219);
            this.btnManageDepartments.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageDepartments.Name = "btnManageDepartments";
            this.btnManageDepartments.Size = new System.Drawing.Size(205, 40);
            this.btnManageDepartments.TabIndex = 14;
            this.btnManageDepartments.Text = "Manage Departments";
            this.btnManageDepartments.UseVisualStyleBackColor = false;
            this.btnManageDepartments.Click += new System.EventHandler(this.btnManageDepartments_Click);
            // 
            // btnViewEnrollments
            // 
            this.btnViewEnrollments.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewEnrollments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnViewEnrollments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEnrollments.ForeColor = System.Drawing.Color.White;
            this.btnViewEnrollments.Location = new System.Drawing.Point(22, 422);
            this.btnViewEnrollments.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewEnrollments.Name = "btnViewEnrollments";
            this.btnViewEnrollments.Size = new System.Drawing.Size(205, 40);
            this.btnViewEnrollments.TabIndex = 18;
            this.btnViewEnrollments.Text = "View Enrollments";
            this.btnViewEnrollments.UseVisualStyleBackColor = false;
            this.btnViewEnrollments.Click += new System.EventHandler(this.btnViewEnrollments_Click);
            // 
            // btnManageClassrooms
            // 
            this.btnManageClassrooms.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageClassrooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageClassrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClassrooms.ForeColor = System.Drawing.Color.White;
            this.btnManageClassrooms.Location = new System.Drawing.Point(22, 272);
            this.btnManageClassrooms.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageClassrooms.Name = "btnManageClassrooms";
            this.btnManageClassrooms.Size = new System.Drawing.Size(205, 40);
            this.btnManageClassrooms.TabIndex = 15;
            this.btnManageClassrooms.Text = "Manage Classrooms";
            this.btnManageClassrooms.UseVisualStyleBackColor = false;
            this.btnManageClassrooms.Click += new System.EventHandler(this.btnManageClassrooms_Click);
            // 
            // btnManageSchedules
            // 
            this.btnManageSchedules.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSchedules.ForeColor = System.Drawing.Color.White;
            this.btnManageSchedules.Location = new System.Drawing.Point(22, 372);
            this.btnManageSchedules.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageSchedules.Name = "btnManageSchedules";
            this.btnManageSchedules.Size = new System.Drawing.Size(205, 40);
            this.btnManageSchedules.TabIndex = 17;
            this.btnManageSchedules.Text = "Manage Schedules";
            this.btnManageSchedules.UseVisualStyleBackColor = false;
            this.btnManageSchedules.Click += new System.EventHandler(this.btnManageSchedules_Click);
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.BackColor = System.Drawing.Color.SteelBlue;
            this.btnManageSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnManageSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSubjects.ForeColor = System.Drawing.Color.White;
            this.btnManageSubjects.Location = new System.Drawing.Point(22, 321);
            this.btnManageSubjects.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(205, 40);
            this.btnManageSubjects.TabIndex = 16;
            this.btnManageSubjects.Text = "Manage Subjects";
            this.btnManageSubjects.UseVisualStyleBackColor = false;
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(294, 92);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(200, 24);
            this.cmbDepartment.TabIndex = 155;
            // 
            // btnFilterByDepartment
            // 
            this.btnFilterByDepartment.Location = new System.Drawing.Point(510, 92);
            this.btnFilterByDepartment.Name = "btnFilterByDepartment";
            this.btnFilterByDepartment.Size = new System.Drawing.Size(150, 35);
            this.btnFilterByDepartment.TabIndex = 156;
            this.btnFilterByDepartment.Text = "Filter by Department";
            this.btnFilterByDepartment.UseVisualStyleBackColor = true;
            this.btnFilterByDepartment.Click += new System.EventHandler(this.btnFilterByDepartment_Click);
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(680, 95);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(82, 16);
            this.lblLastUpdate.TabIndex = 157;
            this.lblLastUpdate.Text = "Last Update: ";
            // 
            // EnrollmentStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.lblLastUpdate);
            this.Controls.Add(this.btnFilterByDepartment);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.dgvStats);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSide);
            this.Name = "EnrollmentStatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Enrollment Statistics";
            this.Load += new System.EventHandler(this.EnrollmentStatsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStats)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStats;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnManageProfessor;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button btnManageDepartments;
        private System.Windows.Forms.Button btnViewEnrollments;
        private System.Windows.Forms.Button btnManageClassrooms;
        private System.Windows.Forms.Button btnManageSchedules;
        private System.Windows.Forms.Button btnManageSubjects;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnFilterByDepartment;
        private System.Windows.Forms.Label lblLastUpdate;
    }
}