using DVLD;
using DVLD_BusinessLogicLayer;

namespace DVLD_Persntation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadLoginForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadLoginForm()
        {
            string username = string.Empty, password = string.Empty;
            bool credentials = SystemUserService.GetRememberedCredentials(ref username, ref password);
            if (credentials)
            {
                tbUserName.Text = username;
                tbPassword.Text = password;
                cbRememperMe.Checked = true;
            }
        }

        private void Login(string username, string password)
        {
            SystemUserService.RememberMe(username, password, cbRememperMe.Checked);
            this.Hide();
            MainForm mainForm = new MainForm(username);
            mainForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            switch (SystemUserService.Authenticate(tbUserName.Text, tbPassword.Text))
            {
                case SystemUserService.enStatus.Success:
                    Login(tbUserName.Text, tbPassword.Text);
                    break;
                case SystemUserService.enStatus.FilledRequiredFields:
                    MessageBox.Show("Please fill all required fields.");
                    break;
                case SystemUserService.enStatus.NotActive:
                    MessageBox.Show("Your account is not active. Please contact support.");
                    break;
                case SystemUserService.enStatus.UserNotFound:
                    MessageBox.Show("User not found. Please check your username.");
                    break;
                case SystemUserService.enStatus.InvalidPassword:
                    MessageBox.Show("Invalid password. Please try again.");
                    break;
            }
        }
    }
}
