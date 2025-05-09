using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class ClassroomsForm : Form
    {
        private int loggedInAdminId = 1; // Placeholder for admin_id; replace with actual session value

        public ClassroomsForm()
        {
            InitializeComponent();
        }

        private void ClassroomsForm_Load(object sender, EventArgs e)
        {
            LoadClassrooms();
        }

        private void LoadClassrooms()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT classroom_id, building, room_number, capacity FROM classrooms";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dgvClassrooms.DataSource = dt;
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

        private bool IsValidCapacity(string capacityText, out int capacity)
        {
            // Check if the capacity is a valid integer
            if (!int.TryParse(capacityText, out capacity))
            {
                MessageBox.Show("Capacity must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if capacity is positive and within a reasonable range (1 to 500)
            if (capacity <= 0 || capacity > 500)
            {
                MessageBox.Show("Capacity must be between 1 and 500.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LogAction(string action, string details)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string logQuery = "INSERT INTO logs (admin_id, action, details, log_date) VALUES (@admin_id, @action, @details, @log_date)";
                    using (MySqlCommand cmd = new MySqlCommand(logQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@admin_id", loggedInAdminId);
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@details", details);
                        cmd.Parameters.AddWithValue("@log_date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to log action: " + ex.Message, "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuilding.Text) ||
                string.IsNullOrWhiteSpace(txtRoomNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Use the IsValidCapacity function to validate capacity
            if (!IsValidCapacity(txtCapacity.Text, out int capacity))
            {
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO classrooms (building, room_number, capacity) VALUES (@building, @room_number, @capacity)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@building", txtBuilding.Text);
                        cmd.Parameters.AddWithValue("@room_number", txtRoomNumber.Text);
                        cmd.Parameters.AddWithValue("@capacity", capacity);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Log the action
                string details = $"Added classroom: {txtBuilding.Text}-{txtRoomNumber.Text} with capacity {capacity}";
                LogAction("Add Classroom", details);

                MessageBox.Show("Classroom added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuilding.Text = "";
                txtRoomNumber.Text = "";
                txtCapacity.Text = "";
                LoadClassrooms();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvClassrooms.SelectedRows.Count > 0)
            {
                int classroomId = Convert.ToInt32(dgvClassrooms.SelectedRows[0].Cells["classroom_id"].Value);
                string building = dgvClassrooms.SelectedRows[0].Cells["building"].Value.ToString();
                string roomNumber = dgvClassrooms.SelectedRows[0].Cells["room_number"].Value.ToString();

                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM classrooms WHERE classroom_id = @classroom_id";
                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@classroom_id", classroomId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Log the action
                    string details = $"Deleted classroom: {building}-{roomNumber}";
                    LogAction("Delete Classroom", details);

                    MessageBox.Show("Classroom deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClassrooms();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a classroom to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvClassrooms_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = dgvClassrooms.SelectedRows.Count > 0;
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
            // Already on ClassroomsForm, no action needed
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
    }
}