using WinFormsApp2.DAL.Database;


namespace WinFormsApp2.Forms
{
    public partial class MainLoginform : Form
    {
        public event Action<string> UserLoggedIn;


        public MainLoginform()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = context.UserPasses
                        .FirstOrDefault(u => u.Username == textBox1.Text && u.Password == textBox2.Text);

                    if (user != null)
                    {
                        MainMenu mainMenuForm = new MainMenu(this);
                        UserLoggedIn?.Invoke(user.Username);
                        mainMenuForm.Show();
                        Loggedin loggedinForm = new Loggedin(this);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
