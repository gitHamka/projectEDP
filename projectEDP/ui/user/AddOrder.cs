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
    public partial class AddOrder : Form
    {
        private decimal totalAmount = 0.00m;
        private int currentCustomerId;

        public AddOrder(int customerId)
        {
            InitializeComponent();
            this.currentCustomerId = customerId;

            if (lblTotal != null)
            {
                lblTotal.MouseHover += new EventHandler(lblTotal_MouseHover);
            }
        }

        private void lblTotal_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(lblTotal, "Calculated using base service rates and structural category size adjustments.");
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "RM 0.00";
        }

        private void CalculateTotal()
        {
            if (cmbService == null || cmbCategory == null || lblTotal == null) return;
            if (cmbService.SelectedIndex == -1 || cmbCategory.SelectedIndex == -1)
            {
                lblTotal.Text = "RM 0.00";
                totalAmount = 0.00m;
                return;
            }

            decimal basePrice = 0.00m;
            string selectedService = cmbService.SelectedItem?.ToString() ?? "";

            if (selectedService == "Wash") basePrice = 8.00m;
            else if (selectedService == "Wash and Dry") basePrice = 16.00m;
            else if (selectedService == "Wash and Dry and Fold") basePrice = 25.00m;

            decimal multiplier = 1.00m;
            string selectedCategory = cmbCategory.SelectedItem?.ToString() ?? "";

            if (selectedCategory == "Medium") multiplier = 1.20m;
            else if (selectedCategory == "Large") multiplier = 1.50m;

            totalAmount = basePrice * multiplier;
            lblTotal.Text = $"RM {totalAmount:F2}";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbCategory == null || cmbCategory.SelectedIndex == -1 ||
        cmbService == null || cmbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a category and a service type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentCustomerId <= 0)
            {
                MessageBox.Show("Invalid session context. Please log in again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string orderId = "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");

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
                        cmd.Parameters.AddWithValue("@notes", (txtNotes == null || string.IsNullOrWhiteSpace(txtNotes.Text)) ? (object)DBNull.Value : txtNotes.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Pending");

                        cmd.ExecuteNonQuery();
                    }
                }

                ProceedPayment paymentForm = new ProceedPayment(orderId, totalAmount, this.currentCustomerId);
                paymentForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save order draft: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserDashboard dashboardForm = new UserDashboard(this.currentCustomerId);
            dashboardForm.Show();
            this.Close();
        }
    }
}