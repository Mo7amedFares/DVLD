using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccessLayer
{
    public class InterntionalDrivingLicenseRepository
    {
        public static DataTable GetAllInterntionalLicenseDriving()
        {
            string query = "sp_GetAllInterntionalLicenseDriving";
            return DBHelper.ExecuteSelectCommand(query, CommandType.StoredProcedure);
        }
        public static DataTable GetApplicationInfoToNewInterntionalLicenseByLicenseID(int licenseID)
        {
            string query = "sp_GetApplicationInfoToNewInterntionalLicenseByLicenseID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@LicensID", licenseID   }
            };
            return DBHelper.ExecuteSelectCommand(query, CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetInterntionalDrivingLicenseByID(int internationalDrivingLicenseID)
        {
            string query = "sp_GetInterntionalDrivingLicenseByID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@InternationalDrivingLicenseID", internationalDrivingLicenseID }
            };
            return DBHelper.ExecuteSelectCommand(query, CommandType.StoredProcedure, parameters);
        }

        public static int? AddNewInternationalDrivingLicense(int requestID, int driverID, int created_by_User_Id, int issuedUsingLocalLicenseID, DateTime expirationDate)
        {
            string query = "sp_AddNewInternationalDrivingLicense";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@RequestID", requestID },
                { "@DriverID", driverID },
                { "@created_by_User_Id", created_by_User_Id },
                { "@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseID },
                {"@IssueDate" , DateTime.Now },
                { "@ExpirationDate", expirationDate }
            };
            return Convert.ToInt32(DBHelper.ExecuteScalar(query, CommandType.StoredProcedure, parameters));
        }


    }
}
