namespace projectEDP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            Title = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            llCreateAccount = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(12, 18);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(309, 467);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial Rounded MT Bold", 19.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.White;
            Title.Location = new Point(353, 21);
            Title.Name = "Title";
            Title.Size = new Size(307, 37);
            Title.TabIndex = 5;
            Title.Text = "RBN SMARTWASH";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(444, 206);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 30);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(444, 242);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 30);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Arial", 12F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(333, 209);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(105, 23);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial", 12F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(334, 245);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(104, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(566, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // llCreateAccount
            // 
            llCreateAccount.AutoSize = true;
            llCreateAccount.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llCreateAccount.LinkColor = Color.White;
            llCreateAccount.Location = new Point(444, 287);
            llCreateAccount.Name = "llCreateAccount";
            llCreateAccount.Size = new Size(114, 16);
            llCreateAccount.TabIndex = 11;
            llCreateAccount.TabStop = true;
            llCreateAccount.Text = "Create an Account";
            llCreateAccount.LinkClicked += llCreateAccount_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 496);
            Controls.Add(llCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(Title);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogo;
        private Label Title;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Button btnLogin;
        private LinkLabel llCreateAccount;
    }
}