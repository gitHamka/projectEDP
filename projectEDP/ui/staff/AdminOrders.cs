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
    public partial class AdminOrders : Form
    {
        public AdminOrders()
        {
            InitializeComponent();
        }

        private void AdminOrders_Load(object sender, EventArgs e)
        {
            LoadCustomers();       // Fills the ComboBox drop-down
            LoadServices();        // Fills the Service drop-down
            LoadCustomersGrid();   // Fills the DataGridView at the bottom

            // Attach dynamic real-time total price calculations
            txtQuantity.TextChanged += CalculateTotal;
            cmbServiceType.SelectedIndexChanged += CalculateTotal;
        }

        // 1. Populates Customer drop-down list from Supabase
        private void LoadCustomers()
        {
            string query = "SELECT customer_id, full_name FROM customers ORDER BY full_name ASC;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbCustomer.DataSource = dt;
                        cmbCustomer.DisplayMember = "full_name";
                        cmbCustomer.ValueMember = "customer_id";
                        cmbCustomer.SelectedIndex = -1; // Keep blank initially
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer dropdown: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Populates Service drop-down list from Supabase
        private void LoadServices()
        {
            string query = "SELECT service_id, service_name, price_per_unit FROM services ORDER BY service_name ASC;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbServiceType.DataSource = dt;
                        cmbServiceType.DisplayMember = "service_name";
                        cmbServiceType.ValueMember = "service_id";
                        cmbServiceType.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Dynamically calculates Total: Quantity * Service Price
        private void CalculateTotal(object sender, EventArgs e)
        {
            if (cmbServiceType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtTotal.Clear();
                return;
            }

            if (int.TryParse(txtQuantity.Text.Trim(), out int qty) && qty > 0)
            {
                DataRowView selectedService = (DataRowView)cmbServiceType.SelectedItem;
                decimal pricePerUnit = Convert.ToDecimal(selectedService["price_per_unit"]);

                decimal total = qty * pricePerUnit;
                txtTotal.Text = total.ToString("F2");
            }
            else
            {
                txtTotal.Text = "Invalid Qty";
            }
        }

        private void LoadCustomersGrid()
        {
            string query = @"SELECT customer_id AS ""Customer ID"", 
                            full_name AS ""Full Name"", 
                            phone AS ""Phone Number"" 
                     FROM customers 
                     ORDER BY full_name ASC;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCustomerList.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer list: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cmbCustomer.SelectedIndex = -1;
            cmbServiceType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtTotal.Clear();

            // Explicitly sets the UI label back to Pending
            lblStatus.Text = "Pending";
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1 || cmbServiceType.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTotal.Text) || txtTotal.Text == "Invalid Qty")
            {
                MessageBox.Show("Please fill out all fields with valid information.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string generatedOrderId = "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");

            string query = @"INSERT INTO orders (order_id, customer_id, service_id, quantity, total_price, status) 
                             VALUES (@orderId, @customerId, @serviceId, @qty, @totalPrice, 'Pending');";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", generatedOrderId);
                        cmd.Parameters.AddWithValue("@customerId", Convert.ToInt64(cmbCustomer.SelectedValue));
                        cmd.Parameters.AddWithValue("@serviceId", Convert.ToInt64(cmbServiceType.SelectedValue));
                        cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(txtQuantity.Text.Trim()));
                        cmd.Parameters.AddWithValue("@totalPrice", Convert.ToDecimal(txtTotal.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Order {generatedOrderId} processed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadCustomersGrid(); // Instantly refreshes your customer data grid 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Write Error: {ex.Message}", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // 1. Find the already open instance of Form1 to avoid duplicating it
            Form form1 = Application.OpenForms["Form1"];

            if (form1 != null)
            {
                form1.Show(); // Bring back the existing Form1
            }
            else
            {
                // Fallback: If Form1 was closed completely, create a new one
                Form1 newForm1 = new Form1();
                newForm1.Show();
            }

            // 2. Close this current AdminOrders form instead of hiding it to free up memory
            this.Close();
        }
    }


}
