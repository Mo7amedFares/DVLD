using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DVLD_DataAccessLayer
{
    public class TestTypesRepository
    {
        public static DataTable GetTestTypes()
        {
            string query = "SELECT * FROM TestTypes";
            return DBHelper.ExecuteSelectQuery(query);
        }

        public static bool UpdateTestType(int id , string name , string description)
        {
            string query = $"UPDATE TestTypes SET Name = '{name}', Description = '{description}' WHERE ID = {id}";
            int rowsAffected = DBHelper.ExecuteNonQuery(query);
            return rowsAffected > 0;
        }

        public static DataRow FindTestTypeById(int id)
        {
            string query = $"SELECT * FROM TestTypes WHERE ID = {id}";
            DataTable result = DBHelper.ExecuteSelectQuery(query);
            if (result.Rows.Count > 0)
            {
                return result.Rows[0];
            }
            return null;
        }
    }
}
