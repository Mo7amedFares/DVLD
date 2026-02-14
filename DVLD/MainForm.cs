using DVLD_BusinessLogicLayer;
using DVLD_Persntation;

namespace DVLD
{
    public partial class MainForm : Form
    {
        public static Form? currentChildForm;
        private Panel contentHostPanel;
        //private int systemUserID;
        private SystemUserService curentLonginSystemUser;
        public MainForm(string username)
        {
            curentLonginSystemUser = SystemUserService.GetSystemUserByUserName(username);
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            contentHostPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            currentChildForm?.Close();

            // أظهر LoginForm تاني
            Application.OpenForms[0]?.Show();
        }
        private void TSBtnPeople_Click(object sender, EventArgs e)
        {
            // شيك لو نفس الفورم فاتح، ما تفتحش تاني
            if (currentChildForm is MangePeopleForm)
                return;
            openChildForm(new MangePeopleForm());

        }

        private void openChildForm(Form childForm)
        {
            // Close the current active child form if it exists
            currentChildForm?.Close();
            currentChildForm = childForm;
            childForm.Show();

        }

        private void sigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curentLonginSystemUser = null;
            this.Close();
        }

        private void curentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemUserInfoForm systemUserInfoForm = new SystemUserInfoForm(curentLonginSystemUser.System_User_Id);
            systemUserInfoForm.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openChildForm(new MangeSystemUser());
        }

        private void chagePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordSystemUserForm changePasswordForm = new ChangePasswordSystemUserForm(curentLonginSystemUser.System_User_Id);
            changePasswordForm.ShowDialog();
        }

        private void applicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationTypesForm applicationTypesForm = new ApplicationTypesForm();
            applicationTypesForm.ShowDialog();
        }
    }
}
