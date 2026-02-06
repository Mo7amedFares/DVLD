using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class US_SystemUserInfo : UserControl
    {
        public US_SystemUserInfo()
        {
            InitializeComponent();
        }

        public void loadData(int SystemUserID)
        {
            var systemUser = DVLD_BusinessLogicLayer.SystemUserService.GetSystemUserById(SystemUserID);
            lblSystemUserID.Text = systemUser.System_User_Id.ToString();
            lblUserName.Text = systemUser.Username;
            lblIsActive.Text = systemUser.IsActive ? "Yes" : "No";
            uC_PersonInfomation1.LoadData(systemUser.User_ID);
        }
    }
}
