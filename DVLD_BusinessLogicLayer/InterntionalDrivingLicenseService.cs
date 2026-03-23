using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BusinessLogicLayer
{
    public class InterntionalDrivingLicenseService: RequestService
    {
        public int DriverID { get; set; }
        public int CreatedByUserId { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int RequestID { get; set; }
        public int? InternationalDrivingLicenseID { get; set; }

  
        public InterntionalDrivingLicenseService(int driverID, int createdByUserId, int issuedUsingLocalLicenseID, DateTime expirationDate, int requestID)
        {
            DriverID = driverID;
            CreatedByUserId = createdByUserId;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            ExpirationDate = expirationDate;
            RequestID = requestID;
        }

        public InterntionalDrivingLicenseService(int driverID, int createdByUserId, int issuedUsingLocalLicenseID, DateTime expirationDate, int requestID, int? newInternationalDrivingLicenseID)
        {
            DriverID = driverID;
            CreatedByUserId = createdByUserId;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            ExpirationDate = expirationDate;
            RequestID = requestID;
            InternationalDrivingLicenseID = newInternationalDrivingLicenseID;
        }
        public InterntionalDrivingLicenseService(int? Base_Request_ID, int user_id, DateTime date, DateTime lastStatusDate, enState state, int created_by_system_user, decimal paidFees, int License_Class_ID , int driverID,  int issuedUsingLocalLicenseID, DateTime expirationDate)
            : base(Base_Request_ID, user_id, date, lastStatusDate, state, created_by_system_user, paidFees, 6)
        {
            this.DriverID= driverID;
            this.ExpirationDate = expirationDate;
            this.IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            this.CreatedByUserId = created_by_system_user;


        }

        public InterntionalDrivingLicenseService()
        {
        }
       
        public static DataRow GetInterntionalDrivingLicenseByID(int internationalDrivingLicenseID)
        {
            DataTable dt = DVLD_DataAccessLayer.InterntionalDrivingLicenseRepository.GetInterntionalDrivingLicenseByID(internationalDrivingLicenseID);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
        public static DataTable GetAllInterntionalLicenseDriving()
        {
            return DVLD_DataAccessLayer.InterntionalDrivingLicenseRepository.GetAllInterntionalLicenseDriving();
        }

        public static DataRow GetApplicationInfoToNewInterntionalLicenseByLicenseID(int licenseID)
        {
            DataTable dt = DVLD_DataAccessLayer.InterntionalDrivingLicenseRepository.GetApplicationInfoToNewInterntionalLicenseByLicenseID(licenseID);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool AddInterntionalDrivingLicense()
        {
            int? requestId = base.AddRequest();
            if (requestId.HasValue)
            {
                this.RequestID = requestId.Value;
                this.InternationalDrivingLicenseID = DVLD_DataAccessLayer.InterntionalDrivingLicenseRepository.AddNewInternationalDrivingLicense(this.RequestID, this.DriverID, this.CreatedByUserId, this.IssuedUsingLocalLicenseID, this.ExpirationDate);
                return this.InternationalDrivingLicenseID!=null;
            }
            return false;
        }

    }
}
