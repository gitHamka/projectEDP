using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Make sure this is added at the very top of your file
using projectEDP.core.database; // References your DatabaseHelper namespace


namespace projectEDP.ui.staff
{
    public partial class AdminManage : Form
    {
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
                ? "UPDATE customers SET full_name = @name, phone = @phone, address = @address WHERE customer_id = @id;"
                : "INSERT INTO customers (full_name, phone, address) VALUES (@name, @phone, @address);";

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
            // Clear the text from all input controls
            txtFullName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            // Optional: Clear Customer ID if you are displaying it
            txtCustomerID.Clear();

            // Move the blinking cursor back to the first field for convenience
            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Check if Customer ID is provided
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Please enter a Customer ID to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask for staff confirmation before destroying data
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Customer ID {txtCustomerID.Text}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM customers WHERE customer_id = @id;";

                try
                {
                    using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                        {
                            // Convert ID text to number to match database BIGINT
                            cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtCustomerID.Text.Trim()));

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer profile deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields(); // Reset fields using your clear method
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
            // 1. Skip if the field is empty
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text)) return;

            // 2. Validate that the input is actually a valid number
            if (!long.TryParse(txtCustomerID.Text.Trim(), out long customerId))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Clear();
                return;
            }

            // 3. SQL Select query to fetch matching customer details
            string query = "SELECT full_name, phone, address FROM customers WHERE customer_id = @id;";

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
                                // 4. Record found: Populate the fields
                                txtFullName.Text = reader["full_name"].ToString();
                                txtPhone.Text = reader["phone"].ToString();
                                txtAddress.Text = reader["address"] != DBNull.Value ? reader["address"].ToString() : "";
                            }
                            else
                            {
                                // 5. Record not found: Clear fields except the ID so they can create a new record
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
