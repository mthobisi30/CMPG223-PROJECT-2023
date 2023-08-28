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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";

            string maintenanceCategory = cmbCategory.Text;
            DateTime dateLogged = dpDateLogged.Value;
            string description = txtDescription.Text;
            string accommodationName = txtName.Text;
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Maintenance (maintenanceCategory, dateLogged, description, accommodationName) " +
                                   "VALUES (@maintenanceCategory, @dateLogged, @description, @accommodationName)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@maintenanceCategory", maintenanceCategory);
                        command.Parameters.AddWithValue("@dateLogged", dateLogged);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@accommodationName", accommodationName);
                        

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
