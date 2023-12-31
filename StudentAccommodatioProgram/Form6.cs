﻿using System;
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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
            pnlEFT.Enabled = false;
            pnlBursary.Enabled = false;
            pnlCash.Enabled = false;


        }
        string connectionString = "YourConnectionStringHere";
        
        public int GetAccommodationId(string accommodationName)
        {
            string query = "SELECT accommodation_ID FROM AccommodationTable WHERE accommodationName = @AccommodationName";

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
        public int GetUserId(string userName,string lastName)
        {
            string query = "SELECT user_ID FROM UserTable WHERE firstName = @userName AND lastName = @lastName";

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

        private int GetMostRecentPaymentID()
        {
            
            int paymentID = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT TOP 1 payment_ID FROM PaymentTable ORDER BY paymentDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        paymentID = reader.GetInt32(0);
                    }

                    reader.Close();
                }
            }

            return paymentID;
        }
        private void InsertPaymentData(decimal amount,  string paymentType)
        {
            frmAccommodation Accommodation = new frmAccommodation();
            string AccommodationName = Accommodation.selectedAccommodationName;
            int accommodationID = GetAccommodationId(AccommodationName);

            frmRegisterStudent registerStudent = new frmRegisterStudent();
            string userName = registerStudent.firstName;
            string lastName = registerStudent.lastName;

            int userID = GetUserId(userName, lastName);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO PaymentTable (amount, paymentDate, paymentType,accommodation_ID,user_ID) " +
                               "VALUES (@Amount, GETDATE(), @PaymentType,@accommodation_Id,@user_Id)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@PaymentType", paymentType);
                    command.Parameters.AddWithValue("@accommodation_Id", accommodationID);
                    command.Parameters.AddWithValue("@user_Id", userID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Payment inserted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert payment.", "Error");
                    }
                }
                connection.Close();
            }
        }

        private void InsertEFTData(int paymentID, string bankName, string accountHolder, string accountNumber)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO EFTTable (payment_ID, bankName, accountHolder, accountNumber) " +
                               "VALUES (@PaymentID, @BankName, @AccountHolder, @AccountNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", paymentID);
                    command.Parameters.AddWithValue("@BankName", bankName);
                    command.Parameters.AddWithValue("@AccountHolder", accountHolder);
                    command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("EFT payment inserted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert EFT payment.", "Error");
                    }
                }
                connection.Close();
            }
        }

        private void InsertCashData(int paymentID, string proofofPayment)
        {
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO CashTable (payment_ID, proofofPayment) " +
                               "VALUES (@PaymentID, @ProofOfPayment)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", paymentID);
                    command.Parameters.AddWithValue("@ProofOfPayment", proofofPayment);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cash payment inserted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert Cash payment.", "Error");
                    }
                }
                connection.Close();
            }
        }

        private void InsertBursaryData(int paymentID, string bursaryName, string email, string cellphone)
        {
            string connectionString = "YourConnectionStringHere";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO BursaryTable (payment_ID, bursaryName, email, cellphone) " +
                               "VALUES (@PaymentID, @BursaryName, @Email, @Cellphone)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PaymentID", paymentID);
                    command.Parameters.AddWithValue("@BursaryName", bursaryName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Cellphone", cellphone);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Bursary payment inserted successfully.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert Bursary payment.", "Error");
                    }
                }
                connection.Close();
            }
        }

        


        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbPayment.SelectedIndex)
            {
                case 0:
                    pnlBursary.Enabled = true;
                    int paymentID = GetMostRecentPaymentID();
                    if (paymentID != -1)
                    {
                        string BursaryName = txtBursar.Text;
                        string mail = txtMail.Text;
                        string cellphone = txtCellphone.Text;

                        InsertBursaryData(paymentID, BursaryName, mail, cellphone);
                    }
                    else
                    {
                        MessageBox.Show("No payment records found.", "Error");
                    }

                    break;
                case 1:
                    pnlEFT.Enabled = true;
                    paymentID = GetMostRecentPaymentID();
                    if (paymentID != -1)
                    {
                        string bankName = txtBank.Text;
                        string accountHolder = txtHolder.Text;
                        string accountNumber = txtAccNo.Text;

                        InsertEFTData(paymentID, bankName, accountHolder, accountNumber);
                    }
                    else
                    {
                        MessageBox.Show("No payment records found.", "Error");
                    }

                    break;
                case 2:
                    pnlCash.Enabled = true;
                    paymentID = GetMostRecentPaymentID();
                    if (paymentID != -1)
                    {
                        string proofofPayment = txtRef.Text;

                        InsertCashData(paymentID, proofofPayment);
                    }
                    else
                    {
                        MessageBox.Show("No payment records found.", "Error");
                    }

                    break;
                default:
                    break;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string paymentType = cmbPayment.SelectedItem.ToString();

            InsertPaymentData(amount, paymentType);
           
            frmLease LeaseAgreement = new frmLease();
            LeaseAgreement.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAccommodation accommodation = new frmAccommodation();
            accommodation.Show();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            
                // Clear ComboBox selection
                cmbPayment.SelectedIndex = -1;

                // Clear panel information
                pnlEFT.Visible = false;
                pnlCash.Visible = false;
                pnlBursary.Visible = false;

                // Clear TextBoxes in EFT panel
                txtBank.Clear();
                txtHolder.Clear();
                txtAccNo.Clear();

                // Clear TextBoxes in Cash panel
                txtRef.Clear();

                // Clear TextBoxes in Bursary panel
                txtBursar.Clear();
                txtMail.Clear();
                txtCellphone.Clear();
            

        }
    }
}
