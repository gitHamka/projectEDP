namespace projectEDP
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuViewOrders = new ToolStripMenuItem();
            MenuUpdateStatus = new ToolStripMenuItem();
            PnlViewOrder = new Panel();
            label1 = new Label();
            lblTOrder = new Label();
            dgvOrderList = new DataGridView();
            lblViewOrder = new Label();
            PnlUpdateStatus = new Panel();
            lblUpdateStatus = new Label();
            menuStrip1.SuspendLayout();
            PnlViewOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            PnlUpdateStatus.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuViewOrders, MenuUpdateStatus });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1168, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuViewOrders
            // 
            MenuViewOrders.Name = "MenuViewOrders";
            MenuViewOrders.Size = new Size(103, 24);
            MenuViewOrders.Text = "View Orders";
            MenuViewOrders.Click += MenuViewOrders_Click;
            // 
            // MenuUpdateStatus
            // 
            MenuUpdateStatus.Name = "MenuUpdateStatus";
            MenuUpdateStatus.Size = new Size(116, 24);
            MenuUpdateStatus.Text = "Update Status";
            MenuUpdateStatus.Click += viewOToolStripMenuItem_Click;
            // 
            // PnlViewOrder
            // 
            PnlViewOrder.Controls.Add(label1);
            PnlViewOrder.Controls.Add(lblTOrder);
            PnlViewOrder.Controls.Add(dgvOrderList);
            PnlViewOrder.Controls.Add(lblViewOrder);
            PnlViewOrder.Controls.Add(PnlUpdateStatus);
            PnlViewOrder.Dock = DockStyle.Fill;
            PnlViewOrder.Location = new Point(0, 28);
            PnlViewOrder.Name = "PnlViewOrder";
            PnlViewOrder.Size = new Size(1168, 552);
            PnlViewOrder.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 415);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 3;
            // 
            // lblTOrder
            // 
            lblTOrder.AutoSize = true;
            lblTOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTOrder.Location = new Point(42, 415);
            lblTOrder.Name = "lblTOrder";
            lblTOrder.Size = new Size(114, 28);
            lblTOrder.TabIndex = 2;
            lblTOrder.Text = "Total Order:";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(144, 64);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(874, 310);
            dgvOrderList.TabIndex = 1;
            // 
            // lblViewOrder
            // 
            lblViewOrder.AutoSize = true;
            lblViewOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewOrder.Location = new Point(524, 17);
            lblViewOrder.Name = "lblViewOrder";
            lblViewOrder.Size = new Size(127, 28);
            lblViewOrder.TabIndex = 0;
            lblViewOrder.Text = "View Orders";
            lblViewOrder.Click += label1_Click;
            // 
            // PnlUpdateStatus
            // 
            PnlUpdateStatus.Controls.Add(lblUpdateStatus);
            PnlUpdateStatus.Dock = DockStyle.Fill;
            PnlUpdateStatus.Location = new Point(0, 0);
            PnlUpdateStatus.Name = "PnlUpdateStatus";
            PnlUpdateStatus.Size = new Size(1168, 552);
            PnlUpdateStatus.TabIndex = 4;
            // 
            // lblUpdateStatus
            // 
            lblUpdateStatus.AutoSize = true;
            lblUpdateStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateStatus.Location = new Point(506, 17);
            lblUpdateStatus.Name = "lblUpdateStatus";
            lblUpdateStatus.Size = new Size(145, 28);
            lblUpdateStatus.TabIndex = 1;
            lblUpdateStatus.Text = "Update Status";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 580);
            Controls.Add(PnlViewOrder);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            PnlViewOrder.ResumeLayout(false);
            PnlViewOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            PnlUpdateStatus.ResumeLayout(false);
            PnlUpdateStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuViewOrders;
        private ToolStripMenuItem MenuUpdateStatus;
        private Panel PnlViewOrder;
        private Label lblViewOrder;
        private Label lblTOrder;
        private DataGridView dgvOrderList;
        private Label label1;
        private Panel PnlUpdateStatus;
        private Label lblUpdateStatus;
    }
}