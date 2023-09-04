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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.;Initial Catalog=dbcampusCasa;Integrated Security=True";
        private void GenerateAccommodationListReport()
        {
            // Retrieve accommodation data from the database
            DataTable dataTable = RetrieveAccommodationData(); // You need to implement this method

            // Bind the data to the DataGridView
            dataGridViewReports.DataSource = dataTable;
        }
        private DataTable RetrievePaymentHistoryData()
        {
            // Use SQL query to retrieve payment history data
            string query = $"SELECT accommodation_ID,user_ID, paymentAmount, paymentDate, paymentType FROM PaymentTable";
            DataTable paymentHistoryData = new DataTable();

            // Use your database connection to execute the query and fill the DataTable
            // Example: using SqlCommand and SqlDataAdapter
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(paymentHistoryData);
                }
            }

            return paymentHistoryData;
        }
        private void GeneratePaymentHistoryReport()
        {
            // Retrieve payment history data from the database
            DataTable paymentHistoryData = RetrievePaymentHistoryData(); // You need to implement this method

            // Bind the data to the DataGridView
            dataGridViewReports.DataSource = paymentHistoryData;
        }
        private DataTable RetrieveAccommodationData()
        {
            // Use SQL query to retrieve accommodation data
            string query = $"SELECT accommodationName, location, rentAmount FROM AccommodationTable";
            DataTable dataTable = new DataTable();

            // Use your database connection to execute the query and fill the DataTable
            // Example: using SqlCommand and SqlDataAdapter
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        private DataTable RetrieveMaintenanceRequestsData()
        {
            string query = $"SELECT studentName, accommodationName, maintenanceCategory, dateLogged, status FROM MaintenanceTable";
            DataTable maintenanceRequestsData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(maintenanceRequestsData);
                }
            }

            return maintenanceRequestsData;
        }
        private void GenerateMaintenanceRequestsListReport()
        {
            // Retrieve accommodation data from the database
            DataTable dataTable = RetrieveMaintenanceRequestsData(); // You need to implement this method

            // Bind the data to the DataGridView
            dataGridViewReports.DataSource = dataTable;
        }
        private void GeneratePaymentSummaryReport()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT paymentType, SUM(amount) AS TotalAmount, COUNT(*) AS PaymentCount " +
                               $"FROM PaymentTable " +
                               $"GROUP BY PaymentType";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReports.DataSource = dataTable;
            }
        }
        private void GenerateAccommodationAvailabilitySummaryReport()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT accommodation_ID, SUM(Quantity) AS TotalQuantity " +
                               $"FROM AccommodationSpecsTable " +
                               $"GROUP BY Accommodation_ID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReports.DataSource = dataTable;
            }
        }

        private void GenerateStudentSummaryReport()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT courseName, COUNT(*) AS StudentCount " +
                               $"FROM UserTable " +
                               $"GROUP BY courseName";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewReports.DataSource = dataTable;
            }
        }
    




        private void btnAll_Click(object sender, EventArgs e)
        {
            switch(cmbReports.SelectedIndex )
            {
                case 0:
                    GenerateAccommodationListReport();
                    break;
                case 1:
                    GeneratePaymentHistoryReport();
                    break;
                case 2:
                    GenerateMaintenanceRequestsListReport();
                    break;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            switch (cmbReports.SelectedIndex)
            {
                case 0:
                    GenerateAccommodationAvailabilitySummaryReport();
                    break;
                case 1:
                    GeneratePaymentSummaryReport();
                    break;
                case 2:
                    GenerateStudentSummaryReport();
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridViewReports.Rows.Clear();
            cmbReports.SelectedIndex = -1;
;
        }
    }
}
