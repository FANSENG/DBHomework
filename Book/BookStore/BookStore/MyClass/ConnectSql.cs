using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.MyClass
{
    class ConnectSql
    {
        public static string connString = "Server=localhost;DataBase=BookStore;uid=sa;pwd=fxh0212";
        public SqlConnection conn = new SqlConnection(connString);

        public DataSet Query(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                adp.Fill(ds);
            }
            catch
            {

            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return ds;
        }

        public bool Delete(string sql)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);

            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return true;
        }

        
    }
}


