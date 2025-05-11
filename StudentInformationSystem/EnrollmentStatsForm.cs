using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class EnrollmentStatsForm : Form
    {
        public EnrollmentStatsForm()
        {
            InitializeComponent();
        }

        private void EnrollmentStatsForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadStats();
            HighlightCurrentButton(btnViewStats);
        }

        private void LoadDepartments()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT department_id, department_name FROM departments";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbDepartment.DataSource = dt;
                        cmbDepartment.DisplayMember = "department_name";
                        cmbDepartment.ValueMember = "department_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStats()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            d.department_name AS Department, 
                            sub.subject_title AS Subject, 
                            COUNT(e.enrollment_id) AS EnrollmentCount
                        FROM enrollment e
                        JOIN subjects sub ON e.subject_id = sub.subject_id
                        JOIN departments d ON sub.department_id = d.department_id
                        GROUP BY d.department_name, sub.subject_title
                        ORDER BY d.department_name, sub.subject_title";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No enrollment statistics found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvStats.DataSource = null;
                        }
                        else
                        {
                            dgvStats.DataSource = dt;
                            dgvStats.Columns["Department"].HeaderText = "Department";
                            dgvStats.Columns["Subject"].HeaderText = "Subject";
                            dgvStats.Columns["EnrollmentCount"].HeaderText = "Enrollment Count";
                        }
                    }

                    // Verify DailyEnrollmentStatsUpdate event
                    query = "SELECT * FROM enrollment_stats ORDER BY stat_date DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblLastUpdate.Text = $"Last Update: {reader["stat_date"]} - Enrollments: {reader["total_enrollments"]}";
                            }
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

        private void btnFilterByDepartment_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedValue == null) return;

            int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("GetAllStudentsInDepartment", conn) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@p_department_id", departmentId);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvStats.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering by department: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var enrollmentsForm = new EnrollmentsForm();
            enrollmentsForm.Show();
            this.Close();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            HighlightCurrentButton(btnViewStats);
            LoadStats();
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