using System;
using System.Configuration; // Required for ConfigurationManager
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                // Retrieve connection string from App.config
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to check if the username and password match an admin record
                    string query = "SELECT COUNT(*) FROM admins WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Successful login
                            lblError.Text = "";
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open DashboardForm and hide LoginForm
                            DashboardForm dashboard = new DashboardForm();
                            dashboard.Show();
                            this.Hide(); // Hide the login form instead of closing to prevent app termination
                        }
                        else
                        {
                            // Failed login
                            lblError.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblError.Text = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Clear error label on form load
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Clear error label when password changes
            lblError.Text = "";
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
    }
}