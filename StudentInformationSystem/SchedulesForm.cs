using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class SchedulesForm : Form
    {
        private int loggedInAdminId = 1; // Placeholder for admin_id; replace with actual session value

        public SchedulesForm()
        {
            InitializeComponent();
        }

        private void SchedulesForm_Load(object sender, EventArgs e)
        {
            LoadSchedules();
        }

        private void LoadSchedules()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT subject_id, professor_id, classroom_id, schedule_day, schedule_start_time, schedule_end_time FROM subject_schedules";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dgvSchedules.DataSource = dt;
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
            if (string.IsNullOrWhiteSpace(txtSubjectId.Text) ||
                string.IsNullOrWhiteSpace(txtProfessorId.Text) ||
                string.IsNullOrWhiteSpace(txtClassroomId.Text) ||
                comboBox1.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtStartTime.Text) ||
                string.IsNullOrWhiteSpace(txtEndTime.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSubjectId.Text, out int subjectId) || subjectId <= 0)
            {
                MessageBox.Show("Subject ID must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProfessorId.Text, out int professorId) || professorId <= 0)
            {
                MessageBox.Show("Professor ID must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtClassroomId.Text, out int classroomId) || classroomId <= 0)
            {
                MessageBox.Show("Classroom ID must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string scheduleDay = comboBox1.SelectedItem.ToString().Replace("\"", "").Trim();
            if (!TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime) || !TimeSpan.TryParse(txtEndTime.Text, out TimeSpan endTime))
            {
                MessageBox.Show("Start Time and End Time must be in HH:MM:SS format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show("End Time must be greater than Start Time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO subject_schedules (subject_id, professor_id, classroom_id, schedule_day, schedule_start_time, schedule_end_time) VALUES (@subjectId, @professorId, @classroomId, @day, @startTime, @endTime)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@subjectId", subjectId);
                        cmd.Parameters.AddWithValue("@professorId", professorId);
                        cmd.Parameters.AddWithValue("@classroomId", classroomId);
                        cmd.Parameters.AddWithValue("@day", scheduleDay);
                        cmd.Parameters.AddWithValue("@startTime", startTime.ToString());
                        cmd.Parameters.AddWithValue("@endTime", endTime.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Schedule added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSubjectId.Text = "";
                    txtProfessorId.Text = "";
                    txtClassroomId.Text = "";
                    comboBox1.SelectedIndex = -1;
                    txtStartTime.Text = "";
                    txtEndTime.Text = "";
                    LoadSchedules();
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
            SubjectsForm subjectsForm = new SubjectsForm();
            subjectsForm.Show();
            this.Hide();
        }

        private void btnManageSchedules_Click(object sender, EventArgs e)
        {
            // Already on SchedulesForm, no action needed
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

        private void txtSubjectId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}