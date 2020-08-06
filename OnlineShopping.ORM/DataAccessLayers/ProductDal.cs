using OnlineShopping.Entity;
using OnlineShopping.ORM.Interfaces;
using OnlineShopping.ORM.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShopping.ORM.DataAccessLayers
{
    public class ProductDal : IEntityDal
    {
        public static bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Products_Delete", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Insert(Product entity)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Products_Insert", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@ProductName", entity.ProductName);
            sqlCommand.Parameters.AddWithValue("@UnitPrice",entity.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", entity.StockAmount);
            sqlCommand.Parameters.AddWithValue("@SellerId", entity.SellerId);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static List<Product> Select()
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Products_Select", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            List<Product> products = new List<Product>();

            Utilities.OpenConnection(sqlCommand);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    ProductName = sqlDataReader["ProductName"].ToString(),
                    SellerId = Convert.ToInt32(sqlDataReader["SellerId"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    isActive = Convert.ToBoolean(sqlDataReader["isActive"])
                };

                products.Add(product);
            }

            Utilities.CloseConnection(sqlCommand);

            return products;
        }

        public static bool Update(Product entity)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Products_Update", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@ProductName", entity.ProductName);
            sqlCommand.Parameters.AddWithValue("@SellerId", entity.SellerId);
            sqlCommand.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@StockAmount", entity.StockAmount);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }
    }
}
