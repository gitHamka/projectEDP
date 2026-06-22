using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projectEDP
{
    public partial class StaffViewOrder : Form
    {
        public StaffViewOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StaffViewOrder_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("All Status");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Washing");
            cmbStatus.Items.Add("Drying");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Ready for Pickup");
            cmbStatus.SelectedIndex = 0;

            //LoadOrders("");
        }
    }
}
