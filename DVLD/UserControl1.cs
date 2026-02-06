using DVLD_BusinessLogicLayer;

namespace DVLD_Persntation
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private int userId = -1;
        public void LoadData(int userId)
        {
            this.userId = userId;
            UserService userService = new UserService();
            userService = userService.GetUserById(userId); // Example user ID

            if (userService == null)
            {
                MessageBox.Show("User not found.");
                return;
            }

            tbFirstName.Text = userService.First_Name;
            tbSecondName.Text = userService.Second_Name;
            tbThirdName.Text = userService.Third_Name;
            tbLastName.Text = userService.Last_Name;
            dtpDateOfBirth.Value = userService.Date_Of_Birth;
            tbEmail.Text = userService.Email;
            tbPhone.Text = userService.Phone;
            tbNationality.Text = userService.Nationality;
            tbAddress.Text = userService.Address;
            tpSSN.Text = userService.SSN;
            if (userService.Gender == 'M')
            {
                rbMale.Checked = true;
            }
            else if (userService.Gender == 'F')
            {
                rbFemale.Checked = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbSecondName.Text) ||
                string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbPhone.Text) ||
                string.IsNullOrWhiteSpace(tbNationality.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) ||
                string.IsNullOrWhiteSpace(tpSSN.Text) ||
                (!rbMale.Checked && !rbFemale.Checked))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            // Save logic here
            UserService user = new UserService(userId);
            //user.User_ID = userId;
            user.First_Name = tbFirstName.Text;
            user.Second_Name = tbSecondName.Text;
            user.Third_Name = tbThirdName.Text;
            user.Last_Name = tbLastName.Text;
            user.Date_Of_Birth = dtpDateOfBirth.Value;
            user.Email = tbEmail.Text;
            user.Phone = tbPhone.Text;
            user.Profile_Photo_URL = PbImage.ImageLocation != null ? PbImage.ImageLocation : "";
            user.Age = DateTime.Now.Year - dtpDateOfBirth.Value.Year;
            user.Nationality = tbNationality.Text;
            user.Address = tbAddress.Text;
            user.SSN = tpSSN.Text;
            user.Gender = rbMale.Checked ? 'M' : 'F';
            bool isSaved = user.Save();
            if (isSaved)
            {
                MessageBox.Show("User information saved successfully.");
            }
            else
            {
                MessageBox.Show("Error saving user information.");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.btnClose.FindForm().Close();
        }

        private void lkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Select Profile Photo",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Multiselect = false
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                PbImage.Image = Image.FromFile(dialog.FileName);
                PbImage.ImageLocation = dialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void lkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbImage.Image = Properties.Resources.user;
            PbImage.ImageLocation = "";
        }
    }
}