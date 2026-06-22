using Npgsql;

namespace projectEDP
{
    public partial class Form1 : Form
    {
        string connStr = "Host=aws-1-ap-northeast-1.pooler.supabase.com;Port=6543;Database=postgres;Username=postgres.cveiuqrnmdidjdjknnwe;Password=pEDPpasswwrd;SSL Mode=Require;Trust Server Certificate=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff Form = new Staff();
            Form.ShowDialog();
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using NpgsqlConnection conn = new NpgsqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Connected successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }
    }
}
