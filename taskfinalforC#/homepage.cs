namespace taskfinalforC_
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginin loginForm = new Loginin();
            loginForm.Show(); // or loginForm.ShowDialog(); for modal
            this.Hide(); // Optional: hide the current form
        }

    }
}
