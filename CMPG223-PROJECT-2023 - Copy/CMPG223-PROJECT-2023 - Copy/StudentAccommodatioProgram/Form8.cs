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
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.;Initial Catalog=dbcampusCasa;Integrated Security=True";
        public int GetUserId(string userName)
        {
            string query = $"SELECT user_ID FROM UserTable WHERE email = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                connection.Close();
            }
            return -1;
        }
        public int GetAccommodationId(string accommodationName)
        {
            string query = $"SELECT accommodation_ID FROM AccommodationTable WHERE accommodationName = @AccommodationName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
                connection.Close();
            }
            return -1;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            

            string maintenanceCategory = cmbCategory.Text;
            DateTime dateLogged = dpDateLogged.Value;
            string description = txtDescription.Text;
            string accommodationName = txtName.Text;
            frmLogin login = new frmLogin();
            string userName = login.UserName;

            
            int accommodationId = GetAccommodationId(accommodationName);
            int userId = GetUserId(userName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"INSERT INTO MaintenanceTable (maintenanceCategory, dateLogged, description, accommodationName,accommodation_ID,user_ID) " +
                                   $"VALUES (@maintenanceCategory, @dateLogged, @description, @accommodationName,@accommodation_Id,@user_Id)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maintenanceCategory", maintenanceCategory);
                        command.Parameters.AddWithValue("@dateLogged", dateLogged);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@accommodationName", accommodationName);
                        command.Parameters.AddWithValue("@user_Id", userId);
                        command.Parameters.AddWithValue("@accommodation_Id", accommodationId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Maintenance entry added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add maintenance entry.");
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDescription.Clear();
            txtName.Clear();
            cmbCategory.SelectedIndex = -1;
            dpDateLogged.Value = DateTime.Now;
        }
    }
    
}
