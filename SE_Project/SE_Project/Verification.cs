using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace SE_Project
{
    public partial class Verification : Form
    {
        private string userEmail;
        private string expectedCode;

        public Verification(string email, string verificationCode)
        {
            InitializeComponent();
            userEmail = email;
            expectedCode = verificationCode;
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            string enteredCode = txt_code.Text.Trim();

            if (enteredCode == expectedCode)
            {
                // Update user as verified in the database
                string connectionString = "Data Source=DESKTOP-RPNSJIA\\HIFZA;Initial Catalog=SEproject;Integrated Security=True;Trust Server Certificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "UPDATE Users SET IsVerified = 1 WHERE Email = @Email";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Email", userEmail);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                              
                                SendConfirmationEmail(userEmail);

                                MessageBox.Show("Email verified successfully! A confirmation email has been sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                login login = new login();
                                login.Show();
                                this.Close(); 
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid verification code. Please try again.", "Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SendConfirmationEmail(string email)
        {
            try
            {
                string firstName = GetFirstName(email);
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.From = new System.Net.Mail.MailAddress("hifzaamir618@gmail.com");
                mail.To.Add(email);
                mail.Subject = $"Hello {firstName}, Your Email Has Been Verified Successfully!";
                mail.Body = $"Dear {firstName},\n\nYour email has been successfully verified. You can now log in to your account and access the news system.\n\nThank you for registering with us.";

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                smtp.Port = 587; // Use the appropriate port for your email provider
                smtp.Credentials = new System.Net.NetworkCredential("hifzaamir618@gmail.com", "ytnc thzu vvke hiyo"); // Use app password here
                smtp.EnableSsl = true;

                smtp.Send(mail);
                MessageBox.Show("Confirmation email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send confirmation email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
