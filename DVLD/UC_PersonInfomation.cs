using DVLD_BusinessLogicLayer;

namespace DVLD_Persntation
{
    public partial class UC_PersonInfomation : UserControl
    {
        private int userId = -1;
        public UC_PersonInfomation()
        {
            InitializeComponent();
        }

        public void LoadData(int userId)
        {
            this.userId = userId;
            UserService userService = UserService.GetUserById(userId);
            if (userService == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            lblPersonId.Text = userService.User_ID.ToString();
            lblName.Text = $"{userService.First_Name} {userService.Second_Name} {userService.Third_Name} {userService.Last_Name}";
            lblBirthOfDate.Text = userService.Date_Of_Birth.ToShortDateString();
            lblEmail.Text = userService.Email;
            lblPhone.Text = userService.Phone;
            lblNationality.Text = userService.Nationality;
            lblAddress.Text = userService.Address;
            lblSSN.Text = userService.SSN;
            if (userService.Gender == 'M')
            {
                lblGendor.Text = "Male";
            }
            else if (userService.Gender == 'F')
            {
                lblGendor.Text = "Female";
            }
            if (userService.Profile_Photo_URL != null && userService.Profile_Photo_URL != "")
            {
                try
                {
                    PbImage.Image = Image.FromFile(userService.Profile_Photo_URL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile photo: " + ex.Message);
                }
            }

        }

        private void reastUserControl()
        {
            
            lblPersonId.Text = "???";
            lblName.Text = "???";
            lblBirthOfDate.Text = "???";
            lblEmail.Text = "???";
            lblPhone.Text = "???";
            lblNationality.Text = "???";
            lblAddress.Text = "???";
            lblSSN.Text = "???";
            lblGendor.Text = "???";
            PbImage.Image = DVLD_Persntation.Properties.Resources.default_profile_picture;
        }

        public void loadData(UserService userService)
        {
            if (userService == null)
            {
                MessageBox.Show("User not found.");
                reastUserControl();
                return;
            }

            this.userId = userService.User_ID;
            lblPersonId.Text = userService.User_ID.ToString();
            lblName.Text = $"{userService.First_Name} {userService.Second_Name} {userService.Third_Name} {userService.Last_Name}";
            lblBirthOfDate.Text = userService.Date_Of_Birth.ToShortDateString();
            lblEmail.Text = userService.Email;
            lblPhone.Text = userService.Phone;
            lblNationality.Text = userService.Nationality;
            lblAddress.Text = userService.Address;
            lblSSN.Text = userService.SSN;
            if (userService.Gender == 'M')
            {
                lblGendor.Text = "Male";
            }
            else if (userService.Gender == 'F')
            {
                lblGendor.Text = "Female";
            }
            if (userService.Profile_Photo_URL != null && userService.Profile_Photo_URL != "")
            {
                try
                {
                    PbImage.Image = Image.FromFile(userService.Profile_Photo_URL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile photo: " + ex.Message);
                }
            }
        }

        private void linklblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewOrUpdateUserForm updateUserForm = new NewOrUpdateUserForm(userId);
            this.Hide();
            updateUserForm.ShowDialog();
            this.Show();
            LoadData(userId); // Refresh data after editing
        }
    }
}
