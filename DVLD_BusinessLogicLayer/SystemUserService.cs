using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class SystemUserService
    {
        public int System_User_Id { get; set; }
        public int User_ID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int? Permission { get; set; }
        public bool IsActive { get; set; }

        private enum enMode
        {
            Add,
            Update
        }
        public enum enStatus
        {
            Success,
            FilledRequiredFields,
            NotActive,
            UserNotFound,
            InvalidPassword
        }
        private enMode mode;
        public SystemUserService()
        {
            this.mode = enMode.Add;
        }

        public SystemUserService(int system_User_Id)
        {
            this.System_User_Id = system_User_Id;
            if (system_User_Id != -1)
            {
                mode = enMode.Update;
            }
            else
                mode = enMode.Add;
        }
        public SystemUserService(int system_User_Id, int user_ID, string username, string password, int? permission, bool isActive)
        {
            this.System_User_Id = system_User_Id;
            this.User_ID = user_ID;
            this.Username = username;
            this.Password = password;
            this.Permission = permission;
            this.IsActive = isActive;
            this.mode = enMode.Update;
        }
        public DataTable GetSystemUsers()
        {
            return DVLD_DataAccessLayer.SystemUserRepository.GetSystemUsers();
        }
        public static SystemUserService GetSystemUserById(int SystemUserId)
        {
            int user_ID = 0;
            string username = string.Empty;
            string password = string.Empty;
            int? permission = 0;
            bool isActive = false;

            if (DVLD_DataAccessLayer.SystemUserRepository.GetSystemUserById(SystemUserId, ref user_ID, ref username, ref password, ref permission, ref isActive))
            {
                return new SystemUserService(SystemUserId, user_ID, username, password, permission, isActive);
            }
            return null;
        }
        public static SystemUserService GetSystemUserByUserName(string username)
        {
            int system_User_Id = 0;
            int user_ID = 0;
            string password = string.Empty;
            int? permission = 0;
            bool isActive = false;
            if (DVLD_DataAccessLayer.SystemUserRepository.GetSystemUserByUsername(username, ref system_User_Id, ref user_ID, ref password, ref permission, ref isActive))
            {
                return new SystemUserService(system_User_Id, user_ID, username, password, permission, isActive);
            }
            return null;
        }

        public static bool GetRememberedCredentials(ref string username, ref string password)
        {
            return DVLD_DataAccessLayer.SystemUserRepository.GetRememberedCredentials(ref username, ref password);
        }
        public static bool Delete(int System_User_Id)
        {
            return DVLD_DataAccessLayer.SystemUserRepository.DeleteSystemUser(System_User_Id);
        }

        public bool Update()
        {
            return DVLD_DataAccessLayer.SystemUserRepository.UpdateSystemUser(this.System_User_Id, this.User_ID, this.Username, this.Password, this.Permission, this.IsActive);
        }

        public bool AddNew()
        {
            return DVLD_DataAccessLayer.SystemUserRepository.AddNewSystemUser(this.User_ID, this.Username, this.Password, this.Permission, this.IsActive);
        }

        public bool Save()
        {
            if (mode == enMode.Add)
                return AddNew();
            else
                return Update();
        }

        public static bool ChangePassword(int System_User_Id, string newPassword)
        {
            return DVLD_DataAccessLayer.SystemUserRepository.ChangePassword(System_User_Id, newPassword);
        }

        public static enStatus Authenticate(string? username, string? password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return enStatus.FilledRequiredFields;

            SystemUserService systemUser = GetSystemUserByUserName(username);
            if (systemUser == null)
                return enStatus.UserNotFound;
            if (!systemUser.IsActive)
                return enStatus.NotActive;
            if (systemUser.Password != password)
                return enStatus.InvalidPassword;
            return enStatus.Success;
        }

        public static bool RememberMe(string? username, string? password, bool remeber)
        {
            // This is a placeholder implementation. In a real application, you would implement this using cookies or local storage.
            if (Authenticate(username, password) == enStatus.Success)
            {
                // Store the username and password securely (e.g., in a cookie or local storage)

                return DVLD_DataAccessLayer.SystemUserRepository.RemberMe(username, password, remeber);
            }
            return false;
        }
    }
}
