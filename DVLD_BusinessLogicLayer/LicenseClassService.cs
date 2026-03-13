using System;
using System.Data;

namespace DVLD_BusinessLogicLayer
{
    public class LicenseClassService
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int ValidityLength { get; set; }
        public decimal Fees { get; set; }

        public static DataTable GetAllIdAndNameLicenseClasses()
        {
            return DVLD_DataAccessLayer.LicenseClassRepository.GetAllIdAndName();
        }

        public static string GetClassNameByID(int License_Class_ID)
        {
            return DVLD_DataAccessLayer.LicenseClassRepository.GetClassNameByID(License_Class_ID);
        }

        public static LicenseClassService GetLicenseClassByID(int licenseClassID)
        {
            DataRow row = DVLD_DataAccessLayer.LicenseClassRepository.GetLicenseClassByID(licenseClassID);
            if (row == null) return null;
            return new LicenseClassService
            {
                ID               = Convert.ToInt32(row["ID"]),
                Name             = row["LicenseClassName"].ToString(),
                Description      = row["Description"] as string,
                MinimumAllowedAge = Convert.ToInt32(row["MinimumAllowedAge"]),
                ValidityLength   = Convert.ToInt32(row["ValidityLength"]),
                Fees             = Convert.ToDecimal(row["Fees"])
            };
        }
    }
}
