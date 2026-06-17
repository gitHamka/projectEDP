namespace projectEDP
{
    partial class StaffViewOrder
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
            dgvOrderList = new DataGridView();
            lblViewOrder = new Label();
            btnBack = new Button();
            txtboxSearch = new TextBox();
            lblSearch = new Label();
            cmbStatus = new ComboBox();
            btnRefresh = new Button();
            lblTotalOrder = new Label();
            lblJumlahOrder = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 500);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 7;
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(123, 177);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.Size = new Size(874, 310);
            dgvOrderList.TabIndex = 5;
            // 
            // lblViewOrder
            // 
            lblViewOrder.AutoSize = true;
            lblViewOrder.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewOrder.Location = new Point(123, 54);
            lblViewOrder.Name = "lblViewOrder";
            lblViewOrder.Size = new Size(171, 38);
            lblViewOrder.TabIndex = 4;
            lblViewOrder.Text = "View Orders";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 548);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(57, 33);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(203, 126);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.PlaceholderText = "Enter OrderID/Name";
            txtboxSearch.Size = new Size(243, 34);
            txtboxSearch.TabIndex = 9;
            txtboxSearch.TextChanged += txtboxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(123, 129);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 10;
            lblSearch.Text = "Search:";
            // 
            // cmbStatus
            // 
            cmbStatus.AllowDrop = true;
            cmbStatus.DisplayMember = "(none)";
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All Status", "Pending", "Washing", "Drying", "Completed", "Ready for pickup" });
            cmbStatus.Location = new Point(462, 126);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(349, 36);
            cmbStatus.TabIndex = 11;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(847, 120);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 46);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblTotalOrder
            // 
            lblTotalOrder.AutoSize = true;
            lblTotalOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalOrder.Location = new Point(847, 490);
            lblTotalOrder.Name = "lblTotalOrder";
            lblTotalOrder.Size = new Size(114, 28);
            lblTotalOrder.TabIndex = 13;
            lblTotalOrder.Text = "Total Order:";
            // 
            // lblJumlahOrder
            // 
            lblJumlahOrder.AutoSize = true;
            lblJumlahOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJumlahOrder.Location = new Point(963, 490);
            lblJumlahOrder.Name = "lblJumlahOrder";
            lblJumlahOrder.Size = new Size(34, 28);
            lblJumlahOrder.TabIndex = 14;
            lblJumlahOrder.Text = "25";
            // 
            // StaffViewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1130, 593);
            Controls.Add(lblJumlahOrder);
            Controls.Add(lblTotalOrder);
            Controls.Add(btnRefresh);
            Controls.Add(cmbStatus);
            Controls.Add(lblSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvOrderList);
            Controls.Add(lblViewOrder);
            Name = "StaffViewOrder";
            Text = "Staff View Order";
            Load += StaffViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOrderList;
        private Label lblViewOrder;
        private Button btnBack;
        private TextBox txtboxSearch;
        private Label lblSearch;
        private ComboBox cmbStatus;
        private Button btnRefresh;
        private Label lblTotalOrder;
        private Label lblJumlahOrder;
    }
}