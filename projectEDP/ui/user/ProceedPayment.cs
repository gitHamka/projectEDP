using Npgsql;
using projectEDP.core.database;
using projectEDP.ui.user;
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
        private int currentCustomerId;
        public ProceedPayment(string orderId, decimal totalAmount, int customerId)
        {
            InitializeComponent();

            this.currentOrderId = orderId;
            this.currentTotalAmount = totalAmount;
            this.currentCustomerId = customerId;
        }

        private void ProceedPayment_Load(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
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

                            // --- PLACE IT RIGHT HERE ---
                            dgvOrderDetails.Columns.Clear();
                            dgvOrderDetails.AutoGenerateColumns = true;

                            // Bind the result straight to your DataGridView
                            dgvOrderDetails.DataSource = dt;
                        }
                    }
                }

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

            UserDashboard dashboardForm = new UserDashboard(this.currentCustomerId);
            dashboardForm.Show();

            // Close the current payment window
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Uses the currentCustomerId stored during form initialization instead of querying the database
            if (this.currentCustomerId > 0)
            {
                AddOrder orderForm = new AddOrder(this.currentCustomerId);
                orderForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not find customer profile context for this session.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
