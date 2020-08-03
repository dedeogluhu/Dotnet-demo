using OnlineShopping.Entity;
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
    public class OrderDetailsDal : IEntityDal
    {
        public static List<OrderDetail> Select()
        {
            SqlCommand sqlCommand = new SqlCommand("prc_OrderDetails_Select", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            List<OrderDetail> orderDetails = new List<OrderDetail>();

            Utilities.OpenConnection(sqlCommand);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Utilities.CloseConnection(sqlCommand);

            while (sqlDataReader.Read())
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = Convert.ToInt32(sqlDataReader["OrderId"]),
                    Price = Convert.ToDecimal(sqlDataReader["Price"]),
                    ProductId = Convert.ToInt32(sqlDataReader["ProductId"]),
                    Quantity = Convert.ToInt32(sqlDataReader["Quantity"]),
                    isActive = Convert.ToBoolean(sqlDataReader["isActive"])
                };

                orderDetails.Add(orderDetail);
            }

            return orderDetails;
        }

        public static bool Insert(OrderDetail orderDetail)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_OrderDetails_Insert", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
            sqlCommand.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
            sqlCommand.Parameters.AddWithValue("@Price", orderDetail.Price);
            sqlCommand.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Update(OrderDetail orderDetail)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_OrderDetails_Update", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
            sqlCommand.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
            sqlCommand.Parameters.AddWithValue("@Price", orderDetail.Price);
            sqlCommand.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Delete(int orderId, int productId)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_OrderDetails_Delete", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@OrderId", orderId);
            sqlCommand.Parameters.AddWithValue("@ProductId", productId);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }
    }
}
