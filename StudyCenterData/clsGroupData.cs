using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsGroupData
    {
        public static bool FindGroupByGroupID(int? GroupID, ref int? TeacherSubjectID, ref int? GradeSubjectID, ref int? StudentCount, ref int? GradeLevelID
            , ref string GroupName, ref bool? IsActive, ref int? ClassID, ref int? UserID, ref int? MeetingID)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindGroupByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GroupID", GroupID == null ? (object)DBNull.Value : GroupID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                TeacherSubjectID = (reader["TeacherSubjectID"] != DBNull.Value) ? (int?)reader["TeacherSubjectID"] : null;
                                GradeSubjectID = (reader["GradeSubjectID"] != DBNull.Value) ? (int?)reader["GradeSubjectID"] : null;
                                StudentCount = (reader["StudentCount"] != DBNull.Value) ? (int?)reader["StudentCount"] : null;
                                GradeLevelID = (reader["GradeLevelID"] != DBNull.Value) ? (int?)reader["GradeLevelID"] : null;
                                GroupName = (reader["GroupName"] != DBNull.Value) ? (string)reader["GroupName"] : null;
                                IsActive = (reader["IsActive"] != DBNull.Value) ? (bool?)reader["IsActive"] : null;
                                ClassID = (reader["ClassID"] != DBNull.Value) ? (int?)reader["ClassID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                MeetingID = (reader["MeetingID"] != DBNull.Value) ? (int?)reader["MeetingID"] : null;
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

        public static int? AddGroup(int? TeacherSubjectID, int? GradeSubjectID, int? GradeLevelID,
    int? ClassID, int? UserID, int? MeetingID)
        {
            int? GroupID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Example of setting string parameters with size (if applicable)
                        command.Parameters.Add(new SqlParameter("@TeacherSubjectID", SqlDbType.Int) { Value = TeacherSubjectID ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@GradeSubjectID", SqlDbType.Int) { Value = GradeSubjectID ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@GradeLevelID", SqlDbType.Int) { Value = GradeLevelID ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@ClassID", SqlDbType.Int) { Value = ClassID ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = UserID ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@MeetingID", SqlDbType.Int) { Value = MeetingID ?? (object)DBNull.Value });

                        SqlParameter output = new SqlParameter("@GroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);

                        command.ExecuteNonQuery();
                        GroupID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return GroupID;
        }
        public static bool UpdateGroup(int? GroupID, int? TeacherSubjectID, int? GradeSubjectID, int? StudentCount, int? GradeLevelID, string GroupName, bool? IsActive,
            int? ClassID, int? UserID, int? MeetingID)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GroupID", GroupID == null ? (object)DBNull.Value : GroupID);
                        command.Parameters.AddWithValue(@"TeacherSubjectID", TeacherSubjectID == null ? (object)DBNull.Value : TeacherSubjectID);
                        command.Parameters.AddWithValue(@"StudentCount", StudentCount == null ? (object)DBNull.Value : StudentCount);
                        command.Parameters.AddWithValue(@"GradeLevelID", GradeLevelID == null ? (object)DBNull.Value : GradeLevelID);
                        command.Parameters.AddWithValue(@"GroupName", GroupName == null ? (object)DBNull.Value : GroupName);
                        command.Parameters.AddWithValue(@"IsActive", IsActive == null ? (object)DBNull.Value : IsActive);
                        command.Parameters.AddWithValue(@"ClassID", ClassID == null ? (object)DBNull.Value : ClassID);
                        command.Parameters.AddWithValue(@"UserID", UserID == null ? (object)DBNull.Value : UserID);
                        command.Parameters.AddWithValue(@"MeetingID", MeetingID == null ? (object)DBNull.Value : MeetingID);
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
        public static DataTable ListGroupByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("SP_ListGroupsByPages", PageNumber, PageSize);
        //public static bool IsGGroupExistByGroupID(int? GradeSubjectID) => clsdatahelper.Exists("", "GradeSubjectID", GradeSubjectID);
        //public static bool IsGGroupExistByTeacherSubjectID(int? GradeID) => clsdatahelper.Exists("", "GradeID", GradeID);
        //public static bool IsGroupExistBStudentID(int? SubjectID) => clsdatahelper.Exists("", "SubjectID", SubjectID);
        public static DataTable ListGroup() => clsdatahelper.list("SP_ListGroups");
        public static int? CountGroups() => clsdatahelper.count("SP_CountGroups");
        public static bool DeleteGroup(int GroupID) => clsdatahelper.delete("SP_DeleteGroup", "GroupID", GroupID);
        public static DataTable GetGroupsNames() => clsdatahelper.list("SP_GetGroupsNames");
        public static DataTable ListGroupsByClassID(int? ClassID) => clsdatahelper.ListByID(ClassID, "ClassID", "SP_ListGroupsByClassID");
    }
}
