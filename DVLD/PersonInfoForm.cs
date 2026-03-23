namespace DVLD_Persntation
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm(int userId)
        {
            InitializeComponent();
            uC_PersonInfomation1.LoadData(userId);
        }

        private void PersonInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCloase_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
