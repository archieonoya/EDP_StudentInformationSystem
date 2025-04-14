namespace StudentInformationSystem
{
    partial class DashboardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitleNavigation = new System.Windows.Forms.Label();
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnManageProfessor = new System.Windows.Forms.Button();
            this.btnManageDepartments = new System.Windows.Forms.Button();
            this.btnManageClassrooms = new System.Windows.Forms.Button();
            this.btnManageSubjects = new System.Windows.Forms.Button();
            this.btnManageSchedules = new System.Windows.Forms.Button();
            this.btnManageEnrollments = new System.Windows.Forms.Button();
            this.btnViewStats = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblSubtitleSummary = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblTotalProfessors = new System.Windows.Forms.Label();
            this.lblTotalDepartments = new System.Windows.Forms.Label();
            this.lblTotalClassrooms = new System.Windows.Forms.Label();
            this.lblTotalSubjects = new System.Windows.Forms.Label();
            this.lblTotalSchedules = new System.Windows.Forms.Label();
            this.lblTotalEnrollments = new System.Windows.Forms.Label();
            this.lblSubtitleRecentLogs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(42, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // lblSubtitleNavigation
            // 
            this.lblSubtitleNavigation.AutoSize = true;
            this.lblSubtitleNavigation.Location = new System.Drawing.Point(44, 103);
            this.lblSubtitleNavigation.Name = "lblSubtitleNavigation";
            this.lblSubtitleNavigation.Size = new System.Drawing.Size(72, 16);
            this.lblSubtitleNavigation.TabIndex = 1;
            this.lblSubtitleNavigation.Text = "Navigation";
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(47, 132);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(150, 40);
            this.btnManageStudents.TabIndex = 2;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            // 
            // btnManageProfessor
            // 
            this.btnManageProfessor.Location = new System.Drawing.Point(203, 132);
            this.btnManageProfessor.Name = "btnManageProfessor";
            this.btnManageProfessor.Size = new System.Drawing.Size(150, 40);
            this.btnManageProfessor.TabIndex = 3;
            this.btnManageProfessor.Text = "Manage Professors";
            this.btnManageProfessor.UseVisualStyleBackColor = true;
            // 
            // btnManageDepartments
            // 
            this.btnManageDepartments.Location = new System.Drawing.Point(359, 132);
            this.btnManageDepartments.Name = "btnManageDepartments";
            this.btnManageDepartments.Size = new System.Drawing.Size(150, 40);
            this.btnManageDepartments.TabIndex = 4;
            this.btnManageDepartments.Text = "Manage Departments";
            this.btnManageDepartments.UseVisualStyleBackColor = true;
            // 
            // btnManageClassrooms
            // 
            this.btnManageClassrooms.Location = new System.Drawing.Point(515, 132);
            this.btnManageClassrooms.Name = "btnManageClassrooms";
            this.btnManageClassrooms.Size = new System.Drawing.Size(150, 40);
            this.btnManageClassrooms.TabIndex = 5;
            this.btnManageClassrooms.Text = "Manage Classrooms";
            this.btnManageClassrooms.UseVisualStyleBackColor = true;
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.Location = new System.Drawing.Point(671, 132);
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(150, 40);
            this.btnManageSubjects.TabIndex = 6;
            this.btnManageSubjects.Text = "Manage Subjects";
            this.btnManageSubjects.UseVisualStyleBackColor = true;
            // 
            // btnManageSchedules
            // 
            this.btnManageSchedules.Location = new System.Drawing.Point(47, 178);
            this.btnManageSchedules.Name = "btnManageSchedules";
            this.btnManageSchedules.Size = new System.Drawing.Size(150, 40);
            this.btnManageSchedules.TabIndex = 7;
            this.btnManageSchedules.Text = "Manage Schedules";
            this.btnManageSchedules.UseVisualStyleBackColor = true;
            // 
            // btnManageEnrollments
            // 
            this.btnManageEnrollments.Location = new System.Drawing.Point(203, 178);
            this.btnManageEnrollments.Name = "btnManageEnrollments";
            this.btnManageEnrollments.Size = new System.Drawing.Size(150, 40);
            this.btnManageEnrollments.TabIndex = 8;
            this.btnManageEnrollments.Text = "Manage Enrollments";
            this.btnManageEnrollments.UseVisualStyleBackColor = true;
            // 
            // btnViewStats
            // 
            this.btnViewStats.Location = new System.Drawing.Point(359, 178);
            this.btnViewStats.Name = "btnViewStats";
            this.btnViewStats.Size = new System.Drawing.Size(150, 40);
            this.btnViewStats.TabIndex = 9;
            this.btnViewStats.Text = "View Enrollment Stats";
            this.btnViewStats.UseVisualStyleBackColor = true;
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Location = new System.Drawing.Point(515, 178);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(150, 40);
            this.btnViewLogs.TabIndex = 10;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(671, 178);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubtitleSummary
            // 
            this.lblSubtitleSummary.AutoSize = true;
            this.lblSubtitleSummary.Location = new System.Drawing.Point(44, 248);
            this.lblSubtitleSummary.Name = "lblSubtitleSummary";
            this.lblSubtitleSummary.Size = new System.Drawing.Size(112, 16);
            this.lblSubtitleSummary.TabIndex = 12;
            this.lblSubtitleSummary.Text = "System Summary";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudents.Location = new System.Drawing.Point(61, 293);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(136, 20);
            this.lblTotalStudents.TabIndex = 13;
            this.lblTotalStudents.Text = "Total Students: 0";
            // 
            // lblTotalProfessors
            // 
            this.lblTotalProfessors.AutoSize = true;
            this.lblTotalProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProfessors.Location = new System.Drawing.Point(61, 323);
            this.lblTotalProfessors.Name = "lblTotalProfessors";
            this.lblTotalProfessors.Size = new System.Drawing.Size(152, 20);
            this.lblTotalProfessors.TabIndex = 14;
            this.lblTotalProfessors.Text = "Total Professors: 0";
            // 
            // lblTotalDepartments
            // 
            this.lblTotalDepartments.AutoSize = true;
            this.lblTotalDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDepartments.Location = new System.Drawing.Point(61, 353);
            this.lblTotalDepartments.Name = "lblTotalDepartments";
            this.lblTotalDepartments.Size = new System.Drawing.Size(167, 20);
            this.lblTotalDepartments.TabIndex = 15;
            this.lblTotalDepartments.Text = "Total Departments: 0";
            // 
            // lblTotalClassrooms
            // 
            this.lblTotalClassrooms.AutoSize = true;
            this.lblTotalClassrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClassrooms.Location = new System.Drawing.Point(61, 384);
            this.lblTotalClassrooms.Name = "lblTotalClassrooms";
            this.lblTotalClassrooms.Size = new System.Drawing.Size(160, 20);
            this.lblTotalClassrooms.TabIndex = 16;
            this.lblTotalClassrooms.Text = "Total Classrooms: 0";
            // 
            // lblTotalSubjects
            // 
            this.lblTotalSubjects.AutoSize = true;
            this.lblTotalSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubjects.Location = new System.Drawing.Point(61, 413);
            this.lblTotalSubjects.Name = "lblTotalSubjects";
            this.lblTotalSubjects.Size = new System.Drawing.Size(135, 20);
            this.lblTotalSubjects.TabIndex = 17;
            this.lblTotalSubjects.Text = "Total Subjects: 0";
            // 
            // lblTotalSchedules
            // 
            this.lblTotalSchedules.AutoSize = true;
            this.lblTotalSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSchedules.Location = new System.Drawing.Point(62, 443);
            this.lblTotalSchedules.Name = "lblTotalSchedules";
            this.lblTotalSchedules.Size = new System.Drawing.Size(148, 20);
            this.lblTotalSchedules.TabIndex = 18;
            this.lblTotalSchedules.Text = "Total Schedules: 0";
            // 
            // lblTotalEnrollments
            // 
            this.lblTotalEnrollments.AutoSize = true;
            this.lblTotalEnrollments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEnrollments.Location = new System.Drawing.Point(62, 473);
            this.lblTotalEnrollments.Name = "lblTotalEnrollments";
            this.lblTotalEnrollments.Size = new System.Drawing.Size(159, 20);
            this.lblTotalEnrollments.TabIndex = 19;
            this.lblTotalEnrollments.Text = "Total Enrollments: 0";
            // 
            // lblSubtitleRecentLogs
            // 
            this.lblSubtitleRecentLogs.AutoSize = true;
            this.lblSubtitleRecentLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitleRecentLogs.Location = new System.Drawing.Point(355, 248);
            this.lblSubtitleRecentLogs.Name = "lblSubtitleRecentLogs";
            this.lblSubtitleRecentLogs.Size = new System.Drawing.Size(104, 20);
            this.lblSubtitleRecentLogs.TabIndex = 20;
            this.lblSubtitleRecentLogs.Text = "Recent Logs";
            this.lblSubtitleRecentLogs.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(359, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(461, 208);
            this.dataGridView1.TabIndex = 21;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSubtitleRecentLogs);
            this.Controls.Add(this.lblTotalEnrollments);
            this.Controls.Add(this.lblTotalSchedules);
            this.Controls.Add(this.lblTotalSubjects);
            this.Controls.Add(this.lblTotalClassrooms);
            this.Controls.Add(this.lblTotalDepartments);
            this.Controls.Add(this.lblTotalProfessors);
            this.Controls.Add(this.lblTotalStudents);
            this.Controls.Add(this.lblSubtitleSummary);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnViewStats);
            this.Controls.Add(this.btnManageEnrollments);
            this.Controls.Add(this.btnManageSchedules);
            this.Controls.Add(this.btnManageSubjects);
            this.Controls.Add(this.btnManageClassrooms);
            this.Controls.Add(this.btnManageDepartments);
            this.Controls.Add(this.btnManageProfessor);
            this.Controls.Add(this.btnManageStudents);
            this.Controls.Add(this.lblSubtitleNavigation);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitleNavigation;
        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnManageProfessor;
        private System.Windows.Forms.Button btnManageDepartments;
        private System.Windows.Forms.Button btnManageClassrooms;
        private System.Windows.Forms.Button btnManageSubjects;
        private System.Windows.Forms.Button btnManageSchedules;
        private System.Windows.Forms.Button btnManageEnrollments;
        private System.Windows.Forms.Button btnViewStats;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSubtitleSummary;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblTotalProfessors;
        private System.Windows.Forms.Label lblTotalDepartments;
        private System.Windows.Forms.Label lblTotalClassrooms;
        private System.Windows.Forms.Label lblTotalSubjects;
        private System.Windows.Forms.Label lblTotalSchedules;
        private System.Windows.Forms.Label lblTotalEnrollments;
        private System.Windows.Forms.Label lblSubtitleRecentLogs;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}