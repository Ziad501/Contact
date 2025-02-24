namespace WinFormsApp2.Forms
{
    public partial class Loggedin : Form
    {
		public static class SessionManager
		{
			public static string LoggedInUsername { get; set; }
		}

		private string _loggedInUsername;

		public Loggedin(MainLoginform mainloginForm)
		{
			InitializeComponent();
			mainloginForm.UserLoggedIn += LoginForm_UserLoggedIn;
		}

		private void LoginForm_UserLoggedIn(string username)
		{
			SessionManager.LoggedInUsername = username;
			lblWelcome.Text = $"Welcome, {SessionManager.LoggedInUsername}!";
		}


		private void Loggedin_Load(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(SessionManager.LoggedInUsername))
			{
				lblWelcome.Text = $"Welcome, {SessionManager.LoggedInUsername}!";
			}
		}
	}
}
