using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DVLD_Persntation
{
    public partial class US_ApplicationBaseInfo : UserControl
    {
        public US_ApplicationBaseInfo()
        {
            InitializeComponent();
        }
        int _personID;

        public void LoadData(int RequestID)
        {
            DVLD_BusinessLogicLayer.RequestService request = new DVLD_BusinessLogicLayer.RequestService(RequestID);
            if (request != null)
            {
                lblRequestID.Text = request.Request_ID.ToString();
                DVLD_BusinessLogicLayer.ApplicationTypesService typesService = new DVLD_BusinessLogicLayer.ApplicationTypesService();
                if (typesService.GetApplicationTypeById(request.RequestTypeID)) lblTypes.Text = typesService.Name;
                lblDate.Text = request.Date.ToShortDateString();
                lblFees.Text = request.PaidFees.ToString("C");
                lblFullName.Text = DVLD_BusinessLogicLayer.UserService.GetUserFullNameByID(request.user_id);
                lblLastStatusDate.Text = request.LastStatusDate.ToShortDateString();
                lblStatus.Text = request.enstate.ToString();
                lblCreatedBy.Text = DVLD_BusinessLogicLayer.SystemUserService.GetUsernameById(request.created_by_system_user);
                _personID = request.user_id;

            }
        }

        private void lnkViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonInfoForm personInfoForm = new PersonInfoForm(_personID);
            personInfoForm.ShowDialog();
        }

        private void gboxApplicationInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
