using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha3.Data_Tier
{
    public class DatabaseSingleton
    {
        private static SqlConnection conn = null;

        private DatabaseSingleton()
        {

        }

        public static SqlConnection GetInstance()
        {
            if (conn == null)
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["localConnection"].ConnectionString);
                conn.Open();
            }
            return conn;
        }

        public static void CloseConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            catch { }
            finally
            {
                conn = null;
            }
        }
    }
}
