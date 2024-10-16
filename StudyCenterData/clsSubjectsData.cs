using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;
namespace StudyCenterData
{
    public class clsSubjectsData
    {
        public static bool FindSubject(int? SubjectID, ref string SubjectName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_FindSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SubjectID", (object)SubjectID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                SubjectName = (string)reader["SubjectName"];
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
        public static int? AddSubject(string subjectName)
        {
            int? subjectID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlParameter subjectNameParam = new SqlParameter("@SubjectName", SqlDbType.VarChar, 20)
                        {
                            Value = subjectName ?? (object)DBNull.Value
                        };
                        command.Parameters.Add(subjectNameParam);
                        SqlParameter output = new SqlParameter("@SubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        subjectID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return subjectID;
        }
        public static bool DeleteSubject(int? SubjectID) => clsdatahelper.delete("SP_DeleteSubject", "SubjectID", SubjectID);
        public static bool IsSubjectExistBySubjectID(int? SubjectID) => clsdatahelper.Exists("SP_IsSubjectExistBySubjectID", "SubjectID", SubjectID);
        public static bool IsSubjectExistBySubjectName(string SubjectName) => clsdatahelper.Exists("SP_IsSubjectExistBySubjectName", "SubjectName", SubjectName);
        public static bool UpdateSubject(int? SubjectID, string SubjectName)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("SubjectID", SubjectID);
                        command.Parameters.AddWithValue("SubjectName", SubjectName);
                        RowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return RowsAffected > 0;
        }
        public static DataTable ListSubjects() => clsdatahelper.list("SP_ListSubjects");
        public static string GetSubjectNameByID(int? subjectID)
        {
            string subjectName = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetSubjectNameByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Pass the SubjectID as a parameter
                        command.Parameters.AddWithValue(@"SubjectID", (object)subjectID ?? DBNull.Value);

                        // Execute the command and retrieve the subject name
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there is a result
                            {
                                subjectName = reader["SubjectName"].ToString(); // Read the SubjectName
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return subjectName;
        }
        public static int? GetSubjectIDByName(string subjectName)
        {
            int? subjectID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetSubjecIDByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SubjectName", subjectName);
                        object result = command.ExecuteScalar();
                        subjectID = result != DBNull.Value ? (int?)result : null;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }

            return subjectID;
        }
        public static DataTable GetSubjectNames() => clsdatahelper.list("SP_ListSubjectsName");
        public static int? CountSubjects() => clsdatahelper.count("SP_CountSubjects");
    }
}
