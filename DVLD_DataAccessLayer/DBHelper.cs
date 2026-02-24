using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class DBHelper : databaseconnection
    {
        public static DataTable ExecuteSelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing select query: " + ex.Message);
            }
            return dt;
        }
        public static int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing non-query: " + ex.Message);
            }
            return rowsAffected;
        }

        public static object ExecutePramterizedScalar(string query , CommandType commandType , Dictionary<string , object> pramters)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = commandType;
                        if (pramters == null)
                        {
                            throw new ArgumentNullException(nameof(pramters));
                        }

                        foreach (var item in pramters)
                        {
                            var parameter = cmd.CreateParameter();
                            parameter.ParameterName = item.Key;
                            parameter.Value = item.Value ?? DBNull.Value;
                            cmd.Parameters.Add(parameter);
                        }
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing scalar query: " + ex.Message);
            }
            return result;
        }

        public static DataTable ExecuteParameterizedSelectQuery(string query, Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing parameterized select query: " + ex.Message);
            }
            return dt;
        }

        public static int ExecuteParameterizedNonQuery(string query,CommandType commandType,Dictionary<string , object> parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = commandType;
                        foreach (var item in parameters)
                        {
                            var p = cmd.CreateParameter();
                            p.ParameterName = item.Key;
                            p.Value = item.Value ?? DBNull.Value;
                            cmd.Parameters.Add(p);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing parameterized non-query: " + ex.Message);
            }
            return rowsAffected;
        }

        public static object ExecuteParameterizedScalar(string query, Dictionary<string, object> parameters)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing parameterized scalar query: " + ex.Message);
            }
            return result;
        }

        public static DataTable ExecutePramterizedSelectCommand(string query, CommandType commandtype , Dictionary<string, object> parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = commandtype;
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing parameterized select command: " + ex.Message);
            }
            return dt;
        }

        public static int ExecuteNonQueryStoredProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing non-query stored procedure: " + ex.Message);
            }
            return rowsAffected;
        }

        public static bool IsExist(string tableName, string columnName, object value)
        {
            string query = $"SELECT 1 FROM {tableName} WHERE {columnName} = {value.ToString()}";

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error checking existence: " + ex.Message);
            }
        }
        public static DataTable ExecuteSelectCommand(string commandText, CommandType commandType, Dictionary<string, object>? parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        cmd.CommandType = commandType;
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing select command: " + ex.Message);
            }
            return dt;
        }
    }
}
