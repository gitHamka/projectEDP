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
            this.Close();

        }

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderHistory historyForm = new OrderHistory(this.currentCustomerId);
            historyForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile profileForm = new UserProfile(this.currentCustomerId);
            profileForm.Show();
            this.Close();
        }

        private void UserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensures the application process terminates completely if the window is closed directly
            if (Application.OpenForms.Count == 0 || (Application.OpenForms.Count == 1 && Application.OpenForms[0] is Form1 == false))
            {
                Application.Exit();
            }
        }

    }
}
