namespace DVLD_Persntation
{
    public partial class NewOrUpdateUserForm : Form
    {
        public delegate void DataBackDelegate(object sender, int id);
        public event DataBackDelegate DataBackEvent;

        public NewOrUpdateUserForm(int id)
        {
            InitializeComponent();
            loadNewOrUpdateUserForm(id);

        }

        void loadNewOrUpdateUserForm(int id)
        {

            if (id == -1)
            {
                lblAddOrNewUser.Text = "Add New pepole";
                userControl11.DataBackEvent += UserControl11_DataBackEvent;

            }
            else
            {
                lblAddOrNewUser.Text = "Update pepole";
                lblAddOrNewUser.ForeColor = Color.Yellow;
                lblAddOrNewUser.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblPersonId.Text = id.ToString();
                userControl11.LoadData(id);
                // This is a placeholder for actual data loading logic
                // Note: Use UserId property, not id parameter
            }
        }

        private void UserControl11_DataBackEvent(object sender, int id)
        {
            loadNewOrUpdateUserForm(id);
            DataBackEvent.Invoke(this, id);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
