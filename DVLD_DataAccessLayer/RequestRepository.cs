using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccessLayer
{
    public class RequestRepository
    {

        public static DataTable GetRequestByID(int Request_ID)
        {
            string storedProc = "sp_GetRequestByID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_ID", Request_ID);
            return DBHelper.ExecuteSelectCommand(storedProc, CommandType.StoredProcedure, parameters);
        }
        public static int? AddRequest(int? Base_Request_ID, int user_id, DateTime date, int state, int created_by_system_user, decimal paidFees, int requestType)
        {
            string storedProc = "sp_AddRequest";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Base_Request_ID", Base_Request_ID);
            parameters.Add("@user_id", user_id);
            parameters.Add("@date", date);
            parameters.Add("@state", state);
            parameters.Add("@created_by_system_user", created_by_system_user);
            parameters.Add("@paidFees", paidFees);
            parameters.Add("@requestType", requestType);


            return (int?)(DBHelper.ExecutePramterizedScalar(storedProc, CommandType.StoredProcedure, parameters));
        }

        public static bool UpdateRequest(int Request_ID, int? Base_Request_ID, int user_id, DateTime date, int state, int created_by_system_user, decimal paidFees, int requestType)
        {
            string storedProc = "sp_UpdateRequest";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_ID", Request_ID);
            parameters.Add("@Base_Request_ID", Base_Request_ID);
            parameters.Add("@user_id", user_id);
            parameters.Add("@date", date);
            parameters.Add("@state", state);
            parameters.Add("@created_by_system_user", created_by_system_user);
            parameters.Add("@paidFees", paidFees);
            parameters.Add("@requestType", requestType);
            return DBHelper.ExecuteParameterizedNonQuery(storedProc, CommandType.StoredProcedure, parameters) > 0;
        }

        public static bool ChangeRequestState(int Request_ID, int newState)
        {
            string storedProc = "sp_ChangeRequestState";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Request_ID", Request_ID);
            parameters.Add("@newState", newState);
            return DBHelper.ExecuteParameterizedNonQuery(storedProc, CommandType.StoredProcedure, parameters) > 0;

        }
    }
}