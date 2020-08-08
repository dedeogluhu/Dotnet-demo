using OnlineShopping.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OnlineShopping.ORM.Tools
{
    public static class Utilities
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get 
            {
                if (connection == null)
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlExpress"].ToString());

                return connection; 
            }
        }

        public static void OpenConnection(SqlCommand sqlCommand)
        {
            if (sqlCommand.Connection.State == ConnectionState.Closed) sqlCommand.Connection.Open();

        }

        public static void CloseConnection(SqlCommand sqlCommand)
        {
            if (sqlCommand.Connection.State == ConnectionState.Open) sqlCommand.Connection.Close();
        }

        public static bool ExecuteNonQuery(SqlCommand sqlCommand)
        {
            try
            {
                OpenConnection(sqlCommand);

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection(sqlCommand);
            }
        }
    }
}
