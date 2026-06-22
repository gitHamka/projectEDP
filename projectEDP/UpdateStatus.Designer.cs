namespace projectEDP
{
    partial class StaffUpdateStatus
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
            btnBack = new Button();
            lblViewOrder = new Label();
            gbOrderDetails = new GroupBox();
            lblKedudukan = new Label();
            lblTarikh = new Label();
            lblBerat = new Label();
            lblServis = new Label();
            lblPelanggan = new Label();
            lblPesanan = new Label();
            lblServiceType = new Label();
            lblWeight = new Label();
            lblOrderiD = new Label();
            lblDatePlaced = new Label();
            lblCustomerN = new Label();
            lblCurrentStat = new Label();
            btnRefresh = new Button();
            cmbStatus = new ComboBox();
            lblSearch = new Label();
            txtboxSearch = new TextBox();
            gbUpdateStatus = new GroupBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            rbPickup = new RadioButton();
            rbCompleted = new RadioButton();
            rbDrying = new RadioButton();
            rbWashing = new RadioButton();
            rbPending = new RadioButton();
            btnCancel = new Button();
            btnSaveStatus = new Button();
            gbOrderDetails.SuspendLayout();
            gbUpdateStatus.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 578);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(57, 33);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblViewOrder
            // 
            lblViewOrder.AutoSize = true;
            lblViewOrder.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewOrder.Location = new Point(106, 32);
            lblViewOrder.Name = "lblViewOrder";
            lblViewOrder.Size = new Size(196, 38);
            lblViewOrder.TabIndex = 13;
            lblViewOrder.Text = "Update Status";
            // 
            // gbOrderDetails
            // 
            gbOrderDetails.Controls.Add(lblKedudukan);
            gbOrderDetails.Controls.Add(lblTarikh);
            gbOrderDetails.Controls.Add(lblBerat);
            gbOrderDetails.Controls.Add(lblServis);
            gbOrderDetails.Controls.Add(lblPelanggan);
            gbOrderDetails.Controls.Add(lblPesanan);
            gbOrderDetails.Controls.Add(lblServiceType);
            gbOrderDetails.Controls.Add(lblWeight);
            gbOrderDetails.Controls.Add(lblOrderiD);
            gbOrderDetails.Controls.Add(lblDatePlaced);
            gbOrderDetails.Controls.Add(lblCustomerN);
            gbOrderDetails.Controls.Add(lblCurrentStat);
            gbOrderDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbOrderDetails.Location = new Point(106, 137);
            gbOrderDetails.Name = "gbOrderDetails";
            gbOrderDetails.Size = new Size(821, 230);
            gbOrderDetails.TabIndex = 19;
            gbOrderDetails.TabStop = false;
            gbOrderDetails.Text = "Order Details";
            // 
            // lblKedudukan
            // 
            lblKedudukan.AutoSize = true;
            lblKedudukan.Font = new Font("Segoe UI", 10.8F);
            lblKedudukan.Location = new Point(522, 158);
            lblKedudukan.Name = "lblKedudukan";
            lblKedudukan.Size = new Size(0, 25);
            lblKedudukan.TabIndex = 37;
            // 
            // lblTarikh
            // 
            lblTarikh.AutoSize = true;
            lblTarikh.Font = new Font("Segoe UI", 10.8F);
            lblTarikh.Location = new Point(243, 158);
            lblTarikh.Name = "lblTarikh";
            lblTarikh.Size = new Size(0, 25);
            lblTarikh.TabIndex = 36;
            // 
            // lblBerat
            // 
            lblBerat.AutoSize = true;
            lblBerat.Font = new Font("Segoe UI", 10.8F);
            lblBerat.Location = new Point(29, 158);
            lblBerat.Name = "lblBerat";
            lblBerat.Size = new Size(0, 25);
            lblBerat.TabIndex = 35;
            // 
            // lblServis
            // 
            lblServis.AutoSize = true;
            lblServis.Font = new Font("Segoe UI", 10.8F);
            lblServis.Location = new Point(522, 76);
            lblServis.Name = "lblServis";
            lblServis.Size = new Size(0, 25);
            lblServis.TabIndex = 34;
            // 
            // lblPelanggan
            // 
            lblPelanggan.AutoSize = true;
            lblPelanggan.Font = new Font("Segoe UI", 10.8F);
            lblPelanggan.Location = new Point(243, 76);
            lblPelanggan.Name = "lblPelanggan";
            lblPelanggan.Size = new Size(0, 25);
            lblPelanggan.TabIndex = 33;
            // 
            // lblPesanan
            // 
            lblPesanan.AutoSize = true;
            lblPesanan.Font = new Font("Segoe UI", 10.8F);
            lblPesanan.Location = new Point(31, 76);
            lblPesanan.Name = "lblPesanan";
            lblPesanan.Size = new Size(0, 25);
            lblPesanan.TabIndex = 32;
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblServiceType.Location = new Point(522, 51);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(107, 25);
            lblServiceType.TabIndex = 27;
            lblServiceType.Text = "Service type";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(29, 133);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(68, 25);
            lblWeight.TabIndex = 28;
            lblWeight.Text = "Weight";
            // 
            // lblOrderiD
            // 
            lblOrderiD.AutoSize = true;
            lblOrderiD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderiD.Location = new Point(29, 51);
            lblOrderiD.Name = "lblOrderiD";
            lblOrderiD.Size = new Size(76, 25);
            lblOrderiD.TabIndex = 26;
            lblOrderiD.Text = "OrderID";
            // 
            // lblDatePlaced
            // 
            lblDatePlaced.AutoSize = true;
            lblDatePlaced.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDatePlaced.Location = new Point(243, 133);
            lblDatePlaced.Name = "lblDatePlaced";
            lblDatePlaced.Size = new Size(106, 25);
            lblDatePlaced.TabIndex = 29;
            lblDatePlaced.Text = "Date placed";
            // 
            // lblCustomerN
            // 
            lblCustomerN.AutoSize = true;
            lblCustomerN.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerN.Location = new Point(243, 51);
            lblCustomerN.Name = "lblCustomerN";
            lblCustomerN.Size = new Size(138, 25);
            lblCustomerN.TabIndex = 30;
            lblCustomerN.Text = "Customer name";
            // 
            // lblCurrentStat
            // 
            lblCurrentStat.AutoSize = true;
            lblCurrentStat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStat.Location = new Point(522, 133);
            lblCurrentStat.Name = "lblCurrentStat";
            lblCurrentStat.Size = new Size(122, 25);
            lblCurrentStat.TabIndex = 31;
            lblCurrentStat.Text = "Current status";
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(755, 85);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 46);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // cmbStatus
            // 
            cmbStatus.AllowDrop = true;
            cmbStatus.DisplayMember = "(none)";
            cmbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All Status", "Pending", "Washing", "Drying", "Completed", "Ready for pickup" });
            cmbStatus.Location = new Point(476, 90);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(272, 36);
            cmbStatus.TabIndex = 24;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(137, 93);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(74, 28);
            lblSearch.TabIndex = 23;
            lblSearch.Text = "Search:";
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtboxSearch.Location = new Point(217, 90);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.PlaceholderText = "Enter OrderID/Name";
            txtboxSearch.Size = new Size(243, 34);
            txtboxSearch.TabIndex = 22;
            // 
            // gbUpdateStatus
            // 
            gbUpdateStatus.Controls.Add(lblNotes);
            gbUpdateStatus.Controls.Add(txtNotes);
            gbUpdateStatus.Controls.Add(rbPickup);
            gbUpdateStatus.Controls.Add(rbCompleted);
            gbUpdateStatus.Controls.Add(rbDrying);
            gbUpdateStatus.Controls.Add(rbWashing);
            gbUpdateStatus.Controls.Add(rbPending);
            gbUpdateStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbUpdateStatus.Location = new Point(106, 373);
            gbUpdateStatus.Name = "gbUpdateStatus";
            gbUpdateStatus.Size = new Size(821, 160);
            gbUpdateStatus.TabIndex = 31;
            gbUpdateStatus.TabStop = false;
            gbUpdateStatus.Text = "Update status";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 10.8F);
            lblNotes.Location = new Point(102, 97);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(63, 25);
            lblNotes.TabIndex = 37;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 10.8F);
            txtNotes.Location = new Point(171, 97);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "(optional)";
            txtNotes.Size = new Size(546, 31);
            txtNotes.TabIndex = 36;
            // 
            // rbPickup
            // 
            rbPickup.AutoSize = true;
            rbPickup.Font = new Font("Segoe UI", 11F);
            rbPickup.Location = new Point(626, 47);
            rbPickup.Name = "rbPickup";
            rbPickup.Size = new Size(89, 29);
            rbPickup.TabIndex = 35;
            rbPickup.TabStop = true;
            rbPickup.Text = "Pickup";
            rbPickup.UseVisualStyleBackColor = true;
            // 
            // rbCompleted
            // 
            rbCompleted.AutoSize = true;
            rbCompleted.Font = new Font("Segoe UI", 11F);
            rbCompleted.Location = new Point(481, 47);
            rbCompleted.Name = "rbCompleted";
            rbCompleted.Size = new Size(125, 29);
            rbCompleted.TabIndex = 34;
            rbCompleted.TabStop = true;
            rbCompleted.Text = "Completed";
            rbCompleted.UseVisualStyleBackColor = true;
            // 
            // rbDrying
            // 
            rbDrying.AutoSize = true;
            rbDrying.Font = new Font("Segoe UI", 11F);
            rbDrying.Location = new Point(365, 47);
            rbDrying.Name = "rbDrying";
            rbDrying.Size = new Size(89, 29);
            rbDrying.TabIndex = 33;
            rbDrying.TabStop = true;
            rbDrying.Text = "Drying";
            rbDrying.UseVisualStyleBackColor = true;
            // 
            // rbWashing
            // 
            rbWashing.AutoSize = true;
            rbWashing.Font = new Font("Segoe UI", 11F);
            rbWashing.Location = new Point(235, 47);
            rbWashing.Name = "rbWashing";
            rbWashing.Size = new Size(106, 29);
            rbWashing.TabIndex = 32;
            rbWashing.TabStop = true;
            rbWashing.Text = "Washing";
            rbWashing.UseVisualStyleBackColor = true;
            // 
            // rbPending
            // 
            rbPending.AutoSize = true;
            rbPending.Font = new Font("Segoe UI", 11F);
            rbPending.Location = new Point(110, 47);
            rbPending.Name = "rbPending";
            rbPending.Size = new Size(102, 29);
            rbPending.TabIndex = 31;
            rbPending.TabStop = true;
            rbPending.Text = "Pending";
            rbPending.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(683, 549);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 49);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSaveStatus
            // 
            btnSaveStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveStatus.Location = new Point(808, 549);
            btnSaveStatus.Name = "btnSaveStatus";
            btnSaveStatus.Size = new Size(119, 49);
            btnSaveStatus.TabIndex = 33;
            btnSaveStatus.Text = "Save Status";
            btnSaveStatus.UseVisualStyleBackColor = true;
            // 
            // StaffUpdateStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1037, 623);
            Controls.Add(btnSaveStatus);
            Controls.Add(btnCancel);
            Controls.Add(gbUpdateStatus);
            Controls.Add(btnRefresh);
            Controls.Add(cmbStatus);
            Controls.Add(lblSearch);
            Controls.Add(txtboxSearch);
            Controls.Add(gbOrderDetails);
            Controls.Add(lblViewOrder);
            Controls.Add(btnBack);
            Name = "StaffUpdateStatus";
            Text = "Staff Update Status";
            Load += StaffUpdateStatus_Load;
            gbOrderDetails.ResumeLayout(false);
            gbOrderDetails.PerformLayout();
            gbUpdateStatus.ResumeLayout(false);
            gbUpdateStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblViewOrder;
        private GroupBox gbOrderDetails;
        private Label lblNotes;
        private Label lblCurrentStat;
        private Label lblCustomerN;
        private Label lblDatePlaced;
        private Label lblOrderiD;
        private Label lblWeight;
        private Button btnRefresh;
        private ComboBox cmbStatus;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private GroupBox gbUpdateStatus;
        private RadioButton rbPickup;
        private RadioButton rbCompleted;
        private RadioButton rbDrying;
        private RadioButton rbWashing;
        private RadioButton rbPending;
        private Label lblServiceType;
        private TextBox txtNotes;
        private Button btnCancel;
        private Button btnSaveStatus;
        private Label lblKedudukan;
        private Label lblTarikh;
        private Label lblBerat;
        private Label lblServis;
        private Label lblPelanggan;
        private Label lblPesanan;
    }
}