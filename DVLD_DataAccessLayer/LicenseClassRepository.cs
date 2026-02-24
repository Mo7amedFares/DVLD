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
    }
}