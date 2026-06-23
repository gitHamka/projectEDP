using Npgsql;
using projectEDP.core.database;
using projectEDP.ui.staff;
using projectEDP.ui.user;

namespace projectEDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(this, new EventArgs());
            }
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
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string role = reader["role"].ToString().ToLower();

                                if (role == "customer")
                                {
                                    UserDashboard dashboardForm = new UserDashboard(userId);
                                    dashboardForm.Show();
                                    this.Hide();
                                }
                                else if (role == "admin" || role == "staff")
                                {
                                    AdminDashboard adminForm = new AdminDashboard();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}