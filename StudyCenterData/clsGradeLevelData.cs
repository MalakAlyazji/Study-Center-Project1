using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsGradeLevelData
    {
        public static bool findlevel(int? GradeLevelID, ref string GradeLevelName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_FindGradeLevelByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", (object)GradeLevelID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                GradeLevelName = (string)reader["GradeLevelName"];
                            }
                            else
                            {
                                isFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clserrorloger.logerror(ex);
            }

            return isFound;
        }
        public static int? addlevel(string GradeLevelName)
        {
            int? GradeLevelID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        SqlParameter outputIdParam = new SqlParameter("@GradeLevelID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        GradeLevelID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return GradeLevelID;
        }
        public static bool update(int? GradeLevelID, string GradeLevelName)
        {
            int? rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateGradeLevel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        rowaffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }

            return (rowaffected > 0);
        }
        public static bool deletelevel(int? GradeLevelID) => clsdatahelper.delete("SP_DeleteGradeLevel", "GradeLevelID", GradeLevelID);
        public static bool Exists(int? GradeLevelID) => clsdatahelper.Exists("SP_IsGradeExistByID", "GradeLevelID", GradeLevelID);
        public static DataTable GetLevelsName() => clsdatahelper.list("SP_ListGradeLevelsName");
        public static int? GetGradeIDByName(string GradeLevelName)
        {
            int? GradeLevelID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetGradeIDByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GradeLevelName", GradeLevelName);

                        // Execute the command and read the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                GradeLevelID = reader.IsDBNull(0) ? (int?)null : reader.GetInt32(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return GradeLevelID;
        }
        public static int? CountGradeLevels() => clsdatahelper.count("SP_CountGradeLevels");
    }
}
