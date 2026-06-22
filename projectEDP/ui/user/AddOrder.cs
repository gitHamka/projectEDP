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
    public partial class AddOrder : Form
    {
        private decimal totalAmount = 0.00m;
        private int currentCustomerId;

        public AddOrder(int customerId)
        {
            InitializeComponent();
            this.currentCustomerId = customerId;
        }

        private void CalculateTotal()
        {
            if (cmbService.SelectedIndex == -1 || cmbCategory.SelectedIndex == -1)
            {
                lblTotal.Text = "RM 0.00";
                totalAmount = 0.00m;
                return;
            }

            // 1. Get Base Service Price
            decimal basePrice = 0.00m;
            string selectedService = cmbService.SelectedItem.ToString();

            if (selectedService == "Wash") basePrice = 8.00m;
            else if (selectedService == "Wash and Dry") basePrice = 16.00m;
            else if (selectedService == "Wash and Dry and Fold") basePrice = 25.00m;

            // 2. Apply Category Size Modifier
            decimal multiplier = 1.00m;
            string selectedCategory = cmbCategory.SelectedItem.ToString();

            if (selectedCategory == "Medium") multiplier = 1.20m;
            else if (selectedCategory == "Large") multiplier = 1.50m;

            // 3. Compute and display final price
            totalAmount = basePrice * multiplier;
            lblTotal.Text = $"RM {totalAmount:F2}";
        }



        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "RM 0.00";
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == -1 || cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a category and a service type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generate a unique Order ID
            string orderId = "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            // Matches your exact columns: order_id, customer_id, category, services, total_price, notes, status
            string query = @"INSERT INTO orders (order_id, customer_id, category, services, total_price, notes, status) 
                     VALUES (@orderId, @customerId, @category, @services, @totalPrice, @notes, @status);";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", orderId);
                        cmd.Parameters.AddWithValue("@customerId", currentCustomerId);
                        cmd.Parameters.AddWithValue("@category", cmbCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@services", cmbService.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@totalPrice", totalAmount);
                        cmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Pending");

                        cmd.ExecuteNonQuery();
                    }
                }

                // Proceed to payment form
                ProceedPayment paymentForm = new ProceedPayment(orderId, totalAmount);
                paymentForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save order draft: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
