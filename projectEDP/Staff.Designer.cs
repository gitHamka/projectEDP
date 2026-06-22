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
            menustripStaff = new MenuStrip();
            MenuDashboard = new ToolStripMenuItem();
            MenuViewOrders = new ToolStripMenuItem();
            MenuUpdateStatus = new ToolStripMenuItem();
            lblWelcome = new Label();
            lblSummary = new Label();
            lblTodayDate = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnlTotalOrderToday = new Panel();
            lblJumlahOrder = new Label();
            lblTodalOrT = new Label();
            pnlPending = new Panel();
            lblBelum = new Label();
            lblPend = new Label();
            pnlCompleted = new Panel();
            lblSudah = new Label();
            lblComp = new Label();
            dgvRecentOrder = new DataGridView();
            lblRecentOrders = new Label();
            lblQuick = new Label();
            btnViewAllOr = new Button();
            btnUpdateOr = new Button();
            btnLogout = new Button();
            menustripStaff.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlTotalOrderToday.SuspendLayout();
            pnlPending.SuspendLayout();
            pnlCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrder).BeginInit();
            SuspendLayout();
            // 
            // menustripStaff
            // 
            menustripStaff.ImageScalingSize = new Size(20, 20);
            menustripStaff.Items.AddRange(new ToolStripItem[] { MenuDashboard, MenuViewOrders, MenuUpdateStatus });
            menustripStaff.Location = new Point(0, 0);
            menustripStaff.Name = "menustripStaff";
            menustripStaff.Size = new Size(1168, 28);
            menustripStaff.TabIndex = 0;
            menustripStaff.Text = "menuStrip1";
            // 
            // MenuDashboard
            // 
            MenuDashboard.Name = "MenuDashboard";
            MenuDashboard.Size = new Size(96, 24);
            MenuDashboard.Text = "Dashboard";
            MenuDashboard.Click += MenuDashboard_Click;
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
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(54, 61);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(278, 38);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Good morning, Staff";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(60, 99);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(304, 28);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Here's today's laundry summary -";
            // 
            // lblTodayDate
            // 
            lblTodayDate.AutoSize = true;
            lblTodayDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodayDate.Location = new Point(355, 99);
            lblTodayDate.Name = "lblTodayDate";
            lblTodayDate.Size = new Size(0, 28);
            lblTodayDate.TabIndex = 3;
            lblTodayDate.Click += label1_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(148, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 120);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pnlTotalOrderToday);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 120);
            panel2.TabIndex = 5;
            // 
            // pnlTotalOrderToday
            // 
            pnlTotalOrderToday.BackColor = Color.MistyRose;
            pnlTotalOrderToday.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalOrderToday.Controls.Add(lblJumlahOrder);
            pnlTotalOrderToday.Controls.Add(lblTodalOrT);
            pnlTotalOrderToday.Location = new Point(-1, -1);
            pnlTotalOrderToday.Name = "pnlTotalOrderToday";
            pnlTotalOrderToday.Size = new Size(274, 120);
            pnlTotalOrderToday.TabIndex = 5;
            // 
            // lblJumlahOrder
            // 
            lblJumlahOrder.AutoSize = true;
            lblJumlahOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahOrder.Location = new Point(120, 57);
            lblJumlahOrder.Name = "lblJumlahOrder";
            lblJumlahOrder.Size = new Size(31, 28);
            lblJumlahOrder.TabIndex = 9;
            lblJumlahOrder.Text = "15";
            lblJumlahOrder.Click += label2_Click;
            // 
            // lblTodalOrT
            // 
            lblTodalOrT.AutoSize = true;
            lblTodalOrT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodalOrT.Location = new Point(52, 11);
            lblTodalOrT.Name = "lblTodalOrT";
            lblTodalOrT.Size = new Size(167, 28);
            lblTodalOrT.TabIndex = 8;
            lblTodalOrT.Text = "Total Order Today";
            // 
            // pnlPending
            // 
            pnlPending.BackColor = Color.FromArgb(255, 255, 192);
            pnlPending.BorderStyle = BorderStyle.FixedSingle;
            pnlPending.Controls.Add(lblBelum);
            pnlPending.Controls.Add(lblPend);
            pnlPending.Location = new Point(449, 163);
            pnlPending.Name = "pnlPending";
            pnlPending.Size = new Size(274, 120);
            pnlPending.TabIndex = 6;
            // 
            // lblBelum
            // 
            lblBelum.AutoSize = true;
            lblBelum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBelum.Location = new Point(124, 57);
            lblBelum.Name = "lblBelum";
            lblBelum.Size = new Size(24, 28);
            lblBelum.TabIndex = 10;
            lblBelum.Text = "4";
            // 
            // lblPend
            // 
            lblPend.AutoSize = true;
            lblPend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPend.Location = new Point(96, 11);
            lblPend.Name = "lblPend";
            lblPend.Size = new Size(83, 28);
            lblPend.TabIndex = 9;
            lblPend.Text = "Pending";
            // 
            // pnlCompleted
            // 
            pnlCompleted.BackColor = Color.FromArgb(192, 255, 192);
            pnlCompleted.BorderStyle = BorderStyle.FixedSingle;
            pnlCompleted.Controls.Add(lblSudah);
            pnlCompleted.Controls.Add(lblComp);
            pnlCompleted.Location = new Point(746, 163);
            pnlCompleted.Name = "pnlCompleted";
            pnlCompleted.Size = new Size(274, 120);
            pnlCompleted.TabIndex = 7;
            // 
            // lblSudah
            // 
            lblSudah.AutoSize = true;
            lblSudah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSudah.Location = new Point(123, 57);
            lblSudah.Name = "lblSudah";
            lblSudah.Size = new Size(31, 28);
            lblSudah.TabIndex = 11;
            lblSudah.Text = "12";
            // 
            // lblComp
            // 
            lblComp.AutoSize = true;
            lblComp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComp.Location = new Point(81, 11);
            lblComp.Name = "lblComp";
            lblComp.Size = new Size(109, 28);
            lblComp.TabIndex = 10;
            lblComp.Text = "Completed";
            // 
            // dgvRecentOrder
            // 
            dgvRecentOrder.AllowUserToAddRows = false;
            dgvRecentOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentOrder.Location = new Point(148, 341);
            dgvRecentOrder.Name = "dgvRecentOrder";
            dgvRecentOrder.ReadOnly = true;
            dgvRecentOrder.RowHeadersWidth = 51;
            dgvRecentOrder.Size = new Size(450, 188);
            dgvRecentOrder.TabIndex = 8;
            dgvRecentOrder.CellContentClick += dgvRecentOrder_CellContentClick;
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentOrders.Location = new Point(142, 310);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(134, 28);
            lblRecentOrders.TabIndex = 9;
            lblRecentOrders.Text = "Recent Orders";
            // 
            // lblQuick
            // 
            lblQuick.AutoSize = true;
            lblQuick.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuick.Location = new Point(782, 310);
            lblQuick.Name = "lblQuick";
            lblQuick.Size = new Size(132, 28);
            lblQuick.TabIndex = 10;
            lblQuick.Text = "Quick Actions";
            // 
            // btnViewAllOr
            // 
            btnViewAllOr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewAllOr.Location = new Point(782, 341);
            btnViewAllOr.Name = "btnViewAllOr";
            btnViewAllOr.Size = new Size(238, 54);
            btnViewAllOr.TabIndex = 11;
            btnViewAllOr.Text = "View all orders";
            btnViewAllOr.UseVisualStyleBackColor = true;
            btnViewAllOr.Click += btnViewAllOr_Click;
            // 
            // btnUpdateOr
            // 
            btnUpdateOr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdateOr.Location = new Point(782, 401);
            btnUpdateOr.Name = "btnUpdateOr";
            btnUpdateOr.Size = new Size(238, 54);
            btnUpdateOr.TabIndex = 12;
            btnUpdateOr.Text = "Update Order Status";
            btnUpdateOr.UseVisualStyleBackColor = true;
            btnUpdateOr.Click += btnUpdateOr_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(782, 461);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(238, 54);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1168, 580);
            Controls.Add(btnLogout);
            Controls.Add(btnUpdateOr);
            Controls.Add(btnViewAllOr);
            Controls.Add(lblQuick);
            Controls.Add(lblRecentOrders);
            Controls.Add(dgvRecentOrder);
            Controls.Add(pnlCompleted);
            Controls.Add(pnlPending);
            Controls.Add(panel1);
            Controls.Add(lblTodayDate);
            Controls.Add(lblSummary);
            Controls.Add(lblWelcome);
            Controls.Add(menustripStaff);
            MainMenuStrip = menustripStaff;
            Name = "Staff";
            Text = "Staff Main";
            Load += Staff_Load;
            menustripStaff.ResumeLayout(false);
            menustripStaff.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlTotalOrderToday.ResumeLayout(false);
            pnlTotalOrderToday.PerformLayout();
            pnlPending.ResumeLayout(false);
            pnlPending.PerformLayout();
            pnlCompleted.ResumeLayout(false);
            pnlCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menustripStaff;
        private ToolStripMenuItem MenuViewOrders;
        private ToolStripMenuItem MenuUpdateStatus;
        private Label lblWelcome;
        private Label lblSummary;
        private Label lblTodayDate;
        private Panel panel1;
        private Panel panel2;
        private Panel pnlTotalOrderToday;
        private Panel pnlPending;
        private Label lblTodalOrT;
        private Label lblPend;
        private Panel pnlCompleted;
        private Label lblComp;
        private Label lblJumlahOrder;
        private Label lblBelum;
        private Label lblSudah;
        private DataGridView dgvRecentOrder;
        private Label lblRecentOrders;
        private Label lblQuick;
        private Button btnViewAllOr;
        private ToolStripMenuItem MenuDashboard;
        private Button btnUpdateOr;
        private Button btnLogout;
    }
}