using Npgsql;
using projectEDP.core.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectEDP.ui.staff
{
    public partial class AdminDashboard : Form
    {
        private class QuickMetric { public decimal Amount { get; set; } public string Status { get; set; } }
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            CalculateLiveMetrics();
        }

        private void CalculateLiveMetrics()
        {
            List<QuickMetric> workingList = new List<QuickMetric>();
            string query = "SELECT total_price, status FROM orders;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                workingList.Add(new QuickMetric
                                {
                                    Amount = Convert.ToDecimal(reader["total_price"]),
                                    Status = reader["status"].ToString()
                                });
                            }
                        }
                    }
                }

                // LINQ Aggregates calculating data straight from memory list array states
                decimal totalRevenue = workingList.Sum(m => m.Amount);
                int pendingCount = workingList.Count(m => m.Status.Equals("Pending", StringComparison.OrdinalIgnoreCase));
                int completedCount = workingList.Count(m => m.Status.Equals("Completed", StringComparison.OrdinalIgnoreCase));

                // Bind computational results safely to labels
                if (lblTotalEarnings != null) lblTotalEarnings.Text = $"RM {totalRevenue:F2}";
                if (lblPendingOrders != null) lblPendingOrders.Text = pendingCount.ToString();
                if (lblCompletedOrders != null) lblCompletedOrders.Text = completedCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to parse platform dashboard analytics indices: {ex.Message}", "Metrics Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            AdminManage manageForm = new AdminManage();
            manageForm.Show();
            this.Hide();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            AdminStatus statusForm = new AdminStatus();
            statusForm.Show();
            this.Hide();
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}
