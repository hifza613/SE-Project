
using System;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace SE_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string firstName = txt_name.Text.Trim();
            string lastName = txt_lname.Text.Trim();
            string email = txt_email.Text.Trim();
            string password = txt_passwod.Text;
            string confirmPassword = txt_confirmpass.Text;

            // Validation
            if (!ValidateName(firstName) || !ValidateName(lastName))
            {
                MessageBox.Show("First and Last name must contain only alphabets.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidatePassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long, contain one uppercase letter, one number, and one special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string verificationCode = new Random().Next(100000, 999999).ToString();
            // Database connection string
            string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";


            // Save user to database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Users (FirstName, LastName, Email, Password,VerificationCode, IsVerified) " +
               "VALUES (@FirstName, @LastName, @Email, @Password,@VerificationCode, @IsVerified)";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", HashPassword(password)); // Hash the password
                        command.Parameters.AddWithValue("@VerificationCode",verificationCode);
                        command.Parameters.AddWithValue("@IsVerified", false);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Send verification email
                            SendVerificationEmail(email, verificationCode);
                            MessageBox.Show("User registered successfully! Please check your email for the verification code.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Verification verification = new Verification(email, verificationCode);
                            verification.Show();
                            this.Hide(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string GetFirstName(string email)
        {
            string firstName = string.Empty;
            string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT FirstName FROM Users WHERE Email = @Email";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            firstName = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return firstName;
        }


        private void SendVerificationEmail(string email, string verificationCode)
        {
            try
            {
                string firstName = GetFirstName(email);
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress("hifzaamir618@gmail.com");
                mail.To.Add(email);
                mail.Subject = $"Hello {firstName}, Please Verify Your Email";
                mail.Body = $"Dear {firstName},\n\nYour verification code is: {verificationCode}\n\nPlease enter this code to verify your email address.\n\nThank you for registering with us.";

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtp.Port = 587; // Update the port as needed
                smtp.Credentials = new System.Net.NetworkCredential("hifzaamir618@gmail.com","ytnc thzu vvke hiyo"); // Use app password here
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Verification email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send verification email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z]+$");
        }

        // Validate email
        private bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validate password
        private bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes); // Return the hashed password as a base64 string
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           login login = new login();
            login.Show();
        }
    }
}
