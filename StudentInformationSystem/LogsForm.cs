using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class LogsForm : Form
    {
        public LogsForm()
        {
            InitializeComponent();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            LoadLogs();
            HighlightCurrentButton(btnViewLogs);
        }

        private void LoadLogs()
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
                            l.log_id AS LogID, 
                            l.change_details AS Message, 
                            l.log_date AS LogDate, 
                            a.username AS User
                        FROM logs l
                        LEFT JOIN admins a ON l.admin_id = a.admin_id
                        ORDER BY l.log_date DESC";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No logs found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvLogs.DataSource = null;
                        }
                        else
                        {
                            dgvLogs.DataSource = dt;
                            dgvLogs.Columns["LogID"].HeaderText = "Log ID";
                            dgvLogs.Columns["Message"].HeaderText = "Message";
                            dgvLogs.Columns["LogDate"].HeaderText = "Log Date";
                            dgvLogs.Columns["User"].HeaderText = "User";
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
            var statsForm = new EnrollmentStatsForm();
            statsForm.Show();
            this.Close();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            HighlightCurrentButton(btnViewLogs);
            LoadLogs();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}