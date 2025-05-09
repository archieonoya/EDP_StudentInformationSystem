using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentInformationSystem
{
    public partial class PasswordRecoveryForm : Form
    {
        private string username;
        private string resetCode;

        public PasswordRecoveryForm(string username, string resetCode)
        {
            InitializeComponent();
            this.username = username;
            this.resetCode = resetCode;
            lblMessage.Text = $"Enter the recovery code sent to your email and your new password.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string enteredCode = txtResetCode.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            if (string.IsNullOrEmpty(enteredCode) || string.IsNullOrEmpty(newPassword))
            {
                lblMessage.Text = "Please enter both the recovery code and new password.";
                return;
            }

            if (enteredCode != resetCode)
            {
                lblMessage.Text = "Invalid recovery code.";
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE admins SET password = @password WHERE username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@username", username);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            lblMessage.Text = "Password reset successfully. You can now log in with the new password.";
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            lblMessage.Text = "Failed to reset password.";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                lblMessage.Text = "Database error: " + ex.Message;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}