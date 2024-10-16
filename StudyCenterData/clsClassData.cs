using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;
using System.Diagnostics.SymbolStore;
using System.Data;
namespace StudyCenterData
{
    public class clsClassData
    {
        public static bool FindClass(int? ClassID, ref string ClassName, ref int? Capacity)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command =new SqlCommand("SP_FindClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"ClassID", ClassID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                ClassName = reader["ClassName"] as string??string.Empty;
                                Capacity = (reader["Capacity"] != DBNull.Value) ? (int?)reader["Capacity"] : null;
                            }else isfound = false;
                        }
                    }
                } 
            }
            catch(Exception ex)
            {
                isfound=false;
                clserrorloger.logerror(ex);
            }return isfound;
        }
       public static int? AddClass( string ClassName, int? Capacity)
        {
            int? ClassID = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"ClassName", ClassName);
                        command.Parameters.AddWithValue(@"Capacity", Capacity);
                        SqlParameter outputIdParam = new SqlParameter("@ClassID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputIdParam);
                        command.ExecuteNonQuery();
                        ClassID = outputIdParam.Value != DBNull.Value? (int?) outputIdParam.Value : null;
    }
}
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }return ClassID;
        }
        public static bool DeleteClass(int? ClassID) => clsdatahelper.delete("SP_DeleteClass", "ClassID", ClassID);
        public static bool UpdateClass(int? ClassID, string ClassName, int? Capacity)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command =new SqlCommand("SP_UpdateClass", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ClassID", (object)ClassID ?? DBNull.Value);
                        command.Parameters.AddWithValue("ClassName", (object)ClassName ?? DBNull.Value);
                        command.Parameters.AddWithValue("Capacity", (object)Capacity ?? DBNull.Value);
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
        public static DataTable ListClasses() => clsdatahelper.list("SP_ListClasses");
        public static DataTable ListClassesByPages(short PageNumber, int PageSize) => clsdatahelper.listbypage("SP_ListClassesByPages", PageNumber, PageSize);
        public static bool IsClassExistByClassID(int? ClassID) => clsdatahelper.Exists("SP_IsClassExistByClassID", "ClassID", ClassID);
        public static int? CountClasses() => clsdatahelper.count("SP_CountClasses");
    }
}
