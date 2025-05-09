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
            LoadStats();
            HighlightCurrentButton(btnViewStats);
        }

        private void LoadStats()
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