using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
