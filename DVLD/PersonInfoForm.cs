namespace DVLD_Persntation
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm(int userId)
        {
            InitializeComponent();
            uC_PersonInfomation1.LoadData(userId);
        }
    }
}
