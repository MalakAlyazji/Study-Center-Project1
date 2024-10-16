using System;
using System.Data;
using System.Data.SqlClient;
using StudyCenterData.GlobalClasses;
namespace StudyCenterData
{
    public class clspeopledata
    {
        public static bool findperson(int? personid, ref string firstname, ref string lastname, ref DateTime? dateofbirth,
                           ref string phone, ref string email, ref string address, ref bool? gender)
        {
            bool isfound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_FindPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"personid", personid);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isfound = true;
                                firstname = reader["firstname"] as string ?? string.Empty;
                                lastname = reader["lastname"] as string ?? string.Empty;
                                dateofbirth = (reader["BirthDate"] != DBNull.Value) ? (DateTime?)reader["BirthDate"] : null;
                                phone = reader["phone"] as string ?? string.Empty;
                                email = reader["Email"] as string ?? string.Empty;
                                address = reader["address"] as string ?? string.Empty;
                                gender = reader["Gender"] != DBNull.Value ? (bool?)reader["Gender"] : null;
                            }
                            else
                            {
                                isfound = false;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                isfound = false;
                clserrorloger.logerror(ex);
            }
            return isfound;
        }

        public static int? addperson(string FirstName, string LastName, byte gender, DateTime? DateOfBirth, string Phone
            , string Email, string Address)
        {
            int? Personid = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_AddPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue(@"FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue(@"gender", gender);
                        command.Parameters.AddWithValue("@DateOfBirth", (object)DateOfBirth ?? DBNull.Value);
                        command.Parameters.AddWithValue("Phone", (object)Phone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
                        SqlParameter output = new SqlParameter(@"Personid", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(output);
                        command.ExecuteNonQuery();
                        Personid = (int?)output.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clserrorloger.logerror(ex);
            }
            return Personid;
        }

        public static bool udateperson(int? personid, string FirstName, string LastName, byte gender, DateTime? DateOfBirth, string Phone
            , string Email, string Address)
        {
            int rowaffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsconnection.ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("personid", (object)personid ?? DBNull.Value);
                        command.Parameters.AddWithValue("FirstName", (object)FirstName ?? DBNull.Value);
                        command.Parameters.AddWithValue("LastName", (object)LastName ?? DBNull.Value);
                        command.Parameters.AddWithValue("gender", gender);
                        command.Parameters.AddWithValue("@DateOfBirth", (object)DateOfBirth ?? DBNull.Value);
                        command.Parameters.AddWithValue("Phone", (object)Phone ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Address", (object)Address ?? DBNull.Value);
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
        public static bool deleteperson(int? personid) => clsdatahelper.delete("SP_DeletePerson", "personid", personid);
        public static bool Exists(int? personid) => clsdatahelper.Exists("SP_DoesPersonExist", "personid", personid);
    }
}
