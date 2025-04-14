namespace StudentInformationSystem
{
    partial class StudentsForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBlockName = new System.Windows.Forms.TextBox();
            this.lblBlockName = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtYearLevel = new System.Windows.Forms.ComboBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblYearLevel = new System.Windows.Forms.Label();
            this.txtDepartmentId = new System.Windows.Forms.TextBox();
            this.lblDepartmentId = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(288, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 33);
            this.lblTitle.TabIndex = 44;
            this.lblTitle.Text = "Manage Students";
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
            this.pnlSide.Location = new System.Drawing.Point(1, 1);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(249, 749);
            this.pnlSide.TabIndex = 33;
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
            this.btnManageStudents.BackColor = System.Drawing.Color.SkyBlue;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(548, 652);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtBlockName
            // 
            this.txtBlockName.Location = new System.Drawing.Point(478, 601);
            this.txtBlockName.Name = "txtBlockName";
            this.txtBlockName.Size = new System.Drawing.Size(200, 22);
            this.txtBlockName.TabIndex = 70;
            // 
            // lblBlockName
            // 
            this.lblBlockName.AutoSize = true;
            this.lblBlockName.Location = new System.Drawing.Point(293, 604);
            this.lblBlockName.Name = "lblBlockName";
            this.lblBlockName.Size = new System.Drawing.Size(84, 16);
            this.lblBlockName.TabIndex = 69;
            this.lblBlockName.Text = "Block Name:";
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(478, 561);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(200, 22);
            this.txtStudentNo.TabIndex = 68;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(293, 564);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(76, 16);
            this.lblStudentNo.TabIndex = 67;
            this.lblStudentNo.Text = "Student No:";
            // 
            // txtYearLevel
            // 
            this.txtYearLevel.FormattingEnabled = true;
            this.txtYearLevel.Items.AddRange(new object[] {
            "\"1st Year\", ",
            "\"2nd Year\", ",
            "\"3rd Year\", ",
            "\"4th Year\", ",
            "\"5th Year\""});
            this.txtYearLevel.Location = new System.Drawing.Point(478, 484);
            this.txtYearLevel.Name = "txtYearLevel";
            this.txtYearLevel.Size = new System.Drawing.Size(200, 24);
            this.txtYearLevel.TabIndex = 66;
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(478, 521);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(200, 22);
            this.txtSemester.TabIndex = 65;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(293, 524);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(68, 16);
            this.lblSemester.TabIndex = 64;
            this.lblSemester.Text = "Semester:";
            // 
            // lblYearLevel
            // 
            this.lblYearLevel.AutoSize = true;
            this.lblYearLevel.Location = new System.Drawing.Point(293, 487);
            this.lblYearLevel.Name = "lblYearLevel";
            this.lblYearLevel.Size = new System.Drawing.Size(75, 16);
            this.lblYearLevel.TabIndex = 63;
            this.lblYearLevel.Text = "Year Level:";
            // 
            // txtDepartmentId
            // 
            this.txtDepartmentId.Location = new System.Drawing.Point(478, 444);
            this.txtDepartmentId.Name = "txtDepartmentId";
            this.txtDepartmentId.Size = new System.Drawing.Size(200, 22);
            this.txtDepartmentId.TabIndex = 62;
            // 
            // lblDepartmentId
            // 
            this.lblDepartmentId.AutoSize = true;
            this.lblDepartmentId.Location = new System.Drawing.Point(293, 447);
            this.lblDepartmentId.Name = "lblDepartmentId";
            this.lblDepartmentId.Size = new System.Drawing.Size(96, 16);
            this.lblDepartmentId.TabIndex = 61;
            this.lblDepartmentId.Text = "Department ID:";
            // 
            // txtGender
            // 
            this.txtGender.FormattingEnabled = true;
            this.txtGender.Items.AddRange(new object[] {
            "\"Male\", ",
            "\"Female\""});
            this.txtGender.Location = new System.Drawing.Point(478, 288);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(200, 24);
            this.txtGender.TabIndex = 60;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(478, 402);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 59;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(293, 405);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(478, 365);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 57;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(293, 368);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 56;
            this.lblAddress.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(478, 325);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 22);
            this.txtContact.TabIndex = 55;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(293, 328);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(106, 16);
            this.lblContact.TabIndex = 54;
            this.lblContact.Text = "Contact Number:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(293, 291);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 16);
            this.lblGender.TabIndex = 53;
            this.lblGender.Text = "Gender:";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(478, 247);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(200, 22);
            this.txtBirthDate.TabIndex = 52;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(293, 250);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(165, 16);
            this.lblBirthDate.TabIndex = 51;
            this.lblBirthDate.Text = "Birth Date (YYYY-MM-DD):";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(478, 210);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 50;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(293, 213);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 16);
            this.lblLastName.TabIndex = 49;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(478, 170);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(200, 22);
            this.txtMiddleName.TabIndex = 48;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Location = new System.Drawing.Point(293, 173);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(91, 16);
            this.lblMiddleName.TabIndex = 47;
            this.lblMiddleName.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(478, 133);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 46;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(293, 136);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 16);
            this.lblFirstName.TabIndex = 45;
            this.lblFirstName.Text = "First Name:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(715, 133);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(550, 553);
            this.dgvStudents.TabIndex = 72;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 748);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBlockName);
            this.Controls.Add(this.lblBlockName);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.txtYearLevel);
            this.Controls.Add(this.txtSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblYearLevel);
            this.Controls.Add(this.txtDepartmentId);
            this.Controls.Add(this.lblDepartmentId);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.lblMiddleName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlSide);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System - Manage Students";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBlockName;
        private System.Windows.Forms.Label lblBlockName;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.ComboBox txtYearLevel;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.TextBox txtDepartmentId;
        private System.Windows.Forms.Label lblDepartmentId;
        private System.Windows.Forms.ComboBox txtGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}