using DVLD_BusinessLogicLayer;

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


    }
}
