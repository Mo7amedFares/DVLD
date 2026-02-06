namespace DVLD_Persntation
{
    public partial class NewOrUpdateUserForm : Form
    {

        public NewOrUpdateUserForm(int id)
        {
            InitializeComponent();

            if (id == -1)
            {
                lblAddOrNewUser.Text = "Add New pepole";

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

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
