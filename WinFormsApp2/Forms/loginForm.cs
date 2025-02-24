using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entities;


namespace WinFormsApp2.Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Username and password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
            else
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var newUser = new UserPass
                        {
                            Username = textBox1.Text,
                            Password = textBox2.Text
                        };
                        context.UserPasses.Add(newUser);
                        context.SaveChanges();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                        MessageBox.Show("User registered successfully", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new MainLoginform().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
