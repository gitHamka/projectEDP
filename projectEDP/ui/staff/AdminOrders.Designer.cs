namespace projectEDP.ui.staff
{
    partial class AdminOrders
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
            btnCreateOrder = new Button();
            btnClearOrder = new Button();
            cmbCustomer = new ComboBox();
            cmbServiceType = new ComboBox();
            txtQuantity = new TextBox();
            dgvCustomerList = new DataGridView();
            txtTotal = new TextBox();
            lblStatus = new Label();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Order Entry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 62);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Select Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 135);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Service Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 218);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 299);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 299);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 5;
            label6.Text = "Status";
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(37, 363);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(299, 29);
            btnCreateOrder.TabIndex = 6;
            btnCreateOrder.Text = "Create order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnClearOrder
            // 
            btnClearOrder.Location = new Point(338, 363);
            btnClearOrder.Name = "btnClearOrder";
            btnClearOrder.Size = new Size(322, 29);
            btnClearOrder.TabIndex = 7;
            btnClearOrder.Text = "Clear";
            btnClearOrder.UseVisualStyleBackColor = true;
            btnClearOrder.Click += btnClearOrder_Click;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(37, 85);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(623, 28);
            cmbCustomer.TabIndex = 8;
            // 
            // cmbServiceType
            // 
            cmbServiceType.FormattingEnabled = true;
            cmbServiceType.Location = new Point(37, 158);
            cmbServiceType.Name = "cmbServiceType";
            cmbServiceType.Size = new Size(623, 28);
            cmbServiceType.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(37, 241);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(623, 27);
            txtQuantity.TabIndex = 10;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(37, 425);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.Size = new Size(623, 339);
            dgvCustomerList.TabIndex = 12;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(37, 322);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(63, 27);
            txtTotal.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(598, 325);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(62, 20);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Pending";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(37, 813);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(623, 29);
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // AdminOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 953);
            Controls.Add(btnHome);
            Controls.Add(lblStatus);
            Controls.Add(txtTotal);
            Controls.Add(dgvCustomerList);
            Controls.Add(txtQuantity);
            Controls.Add(cmbServiceType);
            Controls.Add(cmbCustomer);
            Controls.Add(btnClearOrder);
            Controls.Add(btnCreateOrder);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminOrders";
            Text = "AdminOrders";
            Load += AdminOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
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
        private Button btnCreateOrder;
        private Button btnClearOrder;
        private ComboBox cmbCustomer;
        private ComboBox cmbServiceType;
        private TextBox txtQuantity;
        private DataGridView dgvCustomerList;
        private TextBox txtTotal;
        private Label lblStatus;
        private Button btnHome;
    }
}