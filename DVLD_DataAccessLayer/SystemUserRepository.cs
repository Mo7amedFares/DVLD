// Ensure you have the following NuGet package installed in your project:
// System.Data.SqlClient

using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public class SystemUserRepository : databaseconnection
    {
        public static DataTable GetSystemUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection con = new SqlConnection(_connectionString);
                SqlDataAdapter da = new SqlDataAdapter("GetSystemUsers", con);
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

        public static bool GetSystemUserById(int SystemUserId, ref int User_ID, ref string Username, ref string Password, ref int? Permission, ref bool isActive)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSystemUserById", con))
                    {
                        bool found = false;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SystemUserId", SystemUserId);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User_ID = Convert.ToInt32(reader["User_ID"]);
                                Username = reader["Username"].ToString();
                                Password = reader["Password"].ToString();
                                Permission = Convert.ToInt32(reader["Permission"]);
                                isActive = Convert.ToBoolean(reader["isActive"]);
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
            return false;
        }

        public static bool GetSystemUserByUserId(int User_ID, ref int SystemUserId, ref string Username, ref string Password, ref int? Permission, ref bool isActive)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSystemUserByUserId", con))
                    {
                        bool found = false;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_ID", User_ID);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SystemUserId = Convert.ToInt32(reader["system_user_id"]);
                                Username = reader["Username"].ToString();
                                Password = reader["Password"].ToString();
                                Permission = Convert.ToInt32(reader["Permission"]);
                                isActive = Convert.ToBoolean(reader["isActive"]);
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
            return false;
        }

        public static bool GetRememberedCredentials(ref string username, ref string password)
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rememberme.txt");
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line = reader.ReadLine();
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 2)
                            {
                                username = parts[0];
                                password = parts[1];
                                return true;
                            }
                        }
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

        public static bool UpdateSystemUser(int SystemUserId, int User_ID, string Username, string Password, int? Permission, bool isActive)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("UpdateSystemUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SystemUserId", SystemUserId);
                        cmd.Parameters.AddWithValue("@User_ID", User_ID);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Permission", Permission);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
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

        public static bool AddNewSystemUser(int User_ID, string Username, string Password, int? Permission, bool isActive)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddNewSystemUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@User_ID", User_ID);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Permission", Permission);
                        cmd.Parameters.AddWithValue("@isActive", isActive);
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

        public static bool DeleteSystemUser(int SystemUserId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("DeleteSystemUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SystemUserId", SystemUserId);
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

        public static bool GetSystemUserByUsername(string username, ref int SystemUserId, ref int User_ID, ref string Password, ref int? Permission, ref bool isActive)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetSystemUserByUsername", con))
                    {
                        bool found = false;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                SystemUserId = Convert.ToInt32(reader["system_user_id"]);
                                User_ID = Convert.ToInt32(reader["User_ID"]);
                                Password = reader["Password"].ToString();
                                Permission = Convert.ToInt32(reader["Permission"]);
                                isActive = Convert.ToBoolean(reader["isActive"]);
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
            return false;
        }

        public static bool isUsernameExists(string username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("IsUsernameExists", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username);
                        con.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
        }

        public static bool ChangePassword(int SystemUserId, string newPassword)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ChangeSystemUserPassword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SystemUserId", SystemUserId);
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
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
        }

        public static bool RemberMe(string username, string pasword, bool remember)
        {
            FileStream fileStream = null;

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rememberme.txt");
                if (remember)
                {
                    using (StreamWriter writer = new StreamWriter(filePath, false))
                    {
                        writer.WriteLine($"{username}|{pasword}");
                    }
                }
                else
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                throw;
            }
        }
    }

}
