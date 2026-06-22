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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 25);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 322);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // txtCustomerID
            // 
            txtCustomerID.BackColor = SystemColors.ControlDarkDark;
            txtCustomerID.BorderStyle = BorderStyle.None;
            txtCustomerID.ForeColor = SystemColors.Window;
            txtCustomerID.Location = new Point(12, 94);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(658, 20);
            txtCustomerID.TabIndex = 4;
            txtCustomerID.Leave += txtCustomerID_Leave;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.ControlDarkDark;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.ForeColor = SystemColors.Window;
            txtPhone.Location = new Point(12, 254);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(658, 20);
            txtPhone.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.ControlDarkDark;
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.ForeColor = SystemColors.Window;
            txtFullName.Location = new Point(12, 169);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(658, 20);
            txtFullName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Phone";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.ControlDarkDark;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = SystemColors.Window;
            txtAddress.Location = new Point(12, 345);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(658, 120);
            txtAddress.TabIndex = 8;
            txtAddress.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDarkDark;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.Window;
            btnSave.Location = new Point(12, 491);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(215, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(234, 491);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(215, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(455, 491);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(215, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 541);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(658, 29);
            btnHome.TabIndex = 12;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // AdminManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 582);
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
    }
}