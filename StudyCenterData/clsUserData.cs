using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsuserdata
    {
        public static int? AddUser(int? PersonID, string UserName, string password, bool isactive, int? Permissions)
        {
            int? UserID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"PersonID", (object)PersonID ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"UserName", (object)UserName ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"password", (object)password ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"isactive", (object)isactive ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Permissions", (object)Permissions ?? DBNull.Value);
                        SqlParameter output = new SqlParameter(@"UserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        UserID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return UserID;
        }
        public static bool UpdateUser(int? UserID, int? PersonID, string UserName, string password, bool isactive, int? Permissions)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"UserID", UserID);
                        command.Parameters.AddWithValue(@"PersonID", PersonID);
                        command.Parameters.AddWithValue(@"UserName", UserName);
                        command.Parameters.AddWithValue(@"password", password);
                        command.Parameters.AddWithValue(@"isactive", isactive);
                        command.Parameters.AddWithValue("@Permissions", (object)Permissions ?? DBNull.Value);
                        rowaffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return rowaffected > 0;
        }
        public static bool deleteuser(int? UserID) => clsdatahelper.delete("SP_DeleteUser", "UserID", UserID);
        public static bool isuserexistbyuserid(int? UserID) => clsdatahelper.Exists("SP_DoesUserExistByID", "UserID", UserID);
        public static bool FindUserByUserID(int? UserID, ref int? PersonID, ref string UserName, ref string password, ref bool isactive, ref int? Permissions)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"UserID", UserID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                PersonID = reader["PersonID"] as int?;
                                UserName = reader["UserName"] as string ?? string.Empty;
                                password = reader["password"] as string ?? string.Empty;
                                isactive = (bool)reader["isactive"];
                                Permissions = reader["Permissions"] != DBNull.Value ? (int)reader["Permissions"] : -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return isfound;
        }
        public static bool FindLog(ref int? UserID, ref int? PersonID, string UserName, string password, ref bool isactive, ref int? Permissions)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindUserByUserAndPass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"UserName", UserName);
                        command.Parameters.AddWithValue(@"pass", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                UserID = reader["UserID"] as int?;
                                PersonID = reader["PersonID"] as int?;
                                isactive = (bool)reader["isactive"];
                                Permissions = reader["Permissions"] != DBNull.Value ? (int)reader["Permissions"] : -1;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return isfound;
        }
        public static bool FindUserByPersonID(ref int? UserID, int? PersonID, ref string UserName, ref string password, ref bool isactive, ref int? Permissions)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindUserByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"PersonID", PersonID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                UserID = reader["UserID"] as int?;
                                UserName = reader["UserName"] as string;
                                password = reader["password"] as string;
                                isactive = (bool)reader["isactive"];
                                Permissions = reader["Permissions"] != DBNull.Value ? (int)reader["Permissions"] : -1;
                            }
                            else
                            {
                                isfound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
                isfound = false;
            }
            return isfound;
        }
        public static bool IsUserExistsByPersonID(int? PersonID) => clsdatahelper.Exists("SP_IsUserExistsByPersonID", "PersonID", PersonID);
        public static DataTable ListUsers() => clsdatahelper.list("SP_ListUsers");
        public static bool UpdatePassword(int? UserID, string Password)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_UpdatePassword", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Password", Password);
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return rowsAffected > 0;
        }
        public static int Count() => clsdatahelper.count("SP_CountUsers");
    }
}
