using System;
using System.Collections.Generic;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public class DriverRepository : databaseconnection
    {

        public static DataTable GetAllDrivers()
        {
            string storedProc = "sp_GetAllDrivers";
            return DBHelper.ExecuteSelectCommand(storedProc, CommandType.StoredProcedure);
        }
        public static int GetDriverIDByUserID(int userID)
        {
            string storedProc = "sp_IsDriverExistForUser";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@user_id", userID }
            };
            object result = DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public static bool IsDriverExistForUser(int userID)
        {
            return GetDriverIDByUserID(userID) != -1;
        }

        public static int AddDriver(int userID, DateTime creatDate, int createdBy)
        {
            string storedProc = "sp_AddDriver";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@user_id",   userID    },
                { "@CreatDate", creatDate },
                { "@CreatedBy", createdBy }
            };
            object result = DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        // operation: 1 = increment | 0 = decrement
        public static bool UpdateActiveLicenses(int driverID, byte operation)
        {
            string storedProc = "sp_UpdateActiveLicenses";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@DriverID",  driverID  },
                { "@Operation", operation }
            };
            return DBHelper.ExecuteParameterizedNonQuery(storedProc, CommandType.StoredProcedure, parameters) > 0;
        }

        
    }
}