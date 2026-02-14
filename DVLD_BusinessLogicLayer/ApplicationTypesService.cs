using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace DVLD_BusinessLogicLayer
{
    public class ApplicationTypesService
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; } = string.Empty;
        public decimal Fees { get; set; } = -1;
        public static DataTable GetApplicationTypes()
        {
            return DVLD_DataAccessLayer.ApplicationTypesRepository.GetApplicationTypes();
        }
        public static bool UpdateApplicationType(int id, string name, decimal fees)
        {
            return DVLD_DataAccessLayer.ApplicationTypesRepository.UpdateApplicationType(id, name, fees);
        }

        public bool GetApplicationTypeById(int id)
        {
            bool result = DVLD_DataAccessLayer.ApplicationTypesRepository.GetApplicationTypeById(id, out string Name, out decimal Fees);
            this.ID = id;
            this.Name = Name;
            this.Fees = Fees;
            return result;
        }
    }

}
