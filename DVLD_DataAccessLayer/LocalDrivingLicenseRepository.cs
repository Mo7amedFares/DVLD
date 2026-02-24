using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccessLayer
{
    public class LocalDrivingLicenseRepository:databaseconnection
    {
        public static DataTable GetAllRequestLocalDrivingLicense()
        {
            string storedProc = "sp_GetAllRequestsLocalDriverLicense";
            return DBHelper.ExecuteSelectCommand(storedProc, CommandType.StoredProcedure);
        }
        public static DataTable GetRequestLocalDrivingLicenseByID(int Request_ID)
        {
            string storedProc = "sp_GetRequestLocalDriverLicenseByID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_ID", Request_ID);
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }
        public static int AddLocalDrivingLicense(int Request_id, int License_Class_ID)
        {
            string storedProc = "sp_AddLocalDrivingLicense";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_id", Request_id);
            parameters.Add("@License_Class_ID", License_Class_ID);
            return Convert.ToInt32( DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters));
        }

        public static bool UpdateLocalDrivingLicense(int Request_id, int License_Class_ID)
        {
            string storedProc = "sp_UpdateLocalDrivingLicense";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_id", Request_id);
            parameters.Add("@License_Class_ID", License_Class_ID);
            return DBHelper.ExecuteParameterizedNonQuery(storedProc, CommandType.StoredProcedure, parameters) > 0;
        }

        public static DataTable GetRequestLocalDrivingLicenseByUserID(int user_id)
        {
            string storedProc = "sp_GetRequestLocalDriverLicenseByUserID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@user_id", user_id);
            return DBHelper.ExecutePramterizedSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }
    }
}
