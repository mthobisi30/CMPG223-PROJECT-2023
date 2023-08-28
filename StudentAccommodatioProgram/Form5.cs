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
    public partial class frmAccommodation : Form
    {
        public frmAccommodation()
        {
            InitializeComponent();
        }
        string connectionString = "YourConnectionStringHere";
        public string selectedAccommodationName { get; set; }

  

        private void rdHome_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int accommodationId = 1; // Replace with the actual accommodation ID you want to retrieve specs for

                string query = "SELECT distanceToCampus, gender, parking, Quantity, LAN, description FROM AccommodationSpecs WHERE accommodation_ID = @AccommodationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationId", accommodationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string distanceToCampus = reader["distanceToCampus"].ToString();
                            string gender = reader["gender"].ToString();
                            string parking = reader["parking"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string lan = reader["LAN"].ToString();
                            string description = reader["description"].ToString();

                            string specsText = $"Distance to Campus: {distanceToCampus}\r\n" +
                                               $"Gender: {gender}\r\n" +
                                               $"Parking: {parking}\r\n" +
                                               $"Quantity: {quantity}\r\n" +
                                               $"LAN: {lan}\r\n" +
                                               $"Description: {description}";

                            txtDisplay.Text = "Away Home Specifications\r\n\n" + specsText;
                            selectedAccommodationName = rdHome.Text;
                        }
                        else
                        {
                            txtDisplay.Text = "Accommodation specifications not found.";
                        }
                    }
                }
                connection.Close();
            }
            
                              
        }

        private void rdLofts_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Clear();

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int accommodationId = 1; // Replace with the actual accommodation ID you want to retrieve specs for

                string query = "SELECT distanceToCampus, gender, parking, Quantity, LAN, description FROM AccommodationSpecs WHERE accommodation_ID = @AccommodationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationId", accommodationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string distanceToCampus = reader["distanceToCampus"].ToString();
                            string gender = reader["gender"].ToString();
                            string parking = reader["parking"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string lan = reader["LAN"].ToString();
                            string description = reader["description"].ToString();

                            string specsText = $"Distance to Campus: {distanceToCampus}\r\n" +
                                               $"Gender: {gender}\r\n" +
                                               $"Parking: {parking}\r\n" +
                                               $"Quantity: {quantity}\r\n" +
                                               $"LAN: {lan}\r\n" +
                                               $"Description: {description}";

                            txtDisplay.Text = "StudySafe Lofts Specifications\r\n\n"+specsText;
                            selectedAccommodationName = rdLofts.Text;
                        }
                        else
                        {
                            txtDisplay.Text = "Accommodation specifications not found.";
                        }
                    }
                }
                connection.Close();
            }
        }

        private void rdHouse_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int accommodationId = 1; // Replace with the actual accommodation ID you want to retrieve specs for

                string query = "SELECT distanceToCampus, gender, parking, Quantity, LAN, description FROM AccommodationSpecs WHERE accommodation_ID = @AccommodationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationId", accommodationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string distanceToCampus = reader["distanceToCampus"].ToString();
                            string gender = reader["gender"].ToString();
                            string parking = reader["parking"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string lan = reader["LAN"].ToString();
                            string description = reader["description"].ToString();

                            string specsText = $"Distance to Campus: {distanceToCampus}\r\n" +
                                               $"Gender: {gender}\r\n" +
                                               $"Parking: {parking}\r\n" +
                                               $"Quantity: {quantity}\r\n" +
                                               $"LAN: {lan}\r\n" +
                                               $"Description: {description}";

                            txtDisplay.Text = "Student Living House Specifications \r\n\n" + specsText;
                            selectedAccommodationName = rdHouse.Text;
                        }
                        else
                        {
                            txtDisplay.Text = "Accommodation specifications not found.";
                        }
                    }
                }
                connection.Close();
            }
        }

        private void rdFlats_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int accommodationId = 1; // Replace with the actual accommodation ID you want to retrieve specs for

                string query = "SELECT distanceToCampus, gender, parking, Quantity, LAN, description FROM AccommodationSpecs WHERE accommodation_ID = @AccommodationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationId", accommodationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string distanceToCampus = reader["distanceToCampus"].ToString();
                            string gender = reader["gender"].ToString();
                            string parking = reader["parking"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string lan = reader["LAN"].ToString();
                            string description = reader["description"].ToString();

                            string specsText = $"Distance to Campus: {distanceToCampus}\r\n" +
                                               $"Gender: {gender}\r\n" +
                                               $"Parking: {parking}\r\n" +
                                               $"Quantity: {quantity}\r\n" +
                                               $"LAN: {lan}\r\n" +
                                               $"Description: {description}";

                            txtDisplay.Text = "Campus Flats Specifications \r\n\n" + specsText;
                            selectedAccommodationName = rdFlats.Text;
                        }
                        else
                        {
                            txtDisplay.Text = "Accommodation specifications not found.";
                        }
                    }
                }
                connection.Close();
            }
            

        }

        private void rdApartments_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int accommodationId = 1; // Replace with the actual accommodation ID you want to retrieve specs for

                string query = "SELECT distanceToCampus, gender, parking, Quantity, LAN, description FROM AccommodationSpecs WHERE accommodation_ID = @AccommodationId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationId", accommodationId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string distanceToCampus = reader["distanceToCampus"].ToString();
                            string gender = reader["gender"].ToString();
                            string parking = reader["parking"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            string lan = reader["LAN"].ToString();
                            string description = reader["description"].ToString();

                            string specsText = $"Distance to Campus: {distanceToCampus}\r\n" +
                                               $"Gender: {gender}\r\n" +
                                               $"Parking: {parking}\r\n" +
                                               $"Quantity: {quantity}\r\n" +
                                               $"LAN: {lan}\r\n" +
                                               $"Description: {description}";

                            txtDisplay.Text = "StayHome Apartments Specifications \r\n\n" + specsText;
                            selectedAccommodationName = rdApartments.Text;
                        }
                        else
                        {
                            txtDisplay.Text = "Accommodation specifications not found.";
                        }
                    }
                }


                connection.Close();
            }
            
        }

        private void btnGallery_Click(object sender, EventArgs e)
        {
            frmImages imagesForm = new frmImages();
            imagesForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdApartments.Checked = false;
            rdFlats.Checked = false;
            rdHome.Checked = false;
            rdHouse.Checked = false;
            rdLofts.Checked = false;
            txtDisplay.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmPayment paymentForm = new frmPayment();
            paymentForm.Show();

        }
    }
}
