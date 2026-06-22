namespace projectEDP
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtUsername = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            btnRegister = new Button();
            lblLogin = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(22, 275);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(55, 327);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(51, 373);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 2;
            label3.Text = "Phone :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(351, 275);
            label4.Name = "label4";
            label4.Size = new Size(89, 17);
            label4.TabIndex = 3;
            label4.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(362, 368);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 5;
            label6.Text = "Address :";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = SystemColors.WindowText;
            txtUsername.Location = new Point(120, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 20);
            txtUsername.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Window;
            txtName.BorderStyle = BorderStyle.None;
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(120, 327);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 20);
            txtName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.ForeColor = SystemColors.WindowText;
            txtPhone.Location = new Point(120, 373);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(170, 20);
            txtPhone.TabIndex = 8;
            txtPhone.TextChanged += textBox3_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(446, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 20);
            txtPassword.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Window;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = SystemColors.WindowText;
            txtAddress.Location = new Point(446, 368);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(185, 168);
            txtAddress.TabIndex = 11;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.System;
            btnRegister.ForeColor = SystemColors.Window;
            btnRegister.Location = new Point(537, 597);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.LinkColor = Color.White;
            lblLogin.Location = new Point(353, 601);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(178, 20);
            lblLogin.TabIndex = 13;
            lblLogin.TabStop = true;
            lblLogin.Text = "Already have an account?";
            lblLogin.LinkClicked += lblLogin_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(174, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 698);
            Controls.Add(pictureBox1);
            Controls.Add(lblLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtAddress);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtUsername);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtUsername;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private Button btnRegister;
        private LinkLabel lblLogin;
        private PictureBox pictureBox1;
    }
}