using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadSystemSummary();
            LoadRecentLogs();
        }

        private void LoadSystemSummary()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    lblTotalStudents.Text = "Total Students: " + GetCount(conn, "students");
                    lblTotalProfessors.Text = "Total Professors: " + GetCount(conn, "professors");
                    lblTotalDepartments.Text = "Total Departments: " + GetCount(conn, "departments");
                    lblTotalClassrooms.Text = "Total Classrooms: " + GetCount(conn, "classrooms");
                    lblTotalSubjects.Text = "Total Subjects: " + GetCount(conn, "subjects");
                    lblTotalSchedules.Text = "Total Schedules: " + GetCount(conn, "subject_schedules");
                    lblTotalEnrollments.Text = "Total Enrollments: " + GetCount(conn, "enrollment_stats");
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

        private void LoadRecentLogs()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    DateTime oneWeekAgo = DateTime.Now.AddDays(-7);

                    string query = "SELECT admin_id, table_name, action, change_details, log_date FROM logs WHERE log_date >= @oneWeekAgo ORDER BY log_date DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@oneWeekAgo", oneWeekAgo);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            System.Data.DataTable dt = new System.Data.DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
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

        private int GetCount(MySqlConnection conn, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Already on Dashboard, no action needed
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
            ClassroomsForm classroomForm = new ClassroomsForm();
            classroomForm.Show();
            this.Hide();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.Show();
            this.Hide();
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

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
        }
    }
}