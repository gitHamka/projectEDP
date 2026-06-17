using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectEDP
{
    public partial class StaffUpdateStatus : Form
    {
        public StaffUpdateStatus()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtboxSearch.Clear();

            cmbStatus.SelectedIndex = 0;

            rbCompleted.Checked = false;
            rbDrying.Checked = false;
            rbPending.Checked = false;
            rbPickup.Checked = false;
            rbWashing.Checked = false;

            txtboxSearch.Focus();
        }

        private void StaffUpdateStatus_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
        }
    }
}
