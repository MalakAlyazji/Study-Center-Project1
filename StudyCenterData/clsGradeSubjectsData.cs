using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsGradeSubjectsData
    {
        public static bool FindGradeSubjectByGradeSubjectID(int? GradeSubjectID, ref int? GradeID, ref int? SubjectID, ref decimal? Fees, ref string Titles)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_FindGradeSubjectByGradeSubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GradeSubjectID", (object)GradeSubjectID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                SubjectID = (reader["SubjectID"] != DBNull.Value) ? (int?)reader["SubjectID"] : null;
                                GradeID = (reader["GradeID"] != DBNull.Value) ? (int?)reader["GradeID"] : null;
                                Fees = reader["Fees"] != DBNull.Value ? (decimal?)reader["Fees"] : null;
                                Titles = (reader["Title"] != DBNull.Value) ? (string)reader["Title"] : null;
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
        public static bool FindGradeSubjectByGradeID(ref int? GradeSubjectID, int? GradeID, ref int? SubjectID, ref decimal? Fees, ref string Titles)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindGradeSubjectByGradeID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("GradeID", GradeID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                GradeID = (reader["GradeSubjectID"] != DBNull.Value) ? (int?)reader["GradeSubjectID"] : null;
                                SubjectID = (reader["SubjectID"] != DBNull.Value) ? (int?)reader["SubjectID"] : null;
                                Fees = (reader["Fees"] != DBNull.Value) ? (decimal?)reader["Fees"] : null;
                                Titles = (reader["Titles"] != DBNull.Value) ? (string)reader["Titles"] : null;
                            }
                            else
                            {
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clserrorloger.logerror(ex);
            }
            return IsFound;
        }
        public static bool FindGradeSubjectBySubjectID(ref int? GradeSubjectID, ref int? GradeID, int? SubjectID, ref decimal? Fees, ref string Titles)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindGradeSubjectBySubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("SubjectID", SubjectID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                GradeID = (reader["GradeSubjectID"] != DBNull.Value) ? (int?)reader["GradeSubjectID"] : null;
                                SubjectID = (reader["GradeID"] != DBNull.Value) ? (int?)reader["GradeID"] : null;
                                Fees = (reader["Fees"] != DBNull.Value) ? (decimal?)reader["Fees"] : null;
                                Titles = (reader["Titles"] != DBNull.Value) ? (string)reader["Titles"] : null;
                            }
                            else
                            {
                                IsFound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
                clserrorloger.logerror(ex);
            }
            return IsFound;
        }
        public static int? AddGradeSubject(int? GradeID, int? SubjectID, decimal? Fees)
        {
            int? GradeSubjectID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddGradeSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GradeID", GradeID);
                        command.Parameters.AddWithValue("@SubjectID", SubjectID);
                        command.Parameters.AddWithValue("@Fees", Fees);
                        SqlParameter output = new SqlParameter("@GradeSubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);

                        command.ExecuteNonQuery();
                        GradeSubjectID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return GradeSubjectID;
        }
        public static bool UpdateGradeSubject(int? GradeSubjectID, int? GradeID, int? SubjectID, decimal? Fees)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateGradeSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GradeSubjectID", GradeSubjectID);
                        command.Parameters.AddWithValue(@"GradeID", GradeID);
                        command.Parameters.AddWithValue(@"SubjectID", SubjectID);
                        command.Parameters.AddWithValue(@"Fees", Fees);
                        rowaffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror(e);
            }
            return rowaffected > 0;
        }
        public static DataTable ListGradeSubjectByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("SP_ListGradeSubjectByPages", PageNumber, PageSize);
        public static bool IsGradeSubjectExistByGradeSubjectID(int? GradeSubjectID) => clsdatahelper.Exists("SP_IsGradeSubjectExistByGradeSubjectID", "GradeSubjectID", GradeSubjectID);
        public static bool IsGradeSubjectExistByGradeID(int? GradeID) => clsdatahelper.Exists("SP_IsGradeSubjectExistByGradeID", "GradeID", GradeID);
        public static bool IsGradeSubjectExistBySubjectID(int? SubjectID) => clsdatahelper.Exists("SP_IsGradeSubjectExistBySubjectID", "SubjectID", SubjectID);
        //public static bool DeleteGradeSubject(int? GradeSubjectID) => clsdatahelper.delete("", "GradeSubjectID", GradeSubjectID);
        public static DataTable ListGradeSubject() => clsdatahelper.list("SP_ListGradeSubject");
        public static int CountGradeSubjects() => clsdatahelper.count("SP_CountGradeSubjects");
        public static bool IsGradeSubjectExistByGradeAndSubject(int? GradeID, int? SubjectID) => clsdatahelper.Exists("SP_IsGradeSubjectExistByGradeAndSubject", "GradeID", GradeID, "SubjectID", SubjectID);
        public static DataTable ListGradeSubjectNotAssignedToTeacherID(int? TeacherID) => clsdatahelper.ListByID(TeacherID, "TeacherID", "SP_ListGradeSubjectNotAssignedToTeacherID");
    }
}
