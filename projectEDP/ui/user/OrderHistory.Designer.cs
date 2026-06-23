namespace projectEDP.ui.user
{
    partial class OrderHistory
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
            cmbStatusFilter = new ComboBox();
            dgvHistory = new DataGridView();
            btnDownloadReceipt = new Button();
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(163, 32);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(151, 28);
            cmbStatusFilter.TabIndex = 0;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // dgvHistory
            // 
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(12, 66);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(707, 188);
            dgvHistory.TabIndex = 1;
            // 
            // btnDownloadReceipt
            // 
            btnDownloadReceipt.Location = new Point(625, 275);
            btnDownloadReceipt.Name = "btnDownloadReceipt";
            btnDownloadReceipt.Size = new Size(94, 29);
            btnDownloadReceipt.TabIndex = 2;
            btnDownloadReceipt.Text = "Download";
            btnDownloadReceipt.UseVisualStyleBackColor = true;
            btnDownloadReceipt.Click += btnDownloadReceipt_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(145, 23);
            label1.TabIndex = 3;
            label1.Text = "Filter By Status";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 275);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(93, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(731, 316);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnDownloadReceipt);
            Controls.Add(dgvHistory);
            Controls.Add(cmbStatusFilter);
            Name = "OrderHistory";
            Text = "OrderHistory";
            Load += OrderHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatusFilter;
        private DataGridView dgvHistory;
        private Button btnDownloadReceipt;
        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private Button btnBack;
    }
}