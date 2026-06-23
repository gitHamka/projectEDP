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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(207, 30);
            label1.Name = "label1";
            label1.Size = new Size(278, 34);
            label1.TabIndex = 0;
            label1.Text = "Admin Dashboard";
            // 
            // btnStatus
            // 
            btnStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStatus.Location = new Point(12, 170);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(658, 53);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "Update Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnManage
            // 
            btnManage.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManage.Location = new Point(12, 111);
            btnManage.Name = "btnManage";
            btnManage.Size = new Size(658, 53);
            btnManage.TabIndex = 2;
            btnManage.Text = "Manage Users";
            btnManage.UseVisualStyleBackColor = true;
            btnManage.Click += btnManage_Click;
            // 
            // lblTotalEarnings
            // 
            lblTotalEarnings.AutoSize = true;
            lblTotalEarnings.ForeColor = Color.White;
            lblTotalEarnings.Location = new Point(60, 296);
            lblTotalEarnings.Name = "lblTotalEarnings";
            lblTotalEarnings.Size = new Size(50, 20);
            lblTotalEarnings.TabIndex = 3;
            lblTotalEarnings.Text = "label2";
            // 
            // lblPendingOrders
            // 
            lblPendingOrders.AutoSize = true;
            lblPendingOrders.ForeColor = Color.White;
            lblPendingOrders.Location = new Point(315, 296);
            lblPendingOrders.Name = "lblPendingOrders";
            lblPendingOrders.Size = new Size(50, 20);
            lblPendingOrders.TabIndex = 4;
            lblPendingOrders.Text = "label3";
            // 
            // lblCompletedOrders
            // 
            lblCompletedOrders.AutoSize = true;
            lblCompletedOrders.ForeColor = Color.White;
            lblCompletedOrders.Location = new Point(566, 296);
            lblCompletedOrders.Name = "lblCompletedOrders";
            lblCompletedOrders.Size = new Size(50, 20);
            lblCompletedOrders.TabIndex = 5;
            lblCompletedOrders.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(37, 246);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 6;
            label5.Text = "Total Revenue";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(287, 246);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 7;
            label6.Text = "Pending Orders";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(521, 246);
            label7.Name = "label7";
            label7.Size = new Size(131, 20);
            label7.TabIndex = 8;
            label7.Text = "Completed Orders";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 347);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblCompletedOrders);
            Controls.Add(lblPendingOrders);
            Controls.Add(lblTotalEarnings);
            Controls.Add(btnManage);
            Controls.Add(btnStatus);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load_1;
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
    }
}