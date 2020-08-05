using OnlineShopping.Entity;
using OnlineShopping.ORM.Interfaces;
using OnlineShopping.ORM.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.ORM.DataAccessLayers
{
    public class CustomerDal : IEntityDal
    {
        public static List<Customer> Select()
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Customers_Select", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            List<Customer> customers = new List<Customer>();

            Utilities.OpenConnection(sqlCommand);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();      

            while (sqlDataReader.Read())
            {
                Customer customer = new Customer
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    FirstName = sqlDataReader["FirstName"].ToString(),
                    LastName = sqlDataReader["LastName"].ToString(),
                    CustomerId = sqlDataReader["CustomerId"].ToString(),
                    Password = sqlDataReader["Password"].ToString(),
                    Cash = Convert.ToDecimal(sqlDataReader["Cash"]),
                    isActive = Convert.ToBoolean(sqlDataReader["isActive"])
                };

                customers.Add(customer);
            }

            Utilities.CloseConnection(sqlCommand);

            return customers;
        }

        public static bool Insert(Customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Customers_Insert", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@Cash", customer.Cash);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Update(Customer customer)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Customers_Update", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", customer.Id);
            sqlCommand.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
            sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
            sqlCommand.Parameters.AddWithValue("@FirstName", customer.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", customer.LastName);
            sqlCommand.Parameters.AddWithValue("@Cash", customer.Cash);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Customers_Delete", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return Utilities.ExecuteNonQuery(sqlCommand);

        }
    }
}
