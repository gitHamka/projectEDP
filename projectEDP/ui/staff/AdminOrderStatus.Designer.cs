namespace projectEDP.ui.staff
{
    partial class AdminOrderStatus
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblPending = new Label();
            lblProgress = new Label();
            lblPickup = new Label();
            lblCompleted = new Label();
            dgvOvrdueOrder = new DataGridView();
            dgvActiveOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOvrdueOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvActiveOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 36);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Active Order By Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 135);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Pending";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 135);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "In Progress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(379, 135);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 3;
            label4.Text = "Ready for Pickup";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 135);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Completed Today";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 639);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Overdue Orders";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Location = new Point(75, 204);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(17, 20);
            lblPending.TabIndex = 6;
            lblPending.Text = "1";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(188, 204);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(17, 20);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "2";
            // 
            // lblPickup
            // 
            lblPickup.AutoSize = true;
            lblPickup.Location = new Point(388, 204);
            lblPickup.Name = "lblPickup";
            lblPickup.Size = new Size(17, 20);
            lblPickup.TabIndex = 8;
            lblPickup.Text = "3";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Location = new Point(534, 204);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(17, 20);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "4";
            lblCompleted.Click += lblCompleted_Click;
            // 
            // dgvOvrdueOrder
            // 
            dgvOvrdueOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOvrdueOrder.Location = new Point(21, 699);
            dgvOvrdueOrder.Name = "dgvOvrdueOrder";
            dgvOvrdueOrder.RowHeadersWidth = 51;
            dgvOvrdueOrder.Size = new Size(623, 188);
            dgvOvrdueOrder.TabIndex = 10;
            // 
            // dgvActiveOrder
            // 
            dgvActiveOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveOrder.Location = new Point(21, 318);
            dgvActiveOrder.Name = "dgvActiveOrder";
            dgvActiveOrder.RowHeadersWidth = 51;
            dgvActiveOrder.Size = new Size(623, 188);
            dgvActiveOrder.TabIndex = 11;
            // 
            // AdminOrderStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 953);
            Controls.Add(dgvActiveOrder);
            Controls.Add(dgvOvrdueOrder);
            Controls.Add(lblCompleted);
            Controls.Add(lblPickup);
            Controls.Add(lblProgress);
            Controls.Add(lblPending);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminOrderStatus";
            Text = "AdminOrderStatus";
            ((System.ComponentModel.ISupportInitialize)dgvOvrdueOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvActiveOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblPending;
        private Label lblProgress;
        private Label lblPickup;
        private Label lblCompleted;
        private DataGridView dgvOvrdueOrder;
        private DataGridView dgvActiveOrder;
    }
}