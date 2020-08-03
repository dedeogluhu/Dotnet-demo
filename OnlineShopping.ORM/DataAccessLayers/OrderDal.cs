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
    public class OrderDal : IEntityDal
    {
        public static List<Order> Select()
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Orders_Select", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            List<Order> orders = new List<Order>();

            Utilities.OpenConnection(sqlCommand);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Utilities.CloseConnection(sqlCommand);

            while (sqlDataReader.Read())
            {
                Order order = new Order
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    CustomerId = Convert.ToInt32(sqlDataReader["CustomerId"]),
                    SellerId = Convert.ToInt32(sqlDataReader["SellerId"]),
                    SaleDate = Convert.ToDateTime(sqlDataReader["SaleDate"]),
                    isActive = Convert.ToBoolean(sqlDataReader["isActive"])
                };

                orders.Add(order);
            }

            return orders;
        }

        public static bool Insert(Order order)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Orders_Insert", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SellerId", order.SellerId);
            sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            sqlCommand.Parameters.AddWithValue("@SaleDate", order.SaleDate);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Update(Order order)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Orders_Update", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", order.Id);
            sqlCommand.Parameters.AddWithValue("@SellerId", order.SellerId);
            sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            sqlCommand.Parameters.AddWithValue("@SaleDate", order.SaleDate);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Orders_Delete", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }
    }
}
