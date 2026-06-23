using Npgsql;
using projectEDP.core.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace projectEDP.ui.user
{
    public partial class OrderHistory : Form
    {
        private int currentCustomerId;
        private List<OrderRecord> allOrders = new List<OrderRecord>();

        private class OrderRecord
        {
            public string OrderID { get; set; }
            public string Category { get; set; }
            public string Services { get; set; }
            public decimal TotalPrice { get; set; }
            public string Status { get; set; }
        }

        public OrderHistory(int customerId)
        {
            InitializeComponent();
            this.currentCustomerId = customerId;
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.AddRange(new string[] { "All", "Pending", "In Progress", "Completed" });
            cmbStatusFilter.SelectedIndex = 0;

            FetchOrdersFromDatabase();
        }

        private void FetchOrdersFromDatabase()
        {
            string query = "SELECT order_id, category, services, total_price, status FROM orders WHERE customer_id = @id;";
            allOrders.Clear();

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", currentCustomerId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allOrders.Add(new OrderRecord
                                {
                                    OrderID = reader["order_id"].ToString(),
                                    Category = reader["category"].ToString(),
                                    Services = reader["services"].ToString(),
                                    TotalPrice = Convert.ToDecimal(reader["total_price"]),
                                    Status = reader["status"].ToString()
                                });
                            }
                        }
                    }
                }
                ApplyLinqFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyLinqFilter()
        {
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            var filteredList = selectedStatus == "All"
                ? allOrders
                : allOrders.Where(o => o.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase)).ToList();

            dgvHistory.DataSource = null;
            dgvHistory.DataSource = filteredList;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLinqFilter();
        }
        private void btnDownloadReceipt_Click(object sender, EventArgs e)
        {

        }

        private void btnDownloadReceipt_Click_1(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null)
            {
                MessageBox.Show("Please select an order sequence from the grid view row selection.", "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvHistory.CurrentRow;
            string ordId = row.Cells["OrderID"].Value.ToString();
            string cat = row.Cells["Category"].Value.ToString();
            string svc = row.Cells["Services"].Value.ToString();
            string amt = row.Cells["TotalPrice"].Value.ToString();
            string stat = row.Cells["Status"].Value.ToString();

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.FileName = $"Receipt_{ordId}.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string receiptContent =
                        $"========================================\n" +
                        $"         LAUNDRY SYSTEM RECEIPT         \n" +
                        $"========================================\n" +
                        $"Timestamp   : {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                        $"Order Ref ID: {ordId}\n" +
                        $"Category    : {cat}\n" +
                        $"Service Type: {svc}\n" +
                        $"Status Check: {stat}\n" +
                        $"----------------------------------------\n" +
                        $"TOTAL AMOUNT: RM {amt}\n" +
                        $"========================================\n" +
                        $"        Sila Bayar Di Kaunter           \n" +
                        $"     Thank you for your business!       \n" +
                        $"========================================\n";

                    File.WriteAllText(sfd.FileName, receiptContent);
                    MessageBox.Show("Receipt generated successfully to your storage path.", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
