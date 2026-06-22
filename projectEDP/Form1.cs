namespace projectEDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminManage adminManageForm = new projectEDP.ui.staff.AdminManage();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminOrders adminManageForm = new projectEDP.ui.staff.AdminOrders();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the AdminManage form
            projectEDP.ui.staff.AdminStatus adminManageForm = new projectEDP.ui.staff.AdminStatus();

            // 2. Show the AdminManage form
            adminManageForm.Show();

            // 3. Hide the current Form1 (optional, so it stays in the background)
            this.Hide();
        }

        private void llCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
        }
    }
}