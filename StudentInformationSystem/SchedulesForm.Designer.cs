namespace StudentInformationSystem
{
    partial class SchedulesForm
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
            this.lblScheduleDay = new System.Windows.Forms.Label();
            this.txtClassroomId = new System.Windows.Forms.TextBox();
            this.lblClassroomId = new System.Windows.Forms.Label();
            this.txtProfessorId = new System.Windows.Forms.TextBox();
            this.lblProfessorId = new System.Windows.Forms.Label();
            this.txtSubjectId = new System.Windows.Forms.TextBox();
            this.lblSubjectId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblScheduleDay
            // 
            this.lblScheduleDay.AutoSize = true;
            this.lblScheduleDay.Location = new System.Drawing.Point(293, 259);
            this.lblScheduleDay.Name = "lblScheduleDay";
            this.lblScheduleDay.Size = new System.Drawing.Size(95, 16);
            this.lblScheduleDay.TabIndex = 143;
            this.lblScheduleDay.Text = "Schedule Day:";
            // 
            // txtClassroomId
            // 
            this.txtClassroomId.Location = new System.Drawing.Point(478, 213);
            this.txtClassroomId.Name = "txtClassroomId";
            this.txtClassroomId.Size = new System.Drawing.Size(200, 22);
            this.txtClassroomId.TabIndex = 142;
            // 
            // lblClassroomId
            // 
            this.lblClassroomId.AutoSize = true;
            this.lblClassroomId.Location = new System.Drawing.Point(293, 219);
            this.lblClassroomId.Name = "lblClassroomId";
            this.lblClassroomId.Size = new System.Drawing.Size(91, 16);
            this.lblClassroomId.TabIndex = 141;
            this.lblClassroomId.Text = "Classroom ID:";
            // 
            // txtProfessorId
            // 
            this.txtProfessorId.Location = new System.Drawing.Point(478, 176);
            this.txtProfessorId.Name = "txtProfessorId";
            this.txtProfessorId.Size = new System.Drawing.Size(200, 22);
            this.txtProfessorId.TabIndex = 140;
            // 
            // lblProfessorId
            // 
            this.lblProfessorId.AutoSize = true;
            this.lblProfessorId.Location = new System.Drawing.Point(293, 179);
            this.lblProfessorId.Name = "lblProfessorId";
            this.lblProfessorId.Size = new System.Drawing.Size(84, 16);
            this.lblProfessorId.TabIndex = 139;
            this.lblProfessorId.Text = "Professor ID:";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.Location = new System.Drawing.Point(478, 139);
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(200, 22);
            this.txtSubjectId.TabIndex = 138;
            // 
            // lblSubjectId
            // 
            this.lblSubjectId.AutoSize = true;
            this.lblSubjectId.Location = new System.Drawing.Point(293, 142);
            this.lblSubjectId.Name = "lblSubjectId";
            this.lblSubjectId.Size = new System.Drawing.Size(71, 16);
            this.lblSubjectId.TabIndex = 137;
            this.lblSubjectId.Text = "Subject ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(548, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.TabIndex = 136;
            this.btnAdd.Text = "Add Schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.Location = new System.Drawing.Point(715, 132);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.RowTemplate.Height = 24;
            this.dgvSchedules.Size = new System.Drawing.Size(550, 553);
            this.dgvSchedules.TabIndex = 135;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(288, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 33);
            this.lblTitle.TabIndex = 134;
            this.lblTitle.Text = "Manage Schedules";
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
            this.pnlSide.TabIndex = 133;
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
            // 
            // btnViewStats
            // 
            this.btnViewStats.BackColor = System.Drawing.Color.SteelBlue;
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
            this.btnViewEnrollments.Text = "Manage Enrollments";
            this.btnViewEnrollments.UseVisualStyleBackColor = false;
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
            // 
            // btnManageSchedules
            // 
            this.btnManageSchedules.BackColor = System.Drawing.Color.SkyBlue;
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "\"Monday\", ",
            "\"Tuesday\", ",
            "\"Wednesday\", ",
            "\"Thursday\", ",
            "\"Friday\""});
            this.comboBox1.Location = new System.Drawing.Point(478, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 144;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(478, 327);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(200, 22);
            this.txtEndTime.TabIndex = 148;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(293, 330);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(145, 16);
            this.lblEndTime.TabIndex = 147;
            this.lblEndTime.Text = "End Time (HH:MM:SS):";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(478, 290);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(200, 22);
            this.txtStartTime.TabIndex = 146;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(293, 293);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(148, 16);
            this.lblStartTime.TabIndex = 145;
            this.lblStartTime.Text = "Start Time (HH:MM:SS):";
            // 
            // SchedulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.txtEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblScheduleDay);
            this.Controls.Add(this.txtClassroomId);
            this.Controls.Add(this.lblClassroomId);
            this.Controls.Add(this.txtProfessorId);
            this.Controls.Add(this.lblProfessorId);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.lblSubjectId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSide);
            this.Name = "SchedulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Manage Schedules";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblScheduleDay;
        private System.Windows.Forms.TextBox txtClassroomId;
        private System.Windows.Forms.Label lblClassroomId;
        private System.Windows.Forms.TextBox txtProfessorId;
        private System.Windows.Forms.Label lblProfessorId;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.Label lblSubjectId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSchedules;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label lblStartTime;
    }
}