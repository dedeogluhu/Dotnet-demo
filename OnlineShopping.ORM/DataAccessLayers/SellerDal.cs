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
    public static class SellerDal
    {
        public static List<Seller> Select()
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Sellers_Select", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            List<Seller> sellers = new List<Seller>();

            Utilities.OpenConnection(sqlCommand);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            Utilities.CloseConnection(sqlCommand);

            while (sqlDataReader.Read())
            {
                Seller seller = new Seller
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    CompanyName = sqlDataReader["CompanyName"].ToString(),
                    SellerId = sqlDataReader["SellerId"].ToString(),
                    Password = sqlDataReader["Password"].ToString(),
                    Cash = Convert.ToDecimal(sqlDataReader["Cash"]),
                    isActive = Convert.ToBoolean(sqlDataReader["isActive"])
                };

                sellers.Add(seller);
            }

            return sellers;
        }

        public static bool Insert(Seller seller)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Sellers_Insert", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SellerId", seller.SellerId);
            sqlCommand.Parameters.AddWithValue("@Password", seller.Password);
            sqlCommand.Parameters.AddWithValue("@CompanyName", seller.CompanyName);
            sqlCommand.Parameters.AddWithValue("@Cash", seller.Cash);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Update(Seller seller)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Sellers_Update", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", seller.Id);
            sqlCommand.Parameters.AddWithValue("@SellerId", seller.SellerId);
            sqlCommand.Parameters.AddWithValue("@Password", seller.Password);
            sqlCommand.Parameters.AddWithValue("@CompanyName", seller.CompanyName);
            sqlCommand.Parameters.AddWithValue("@Cash", seller.Cash);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }

        public static bool Delete(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("prc_Sellers_Delete", Utilities.Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Id", id);

            return Utilities.ExecuteNonQuery(sqlCommand);
        }
    }
}
