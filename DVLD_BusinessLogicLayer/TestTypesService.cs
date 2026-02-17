using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_BusinessLogicLayer
{
    public class TestTypesService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Fees { get; set; }
        public static DataTable GetTestTypes()
        {
            return DVLD_DataAccessLayer.TestTypesRepository.GetTestTypes();
        }

        public  bool UpdateTestType()
        {
            return DVLD_DataAccessLayer.TestTypesRepository.UpdateTestType(this.Id, this.Name, this.Description);
        } 

        public static TestTypesService FindTestTypeById(int id)
        {
            DataRow testType =  DVLD_DataAccessLayer.TestTypesRepository.FindTestTypeById(id);
            if (testType!=null)
            {
                return new TestTypesService
                {
                    Id = id,
                    Name = testType["Name"].ToString(),
                    Description = testType["Description"].ToString(),
                    Fees = Convert.ToDecimal(testType["Fees"])
                };
            }
            else
            {
                return null;
            }
        }
    }
}
