namespace StudentInformationSystem
{
    partial class SubjectsForm
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
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtSubjectTitle = new System.Windows.Forms.TextBox();
            this.lblSubjectTitle = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(477, 216);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(200, 22);
            this.txtUnits.TabIndex = 130;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(292, 219);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(40, 16);
            this.lblUnits.TabIndex = 129;
            this.lblUnits.Text = "Units:";
            // 
            // txtSubjectTitle
            // 
            this.txtSubjectTitle.Location = new System.Drawing.Point(477, 176);
            this.txtSubjectTitle.Name = "txtSubjectTitle";
            this.txtSubjectTitle.Size = new System.Drawing.Size(200, 22);
            this.txtSubjectTitle.TabIndex = 128;
            // 
            // lblSubjectTitle
            // 
            this.lblSubjectTitle.AutoSize = true;
            this.lblSubjectTitle.Location = new System.Drawing.Point(292, 179);
            this.lblSubjectTitle.Name = "lblSubjectTitle";
            this.lblSubjectTitle.Size = new System.Drawing.Size(84, 16);
            this.lblSubjectTitle.TabIndex = 127;
            this.lblSubjectTitle.Text = "Subject Title:";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(477, 139);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(200, 22);
            this.txtSubjectCode.TabIndex = 126;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Location = new System.Drawing.Point(292, 142);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(91, 16);
            this.lblSubjectCode.TabIndex = 125;
            this.lblSubjectCode.Text = "Subject Code:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(547, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.TabIndex = 124;
            this.btnAdd.Text = "Add Subject";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(714, 132);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RowHeadersWidth = 51;
            this.dgvSubjects.RowTemplate.Height = 24;
            this.dgvSubjects.Size = new System.Drawing.Size(550, 553);
            this.dgvSubjects.TabIndex = 123;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 59);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 33);
            this.lblTitle.TabIndex = 122;
            this.lblTitle.Text = "Manage Subjects";
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
            this.pnlSide.Location = new System.Drawing.Point(0, 0);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(249, 749);
            this.pnlSide.TabIndex = 121;
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
            this.btnViewEnrollments.Text = "View Enrollments";
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
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.BackColor = System.Drawing.Color.SkyBlue;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 131;
            this.label1.Text = "Department ID:";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.txtSubjectTitle);
            this.Controls.Add(this.lblSubjectTitle);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSide);
            this.Name = "SubjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Manage Subjects";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtSubjectTitle;
        private System.Windows.Forms.Label lblSubjectTitle;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSubjects;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}