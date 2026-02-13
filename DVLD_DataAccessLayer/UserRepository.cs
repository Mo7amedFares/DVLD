// Ensure you have the following NuGet package installed in your project:
// System.Data.SqlClient

using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public class UserRepository : databaseconnection
    {

        public static DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetUsers", con);
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

        public static bool GetUserById(int userId, ref string First_Name, ref string Secound_Name, ref string Third_Name, ref string Last_Name, ref DateTime Date_Of_Birth, ref int Age, ref string Email, ref string Phone, ref string Nationality, ref string Address, ref string Profile_Photo_URL, ref char Gender, ref string SSN)
        {
            bool found = false;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_ID", userId);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                First_Name = reader["First_Name"].ToString();
                                Secound_Name = reader["Second_Name"].ToString();
                                Third_Name = reader["Third_Name"].ToString();
                                Last_Name = reader["Last_Name"].ToString();
                                Date_Of_Birth = reader.IsDBNull(reader.GetOrdinal("Date_Of_Birth"))
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["Date_Of_Birth"]);
                                Age = reader.IsDBNull(reader.GetOrdinal("Age"))
                                    ? 0
                                    : Convert.ToInt32(reader["Age"]);
                                Email = reader["Email"].ToString();
                                Phone = reader["Phone"].ToString();
                                Nationality = reader["Nationality"].ToString();
                                Address = reader["Address"].ToString();
                                Profile_Photo_URL = reader["Profile_Photo_URL"].ToString();
                                SSN = reader["SSN"].ToString();
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender"))
                                    ? '\0'
                                    : Convert.ToChar(reader["Gender"]);
                                found = true;
                            }
                        }
                        con.Close();
                        return found;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return found;
        }

        public static bool GetUserBySSN(string ssn, ref int User_ID, ref string First_Name, ref string Secound_Name, ref string Third_Name, ref string Last_Name, ref DateTime Date_Of_Birth, ref int Age, ref string Email, ref string Phone, ref string Nationality, ref string Address, ref string Profile_Photo_URL, ref char Gender)
        {
            bool found = false;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserBySSN", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User_ID = reader.IsDBNull(reader.GetOrdinal("User_ID"))
                                    ? 0
                                    : Convert.ToInt32(reader["User_ID"]);
                                First_Name = reader["First_Name"].ToString();
                                Secound_Name = reader["Second_Name"].ToString();
                                Third_Name = reader["Third_Name"].ToString();
                                Last_Name = reader["Last_Name"].ToString();
                                Date_Of_Birth = reader.IsDBNull(reader.GetOrdinal("Date_Of_Birth"))
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["Date_Of_Birth"]);
                                Age = reader.IsDBNull(reader.GetOrdinal("Age"))
                                    ? 0
                                    : Convert.ToInt32(reader["Age"]);
                                Email = reader["Email"].ToString();
                                Phone = reader["Phone"].ToString();
                                Address = reader["Address"].ToString();
                                Profile_Photo_URL = reader["Profile_Photo_URL"].ToString();
                                Nationality = reader["Nationality"].ToString();
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender"))
                                    ? '\0'
                                    : Convert.ToChar(reader["Gender"]);

                                found = true;
                            }
                        }
                        con.Close();
                        return found;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return found;
        }

        public static bool GetUserByEmail(string email, ref int User_ID, ref string First_Name, ref string Secound_Name, ref string Third_Name, ref string Last_Name, ref DateTime Date_Of_Birth, ref int Age, ref string Phone, ref string Nationality, ref string Address, ref string Profile_Photo_URL, ref char Gender, ref string SSN)
        {
            bool found = false;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetUserByEmail", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", email);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User_ID = reader.IsDBNull(reader.GetOrdinal("User_ID"))
                                    ? 0
                                    : Convert.ToInt32(reader["User_ID"]);
                                First_Name = reader["First_Name"].ToString();
                                Secound_Name = reader["Second_Name"].ToString();
                                Third_Name = reader["Third_Name"].ToString();
                                Last_Name = reader["Last_Name"].ToString();
                                Date_Of_Birth = reader.IsDBNull(reader.GetOrdinal("Date_Of_Birth"))
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["Date_Of_Birth"]);
                                Age = reader.IsDBNull(reader.GetOrdinal("Age"))
                                    ? 0
                                    : Convert.ToInt32(reader["Age"]);
                                Phone = reader["Phone"].ToString();
                                Nationality = reader["Nationality"].ToString();
                                Address = reader["Address"].ToString();
                                Profile_Photo_URL = reader["Profile_Photo_URL"].ToString();
                                SSN = reader["SSN"].ToString();
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender"))
                                    ? '\0'
                                    : Convert.ToChar(reader["Gender"]);
                                found = true;
                            }
                        }
                        con.Close();
                        return found;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return found;
        }

        public static bool GetUserByPhone(string phone, ref int User_ID, ref string First_Name, ref string Secound_Name, ref string Third_Name, ref string Last_Name, ref DateTime Date_Of_Birth, ref int Age, ref string Email, ref string Nationality, ref string Address, ref string Profile_Photo_URL, ref char Gender, ref string SSN)
        {
            bool found = false;
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = $"select * from Users where Users.Phone = '{phone}'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User_ID = reader.IsDBNull(reader.GetOrdinal("User_ID"))
                                    ? 0
                                    : Convert.ToInt32(reader["User_ID"]);
                                First_Name = reader["First_Name"].ToString();
                                Secound_Name = reader["Second_Name"].ToString();
                                Third_Name = reader["Third_Name"].ToString();
                                Last_Name = reader["Last_Name"].ToString();
                                Date_Of_Birth = reader.IsDBNull(reader.GetOrdinal("Date_Of_Birth"))
                                    ? DateTime.MinValue
                                    : Convert.ToDateTime(reader["Date_Of_Birth"]);
                                Age = reader.IsDBNull(reader.GetOrdinal("Age"))
                                    ? 0
                                    : Convert.ToInt32(reader["Age"]);
                                Email = reader["Email"].ToString();
                                Nationality = reader["Nationality"].ToString();
                                Address = reader["Address"].ToString();
                                Profile_Photo_URL = reader["Profile_Photo_URL"].ToString();
                                SSN = reader["SSN"].ToString();
                                Gender = reader.IsDBNull(reader.GetOrdinal("Gender"))
                                    ? '\0'
                                    : Convert.ToChar(reader["Gender"]);
                                found = true;
                            }
                        }
                        con.Close();
                        return found;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return found;
        }

        public static bool UpdateUser(int userId, string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int age, string email, string phone, string nationality, string address, string profilePhotoURL, char gender, string ssn)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_ID", userId);
                        cmd.Parameters.AddWithValue("@First_Name", firstName);
                        cmd.Parameters.AddWithValue("@Second_Name", secondName);
                        cmd.Parameters.AddWithValue("@Third_Name", thirdName);
                        cmd.Parameters.AddWithValue("@Last_Name", lastName);
                        cmd.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Nationality", nationality);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Profile_Photo_URL", profilePhotoURL);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return false;
        }

        public static int AddNewUser(string firstName, string secondName, string thirdName, string lastName, DateTime dateOfBirth, int age, string email, string phone, string nationality, string address, string profilePhotoURL, char gender, string ssn)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddNewUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@First_Name", firstName);
                        cmd.Parameters.AddWithValue("@Second_Name", secondName);
                        cmd.Parameters.AddWithValue("@Third_Name", thirdName);
                        cmd.Parameters.AddWithValue("@Last_Name", lastName);
                        cmd.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Nationality", nationality);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Profile_Photo_URL", profilePhotoURL);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        con.Close();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return -1;
        }


        public static bool DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_ID", userId);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
            return false;
        }
    }
}
