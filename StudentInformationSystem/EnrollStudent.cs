using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class EnrollStudent : Form
    {
        private int loggedInAdminId = 1; // Placeholder for admin_id; ideally, pass this from LoginForm

        public EnrollStudent()
        {
            InitializeComponent();
        }

        private void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (!ValidateInputs()) return;

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert new student
                    string insertQuery = @"
                        INSERT INTO students (student_no, first_name, middle_name, last_name, birth_date, gender, contact_number, address, email, department_id, year_level, semester, block_name, admin_id)
                        VALUES (@student_no, @first_name, @middle_name, @last_name, @birth_date, @gender, @contact_number, @address, @email, @department_id, @year_level, @semester, @block_name, @admin_id);
                        SELECT LAST_INSERT_ID();"; // Get the new student_id

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@student_no", txtStudentNo.Text);
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text);
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@birth_date", DateTime.Parse(txtBirthDate.Text));
                        cmd.Parameters.AddWithValue("@gender", txtGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@contact_number", txtContact.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@department_id", int.Parse(txtDepartmentId.Text));
                        cmd.Parameters.AddWithValue("@year_level", txtYearLevel.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@semester", txtSemester.Text);
                        cmd.Parameters.AddWithValue("@block_name", txtBlockName.Text);
                        cmd.Parameters.AddWithValue("@admin_id", loggedInAdminId);

                        int newStudentId = Convert.ToInt32(cmd.ExecuteScalar());

                        // Log the action
                        string logQuery = @"
                            INSERT INTO logs (admin_id, table_name, row_id, action, change_details, log_date)
                            VALUES (@admin_id, @table_name, @row_id, @action, @change_details, @log_date)";
                        using (MySqlCommand logCmd = new MySqlCommand(logQuery, conn))
                        {
                            logCmd.Parameters.AddWithValue("@admin_id", loggedInAdminId);
                            logCmd.Parameters.AddWithValue("@table_name", "students");
                            logCmd.Parameters.AddWithValue("@row_id", newStudentId);
                            logCmd.Parameters.AddWithValue("@action", "INSERT");
                            logCmd.Parameters.AddWithValue("@change_details", $"New student enrolled: {txtFirstName.Text} {txtLastName.Text}");
                            logCmd.Parameters.AddWithValue("@log_date", DateTime.Now);
                            logCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Student enrolled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    this.DialogResult = DialogResult.OK; // Indicate success to the parent form
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBirthDate.Text) ||
                txtGender.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentId.Text) ||
                txtYearLevel.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtSemester.Text) ||
                string.IsNullOrWhiteSpace(txtBlockName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate birth_date format
            if (!DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date in YYYY-MM-DD format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate department_id exists
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM departments WHERE department_id = @department_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@department_id", int.Parse(txtDepartmentId.Text));
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 0)
                        {
                            MessageBox.Show("Invalid Department ID. Please enter a valid department ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Department ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Additional validation for email format (basic check)
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtStudentNo.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtBirthDate.Text = "";
            txtGender.SelectedIndex = -1;
            txtContact.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtDepartmentId.Text = "";
            txtYearLevel.SelectedIndex = -1;
            txtSemester.Text = "";
            txtBlockName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EnrollStudent_Load(object sender, EventArgs e)
        {
            // No action needed on load
        }
    }
}