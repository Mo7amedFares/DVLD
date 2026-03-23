using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public class LicenseRepository : databaseconnection
    {
        public static int AddLicense(int requestID, int driverID, int licenseClass,
            DateTime issueDate, DateTime expirationDate, string notes,
            decimal paidFees, bool isActive, byte issueReason, int createdBy)
        {
            string storedProc = "sp_AddLicense";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@RequestID",      requestID  },
                { "@DriverID",       driverID   },
                { "@LicenseClass",   licenseClass },
                { "@IssueDate",      issueDate  },
                { "@ExpirationDate", expirationDate },
                { "@Notes",          string.IsNullOrWhiteSpace(notes) ? (object)DBNull.Value : notes },
                { "@PaidFees",       paidFees   },
                { "@IsActive",       isActive   },
                { "@IssueReason",    issueReason },
                { "@CreatedBy",      createdBy  }
            };
            object result = DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public static bool ExistLicenseDriveBy(int localDrivingLicenseID)
        {
            string storedProc = "sp_ExistLicenseDriveBylocalDrivingLicenseID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@localDrivingLicenseID", localDrivingLicenseID }
            };
            object result = DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters);
            return result != null;
        }

        public static DataTable GetDriverLicenseInfoByLocalDrivingLicenseID(int LocalDrivingLicenseID)
        {
            string storedProc = "sp_getDriverLicenseInfoByLocalDrivingLicenseID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Local_Driving_License_Id", LocalDrivingLicenseID }
            };
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }
        public static DataTable GetLocalDriverLicenseHistoryBy(int driverID)
        {
            string storedProc = "sp_GetlocalDriverLicenseHistoryByDriverID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@DriverID", driverID }
            };
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetInerntionalDriverLicenseHistoryBy(int driverID)
        {
            string storedProc = "sp_GetInternationalDriverLicenseHistoryByDriverID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@DriverID", driverID }
            };
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }

        public static DataTable GetDriverLicenseInfoByLicenseID(int LicenseID)
        {
            string storedProc = "sp_getDriverLicenseInfoByLicenseID";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@LicenseID", LicenseID }
            };
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);

        }

        public static bool IsActiveLicenseDriveBy(int licenseID)
        {
            string query = "sp_IsActiveLicenseDriveByLicenseID";
            Dictionary<string, object> parmters = new Dictionary<string, object>
            {
                {"@LicenseID", licenseID }
            };

            return DBHelper.ExecutePramterizedScalar(query,CommandType.StoredProcedure, parmters)!=null;
        }
    }
}