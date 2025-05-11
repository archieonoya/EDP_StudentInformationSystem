using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class EnrollmentsForm : Form
    {
        public EnrollmentsForm()
        {
            InitializeComponent();
        }

        private void EnrollmentsForm_Load(object sender, EventArgs e)
        {
            LoadEnrollments();
            HighlightCurrentButton(btnViewEnrollments);
        }

        private void LoadEnrollments()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Connection string 'MySqlConnection' not found in configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            e.enrollment_id AS EnrollmentID, 
                            CONCAT(s.first_name, ' ', s.last_name) AS StudentName, 
                            sub.subject_title AS SubjectName, 
                            e.enrollment_date AS EnrollmentDate
                        FROM enrollment e
                        JOIN students s ON e.student_id = s.student_id
                        JOIN subjects sub ON e.subject_id = sub.subject_id
                        ORDER BY e.enrollment_date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No enrollments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvSchedules.DataSource = null;
                        }
                        else
                        {
                            dgvSchedules.DataSource = dt;
                            dgvSchedules.Columns["EnrollmentID"].HeaderText = "Enrollment ID";
                            dgvSchedules.Columns["StudentName"].HeaderText = "Student Name";
                            dgvSchedules.Columns["SubjectName"].HeaderText = "Subject Name";
                            dgvSchedules.Columns["EnrollmentDate"].HeaderText = "Enrollment Date";
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

        private void HighlightCurrentButton(Button currentButton)
        {
            foreach (Control control in pnlSide.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = (button == currentButton) ? System.Drawing.Color.SkyBlue : System.Drawing.Color.SteelBlue;
                }
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(txtStudentId.Text); // Assume TextBox for student ID
            int subjectId = int.Parse(txtSubjectId.Text); // Assume TextBox for subject ID
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO enrollment (student_id, subject_id, enrollment_date, admin_id) VALUES (@studentId, @subjectId, CURDATE(), 1)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments();
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

        private void btnDeleteEnrollment_Click(object sender, EventArgs e)
        {
            if (dgvSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an enrollment to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int enrollmentId = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["EnrollmentID"].Value);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM enrollment WHERE enrollment_id = @enrollmentId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@enrollmentId", enrollmentId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Enrollment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments();
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
            var dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            var studentsForm = new StudentsForm();
            studentsForm.Show();
            this.Close();
        }

        private void btnManageProfessor_Click(object sender, EventArgs e)
        {
            var professorsForm = new ProfessorsForm();
            professorsForm.Show();
            this.Close();
        }

        private void btnManageDepartments_Click(object sender, EventArgs e)
        {
            var departmentsForm = new DepartmentsForm();
            departmentsForm.Show();
            this.Close();
        }

        private void btnManageClassrooms_Click(object sender, EventArgs e)
        {
            var classroomsForm = new ClassroomsForm();
            classroomsForm.Show();
            this.Close();
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            var subjectsForm = new SubjectsForm();
            subjectsForm.Show();
            this.Close();
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            var schedulesForm = new SchedulesForm();
            schedulesForm.Show();
            this.Close();
        }

        private void btnViewEnrollments_Click(object sender, EventArgs e)
        {
            HighlightCurrentButton(btnViewEnrollments);
            LoadEnrollments();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            var statsForm = new EnrollmentStatsForm();
            statsForm.Show();
            this.Close();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            var logsForm = new LogsForm();
            logsForm.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}