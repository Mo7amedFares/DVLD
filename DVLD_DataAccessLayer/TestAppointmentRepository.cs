using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccessLayer
{
    public class TestAppointmentRepository : databaseconnection
    {
        public static int AddTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, double PaidFees, int CreatedByUserID)
        {
            string query = "sp_AddTestAppointment";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LocalDrivngLicenseID", LocalDrivingLicenseApplicationID);
            parameters.Add("@TestTypeID", TestTypeID);
            parameters.Add("@payedTest", PaidFees);
            parameters.Add("@AppointmentDate", DateTime.Now);
            parameters.Add("@CreatedBy", CreatedByUserID);
            return Convert.ToInt32(DBHelper.ExecutePramterizedScalar(query, System.Data.CommandType.StoredProcedure, parameters));

        }

        public static DataTable GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(int LicenseDriveID, int TestTypeID)
        {
            string query = "sp_GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LicenseDriveID", LicenseDriveID);
            parameters.Add("@TestTypeID", TestTypeID);
            return DBHelper.ExecuteSelectCommand(query, System.Data.CommandType.StoredProcedure, parameters);
        }
        public static int GetCountOfTestAppointmentsCompletedByLicenseDriveID(int LicenseDriveID)
        {
            string query = "sp_GetCountOfTestAppointmentsCompletedByLicenseDriveID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LicenseDriveID", LicenseDriveID);
            return Convert.ToInt32(DBHelper.ExecutePramterizedScalar(query, System.Data.CommandType.StoredProcedure, parameters));
        }

        public static bool doseTestAppointmentIsNotCompleted(int LicenseDriveID, int TestTypeID)
        {
            string query = "sp_doseTestAppointmentIsNotCompleted";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LicenseDriveID", LicenseDriveID);
            parameters.Add("@TestTypeID", TestTypeID);
            return DBHelper.ExecutePramterizedScalar(query, System.Data.CommandType.StoredProcedure, parameters) != null;
        }

        public static bool doseTestAppointmentIsCompletedAndPassed(int LicenseDriveID, int TestTypeID)
        {
            string query = "sp_doseTestAppointmentIsCompletedAndPassed";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LicenseDriveID", LicenseDriveID);
            parameters.Add("@TestTypeID", TestTypeID);
            return DBHelper.ExecutePramterizedScalar(query, System.Data.CommandType.StoredProcedure, parameters) != null;
        }

        public static bool doseTestAppointmentIsCompletedAndFailed(int LicenseDriveID, int TestTypeID)
        {
            string query = "sp_doseTestAppointmentIsCompletedAndFailed";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LicenseDriveID", LicenseDriveID);
            parameters.Add("@TestTypeID", TestTypeID);
            return DBHelper.ExecutePramterizedScalar(query, System.Data.CommandType.StoredProcedure, parameters) != null;
        }

        public static bool TakeTestAppointment(int TestAppointmentID, bool IsPassed, int UpdatedByUserID, string Notes)
        {
            string query = "sp_TakeTestAppointment";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TestAppointmentID", TestAppointmentID);
            parameters.Add("@IsPassed", IsPassed);
            parameters.Add("@UpdatedByUserID", UpdatedByUserID);
            parameters.Add("@Notes", Notes);
            return DBHelper.ExecuteParameterizedNonQuery(query, System.Data.CommandType.StoredProcedure, parameters) > 0;
        }
        public static DataRow GetDateToTestAppointmentBy(int TestAppointmentID)
        {
            string query = "sp_GetDateToTestAppointment";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TestAppointmentID", TestAppointmentID);
            DataTable dt = DBHelper.ExecuteSelectCommand(query, System.Data.CommandType.StoredProcedure, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public static DataRow GetDateToAddTestAppointmentBy(int LocalDrivingLicenseID, int TestTypeID)
        {
            string query = "sp_GetDateToAddTestAppointmentByLocalDrivingLicenseIDAndTestTypeID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LocalDrivingLicenseID", LocalDrivingLicenseID);
            parameters.Add("@TestTypeID", TestTypeID);
            DataTable dt = DBHelper.ExecuteSelectCommand(query, System.Data.CommandType.StoredProcedure, parameters);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate, int UpdatedByUserID)
        {
            string query = "sp_UpdateTestAppointment";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@TestAppointmentID", TestAppointmentID);
            parameters.Add("@AppointmentDate", AppointmentDate);
            parameters.Add("@UpdatedByUserID", UpdatedByUserID);
            return DBHelper.ExecuteParameterizedNonQuery(query, System.Data.CommandType.StoredProcedure, parameters) > 0;
        }
    }
}

