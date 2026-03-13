using System;

namespace DVLD_BusinessLogicLayer
{
    public class LicenseService
    {
        public enum enIssueReason : byte
        {
            FirstTime             = 1,
            Renewal               = 2,
            ReplacementForDamaged = 3,
            ReplacementForLost    = 4
        }

        public int LicenseID      { get; set; }
        public int RequestID      { get; set; }
        public int DriverID       { get; set; }
        public int LicenseClass   { get; set; }
        public DateTime IssueDate       { get; set; }
        public DateTime ExpirationDate  { get; set; }
        public string Notes       { get; set; }
        public decimal PaidFees   { get; set; }
        public bool IsActive      { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedBy      { get; set; }

        private int Add()
        {
            return DVLD_DataAccessLayer.LicenseRepository.AddLicense(
                RequestID, DriverID, LicenseClass,
                IssueDate, ExpirationDate, Notes,
                PaidFees, IsActive, (byte)IssueReason, CreatedBy);
        }

        /// <summary>
        /// Issues a first-time driving license:
        /// creates driver if needed → adds license → updates Active_Licenses → completes request.
        /// Returns the new LicenseID, or -1 on failure.
        /// </summary>
        public static int IssueFirstTimeLicense(
            LocalDrivingLicenseService localDrivingLicense,
            string notes,
            int createdBySystemUserID)
        {
            // 1. Check / create driver
            int driverID = DVLD_DataAccessLayer.DriverRepository.GetDriverIDByUserID(localDrivingLicense.user_id);
            if (driverID == -1)
            {
                driverID = DVLD_DataAccessLayer.DriverRepository.AddDriver(
                    localDrivingLicense.user_id, DateTime.Now, createdBySystemUserID);
                if (driverID <= 0) return -1;
            }

            // 2. Get license class info (validity & fees)
            LicenseClassService licenseClass = LicenseClassService.GetLicenseClassByID(localDrivingLicense.License_Class_ID);
            if (licenseClass == null) return -1;

            DateTime issueDate      = DateTime.Now;
            DateTime expirationDate = issueDate.AddYears(licenseClass.ValidityLength);

            // 3. Add license record
            LicenseService license = new LicenseService
            {
                RequestID      = localDrivingLicense.Request_id,
                DriverID       = driverID,
                LicenseClass   = localDrivingLicense.License_Class_ID,
                IssueDate      = issueDate,
                ExpirationDate = expirationDate,
                Notes          = notes,
                PaidFees       = licenseClass.Fees,
                IsActive       = true,
                IssueReason    = enIssueReason.FirstTime,
                CreatedBy      = createdBySystemUserID
            };

            int newLicenseID = license.Add();
            if (newLicenseID <= 0) return -1;

            // 4. Increment Active_Licenses on driver
            DVLD_DataAccessLayer.DriverRepository.UpdateActiveLicenses(driverID, 1);

            // 5. Mark request as Completed
            DVLD_DataAccessLayer.RequestRepository.ChangeRequestState(
                localDrivingLicense.Request_id,
                (int)RequestService.enState.Completed);

            return newLicenseID;
        }
        public static bool ExistLicenseDriveBy(int Local_Driving_License_Id)
        {
            return DVLD_DataAccessLayer.LicenseRepository.ExistLicenseDriveBy(Local_Driving_License_Id);
        }
    }
}