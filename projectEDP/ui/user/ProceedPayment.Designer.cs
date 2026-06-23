namespace projectEDP
{
    partial class ProceedPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProceedPayment));
            dgvOrderDetails = new DataGridView();
            btnBack = new Button();
            btnProceed = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(12, 12);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.Size = new Size(558, 129);
            dgvOrderDetails.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(286, 147);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(284, 163);
            btnBack.TabIndex = 6;
            btnBack.Text = "Change My Order";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(286, 315);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(284, 167);
            btnProceed.TabIndex = 7;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 334);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ProceedPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(582, 493);
            Controls.Add(pictureBox1);
            Controls.Add(btnProceed);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderDetails);
            Name = "ProceedPayment";
            Text = "ProceedPayment";
            Load += ProceedPayment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvOrderDetails;
        private Button btnBack;
        private Button btnProceed;
        private PictureBox pictureBox1;
    }
}