using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentAccommodatioProgram
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
       public  string UserName { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string
            UserName = txtID.Text;
            string Password = txtPassword.Text;

            if (string.IsNullOrEmpty(txtID.Text))
            {
                errorProvider1.SetError(txtID, "UserName(Email) is required.");
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password is required.");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT CourseName, CompanyName FROM UserTable WHERE Email = @email AND password = @Password";
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string courseName = reader["CourseName"].ToString();
                            string companyName = reader["CompanyName"].ToString();

                            if (!string.IsNullOrEmpty(courseName))
                            {
                                MessageBox.Show("Welcome, Student!");
                                // Redirect to student form

                                frmStudentDash studentDash = new frmStudentDash();
                                studentDash.Show();
                            }
                            else if (!string.IsNullOrEmpty(companyName))
                            {
                                MessageBox.Show("Welcome, Agent!");
                                // Redirect to agent form
                                frmAgent Agentform = new frmAgent();
                                Agentform.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials.");
                    }
                }

                connection.Close();
            }
        }
    }
}
