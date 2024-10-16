using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsTeacherSubjectsData
    {
        public static bool FindTeacherSubjectsByTeacherSubjectID(int? TeacherSubjectID, ref int? TeacherID, ref int? GradeLevelSubjectID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherSubjectsByTeacherSubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"TeacherSubjectID", TeacherSubjectID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                TeacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
                                GradeLevelSubjectID = (reader["GradeSubjectID"] != DBNull.Value) ? (int?)reader["GradeSubjectID"] : null;
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
        public static bool FindTeacherSubjectsByTeachertID(ref int? TeacherSubjectID, int? TeacherID, ref int? GradeLevelSubjectID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherSubjectsByTeachertID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"TeacherID", TeacherID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                TeacherSubjectID = (reader["TeacherSubjectID"] != DBNull.Value) ? (int?)reader["TeacherSubjectID"] : null;
                                TeacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
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
        public static bool FindTeacherSubjectsByGradeLevelSubjectID(ref int? TeacherSubjectID, ref int? TeacherID, int? GradeLevelSubjectID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherSubjectsByGradeLevelSubjectID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GradeLevelSubjectID", GradeLevelSubjectID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                TeacherSubjectID = (reader["TeacherSubjectID"] != DBNull.Value) ? (int?)reader["TeacherSubjectID"] : null;
                                TeacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
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
        public static int? AddTeacherSubject(int? TeacherID, int? GradeLevelSubjectID)
        {
            int? TeacherSubjectID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddTeacherSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherID", TeacherID ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@GradeLevelSubjectID", GradeLevelSubjectID ?? (object)DBNull.Value);

                        SqlParameter output = new SqlParameter("@TeacherSubjectID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        TeacherSubjectID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return TeacherSubjectID;
        }
        public static bool UpdateTeacherSubject(int? TeacherSubjectID, int? TeacherID, int? GradeLevelSubjectID)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateTeacherSubject", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"TeacherSubjectID", TeacherSubjectID);
                        command.Parameters.AddWithValue(@"TeacherID", TeacherID);
                        command.Parameters.AddWithValue(@"GradeLevelSubjectID", GradeLevelSubjectID);

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
        public static DataTable ListTeacherSubjectByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("SP_ListTeacherSubjectByPages", PageNumber, PageSize);
        public static bool IsTeacherSubjectExistByTeacherSubjectID(int? TeacherSubjectID) => clsdatahelper.Exists("SP_IsTeacherSubjectExistByTeacherSubjectID", "TeacherSubjectID", TeacherSubjectID);
        public static bool IsTeacherSubjectExistByTeacherID(int? TeacherID) => clsdatahelper.Exists("SP_IsTeacherSubjectExistByTeacherID", "TeacherID", TeacherID);
        public static bool IsTeacherSubjectExistBySubjectID(int? GradeLevelSubjectID) => clsdatahelper.Exists("SP_IsTeacherSubjectExistBySubjectID", "GradeLevelSubjectID", GradeLevelSubjectID);
        public static DataTable ListTeacherSubjects() => clsdatahelper.list("SP_ListTeacherSubject");
        public static DataTable ListTeacherSubjectsByTeacherID(int? TeacherID) => clsdatahelper.ListByID(TeacherID, "TeacherID", "sp_listteachersubjectbyteacherid ");
        public static DataTable ListTeacherSubjectsBySelectedTeacherSubjectID(int? SelectedTeacherSubjectID)
            => clsdatahelper.ListByID(SelectedTeacherSubjectID, "SelectedTeacherSubjectID", "SP_ListTeacherSubjectsBySelectedTeacherSubjectID");
        public static DataTable ListTeachersSubjectByClassID(int? ClassID) => clsdatahelper.ListByID(ClassID, "ClassID", "SP_ListTeachersSubjectByClassID");
        public static DataTable ListTeachersSubjectBySubjectID(int? SubjectID) => clsdatahelper.ListByID(SubjectID, "SubjectID", "SP_ListTeachersSubjectBySubjectID");
        public static bool IsTeacherSubjectExistByTeachrAndSubjectID(int? TeacherID, int? SubjectID) => clsdatahelper.Exists("SP_IsTeacherSubjectExistByTeachrAndSubjectID", "TeacherID", TeacherID, "SubjectID", SubjectID);
    }
}
