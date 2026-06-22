namespace projectEDP
{
    partial class CustomerPAYMENT
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
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Cart :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(38, 58);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 184);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 327);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Add anything else?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(595, 327);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 4;
            label3.Text = "Proceed to payment?";
            // 
            // button1
            // 
            button1.Location = new Point(392, 359);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 5;
            button1.Text = "Change my service";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(594, 359);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 6;
            button2.Text = "Yes";
            button2.UseVisualStyleBackColor = true;
            // 
            // CustomerPAYMENT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "CustomerPAYMENT";
            Text = "CustomerPAYMENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}