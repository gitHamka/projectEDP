using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql; 
using projectEDP.core.database;
using System.Linq;


namespace projectEDP.ui.staff
{
    public partial class AdminManage : Form
    {
        public delegate void OrderLogger(string input);
        public delegate decimal PremiumTaxEngine(decimal baseline);
        public AdminManage()
        {
            InitializeComponent();
        }

        private void AdminManage_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Full Name and Phone fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isUpdating = !string.IsNullOrWhiteSpace(txtCustomerID.Text);
            string query = isUpdating
                ? "UPDATE users SET full_name = @name, phone = @phone, address = @address WHERE user_id = @id;"
                : "INSERT INTO users (full_name, phone, address) VALUES (@name, @phone, @address);";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@address", string.IsNullOrWhiteSpace(txtAddress.Text) ? (object)DBNull.Value : txtAddress.Text.Trim());

                        if (isUpdating)
                        {
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtCustomerID.Text.Trim()));
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string msg = isUpdating ? "Customer profile updated!" : "Customer registered successfully!";
                            MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadCustomerGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            
            txtCustomerID.Clear();

            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please enter a Customer ID to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Customer ID {txtCustomerID.Text}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM users WHERE user_id = @id;";

                try
                {
                    using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                          
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtCustomerID.Text.Trim()));

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer profile deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
                                LoadCustomerGrid();
                            }
                            else
                            {
                                MessageBox.Show("Customer ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text)) return;

           
            if (!long.TryParse(txtCustomerID.Text.Trim(), out long customerId))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Clear();
                return;
            }

            
            string query = "SELECT full_name, phone, address FROM users WHERE user_id = @id;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                            
                                txtFullName.Text = reader["full_name"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                                txtAddress.Text = reader["address"] != DBNull.Value ? reader["address"].ToString() : "";
                            }
                            else
                            {
                               
                                MessageBox.Show("No customer found with this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtFullName.Clear();
                                txtPhone.Clear();
                                txtAddress.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form adminDashboard = Application.OpenForms["AdminDashboard"];

            if (adminDashboard != null)
            {
                adminDashboard.Show(); 
            }
            else
            {
                
                AdminDashboard newDashboard = new AdminDashboard();
                newDashboard.Show();
            }

           
            this.Close();
        }

        private void AdminManage_Load(object sender, EventArgs e)
        {
            LoadCustomerGrid();
        }

        private void LoadCustomerGrid()
        {
            string query = @"SELECT user_id AS ""Customer ID"", full_name AS ""Full Name"", 
                            phone AS ""Phone"", address AS ""Address""
                     FROM users
                     ORDER BY user_id;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCustomer.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class OrderAuditItem { public string Id { get; set; } public decimal Price { get; set; } public string Status { get; set; } public string Category { get; set; } }

        private void ExecuteSystemAnalytics()
        {
       
            OrderLogger logAction = (info) => Console.WriteLine($"[ANALYTICS LINK]: {info}");
            PremiumTaxEngine taxCalc = (val) => val * 1.06m;

            logAction("Running data analysis sequence...");

            List<OrderAuditItem> dataset = new List<OrderAuditItem>
            {
                new OrderAuditItem { Id = "ORD-01", Price = 15.50m, Status = "Pending", Category = "Large" },
                new OrderAuditItem { Id = "ORD-02", Price = 24.00m, Status = "Completed", Category = "Medium" },
                new OrderAuditItem { Id = "ORD-03", Price = 8.00m, Status = "Pending", Category = "Small" },
                new OrderAuditItem { Id = "ORD-04", Price = 50.00m, Status = "In Progress", Category = "Large" }
            };

            
            var pendingOrders = dataset.Where(x => x.Status == "Pending").ToList();

            var pricesList = dataset.Select(x => x.Price).ToList();

            var sortedByPrice = dataset.OrderByDescending(x => x.Price).ToList();

            decimal collectiveRevenue = dataset.Sum(x => x.Price);

            decimal averageReceiptValue = dataset.Average(x => x.Price);

            int activeWorkloadCount = dataset.Count(x => x.Status == "In Progress");

            var groupedOutput = dataset.GroupBy(x => x.Category).ToList();

            bool containsHighValueOrders = dataset.Any(x => x.Price > 40.00m);

            logAction($"Analytics running state tracking indicator result: {containsHighValueOrders}");
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
            txtCustomerID.Text = row.Cells["Customer ID"].Value.ToString();
            txtFullName.Text = row.Cells["Full Name"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value != DBNull.Value ? row.Cells["Address"].Value.ToString() : "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().Replace("'", "''");

            if (dgvCustomer.DataSource is DataTable dt)
            {
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
                else
                {

                    dt.DefaultView.RowFilter = string.Format(
                        "Convert([Customer ID], 'System.String') LIKE '%{0}%' OR [Full Name] LIKE '%{0}%'",
                        filterText
                    );
                }
            }
        }


    }
}
