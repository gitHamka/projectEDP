namespace projectEDP.ui.user
{
    partial class UserProfile
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
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            btnBack = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(218, 46);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(419, 27);
            txtFullName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 84);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(419, 27);
            txtPhone.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(218, 122);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(419, 27);
            txtAddress.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(515, 184);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Profile";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 184);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 5;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(44, 78);
            label2.Name = "label2";
            label2.Size = new Size(168, 31);
            label2.TabIndex = 6;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(115, 116);
            label3.Name = "label3";
            label3.Size = new Size(97, 31);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 225);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Name = "UserProfile";
            Text = "UserProfile";
            Load += UserProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Button btnUpdate;
        private Button btnBack;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}