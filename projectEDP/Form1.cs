using Npgsql;
using projectEDP.core.database;
using projectEDP.ui.staff;

namespace projectEDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminManage adminManageForm = new projectEDP.ui.staff.AdminManage();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminOrders adminManageForm = new projectEDP.ui.staff.AdminOrders();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminStatus adminManageForm = new projectEDP.ui.staff.AdminStatus();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void llCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Check if the text fields are empty
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Updated SQL query to retrieve both user_id and role matching the credentials
            string query = "SELECT user_id, role FROM users WHERE username = @username AND password = @password;";

            try
            {
                using (NpgsqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                        // 3. Use ExecuteReader to read multiple columns from the matching database row
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Extract columns from the row returned by Supabase
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string role = reader["role"].ToString().ToLower();

                                if (role == "customer")
                                {
                                    // 4. Pass the extracted userId directly into the AddOrder constructor
                                    AddOrder customerForm = new AddOrder(userId);
                                    customerForm.Show();
                                    this.Hide();
                                }
                                else if (role == "admin" || role == "staff")
                                {
                                    AdminStatus adminForm = new AdminStatus();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Unrecognized user role assigned to this account.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}