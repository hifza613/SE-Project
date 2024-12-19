using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class forgotPassword : Form
    {
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void btn_forgotverificationcode_Click(object sender, EventArgs e)
        {
            string email = txt_forgotemail.Text.Trim();

            // Validate if the email is not empty
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate email format
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the email exists in the database
            if (!IsEmailExistsInDatabase(email))
            {
                MessageBox.Show("Email not found. Please check your email address and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed to the ChangePassword form
            ChangePassword resetPassword = new ChangePassword(email);
            resetPassword.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsEmailExistsInDatabase(string email)
        {
            string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE LOWER(Email) = LOWER(@Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int emailCount = (int)command.ExecuteScalar();

                        return emailCount > 0; // Return true if the email exists in the database
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking email existence: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
