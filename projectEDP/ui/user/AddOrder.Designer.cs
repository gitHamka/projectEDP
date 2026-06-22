namespace projectEDP
{
    partial class AddOrder
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
<<<<<<< HEAD
            cmbCategory = new ComboBox();
            btnNext = new Button();
            cmbService = new ComboBox();
            label4 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            txtNotes = new RichTextBox();
=======
            comboBox1 = new ComboBox();
            btnNext = new Button();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 46);
            label1.TabIndex = 0;
            label1.Text = "Order Form";
=======
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(257, 36);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Order";
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
=======
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 122);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            label2.TabIndex = 1;
            label2.Text = "Category :";
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< HEAD
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(243, 32);
            label3.TabIndex = 2;
            label3.Text = "Type of Service :";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbCategory.Location = new Point(12, 126);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(658, 28);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
=======
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(27, 262);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 2;
            label3.Text = "Type of Service :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Small (5 KG)", "Medium (10 KG)", "Large (15 KG)" });
            comboBox1.Location = new Point(27, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(269, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            btnNext.Location = new Point(512, 500);
=======
            btnNext.Location = new Point(491, 624);
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(158, 46);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            btnNext.Click += btnNext_Click;
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Wash", "Wash and Dry", "Wash and Dry and Fold" });
            cmbService.Location = new Point(12, 219);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(658, 28);
            cmbService.TabIndex = 6;
            cmbService.SelectedIndexChanged += cmbService_SelectedIndexChanged;
=======
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Wash", "Wash & Dry", "Wash & Dry & Fold" });
            comboBox2.Location = new Point(27, 301);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(269, 28);
            comboBox2.TabIndex = 6;
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< HEAD
            label4.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 463);
            label4.Name = "label4";
            label4.Size = new Size(197, 32);
            label4.TabIndex = 7;
            label4.Text = "Total Amount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(71, 523);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(69, 23);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "label5";
=======
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(521, 493);
            label4.Name = "label4";
            label4.Size = new Size(104, 17);
            label4.TabIndex = 7;
            label4.Text = "Total Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(538, 545);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 8;
            label5.Text = "label5";
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(314, 639);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 9;
            // 
<<<<<<< HEAD
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 283);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 10;
            label5.Text = "Notes :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(12, 318);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(658, 120);
            txtNotes.TabIndex = 11;
            txtNotes.Text = "";
            // 
=======
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
<<<<<<< HEAD
            ClientSize = new Size(682, 583);
            Controls.Add(txtNotes);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(cmbService);
            Controls.Add(btnNext);
            Controls.Add(cmbCategory);
=======
            ClientSize = new Size(682, 698);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(btnNext);
            Controls.Add(comboBox1);
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrder";
            Text = "AddOrder";
<<<<<<< HEAD
            Load += AddOrder_Load;
=======
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
<<<<<<< HEAD
        private ComboBox cmbCategory;
        private Button btnNext;
        private ComboBox cmbService;
        private Label label4;
        private Label lblTotal;
        private Label label6;
        private Label label5;
        private RichTextBox txtNotes;
=======
        private ComboBox comboBox1;
        private Button btnNext;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
>>>>>>> 88b80bd0155d31792faeed1c6dff4b57a38abfbb
    }
}