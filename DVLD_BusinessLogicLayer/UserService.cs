using DVLD_DataAccessLayer;
using System.Data;
using System.Runtime.Intrinsics.X86;

namespace DVLD_BusinessLogicLayer
{

    public class UserService
    {
        enum enMode
        {
            Add,
            Update
        }
        enMode mode;
        public int User_ID { get; set; }
        public string First_Name { get; set; }
        public string Second_Name { get; set; }
        public string Third_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string Profile_Photo_URL { get; set; }
        public char Gender { get; set; }
        public string SSN { get; set; }

        public UserService()
        {
        }
        public UserService(int user_ID)
        {
            this.User_ID = user_ID;
            if (user_ID != -1)
            {
                mode = enMode.Update;
            }
            else
                mode = enMode.Add;
        }

        public UserService(int user_ID, string first_Name, string secound_Name, string third_Name, string last_Name, DateTime date_Of_Birth, int age, string email, string phone, string nationality, string address, string profile_Photo_URL, char gender, string ssn)
        {
            this.User_ID = user_ID;
            this.First_Name = first_Name;
            this.Second_Name = secound_Name;
            this.Third_Name = third_Name;
            this.Last_Name = last_Name;
            this.Date_Of_Birth = date_Of_Birth;
            this.Age = age;
            this.Email = email;
            this.Phone = phone;
            this.Nationality = nationality;
            this.Address = address;
            this.Profile_Photo_URL = profile_Photo_URL;
            this.Gender = gender;
            this.SSN = ssn;
        }

        public DataTable GetUsers()
        {
            return DVLD_DataAccessLayer.UserRepository.GetUsers();
        }

        public static UserService GetUserById(int userId)
        {
            // Initialize variables to default values to avoid CS0165 and CS8601
            string first_Name = string.Empty;
            string secound_Name = string.Empty;
            string third_Name = string.Empty;
            string last_Name = string.Empty;
            DateTime date_Of_Birth = default;
            int age = 0;
            string email = string.Empty;
            string phone = string.Empty;
            string nationality = string.Empty;
            string address = string.Empty;
            string profile_Photo_URL = string.Empty;
            char gender = default;
            string sSN = string.Empty;


            if (DVLD_DataAccessLayer.UserRepository.GetUserById(userId, ref first_Name, ref secound_Name, ref third_Name, ref last_Name, ref date_Of_Birth, ref age, ref email, ref phone, ref nationality, ref address, ref profile_Photo_URL, ref gender, ref sSN))
            {

                return new UserService(userId, first_Name, secound_Name, third_Name, last_Name, date_Of_Birth, age, email, phone, nationality, address, profile_Photo_URL, gender, sSN);

            }
            return null;
        }

        public static UserService GetUserBySSN(string ssn)
        {
            // Initialize variables to default values to avoid CS0165 and CS8601
            int user_ID = 0;
            string first_Name = string.Empty;
            string secound_Name = string.Empty;
            string third_Name = string.Empty;
            string last_Name = string.Empty;
            DateTime date_Of_Birth = default;
            int age = 0;
            string email = string.Empty;
            string phone = string.Empty;
            string nationalty = string.Empty;
            string address = string.Empty;
            string profile_Photo_URL = string.Empty;
            char gender = '\0';
            if (DVLD_DataAccessLayer.UserRepository.GetUserBySSN(ssn, ref user_ID, ref first_Name, ref secound_Name, ref third_Name, ref last_Name, ref date_Of_Birth, ref age, ref email, ref phone, ref nationalty, ref address, ref profile_Photo_URL, ref gender))
            {
                return new UserService(user_ID, first_Name, secound_Name, third_Name, last_Name, date_Of_Birth, age, email, phone, nationalty, address, profile_Photo_URL , gender , ssn);
            }
            return null;
        }

        public static UserService GetUserByEmail(string email)
        {
            // Initialize variables to default values to avoid CS0165 and CS8601
            int user_ID = 0;
            string first_Name = string.Empty;
            string secound_Name = string.Empty;
            string third_Name = string.Empty;
            string last_Name = string.Empty;
            DateTime date_Of_Birth = default;
            int age = 0;
            string phone = string.Empty;
            string nationalty = string.Empty;
            string address = string.Empty;
            string profile_Photo_URL = string.Empty;
            char gender = '\0';
            string sSN = string.Empty;

            if (DVLD_DataAccessLayer.UserRepository.GetUserByEmail(email, ref user_ID, ref first_Name, ref secound_Name, ref third_Name, ref last_Name, ref date_Of_Birth, ref age, ref phone, ref nationalty, ref address, ref profile_Photo_URL, ref gender, ref sSN))
            {
                return new UserService(user_ID, first_Name, secound_Name, third_Name, last_Name, date_Of_Birth, age, email, phone, nationalty, address, profile_Photo_URL, gender, sSN);
            }
            return null;
        }
        public static UserService GetUserByPhone(string email)
        {
            // Initialize variables to default values to avoid CS0165 and CS8601
            int user_ID = 0;
            string first_Name = string.Empty;
            string secound_Name = string.Empty;
            string third_Name = string.Empty;
            string last_Name = string.Empty;
            DateTime date_Of_Birth = default;
            int age = 0;
            string phone = string.Empty;
            string nationalty = string.Empty;
            string address = string.Empty;
            string profile_Photo_URL = string.Empty;
            char gender = '\0';
            string sSN = string.Empty;

            if (DVLD_DataAccessLayer.UserRepository.GetUserByPhone(phone, ref user_ID, ref first_Name, ref secound_Name, ref third_Name, ref last_Name, ref date_Of_Birth, ref age, ref email, ref nationalty, ref address, ref profile_Photo_URL, ref gender, ref sSN))
            {
                return new UserService(user_ID, first_Name, secound_Name, third_Name, last_Name, date_Of_Birth, age, email, phone, nationalty, address, profile_Photo_URL, gender, sSN);
            }
            return null;
        }

        public static List<string> GetNaltionalities()
        {
            return UserRepository.GetNationalities();
        }
        private bool UpdateUser()
        {
            return DVLD_DataAccessLayer.UserRepository.UpdateUser(this.User_ID, this.First_Name, this.Second_Name, this.Third_Name, this.Last_Name, this.Date_Of_Birth, this.Age, this.Email, this.Phone, this.Nationality, this.Address, this.Profile_Photo_URL, this.Gender, this.SSN);

        }

        private bool AddNewUser()
        {
            this.User_ID = DVLD_DataAccessLayer.UserRepository.AddNewUser(this.First_Name, this.Second_Name, this.Third_Name, this.Last_Name, this.Date_Of_Birth, this.Age, this.Email, this.Phone, this.Nationality, this.Address, this.Profile_Photo_URL, this.Gender, this.SSN);
            return this.User_ID!=-1;
        }
        public bool Save()
        {
            if (mode == enMode.Add)
                return AddNewUser();
            else
                return UpdateUser();
        }

        public static bool Delete(int User_ID)
        {
            return DVLD_DataAccessLayer.UserRepository.DeleteUser(User_ID);
        }
    }
}
