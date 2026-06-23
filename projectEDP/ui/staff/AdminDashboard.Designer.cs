namespace projectEDP.ui.staff
{
    partial class AdminDashboard
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
            label1 = new Label();
            btnStatus = new Button();
            btnManage = new Button();
            lblTotalEarnings = new Label();
            lblPendingOrders = new Label();
            lblCompletedOrders = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(227, 56);
            label1.Name = "label1";
            label1.Size = new Size(278, 34);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // btnStatus
            // 
            btnStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatus.Location = new Point(99, 167);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(530, 48);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Update Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManage.Location = new Point(99, 108);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(530, 48);
            btnManage.TabIndex = 2;
            btnManage.Text = "Manage Users";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // lblTotalEarnings
            // 
            lblTotalEarnings.AutoSize = true;
            lblTotalEarnings.Font = new Font("Arial Rounded MT Bold", 12F);
            lblTotalEarnings.ForeColor = Color.White;
            lblTotalEarnings.Location = new Point(64, 296);
            lblTotalEarnings.Name = "lblTotalEarnings";
            lblTotalEarnings.Size = new Size(69, 23);
            lblTotalEarnings.TabIndex = 3;
            lblTotalEarnings.Text = "label1";
            lblTotalEarnings.Click += lblTotalEarnings_Click;
            // 
            // lblPendingOrders
            // 
            lblPendingOrders.AutoSize = true;
            lblPendingOrders.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPendingOrders.ForeColor = Color.White;
            lblPendingOrders.Location = new Point(329, 296);
            lblPendingOrders.Name = "lblPendingOrders";
            lblPendingOrders.Size = new Size(69, 23);
            lblPendingOrders.TabIndex = 4;
            lblPendingOrders.Text = "label3";
            // 
            // lblCompletedOrders
            // 
            lblCompletedOrders.AutoSize = true;
            lblCompletedOrders.Font = new Font("Arial Rounded MT Bold", 12F);
            lblCompletedOrders.ForeColor = Color.White;
            lblCompletedOrders.Location = new Point(578, 296);
            lblCompletedOrders.Name = "lblCompletedOrders";
            lblCompletedOrders.Size = new Size(69, 23);
            lblCompletedOrders.TabIndex = 5;
            lblCompletedOrders.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 246);
            label5.Name = "label5";
            label5.Size = new Size(149, 23);
            label5.TabIndex = 6;
            label5.Text = "Total Revenue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(279, 246);
            label6.Name = "label6";
            label6.Size = new Size(165, 23);
            label6.TabIndex = 7;
            label6.Text = "Pending Orders";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(513, 246);
            label7.Name = "label7";
            label7.Size = new Size(192, 23);
            label7.TabIndex = 8;
            label7.Text = "Completed Orders";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(619, 361);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(725, 402);
            Controls.Add(btnLogout);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblCompletedOrders);
            Controls.Add(lblPendingOrders);
            Controls.Add(lblTotalEarnings);
            Controls.Add(btnManage);
            Controls.Add(btnStatus);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStatus;
        private Button btnManage;
        private Label lblTotalEarnings;
        private Label lblPendingOrders;
        private Label lblCompletedOrders;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnLogout;
    }
}