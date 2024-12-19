using System;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
namespace SE_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_loginemail.Text.Trim();
            string password = txt_loginpass.Text;


            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Database connection string
            string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to fetch user details
                    string query = "SELECT Password FROM Users WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        object result = command.ExecuteScalar(); // Get the hashed password from the database

                        if (result != null)
                        {
                            string storedPasswordHash = result.ToString();

                            // Verify the entered password with the stored hash
                            if (VerifyPassword(password, storedPasswordHash))
                            {
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //// Open the DashboardForm (or your main application form)
                                //DashboardForm dashboard = new DashboardForm(); // Replace with your actual form name
                                //this.Hide(); // Hide the login form
                                //dashboard.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private bool ValidateEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Verify hashed password
        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(enteredPassword));
                string enteredPasswordHash = Convert.ToBase64String(hashBytes);
                return enteredPasswordHash == storedPasswordHash;
            }
        }

        private void btn_clickhere_Click(object sender, EventArgs e)
        {
            forgotPassword forgotPassword = new forgotPassword();
            forgotPassword.Show();
            this.Close();
        }

        private void btn_registerhere_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
        }
    }

}
