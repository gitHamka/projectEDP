using Npgsql;
using projectEDP.core.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectEDP.ui.user
{
    public partial class UserDashboard : Form
    {
        private int currentCustomerId;
        public UserDashboard(int customerId)
        {
            InitializeComponent();
            this.currentCustomerId = customerId;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadPastOrders();
        }

        private void LoadPastOrders()
        {
            string query = @"SELECT order_id AS ""Order ID"", 
                                    category AS ""Category"", 
                                    services AS ""Service Type"", 
                                    total_price AS ""Total Price"", 
                                    notes AS ""Special Notes"", 
                                    status AS ""Status"" 
                             FROM orders 
                             WHERE customer_id = @customerId 
                             ORDER BY order_id DESC;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", currentCustomerId);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Automatically updates the UI grid display
                            dgvOrders.DataSource = dt;
                        }
                    }
                }

                // Adjust column rendering properties
                if (dgvOrders.Columns["Total Price"] != null)
                {
                    dgvOrders.Columns["Total Price"].DefaultCellStyle.Format = "RM 0.00";
                }
                dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load your order history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            // Close the dashboard completely to terminate the current session context
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder orderForm = new AddOrder(this.currentCustomerId);
            orderForm.Show();

            // Close the dashboard window
            this.Close();
        }

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
