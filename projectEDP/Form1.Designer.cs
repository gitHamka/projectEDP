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
            button1 = new Button();
            btnTestConnection = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 171);
            button1.Name = "button1";
            button1.Size = new Size(306, 29);
            button1.TabIndex = 0;
            button1.Text = "BUTTON TO RUN APP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.Location = new Point(235, 229);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(306, 29);
            btnTestConnection.TabIndex = 1;
            btnTestConnection.Text = "BUTTON TO CHECK CONNECTION";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTestConnection);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnTestConnection;
    }
}
