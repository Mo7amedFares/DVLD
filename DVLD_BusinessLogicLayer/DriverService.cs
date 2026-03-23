using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BusinessLogicLayer
{
    public class DriverService
    {
        public enum enActiveLicenseOperation : byte
        {
            Decrement = 0,
            Increment = 1
        }
        public static DataTable GetAllDrivers()
        {
            return DVLD_DataAccessLayer.DriverRepository.GetAllDrivers();
        }
        public static int GetDriverIDByUserID(int userID)
        {
            return DVLD_DataAccessLayer.DriverRepository.GetDriverIDByUserID(userID);
        }

        public static bool IsDriverExistForUser(int userID)
        {
            return DVLD_DataAccessLayer.DriverRepository.IsDriverExistForUser(userID);
        }

        public static int AddDriver(int userID, DateTime creatDate, int createdBy)
        {
            return DVLD_DataAccessLayer.DriverRepository.AddDriver(userID, creatDate, createdBy);
        }

        public static bool UpdateActiveLicenses(int driverID, enActiveLicenseOperation operation)
        {
            return DVLD_DataAccessLayer.DriverRepository.UpdateActiveLicenses(driverID, (byte)operation);
        }
    }
}
