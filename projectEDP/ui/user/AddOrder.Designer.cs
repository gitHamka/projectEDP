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
            cmbCategory = new ComboBox();
            btnNext = new Button();
            cmbService = new ComboBox();
            label4 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            label5 = new Label();
            txtNotes = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 46);
            label1.TabIndex = 0;
            label1.Text = "Order Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(157, 32);
            label2.TabIndex = 1;
            label2.Text = "Category :";
            // 
            // label3
            // 
            label3.AutoSize = true;
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
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            cmbCategory.Location = new Point(12, 126);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(658, 28);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += new EventHandler(cmbCategory_SelectedIndexChanged);
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(512, 500);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(158, 46);
            btnNext.TabIndex = 5;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += new EventHandler(btnNext_Click);
            // 
            // cmbService
            // 
            cmbService.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Wash", "Wash and Dry", "Wash and Dry and Fold" });
            cmbService.Location = new Point(12, 219);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(658, 28);
            cmbService.TabIndex = 6;
            cmbService.SelectedIndexChanged += new EventHandler(cmbService_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
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
            lblTotal.Text = "RM 0.00";
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
            // AddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(682, 583);
            Controls.Add(txtNotes);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(cmbService);
            Controls.Add(btnNext);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddOrder";
            Text = "AddOrder";
            Load += new EventHandler(AddOrder_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCategory;
        private Button btnNext;
        private ComboBox cmbService;
        private Label label4;
        private Label lblTotal;
        private Label label6;
        private Label label5;
        private RichTextBox txtNotes;
    }
}