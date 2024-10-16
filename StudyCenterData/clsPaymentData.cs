using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using StudyCenterData.GlobalClasses;

namespace StudyCenterData
{
    public class clsPaymentData
    {
        public static bool FindPaymentByPaymentID(int? PaymentID,ref int? StudentGroupID, ref int? GradeSubjectID,
           ref decimal? PaymentAmount, ref DateTime? PaymentDate, ref int? UserID, ref string PaymentMethods)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(@"SP_FindPaymentByPaymentID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PaymentID", (object)PaymentID ?? DBNull.Value);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                StudentGroupID = reader["StudentGroupID"] != DBNull.Value ? (int?)reader["StudentGroupID"] : null;
                                GradeSubjectID = reader["GradeSubjectID"] != DBNull.Value ? (int?)reader["GradeSubjectID"] : null;
                                PaymentAmount = reader["PaymentAmount"] != DBNull.Value ? (decimal?)reader["PaymentAmount"] : null;
                                UserID = reader["UserID"] != DBNull.Value ? (int?)reader["UserID"] : null;
                                PaymentDate = (reader["PaymentDate"] != DBNull.Value) ? (DateTime?)reader["PaymentDate"] : null;
                                PaymentMethods = reader["PaymentMethods"] != DBNull.Value ? (string)reader["PaymentMethods"] : null;
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
        public static int? AddPayment(int? StudentGroupID, int? GradeSubjectID,
            decimal? PaymentAmount, DateTime? PaymentDate, int? UserID, string PaymentMethods)
        {
            int? PaymentID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_AddPayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentGroupID", StudentGroupID);
                        command.Parameters.AddWithValue("@GradeSubjectID", GradeSubjectID);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PaymentMethods", PaymentMethods);
                        SqlParameter outputIdParam = new SqlParameter("@PaymentID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        PaymentID = (int?)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return PaymentID;
        }
        public static bool UpdatePayment(int? PaymentID, int? StudentGroupID, int? GradeSubjectID,
            decimal? PaymentAmount, DateTime? PaymentDate, int? UserID, string PaymentMethods)
        {
            int? rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SP_UpdatePayment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PaymentID", PaymentID);
                        command.Parameters.AddWithValue("@StudentGroupID", StudentGroupID);
                        command.Parameters.AddWithValue("@GradeSubjectID", GradeSubjectID);
                        command.Parameters.AddWithValue("@PaymentAmount", PaymentAmount);
                        command.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@PaymentMethods", PaymentMethods);
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
        public static bool DeletePayment(int? PaymentID) => clsdatahelper.delete("SP_DeletePayment", "PaymentID", PaymentID);
        public static DataTable ListPayment() => clsdatahelper.list("SP_ListPayments");
        public static DataTable ListPaymentByPages(short PageNumber,int PageSize) => clsdatahelper.listbypage("SP_ListPaymentByPages", PageNumber,PageSize);
        public static int CountPayments() => clsdatahelper.count("SP_CountPayments");
    }
}
