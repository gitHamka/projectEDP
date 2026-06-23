using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using projectEDP.core.database;

namespace projectEDP.ui.staff
{
    public partial class AdminStatus : Form
    {
        public AdminStatus()
        {
            InitializeComponent();
        }

        private void AdminStatus_Load(object sender, EventArgs e)
        {
            RefreshDashboard();
        }

        private void RefreshDashboard()
        {
            LoadStatusCounters();
            LoadActiveOrdersGrid();
            LoadOverdueOrdersGrid();
        }

        private void LoadStatusCounters()
        {
            string query = @"SELECT 
                        COUNT(CASE WHEN status = 'Pending' THEN 1 END) as pending,
                        COUNT(CASE WHEN status = 'In Progress' THEN 1 END) as progress,
                        COUNT(CASE WHEN status = 'Ready for Pickup' THEN 1 END) as ready,
                        COUNT(CASE WHEN status = 'Completed' AND date_in::date = CURRENT_DATE THEN 1 END) as completed
                     FROM orders;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblPendingCount.Text = reader["pending"].ToString();
                            lblInProgressCount.Text = reader["progress"].ToString();
                            lblReadyCount.Text = reader["ready"].ToString();
                            lblCompletedCount.Text = reader["completed"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Counter Error: {ex.Message}");
            }
        }

        private void LoadActiveOrdersGrid()
        {
            string query = @"SELECT o.order_id AS ""Order ID"", u.full_name AS ""Customer"", 
                                    o.services AS ""Service"", o.status AS ""Status"", 
                                    o.date_in AS ""Date In""
                             FROM orders o
                             JOIN users u ON o.customer_id = u.user_id
                             WHERE o.status != 'Completed'
                             ORDER BY o.date_in DESC;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvActiveOrders.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Grid Error: {ex.Message}");
            }
        }

        private void LoadOverdueOrdersGrid()
        {
            string query = @"SELECT o.order_id AS ""Order ID"", u.full_name AS ""Customer"", 
                                    (CURRENT_DATE - o.date_in::date) AS ""Days Overdue""
                             FROM orders o
                             JOIN users u ON o.customer_id = u.user_id
                             WHERE o.status NOT IN ('Completed', 'Ready for pickup') 
                               AND (CURRENT_DATE - o.date_in::date) >= 1
                             ORDER BY ""Days Overdue"" DESC;";
            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Overdue Error: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            txtSearchOrderID.Clear();
            txtCustomerName.Clear();
            txtServiceType.Clear();
            txtCurrentStatus.Clear();
            txtNotes.Clear();
            cmbNewStatus.SelectedIndex = -1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchOrderID.Text))
            {
                MessageBox.Show("Please load a valid Order ID first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbNewStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a new status from the dropdown list to apply.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string finalStatus = cmbNewStatus.SelectedItem.ToString();
            string query = @"UPDATE orders 
                             SET status = @status, notes = @notes 
                             WHERE order_id = @orderId;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", finalStatus);
                        cmd.Parameters.AddWithValue("@notes", string.IsNullOrWhiteSpace(txtNotes.Text) ? (object)DBNull.Value : txtNotes.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderId", txtSearchOrderID.Text.Trim());

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show($"Order status updated to '{finalStatus}' successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            RefreshDashboard();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearStatus_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSearchOrderID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchOrderID.Text)) return;
 
            string query = @"SELECT u.full_name, o.services, o.status, o.notes 
                             FROM orders o
                             JOIN users u ON o.customer_id = u.user_id
                             WHERE o.order_id = @orderId;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderId", txtSearchOrderID.Text.Trim());

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCustomerName.Text = reader["full_name"].ToString();
                                txtServiceType.Text = reader["services"].ToString();
                                txtCurrentStatus.Text = reader["status"].ToString();
                                txtNotes.Text = reader["notes"] != DBNull.Value ? reader["notes"].ToString() : "";
                                cmbNewStatus.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Order ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearFields();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel1.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel1.Width - cornerRadius, panel1.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel1.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            panel1.Region = new System.Drawing.Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel2.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel2.Width - cornerRadius, panel2.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel2.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            panel2.Region = new System.Drawing.Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel3.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel3.Width - cornerRadius, panel3.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel3.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            panel3.Region = new System.Drawing.Region(path);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel4.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel4.Width - cornerRadius, panel4.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel4.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseAllFigures();

            panel4.Region = new System.Drawing.Region(path);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblInProgressCount_Click(object sender, EventArgs e)
        {

        }
    }
}
