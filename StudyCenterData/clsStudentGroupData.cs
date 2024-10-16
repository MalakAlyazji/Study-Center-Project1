using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsStudentGroupData
    {
        public static bool FindStudentGroupByStudentGroupID(int? StudentGroupID, ref int? StudentID, ref int? GroupID, ref int? UserID, ref TimeSpan? StartDate, ref TimeSpan? EndDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindStudentGroupByStudentGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"StudentGroupID", StudentGroupID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                StudentID = (reader["StudentID"] != DBNull.Value) ? (int?)reader["StudentID"] : null;
                                GroupID = (reader["GroupID"] != DBNull.Value) ? (int?)reader["GroupID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                StartDate = (reader["StartDate"] != DBNull.Value) ? (TimeSpan?)reader["StartDate"] : null;
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (TimeSpan?)reader["EndDate"] : null;
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
        public static bool FindTeacherSubjectsByStudentID(ref int? StudentGroupID, int? StudentID, ref int? GroupID, ref int? UserID, ref TimeSpan? StartDate, ref TimeSpan? EndDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherSubjectsByStudenttID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"StudentID", StudentID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                StudentGroupID = (reader["StudentGroupID"] != DBNull.Value) ? (int?)reader["StudentGroupID"] : null;
                                GroupID = (reader["GroupID"] != DBNull.Value) ? (int?)reader["GroupID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                StartDate = (reader["StartDate"] != DBNull.Value) ? (TimeSpan?)reader["StartDate"] : null;
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (TimeSpan?)reader["EndDate"] : null;
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
        public static bool FindStudentGroupByGroupID(ref int? StudentGroupID, ref int? StudentID, int? GroupID, ref int? UserID, ref TimeSpan? StartDate, ref TimeSpan? EndDate)
        {
            bool IsFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindStudentGroupByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"GroupID", GroupID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                StudentID = (reader["StudentID"] != DBNull.Value) ? (int?)reader["StudentID"] : null;
                                StudentGroupID = (reader["StudentGroupID"] != DBNull.Value) ? (int?)reader["StudentGroupID"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                                StartDate = (reader["StartDate"] != DBNull.Value) ? (TimeSpan?)reader["StartDate"] : null;
                                EndDate = (reader["EndDate"] != DBNull.Value) ? (TimeSpan?)reader["EndDate"] : null;
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
        public static int? AddStudentGroup(int? StudentID, int? GroupID, int? UserID)
        {
            int? StudentGroupID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddStudentGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"StudentID", StudentID);
                        command.Parameters.AddWithValue(@"GroupID", GroupID);
                        command.Parameters.AddWithValue(@"UserID", UserID);

                        SqlParameter output = new SqlParameter(@"StudentGroupID", StudentGroupID)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        StudentGroupID = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return StudentGroupID;
        }
        public static (int? StudentGroupID, int? PaymentID) AddStudentGroupWithPayment(int? StudentID, int? GroupID, int? UserID, string PaymentMethod)
        {
            int? StudentGroupID = null;
            int? PaymentID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddStudentGroupWithPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue(@"StudentID", (object)StudentID ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"GroupID", (object)GroupID ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"UserID", (object)UserID ?? DBNull.Value);

                        // Create the PaymentMethod parameter with size
                        SqlParameter paymentMethodParam = new SqlParameter(@"PaymentMethods", SqlDbType.VarChar, 50)
                        {
                            Value = (object)PaymentMethod ?? DBNull.Value
                        };
                        command.Parameters.Add(paymentMethodParam);

                        SqlParameter outputStudentGroupID = new SqlParameter(@"StudentGroupID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputStudentGroupID);

                        SqlParameter outputPaymentID = new SqlParameter(@"PaymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputPaymentID);

                        command.ExecuteNonQuery();

                        StudentGroupID = (int?)outputStudentGroupID.Value;
                        PaymentID = (int?)outputPaymentID.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }

            return (StudentGroupID, PaymentID); // Return both IDs
        }
        public static bool UpdateStudentGroup(int? StudentGroupID, int? StudentID, int? GroupID, int? UserID)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateStudentGroup", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"StudentGroupID", StudentGroupID);
                        command.Parameters.AddWithValue(@"StudentID", StudentID);
                        command.Parameters.AddWithValue(@"GroupID", GroupID);
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
        public static DataTable ListStudentGroupByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("SP_ListStudentGroupsByPages", PageNumber, PageSize);
        public static bool IsStudentGroupExistByStudentGroupID(int? StudentGroupID) => clsdatahelper.Exists("SP_IsStudentGroupExistByStudentGroupID", "StudentGroupID", StudentGroupID);
        public static bool IsStudentGroupExistByGroupID(int? GroupID) => clsdatahelper.Exists("SP_IsStudentGroupExistByGroupID", "GroupID", GroupID);
        public static bool IsStudentGroupExistByStudentID(int? StudentID) => clsdatahelper.Exists("SP_IsStudentGroupExistByStudentID", "StudentID", StudentID);
        public static DataTable ListStudentGroups() => clsdatahelper.list("SP_ListStudentGroups");
        public static DataTable ListGroupStudentNotAssignedIn(int? StudentID) => clsdatahelper.ListByID(StudentID, "StudentID", "SP_ListGroupStudentNotAssignedIn");
        public static decimal GetGradeSubjectFeesByGroupID(int? GroupID)
        {
            decimal Fees = 0m;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("sp_GetGradeSubjectFeesByGroupID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@GroupID", GroupID);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            Fees = Convert.ToDecimal(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror(e);
            }
            return Fees;
        }
        public static int? GetGradeLevelIDByStudentID(int? StudentID)
        {
            int? GradeLevelID = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_GetGradeLevelIDByStudentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            GradeLevelID = Convert.ToInt16(result);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror(e);
            }
            return GradeLevelID;
        }
        public static bool IsStudentAssignedToGroup(int? StudentID, int? GroupID) => clsdatahelper.Exists("SP_IsStudentAssignedToGroup", "StudentID", StudentID, "GroupID", GroupID);
        public static DataTable ListStudentGroupByGroupID(int? GroupID) => clsdatahelper.ListByID(GroupID, "GroupID", "SP_ListStudentGroupByGroupID");
    }
}
