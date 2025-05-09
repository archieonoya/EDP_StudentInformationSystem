using System;
using System.Configuration;
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    lblError.Text = "Connection string not found in configuration.";
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM admins WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            lblError.Text = "";

                            Form successForm = new Form()
                            {
                                StartPosition = FormStartPosition.CenterScreen,
                                Size = new System.Drawing.Size(300, 150),
                                FormBorderStyle = FormBorderStyle.FixedDialog,
                                Text = "Login Success",
                                ControlBox = false,
                                TopMost = true
                            };

                            Label lbl = new Label()
                            {
                                Text = "Login successful! Redirecting...",
                                Dock = DockStyle.Fill,
                                Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold),
                                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                            };

                            successForm.Controls.Add(lbl);
                            successForm.Show();

                            Timer timer = new Timer();
                            timer.Interval = 2000; // 2 seconds
                            timer.Tick += (s, args) =>
                            {
                                timer.Stop();
                                successForm.Close();

                                DashboardForm dashboard = new DashboardForm();
                                dashboard.Show();
                                this.Hide();
                            };
                            timer.Start();
                        }
                        else
                        {
                            lblError.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblError.Text = "Database error: " + ex.Message;
                MessageBox.Show($"MySQL Error: {ex.Message}\nError Code: {ex.Number}\nStack Trace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "Please enter your username first.";
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"]?.ConnectionString;
                if (string.IsNullOrEmpty(connectionString))
                {
                    lblError.Text = "Connection string not found in configuration.";
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT email FROM admins WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        string email = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(email))
                        {
                            // Simulate generating a reset code (in a real app, use a secure random code and email service)
                            string resetCode = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
                            MessageBox.Show($"A recovery code has been sent to {email}. Please use code: {resetCode}", "Password Recovery", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open recovery form with the username and reset code
                            PasswordRecoveryForm recoveryForm = new PasswordRecoveryForm(username, resetCode);
                            recoveryForm.ShowDialog();
                        }
                        else
                        {
                            lblError.Text = "Username not found.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblError.Text = "Database error: " + ex.Message;
                MessageBox.Show($"MySQL Error: {ex.Message}\nError Code: {ex.Number}\nStack Trace: {ex.StackTrace}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}