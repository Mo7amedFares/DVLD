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
    }
}