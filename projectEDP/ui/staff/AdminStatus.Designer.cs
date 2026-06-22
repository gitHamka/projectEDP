namespace projectEDP.ui.staff
{
    partial class AdminStatus
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
            label8 = new Label();
            txtSearchOrderID = new TextBox();
            txtCustomerName = new TextBox();
            txtServiceType = new TextBox();
            cmbNewStatus = new ComboBox();
            txtNotes = new TextBox();
            btnUpdateStatus = new Button();
            btnClearStatus = new Button();
            txtCurrentStatus = new TextBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblCompletedCount = new Label();
            lblReadyCount = new Label();
            lblInProgressCount = new Label();
            lblPendingCount = new Label();
            dgvActiveOrders = new DataGridView();
            dgvOverdueOrders = new DataGridView();
            btnHome = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActiveOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOverdueOrders).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 0;
            label1.Text = "Order status mangement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 184);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 263);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(350, 263);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Service Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "Current Status";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(350, 328);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 5;
            label6.Text = "Update status to";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 398);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 7;
            label8.Text = "Note";
            // 
            // txtSearchOrderID
            // 
            txtSearchOrderID.Location = new Point(12, 207);
            txtSearchOrderID.Multiline = true;
            txtSearchOrderID.Name = "txtSearchOrderID";
            txtSearchOrderID.Size = new Size(658, 34);
            txtSearchOrderID.TabIndex = 8;
            txtSearchOrderID.Leave += txtSearchOrderID_Leave;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 286);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(321, 27);
            txtCustomerName.TabIndex = 9;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(350, 286);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.ReadOnly = true;
            txtServiceType.Size = new Size(320, 27);
            txtServiceType.TabIndex = 10;
            // 
            // cmbNewStatus
            // 
            cmbNewStatus.FormattingEnabled = true;
            cmbNewStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Ready for Pickup", "Completed" });
            cmbNewStatus.Location = new Point(350, 351);
            cmbNewStatus.Name = "cmbNewStatus";
            cmbNewStatus.Size = new Size(320, 28);
            cmbNewStatus.TabIndex = 12;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(12, 421);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(657, 89);
            txtNotes.TabIndex = 13;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(12, 516);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(332, 29);
            btnUpdateStatus.TabIndex = 14;
            btnUpdateStatus.Text = "Update status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnClearStatus
            // 
            btnClearStatus.Location = new Point(350, 516);
            btnClearStatus.Name = "btnClearStatus";
            btnClearStatus.Size = new Size(319, 29);
            btnClearStatus.TabIndex = 15;
            btnClearStatus.Text = "Clear";
            btnClearStatus.UseVisualStyleBackColor = true;
            btnClearStatus.Click += btnClearStatus_Click;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.Location = new Point(12, 351);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.ReadOnly = true;
            txtCurrentStatus.Size = new Size(321, 27);
            txtCurrentStatus.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(39, 12);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 17;
            label7.Text = "In Progress";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 12);
            label9.Name = "label9";
            label9.Size = new Size(120, 20);
            label9.TabIndex = 18;
            label9.Text = "Ready for Pickup";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(34, 12);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 19;
            label10.Text = "Completed";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(39, 12);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 20;
            label11.Text = "Pending";
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.ForeColor = Color.White;
            lblCompletedCount.Location = new Point(54, 49);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(42, 20);
            lblCompletedCount.TabIndex = 21;
            lblCompletedCount.Text = "Note";
            // 
            // lblReadyCount
            // 
            lblReadyCount.AutoSize = true;
            lblReadyCount.ForeColor = Color.White;
            lblReadyCount.Location = new Point(51, 49);
            lblReadyCount.Name = "lblReadyCount";
            lblReadyCount.Size = new Size(42, 20);
            lblReadyCount.TabIndex = 22;
            lblReadyCount.Text = "Note";
            // 
            // lblInProgressCount
            // 
            lblInProgressCount.AutoSize = true;
            lblInProgressCount.ForeColor = Color.White;
            lblInProgressCount.Location = new Point(56, 49);
            lblInProgressCount.Name = "lblInProgressCount";
            lblInProgressCount.Size = new Size(42, 20);
            lblInProgressCount.TabIndex = 23;
            lblInProgressCount.Text = "Note";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.ForeColor = Color.White;
            lblPendingCount.Location = new Point(48, 49);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(42, 20);
            lblPendingCount.TabIndex = 24;
            lblPendingCount.Text = "Note";
            // 
            // dgvActiveOrders
            // 
            dgvActiveOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActiveOrders.BackgroundColor = SystemColors.MenuHighlight;
            dgvActiveOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActiveOrders.Location = new Point(12, 46);
            dgvActiveOrders.Name = "dgvActiveOrders";
            dgvActiveOrders.RowHeadersWidth = 51;
            dgvActiveOrders.Size = new Size(658, 108);
            dgvActiveOrders.TabIndex = 25;
            // 
            // dgvOverdueOrders
            // 
            dgvOverdueOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOverdueOrders.BackgroundColor = SystemColors.MenuHighlight;
            dgvOverdueOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOverdueOrders.Location = new Point(12, 727);
            dgvOverdueOrders.Name = "dgvOverdueOrders";
            dgvOverdueOrders.RowHeadersWidth = 51;
            dgvOverdueOrders.Size = new Size(658, 108);
            dgvOverdueOrders.TabIndex = 26;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 841);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(657, 29);
            btnHome.TabIndex = 27;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblPendingCount);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(12, 578);
            panel1.Name = "panel1";
            panel1.Size = new Size(151, 85);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblInProgressCount);
            panel2.Location = new Point(182, 578);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 85);
            panel2.TabIndex = 29;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.MenuHighlight;
            panel3.Controls.Add(label9);
            panel3.Controls.Add(lblReadyCount);
            panel3.Location = new Point(350, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(151, 85);
            panel3.TabIndex = 30;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.MenuHighlight;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(lblCompletedCount);
            panel4.Location = new Point(518, 578);
            panel4.Name = "panel4";
            panel4.Size = new Size(151, 85);
            panel4.TabIndex = 30;
            panel4.Paint += panel4_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(12, 704);
            label12.Name = "label12";
            label12.Size = new Size(113, 20);
            label12.TabIndex = 25;
            label12.Text = "Overdue Orders";
            // 
            // AdminStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 882);
            Controls.Add(label12);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnHome);
            Controls.Add(dgvOverdueOrders);
            Controls.Add(dgvActiveOrders);
            Controls.Add(txtCurrentStatus);
            Controls.Add(btnClearStatus);
            Controls.Add(btnUpdateStatus);
            Controls.Add(txtNotes);
            Controls.Add(cmbNewStatus);
            Controls.Add(txtServiceType);
            Controls.Add(txtCustomerName);
            Controls.Add(txtSearchOrderID);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminStatus";
            Text = "AdminStatus";
            Load += AdminStatus_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActiveOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOverdueOrders).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label8;
        private TextBox txtSearchOrderID;
        private TextBox txtCustomerName;
        private TextBox txtServiceType;
        private ComboBox cmbNewStatus;
        private TextBox txtNotes;
        private Button btnUpdateStatus;
        private Button btnClearStatus;
        private TextBox txtCurrentStatus;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblCompletedCount;
        private Label lblReadyCount;
        private Label lblInProgressCount;
        private Label lblPendingCount;
        private DataGridView dgvActiveOrders;
        private DataGridView dgvOverdueOrders;
        private Button btnHome;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label12;
    }
}