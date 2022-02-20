using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollAdo.net
{
    internal class payroll
    {
       public static string Connection = @"Data Source=DESKTOP-J69EB7S\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void Retrieve()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Connection);
                connection.Open(); 
                payrollmodel model = new payrollmodel();
                string query = "select * from AddressBook";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model.Id = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                        model.FirstName = reader["FirstName"] == DBNull.Value ? default : reader["FirstName"].ToString();
                        model.LastName = reader["LastName"] == DBNull.Value ? default : reader["LastName"].ToString();
                        model.Address = reader["Address"] == DBNull.Value ? default : reader["Address"].ToString();
                        model.City = reader["City"] == DBNull.Value ? default : reader["City"].ToString();
                        model.State= reader["State"] == DBNull.Value ? default : reader["State"].ToString();
                        model.Zip = Convert.ToInt64(reader["Zip"] == DBNull.Value ? default : reader["Zip"]);
                        model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"] == DBNull.Value ? default : reader["PhoneNumber"]);
                        model.Email = reader["Email"] == DBNull.Value ? default : reader["Email"].ToString();
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", model.Id, model.FirstName, model.LastName, model.Address, model.City, model.State, model.Zip, model.PhoneNumber, model.Email);

                    }
                }
                else
                {
                    Console.WriteLine("No rows is present");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}