using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace StudentAccommodatioProgram
{
    public partial class frmLease : Form
    {
        public frmLease()
        {
            InitializeComponent();
            DisplayLeaseAgreement();
        }
        private PrintDocument printDocument = new PrintDocument();
        string connectionString = "YourConnectionStringHere";
        public int GetUserId(string userName, string lastName)
        {
            string query = "SELECT user_Id FROM UserTable WHERE firstName = @userName AND lastName = @lastName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", userName);
                    command.Parameters.AddWithValue("@lastName", lastName);
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
            string query = "SELECT accommodation_ID FROM Accommodation WHERE accommodationName = @AccommodationName";

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
        private void DisplayLeaseAgreement()
        {
            
            frmAccommodation accommodationForm = new frmAccommodation();
            string accommodationName = accommodationForm.selectedAccommodationName;

            decimal rentAmount = GetRentAmountFromDatabase(accommodationName);
            string contractPeriod = GetContractPeriodFromDatabase(accommodationName);
            string typeOfAccommodation = GetTypeOfAccommodationFromDatabase(accommodationName);

            string termsAndConditions =
       "- Tenant agrees to pay rent on time every month.\n" +
       "- Tenant is responsible for keeping the accommodation clean and tidy.\n" +
       "- Tenant shall not make any structural changes to the accommodation.\n" +
       "- Landlord has the right to inspect the accommodation periodically.\n" +
       "- Tenant agrees not to disturb other residents with noise.\n" +
       "- Any damage caused by the Tenant will be repaired at their expense.\n" +
       "- Tenant shall comply with all local laws and regulations.\n" +
       "- Landlord reserves the right to terminate the lease for violation of terms.\n" +
       "- Tenant shall give notice before vacating the accommodation.\n" +
       "- All disputes will be settled according to local laws.\n";

            string leaseAgreementText = $"Lease Agreement\n\n" +
                $"This Lease Agreement is made between full Name: and {accommodationName}.\n\n" +
                $"Rent Amount: {rentAmount:C}\n" +
                $"Contract Period: {contractPeriod}\n" +
                $"Type of Accommodation: {typeOfAccommodation}\n\n" +
                $"Terms and Conditions:\n" +
                 $"{termsAndConditions}"; 

            rtTerms.Text = leaseAgreementText;
        }

        private decimal GetRentAmountFromDatabase(string accommodationName)
        {
            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                connection.Open();
                string query = "SELECT rentAmount FROM Accommodation WHERE accommodationName = @AccommodationName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);
                    return Convert.ToDecimal(command.ExecuteScalar());
                }
            }
        }

        private string GetContractPeriodFromDatabase(string accommodationName)
        {
            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                connection.Open();
                string query = "SELECT contractPeriod FROM Accommodation WHERE accommodationName = @AccommodationName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);
                    return command.ExecuteScalar()?.ToString();
                }
            }
        }

        private string GetTypeOfAccommodationFromDatabase(string accommodationName)
        {
            using (SqlConnection connection = new SqlConnection("YourConnectionStringHere"))
            {
                connection.Open();
                string query = "SELECT typeOfAccommodation FROM Accommodation WHERE accommodationName = @AccommodationName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccommodationName", accommodationName);
                    return command.ExecuteScalar()?.ToString();
                }
            }
        }

        private void InsertLeaseAgreement(DateTime startDate, DateTime endDate)
        {
            string status = chkSigned.Checked ? "Active" : "Inactive";
            frmRegisterStudent registerStudent = new frmRegisterStudent();
            string userName = registerStudent.firstName;
            string lastName = registerStudent.lastName;

            frmAccommodation accommodationForm = new frmAccommodation();
            string accommodationName = accommodationForm.selectedAccommodationName;

            int accommodationId = GetAccommodationId(accommodationName);
            int userID = GetUserId(userName, lastName);
            // Replace these with your actual database connection and query execution logic
            SqlConnection connection = new SqlConnection("your_connection_string_here");
            connection.Open();

            // Insert query
            string query = "INSERT INTO LeaseAgreement (StartDate, EndDate, Status,user_Id,accommodation_Id) " +
                           "VALUES (@StartDate, @EndDate, @Status,@user_Id,@accommodation_Id)";

            SqlCommand command = new SqlCommand(query, connection);

            // Set parameters
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@Status", status); // Assuming default status is "Active"
            command.Parameters.AddWithValue("@user_Id", userID);
            command.Parameters.AddWithValue("@accommodation_Id", accommodationId);
            // Execute the query
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Content to be printed
            string content = rtTerms.Text;
            string startDate = $"Start Date: {dpArrival.Value.ToShortDateString()}";
            string endDate = $"End Date: {dpDeparture.Value.ToShortDateString()}";

            // Create a font and brush for drawing
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Calculate margins and page bounds
            float marginLeft = e.MarginBounds.Left;
            float marginTop = e.MarginBounds.Top;
            float pageWidth = e.PageBounds.Width;
            float pageHeight = e.PageBounds.Height;

            // Draw content on the page
            e.Graphics.DrawString(content, font, brush, marginLeft, marginTop);
            e.Graphics.DrawString(startDate, font, brush, marginLeft, marginTop + 50);
            e.Graphics.DrawString(endDate, font, brush, marginLeft, marginTop + 80);

            e.HasMorePages = false; // Only one page for this example
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear(); // Clear any previous error indicators

            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtSignature.Text))
            {
                errorProvider1.SetError(txtSignature, "Please enter your full name.");
                isValid = false;
            }

            if (!chkTerms.Checked)
            {
                errorProvider1.SetError(chkTerms, "Please accept the terms and conditions.");
                isValid = false;
            }

            if (dpArrival.Value == dpArrival.MinDate ||
                dpDeparture.Value == dpDeparture.MinDate)
            {
                errorProvider1.SetError(dpArrival, "Please select valid start and end dates.");
                errorProvider1.SetError(dpDeparture, "Please select valid start and end dates.");
                isValid = false;
            }

            if (!isValid)
            {
                return; // If any validation error occurred, exit the method
            }
            else
            {
                DateTime startDate = dpArrival.Value;
                DateTime endDate = dpDeparture.Value;
                InsertLeaseAgreement(startDate, endDate);


                if (rbtnYES.Checked)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            printDocument.Print();
                        }
                    }

                    MessageBox.Show("PDF generated successfully and downloaded!");
                }
                else if (rbtnNO.Checked)
                {
                    printDocument.Print();
                    MessageBox.Show("PDF generated successfully!");
                }
                else
                {
                    MessageBox.Show("Please select an option for downloading the PDF.");
                }

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.Show();

        }
    }
}
