using Npgsql;
using projectEDP.core.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class ProceedPayment : Form
    {
        private string currentOrderId;
        private decimal currentTotalAmount;
        public ProceedPayment(string orderId, decimal totalAmount)
        {
            InitializeComponent();

            this.currentOrderId = orderId;
            this.currentTotalAmount = totalAmount;
        }

        private void ProceedPayment_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            // Querying specific columns from your schema to present cleanly in the UI
            string query = @"SELECT order_id AS ""Order ID"", 
                                    category AS ""Category"", 
                                    services AS ""Service Type"", 
                                    total_price AS ""Total Price (RM)"", 
                                    notes AS ""Special Notes"", 
                                    status AS ""Status"" 
                             FROM orders 
                             WHERE order_id = @orderId;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", currentOrderId);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Bind the result straight to your DataGridView
                            dgvOrderDetails.DataSource = dt;
                        }
                    }
                }

                // Optional: Adjust column layouts so they stretch cleanly across the control
                dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load order context details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceeding to payment gateway...", "Sila Bayar di Kaunter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string query = "SELECT customer_id FROM orders WHERE order_id = @orderId;";
            int customerId = 0;

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", currentOrderId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            customerId = Convert.ToInt32(result);
                        }
                    }
                }

                // If a valid customer ID was recovered, reopen the AddOrder form with it
                if (customerId > 0)
                {
                    AddOrder orderForm = new AddOrder(customerId);
                    orderForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Could not find customer profile context for this session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning to previous form: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
