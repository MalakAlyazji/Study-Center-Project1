using System;
using System.Collections.Generic;
using System.Text;
using StudyCenterData.GlobalClasses;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Threading;
namespace StudyCenterData
{
    public class clsteacherdata
    {
        public static bool findteacherbyTEACHERID(int? TeacherID,ref int? PersonID, ref DateTime? HireDate, ref string Qualification, ref decimal? Salary, ref int? UserID)
        {
            bool isfound=false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherByTeacherID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"TeacherID", TeacherID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                PersonID = (reader["PersonID"] != DBNull.Value) ? (int?)reader["PersonID"] : null;
                                HireDate = (reader["HireDate"] != DBNull.Value) ? (DateTime?)reader["HireDate"] : null;
                                Qualification= (reader["Qualification"] != DBNull.Value) ? (string)reader["Qualification"] : null;
                                Salary = (reader["Salary"] != DBNull.Value) ? (decimal?)reader["Salary"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                            }
                            else
                            {
                                isfound = false;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                isfound=false;
                clserrorloger.logerror(e);
            }
            return isfound;
        }
        public static int? AddTeacher(int? PersonID,DateTime? HireDate, string Qualification, decimal? Salary,  int? UserID)
        {
            int? teacherid = null ;
            try
            {
                using (SqlConnection connection= new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddTeacher", connection))
                    {
                        command.CommandType=CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        command.Parameters.AddWithValue("@HireDate", DateTime.Now);
                        SqlParameter output = new SqlParameter("TeacherID",SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        teacherid = (int?)output.Value;
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror(e);
            }return teacherid;
        }
        public static bool updateteacher(int? TeacherID,int? PersonID, DateTime? HireDate, string Qualification,decimal? Salary,int? UserID)
        {
            int rowaffexted = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdateTeacher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@Qualification", (object)Qualification ?? DBNull.Value);
                        command.Parameters.AddWithValue("@HireDate", (object)HireDate ?? DBNull.Value);
                        rowaffexted=command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                clserrorloger.logerror  (e);
            }
            return rowaffexted > 0;
        }
        public static bool FindTeacherByPersonID(ref int? TeacherID,  int? PersonID, ref DateTime? HireDate, ref string Qualification, ref decimal? Salary, ref int? UserID)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindTeacherByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"PersonID", PersonID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                TeacherID = (reader["TeacherID"] != DBNull.Value) ? (int?)reader["TeacherID"] : null;
                                HireDate = (reader["HireDate"] != DBNull.Value) ? (DateTime?)reader["HireDate"] : null;
                                Qualification = (reader["Qualification"] != DBNull.Value) ? (string)reader["Qualification"] : null;
                                Salary = (reader["Salary"] != DBNull.Value) ? (decimal?)reader["Salary"] : null;
                                UserID = (reader["UserID"] != DBNull.Value) ? (int?)reader["UserID"] : null;
                            }
                            else
                            {
                                isfound = false;
                            }
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
        public static bool Deleteteacher(int? TeacherID)
               => clsdatahelper.delete("SP_DeleteTeacher", "TeacherID", TeacherID);
        public static bool Exists(int? TeacherID)
                 => clsdatahelper.Exists("SP_DoesTeacherExist", "TeacherID", TeacherID);
        public static DataTable All()
                => clsdatahelper.list("SP_ListTeachers");
        public static bool IsTeacherExistByPersonID(int? PersonID) => clsdatahelper.Exists("SP_IsTeacherExistByPersonID", "PersonID", PersonID);
        public static DataTable listbypage(short rowsperpage, int numberofpages) => clsdatahelper.listbypage("SP_ListTeachersByPages", rowsperpage, numberofpages);
        public static int count() => clsdatahelper.count("SP_GetTeacherCount");
    }
}
