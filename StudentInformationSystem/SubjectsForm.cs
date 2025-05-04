using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class SubjectsForm : Form
    {
        private int loggedInAdminId = 1; // Placeholder for admin_id; replace with actual session value

        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT subject_code, subject_title, units, department_id FROM subjects";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dgvSubjects.DataSource = dt;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) ||
                string.IsNullOrWhiteSpace(txtSubjectTitle.Text) ||
                string.IsNullOrWhiteSpace(txtUnits.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtUnits.Text, out int units) || units <= 0)
            {
                MessageBox.Show("Units must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int departmentId) || departmentId <= 0)
            {
                MessageBox.Show("Department ID must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO subjects (subject_code, subject_title, units, department_id) VALUES (@code, @title, @units, @deptId)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", txtSubjectCode.Text);
                        cmd.Parameters.AddWithValue("@title", txtSubjectTitle.Text);
                        cmd.Parameters.AddWithValue("@units", units);
                        cmd.Parameters.AddWithValue("@deptId", departmentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Subject added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubjectCode.Text = "";
                    txtSubjectTitle.Text = "";
                    txtUnits.Text = "";
                    textBox1.Text = "";
                    LoadSubjects();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            StudentsForm studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Hide();
        }

        private void btnManageProfessor_Click(object sender, EventArgs e)
        {
            ProfessorsForm professorsForm = new ProfessorsForm();
            professorsForm.Show();
            this.Hide();
        }

        private void btnManageDepartments_Click(object sender, EventArgs e)
        {
            DepartmentsForm departmentsForm = new DepartmentsForm();
            departmentsForm.Show();
            this.Hide();
        }

        private void btnManageClassrooms_Click(object sender, EventArgs e)
        {
            ClassroomsForm classroomsForm = new ClassroomsForm();
            classroomsForm.Show();
            this.Hide();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            // Already on SubjectsForm, no action needed
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            SchedulesForm schedulesForm = new SchedulesForm();
            schedulesForm.Show();
            this.Hide();
        }

        private void btnViewEnrollments_Click(object sender, EventArgs e)
        {
            EnrollmentsForm enrollmentsForm = new EnrollmentsForm();
            enrollmentsForm.Show();
            this.Hide();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            EnrollmentStatsForm statsForm = new EnrollmentStatsForm();
            statsForm.Show();
            this.Hide();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();
            logsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}