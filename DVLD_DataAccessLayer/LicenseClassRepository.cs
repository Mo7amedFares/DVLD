using System.Data;

namespace DVLD_DataAccessLayer
{
    public class LicenseClassRepository : databaseconnection
    {
        public static DataTable GetAllIdAndName()
        {
            string storedProc = "sp_GetAllLicenseClassesIdAndName";
            return DBHelper.ExecuteSelectCommand(storedProc, CommandType.StoredProcedure);
        }

        public static string GetClassNameByID(int License_Class_ID)
        {
            string storedProc = "sp_GetLicenseClassNameByID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@License_Class_ID", License_Class_ID);
            object result = DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters);
            return result != null ? result.ToString() : string.Empty;
        }

        public static DataRow GetLicenseClassByID(int licenseClassID)
        {
            string storedProc = "sp_GetLicenseClassByID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@License_Class_ID", licenseClassID);
            DataTable dt = DBHelper.ExecuteSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}