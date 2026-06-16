using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class Staff : Form
    {
        private Form _activeChildForm = null;
        public Staff()
        {
            InitializeComponent();
        }

        private void viewOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Regular);
            MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Regular);

            StaffUpdateStatus frm = new StaffUpdateStatus();
            frm.FormClosed += (s, args) =>
            {
                MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Regular);
                MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            };
            frm.Show();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            lblTodayDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Bold);
        }

        private void MenuViewOrders_Click(object sender, EventArgs e)
        {
            MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Regular);
            MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Regular);

            StaffViewOrder frm = new StaffViewOrder();
            //Buang bold jadi asal
            frm.FormClosed += (s, args) =>
            {
                //bila form tutup font dashboard bold semula
                MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Regular);
                MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Bold); // ← add this
            };
            frm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvRecentOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAllOr_Click(object sender, EventArgs e)
        {
            MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Regular);
            MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Regular);

            StaffViewOrder frm = new StaffViewOrder();

            frm.FormClosed += (s, args) =>
            {
                MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Regular);
                MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            };
            frm.Show();
        }

        private void btnUpdateOr_Click(object sender, EventArgs e)
        {
            MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            MenuViewOrders.Font = new Font(menustripStaff.Font, FontStyle.Regular);
            MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Regular);

            StaffUpdateStatus frm = new StaffUpdateStatus();
            frm.FormClosed += (s, args) =>
            {
                MenuUpdateStatus.Font = new Font(menustripStaff.Font, FontStyle.Regular);
                MenuDashboard.Font = new Font(menustripStaff.Font, FontStyle.Bold);
            };
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?","Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // close any open child form first
                if (_activeChildForm != null && !_activeChildForm.IsDisposed)
                {
                    _activeChildForm.Close();
                }

                //Bila ada login page tambah Login loginForm = new Login();
                //loginForm.Show();
                this.Close();
            }
        }
    }
}
