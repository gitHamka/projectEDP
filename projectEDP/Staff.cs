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
        public Staff()
        {
            InitializeComponent();
        }

        private void viewOToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            PnlUpdateStatus.BringToFront();
        }
        
            
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            PnlViewOrder.BringToFront();
        }

        private void MenuViewOrders_Click(object sender, EventArgs e)
        {
            PnlViewOrder.BringToFront();
        }
    }
}
