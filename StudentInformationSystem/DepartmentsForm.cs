using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class DepartmentsForm : Form
    {
        private int loggedInAdminId = 1; // Placeholder for admin_id; replace with actual session value
        private string selectedDepartment;

        public DepartmentsForm()
        {
            InitializeComponent();
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT department_name FROM departments";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        adapter.Fill(dt);
                        dgvDepartments.DataSource = dt;
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
            if (string.IsNullOrWhiteSpace(txtDepartmentName.Text))
            {
                MessageBox.Show("Please enter a department name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO departments (department_name) VALUES (@department_name)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@department_name", txtDepartmentName.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDepartmentName.Text = "";
                    LoadDepartments();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDepartment))
            {
                MessageBox.Show("Please select a department to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete department '{selectedDepartment}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM departments WHERE department_name = @department_name";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@department_name", selectedDepartment);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Department deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            selectedDepartment = null;
                            LoadDepartments();
                        }
                        else
                        {
                            MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvDepartments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDepartments.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDepartments.SelectedRows[0];
                selectedDepartment = row.Cells["department_name"].Value.ToString();
                txtDepartmentName.Text = selectedDepartment;
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
            // Already on DepartmentsForm, no action needed
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