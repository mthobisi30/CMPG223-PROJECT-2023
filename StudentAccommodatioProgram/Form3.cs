using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAccommodatioProgram
{
    public partial class frmRegisterStudent : Form
    {
        public frmRegisterStudent()
        {
            InitializeComponent();
        }
        private string GeneratePassword(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Both first name and last name are required.");
            }

            // Generate a random special character
            string specialCharacters = "!@#$%^&*";
            Random random = new Random();
            char randomSpecialChar = specialCharacters[random.Next(specialCharacters.Length)];

            // Calculate the desired password length based on the length of the last name
            int passwordLength = lastName.Length;

            // Create the password by combining the components
            string password = $"{firstName}{randomSpecialChar}{passwordLength}";

            return password;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string email = txtMail.Text;
            string course = txtCourse.Text;
            string Cell = txtPhone.Text;

            if (string.IsNullOrEmpty(txtFName.Text))
            {
                errorProvider1.SetError(txtFName, "First Name is required.");
            }

            if (string.IsNullOrEmpty(txtLName.Text))
            {
                errorProvider1.SetError(txtLName, "Last Name is required.");
            }

            if (string.IsNullOrEmpty(txtMail.Text))
            {
                errorProvider1.SetError(txtMail, "Email is required.");
            }

            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                errorProvider1.SetError(txtCourse, "CompanyName is required.");
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Phone Number is required.");
            }


            string Password = GeneratePassword(firstName, lastName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert into User table
                string userInsertQuery = "INSERT INTO UserTable (firstName, lastName,courseName, email, cellphone, password) " +
                                         "VALUES (@FirstName, @lastName, @courseName, @Email, @Cellphone, @Password);";
                using (SqlCommand command = new SqlCommand(userInsertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@CourseName", course);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cellphone", Cell);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.ExecuteNonQuery();
                }



           
                connection.Close();
            }

            MessageBox.Show($"Registration Successful, Please Save your credentials for loggin in to the system!\n\nUserName: {email}\n\nPassword:{Password}", "Success");

            frmAccommodation AccommodationForm = new frmAccommodation();
            AccommodationForm.Show();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin LoginForm = new frmLogin();
            LoginForm.Show();
            this.Hide();
        }
    }
}
