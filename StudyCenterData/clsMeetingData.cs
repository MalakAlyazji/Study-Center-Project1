using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsMeetingData
    {
        public static bool FindMeetingByMeetingID(int? MeetingID, ref TimeSpan? StartTime, ref TimeSpan? EndTime, ref string MeetingDays)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_FindMeetingByMeetingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MeetingID", (object)MeetingID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                StartTime = reader["StartTime"] != DBNull.Value ? (TimeSpan?)reader["StartTime"] : null;
                                EndTime = (reader["EndTime"] != DBNull.Value) ? (TimeSpan?)reader["EndTime"] : null;
                                MeetingDays = reader["MeetingDays"] != DBNull.Value ? (string)reader["MeetingDays"] : null;
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
        public static int? AddMeeting(TimeSpan? StartTime, string MeetingDays)
        {
            int? MeetingID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddMeeting", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StartTime", StartTime);
                        command.Parameters.AddWithValue("@MeetingDays", MeetingDays);

                        SqlParameter outputIdParam = new SqlParameter("@MeetingID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        MeetingID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return MeetingID;
        }
        public static bool? UpdateMeeting(int? MeetingID, TimeSpan? StartTime, string MeetingDays)
        {
            int? rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdateMeeting", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MeetingID", MeetingID);
                        command.Parameters.AddWithValue("@StartTime", StartTime);
                        command.Parameters.AddWithValue("@MeetingDays", MeetingDays);
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
        public static bool? DeleteMeeting(int? MeetingID) => clsdatahelper.delete("SP_DeleteMeeting", "MeetingID", MeetingID);
        public static bool? IsMeetingExist(int? MeetingID) => clsdatahelper.Exists("SP_IsMeetingExist", "MeetingID", MeetingID);
        public static DataTable ListMeetings() => clsdatahelper.list("SP_ListMeetings");
        public static DataTable ListMeetingsByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("", PageNumber, PageSize);
        public static DataTable ListMeetingsByCLassAndTeacher(int? ClassID, int? TeacherID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_ListMeetingsByCLassAndTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"ClassID", (object)ClassID ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"TeacherID", (object)TeacherID ?? DBNull.Value);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return dt;
        }
        public static DataTable ListMeetingBySeletedMeetingID(int? SeletedMeetingID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_ListMeetingBySeletedMeetingID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"SeletedMeetingID", (object)SeletedMeetingID ?? DBNull.Value);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return dt;
        }
        public static bool? IsMeetingExistByDayAndDate(TimeSpan? StartTime, string MeetingDays) => clsdatahelper.Exists("SP_IsMeetingExist", "StartTime", StartTime, "MeetingDays", MeetingDays);
        public static int? CountMeetings() => clsdatahelper.count("SP_CountMeetings");
    }
}
