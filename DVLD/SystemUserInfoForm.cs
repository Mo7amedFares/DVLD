using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD_Persntation
{
    public partial class SystemUserInfoForm : Form
    {
        public SystemUserInfoForm(int systemUserId)
        {
            InitializeComponent();
            uS_SystemUserInfo1.loadData(systemUserId);
        }
    }
}
