using System;
using System.Linq;
using System.Windows.Forms;
using taskfinalfor_.db; 

namespace taskfinalforC_
{
    public partial class Loginin : Form
    {
        public Loginin()
        {
            InitializeComponent();
        }

        private void buttontocheckuser_Click(object sender, EventArgs e)
        {
            string username = textBoxforusername.Text.Trim();
            string password = textBoxforpassword.Text;

            using (var context = new AppDbContext())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.UserName == username && u.PAssword == password);

                if (user != null)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open Form2 and hide the login form
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

