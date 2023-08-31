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

    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
            LoadAccommodationData(connection);
        }
        public String connection = "Your connection string";
        private void LoadAccommodationData(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Accommodation";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewAccommodation.DataSource = dataTable;
            }
        }
        static void InsertIntoAccommodationTable(string connectionString, int agentId, string accommodationName, string location, decimal rentAmount)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO AccommodationTable (Agent_ID, accommodationName, location, rentAmount) " +
                               "VALUES (@AgentID, @AccommodationName, @Location, @RentAmount)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AgentID", agentId);
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@RentAmount", rentAmount);

                    command.ExecuteNonQuery();
                }
            }
        }
        static bool InsertIntoAccommodationSpecsTable(string connectionString, int accommodationId, decimal distanceToCampus, string gender,
                                                     bool parking, int quantity, bool lan, string description)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO AccommodationSpecsTable (accommodation_ID, distanceToCampus, gender, parking, Quantity, LAN, description) " +
                               "VALUES (@AccommodationID, @DistanceToCampus, @Gender, @Parking, @Quantity, @LAN, @Description)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationID", accommodationId);
                    command.Parameters.AddWithValue("@DistanceToCampus", distanceToCampus);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Parking", parking);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@LAN", lan);
                    command.Parameters.AddWithValue("@Description", description);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        static int GetAgentIdByAgentName(string connectionString, string agentName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_ID FROM UserTable WHERE firstName = @AgentName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AgentName", agentName);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return -1; // Agent not found
                    }
                }
            }
        }
        static int GetLatestAccommodationId(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TOP 1 accommodation_ID FROM AccommodationTable ORDER BY accommodation_ID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int latestId))
                    {
                        return latestId;
                    }
                }
            }

            return -1; // Return -1 if failed to retrieve latest ID
        }
        static bool DeleteAccommodationByName(string connectionString, string accommodationName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM accommodationTable WHERE accommodationName = @AccommodationName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        private void UpdateAccommodationAvailability(string connectionString,int accommodationId, int newAvailableSpots)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE AccommodationSpecsTable SET AvailableSpots = @NewAvailableSpots WHERE accommodation_ID = @AccommodationID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewAvailableSpots", newAvailableSpots);
                    command.Parameters.AddWithValue("@AccommodationID", accommodationId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Accommodation availability updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Accommodation ID not found or no changes were made.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void LoadLeaseAgreements(string connectionString)
        {
            string query = "SELECT lease_ID, accommodation_ID, startDate, endDate, status, approved FROM LeaseAgreementTable";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewAccommodation.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            string accName, agentName, type, adress, gender, description;
            decimal rentAmount, distance;
            int agentId, numberSpots,accommodationId;
            bool parking, wifi; 

            if (frmAdd.ShowDialog() == DialogResult.OK )
            {
                accName = frmAdd.accName;
                agentName = frmAdd.agentName;
                adress = frmAdd.address;
                type = frmAdd.type;
                rentAmount = frmAdd.rent;
                agentId = GetAgentIdByAgentName(connection, agentName);
                parking = frmAdd.parking;
                gender = frmAdd.gender;
                wifi = frmAdd.wifi;
                numberSpots = frmAdd.numberSpots;
                distance = frmAdd.Distance;
                description = frmAdd.description;
                accommodationId = GetLatestAccommodationId(connection);
                InsertIntoAccommodationSpecsTable(connection, accommodationId, distance, gender, parking, numberSpots, wifi, description);
                InsertIntoAccommodationTable(connection,agentId,accName,adress,rentAmount);

            }
            LoadAccommodationData(connection);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string userInput;
            using (var inputDialog = new InputBox("Enter Accommodation name:"))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    userInput = inputDialog.container;
                    MessageBox.Show($"You entered: {userInput}", "Input Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DeleteAccommodationByName(connection, userInput);
                }
            }
            LoadAccommodationData(connection);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int  spots;
            int name;
            using (var inputDialog = new InputBox("Enter Accommodation ID:"))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    name = int.Parse(inputDialog.container);
                    spots = int.Parse(inputDialog.counter);

                    UpdateAccommodationAvailability(connection, name, spots);
                    MessageBox.Show("Updated Successfully");
                }
            }

        }

        private void btnLease_Click(object sender, EventArgs e)
        {
            LoadLeaseAgreements(connection);

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.Show();
        }
        private void UpdateLeaseAgreementApproval(int leaseId, bool approved,string connectionString)
        {
            string query = "UPDATE LeaseAgreementTable SET approved = @Approved WHERE lease_ID = @LeaseId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Approved", approved);
                    command.Parameters.AddWithValue("@LeaseId", leaseId);
                    command.ExecuteNonQuery();
                }
            }
        }
    
        private void dataGridViewAccommodation_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewAccommodation.Rows[rowIndex];

            int leaseId = Convert.ToInt32(row.Cells["lease_ID"].Value);
            bool approved = Convert.ToBoolean(row.Cells["approved"].Value);

            UpdateLeaseAgreementApproval(leaseId, approved,connection);
            MessageBox.Show("Approved successfully!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
