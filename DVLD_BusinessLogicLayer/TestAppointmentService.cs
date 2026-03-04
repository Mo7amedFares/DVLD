using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BusinessLogicLayer
{
    public class TestAppointmentService
    {
        public static int AddTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, double PaidFees, int CreatedByUserID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.AddTestAppointment(LocalDrivingLicenseApplicationID , TestTypeID , PaidFees , CreatedByUserID);
        }

        public static DataTable GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(int LicenseDriveID, int TestTypeID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.GetAllTestAppointmentsByLicenseDriveIDAndTestTypeID(LicenseDriveID, TestTypeID);
        }

        public static int GetCountOfTestAppointmentsByLicenseDriveID(int LicenseDriveID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.GetCountOfTestAppointmentsCompletedByLicenseDriveID(LicenseDriveID);
        }

        public static bool doseTestAppointmentIsNotCompleted(int LicenseDriveID, int TestTypeID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.doseTestAppointmentIsNotCompleted(LicenseDriveID, TestTypeID);
        }

        public static bool doseTestAppointmentIsCompletedAndPassed(int LicenseDriveID, int TestTypeID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.doseTestAppointmentIsCompletedAndPassed(LicenseDriveID, TestTypeID);
        }

        public static bool doseTestAppointmentIsCompletedAndFailed(int LicenseDriveID, int TestTypeID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.doseTestAppointmentIsCompletedAndFailed(LicenseDriveID, TestTypeID);
        }
        public static bool TakeTestAppointment(int TestAppointmentID, bool TestResult, int UpdatedByUserID, string Notes)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.TakeTestAppointment(TestAppointmentID, TestResult, UpdatedByUserID , Notes);
        }

        public static DataRow GetDateToTestAppointmentBy(int TestAppointmentID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.GetDateToTestAppointmentBy(TestAppointmentID);
        }

        public static DataRow GetDateToAddTestAppointmentBy(int LocalDrivingLicenseID, int TestTypeID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.GetDateToAddTestAppointmentBy(LocalDrivingLicenseID, TestTypeID);
        }
        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate, int UpdatedByUserID)
        {
            return DVLD_DataAccessLayer.TestAppointmentRepository.UpdateTestAppointment(TestAppointmentID,AppointmentDate ,UpdatedByUserID);
        }


    }
}
