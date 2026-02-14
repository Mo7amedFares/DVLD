using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class ApplicationTypesRepository : databaseconnection
    {
        public static DataTable GetApplicationTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetApplecationTypes", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                // Log the error or handle it appropriately
                throw;
            }

            return dt;

        }

        public static bool UpdateApplicationType(int id, string name, decimal fees)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateApplicationType", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Fees", fees);
                        con.Open();

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return false;
        }

        public static bool GetApplicationTypeById(int id, out string name, out decimal fees)
        {
            name = string.Empty;
            fees = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetApplicationTypeById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", id);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                name = reader["Name"].ToString();
                                fees = Convert.ToDecimal(reader["Fees"]);
                                return true;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return false;
        }
    }
}
