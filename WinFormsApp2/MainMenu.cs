using System.Data;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.Forms;

namespace WinFormsApp2
{
    public partial class MainMenu : Form
    {
        private Form activef;
        private Button _activeButton;
        private Loggedin _loggedinForm;
        private MainLoginform _mainLoginForm;
        private Color _originalBackColor;
        private Color _originalForeColor;
        private FlatStyle _originalFlatStyle; 

        public MainMenu(MainLoginform mainLoginForm)
        {
            InitializeComponent();
            _mainLoginForm = mainLoginForm;
            _loggedinForm = new Loggedin(_mainLoginForm);

            button8.Click += button8_Click_1;
            button7.Click += button7_Click_1;
            button6.Click += button6_Click_1;
            button1.Click += button1_Click;
            button2.Click += button2_Click_1;
            openchildform(_loggedinForm, button6);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = context.Employees.Where(p => p.Id < 10);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
        }
        private void openchildform(Form childform, Button btnSender)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = _originalBackColor;
                _activeButton.ForeColor = _originalForeColor;
                _activeButton.FlatStyle = _originalFlatStyle;
            }
            _originalBackColor = btnSender.BackColor;
            _originalForeColor = btnSender.ForeColor;
            _originalFlatStyle = btnSender.FlatStyle;
            btnSender.BackColor = Color.LightBlue; 
            btnSender.ForeColor = Color.Black;
            btnSender.FlatStyle = FlatStyle.Flat; 
            _activeButton = btnSender;

            if (activef != null)
            {
                activef.Close();

            }
            activef = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelshow.Controls.Add(childform);
            this.panelshow.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openchildform(new Editform(), (Button)sender);

        }
        private void button7_Click_1(Object sender, EventArgs e)
        {
            openchildform(new AddFileform(), (Button)sender);

        }
        private void button6_Click_1(Object sender, EventArgs e)
        {

            openchildform(new Loggedin(_mainLoginForm), (Button)sender);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            openchildform(new Export(), (Button)sender);

        }

        private void panelshow_Paint(Object sender, PaintEventArgs e)
        {
            openchildform(_loggedinForm, (Button)sender);
        }

        private void aloneButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


