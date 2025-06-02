using System;
using System.Windows.Forms;

namespace taskfinalforC_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: handle label click if needed
        }

        // Go to Orders form
        private void button1_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders(); // Make sure Orders is a Form
            ordersForm.Show();
            this.Hide(); // Hide Form2
        }

        // Go back to Form1
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Hide Form2
        }
    }
}
