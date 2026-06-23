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
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Location = new Point(12, 32);
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
            dgvHistory.Size = new Size(558, 188);
            dgvHistory.TabIndex = 1;
            // 
            // btnDownloadReceipt
            // 
            btnDownloadReceipt.Location = new Point(241, 275);
            btnDownloadReceipt.Name = "btnDownloadReceipt";
            btnDownloadReceipt.Size = new Size(94, 29);
            btnDownloadReceipt.TabIndex = 2;
            btnDownloadReceipt.Text = "Download";
            btnDownloadReceipt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Filter By Status";
            // 
            // OrderHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 316);
            Controls.Add(label1);
            Controls.Add(btnDownloadReceipt);
            Controls.Add(dgvHistory);
            Controls.Add(cmbStatusFilter);
            Name = "OrderHistory";
            Text = "OrderHistory";
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
    }
}