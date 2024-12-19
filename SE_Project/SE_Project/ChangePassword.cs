using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SE_Project
{
    public partial class ChangePassword : Form
    {

        private string userEmail;

        public ChangePassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }
        private void btn_change_Click(object sender, EventArgs e)
        {
            string newPassword = txt_new.Text.Trim();
            string confirmPassword = txt_connfirm.Text.Trim();

            // Validate if the password fields are not empty
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate if the passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password strength (e.g., minimum length, complexity)
            if (newPassword.Length < 8)  // Example: Minimum 6 characters
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the password in the database
            if (UpdatePasswordInDatabase(userEmail, newPassword))
            {
                MessageBox.Show("Your password has been successfully reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to reset the password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdatePasswordInDatabase(string email, string newPassword)
        {
            string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Hash the password before storing it in the database
                    string hashedPassword = HashPassword(newPassword);

                    string query = "UPDATE Users SET Password = @Password WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@Email", email);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0; // Return true if the password was updated successfully
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating password: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // Method to hash the password (use a secure hashing algorithm like SHA256 or bcrypt in production)
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }

}
