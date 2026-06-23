namespace projectEDP.ui.staff
{
    partial class AdminManage
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
            txtCustomerID = new TextBox();
            txtPhone = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            txtAddress = new RichTextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnHome = new Button();
            dgvCustomer = new DataGridView();
            txtSearch = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(211, 22);
            label1.Name = "label1";
            label1.Size = new Size(238, 23);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 315);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 379);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 511);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(12, 338);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(658, 27);
            txtCustomerID.TabIndex = 4;
            txtCustomerID.Leave += txtCustomerID_Leave;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 470);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(658, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 402);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(658, 27);
            txtFullName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 447);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 7;
            label5.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 531);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(658, 100);
            txtAddress.TabIndex = 8;
            txtAddress.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(12, 644);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 255, 192);
            btnClear.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(234, 644);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(215, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(455, 644);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(12, 685);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(658, 29);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(12, 143);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(658, 160);
            dgvCustomer.TabIndex = 13;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 110);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(658, 27);
            txtSearch.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 90);
            label6.Name = "label6";
            label6.Size = new Size(212, 17);
            label6.TabIndex = 15;
            label6.Text = "Search Customer (ID/Name)";
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 728);
            Controls.Add(label6);
            Controls.Add(txtSearch);
            Controls.Add(dgvCustomer);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(label5);
            Controls.Add(txtFullName);
            Controls.Add(txtPhone);
            Controls.Add(txtCustomerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManage";
            Load += AdminManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCustomerID;
        private TextBox txtPhone;
        private TextBox txtFullName;
        private Label label5;
        private RichTextBox txtAddress;
        private Button btnSave;
        private Button btnClear;
        private Button btnDelete;
        private Button btnHome;
        private DataGridView dgvCustomer;
        private TextBox txtSearch;
        private Label label6;
    }
}