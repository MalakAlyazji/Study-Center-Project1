using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsstudentdata
    {
        public static bool FindStudentbyStudentID(int? StudentID, ref int? PersonID, ref DateTime? EnrollmentDate, ref int? GradeLevelID, ref string EmergencyContactPhone, ref int? UserID)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", (object)StudentID ?? DBNull.Value);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                EnrollmentDate = (reader["EnrollmentDate"] != DBNull.Value) ? (DateTime?)reader["EnrollmentDate"] : null;
                                GradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (int?)reader["GradeLevelID"] : null;
                                EmergencyContactPhone = (reader["EmergencyContactPhone"] != DBNull.Value) ? (string)reader["EmergencyContactPhone"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                            }
                            else isfound = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                isfound = false;
                clserrorloger.logerror(e);
            }
            return isfound;
        }
        public static bool FindStudentbyPersonID(ref int? StudentID, int? PersonID, ref DateTime? EnrollmentDate, ref int? GradeLevelID, ref string EmergencyContactPhone, ref int? UserID)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindStudentByPersonID", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"PersonID", (object)PersonID ?? DBNull.Value);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                StudentID = (reader["StudentID"] != DBNull.Value) ? (int?)reader["StudentID"] : null;
                                EnrollmentDate = (reader["EnrollmentDate"] != DBNull.Value) ? (DateTime?)reader["EnrollmentDate"] : null;
                                GradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (int?)reader["GradeLevelID"] : null;
                                EmergencyContactPhone = (reader["EmergencyContactPhone"] != DBNull.Value) ? (string)reader["EmergencyContactPhone"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                            }
                            else isfound = false;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                isfound = false;
                clserrorloger.logerror(e);
            }
            return isfound;
        }
        public static int? AddStudent(int? PersonID, DateTime? EnrollmentDate, int? GradeLevelID, string EmergencyContactPhone, int? UserID)
        {
            int? StudentID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddStudent", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"PersonID", PersonID);
                        command.Parameters.AddWithValue(@"EnrollmentDate", EnrollmentDate);
                        command.Parameters.AddWithValue(@"GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue(@"EmergencyContactPhone", EmergencyContactPhone);
                        command.Parameters.AddWithValue(@"UserID", UserID);
                        SqlParameter output = new SqlParameter(@"StudentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        StudentID = (int?)output.Value;
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror(e);
            }
            return StudentID;
        }
        public static bool UpdateStudent(int? StudentID, int? PersonID, DateTime? EnrollmentDate, int? GradeLevelID, string EmergencyContactPhone, int? UserID)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"StudentID", StudentID);
                        command.Parameters.AddWithValue(@"PersonID", PersonID);
                        command.Parameters.AddWithValue(@"EnrollmentDate", EnrollmentDate);
                        command.Parameters.AddWithValue(@"GradeLevelID", GradeLevelID);
                        command.Parameters.AddWithValue(@"EmergencyContactPhone", EmergencyContactPhone);
                        command.Parameters.AddWithValue(@"UserID", UserID);
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
        public static bool DeleteStudent(int? StudentID) => clsdatahelper.delete("SP_DeleteStudent", "StudentID", StudentID);
        public static bool IsStudentExistByStudentID(int? StudentID) => clsdatahelper.Exists("SP_IsStudentExistByStudentID", "StudentID", StudentID);
        public static DataTable ListByPage(short pagenumber, int PageSize) => clsdatahelper.listbypage("SP_ListStudentsByPages", pagenumber, PageSize);
        public static bool IsStudentExistByPersonID(int? PersonID) => clsdatahelper.Exists("SP_IsStudentExistByPersonID", "PersonID", PersonID);
        public static int CountStudents() => clsdatahelper.count("SP_CountStudents");
        public static DataTable ListStudents() => clsdatahelper.list("SP_ListStudents");
    }
}
