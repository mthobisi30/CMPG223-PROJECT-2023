using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentAccommodatioProgram
{
    public partial class frmStudentDash : Form
    {
        public frmStudentDash()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            string user;
            frmLogin login = new frmLogin();
            
            string userInput = login.UserName; // Get user input from txtUsername TextBox

            string selectQuery = $"SELECT firstName, lastName FROM UserTable WHERE email LIKE @UserInput";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=dbcampusCasa;Integrated Security=True"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserInput", $"%{userInput}%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                user = reader.GetString(0); // Assuming email is the first column in the result
                                                            // Now you have the userEmail from the database
                                                            // You can display it or use it as needed
                                lblDisplay.Text = "Welcome Back " + user;
                            }
                        }
                    }
                }
                conn.Close();
            }
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int selectedIndex = cmbBoard.SelectedIndex;

            switch (selectedIndex)
            {
                case 0: // Accommodation
                    frmAccommodation accommodationForm = new frmAccommodation();
                    accommodationForm.Show();
                    break;

                case 1: // Payment
                    frmPayment paymentForm = new frmPayment();
                    paymentForm.Show();
                    break;

                case 2: // Lease
                    frmLease leaseForm = new frmLease();
                    leaseForm.Show();
                    break;

                case 3: // Maintenance
                    frmMaintenance maintenanceForm = new frmMaintenance();
                    maintenanceForm.Show();
                    break;

                // Add more cases for other items if needed

                default:
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
