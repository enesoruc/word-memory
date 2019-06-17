using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.DAL
{
    public class Helper
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Helper()
        {
            conn = new SqlConnection(Properties.Settings.Default.NWD);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public void AddParametersToCommand(List<SqlParameter> parameterList)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(parameterList.ToArray());
        }

        public int MyExecuteScalar(string query)
        {
            int returnValue;
            cmd.CommandText = query;
            conn.Open();
            try
            {
                returnValue = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                returnValue = 0;
            }

            conn.Close();

            return returnValue;
        }

        public int MyExecuteNonQuery(string query)
        {
            cmd.CommandText = query;
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public SqlDataReader MyExecuteReader(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public SqlDataReader ExecuteSpReader(string storeProcedure)
        {
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = storeProcedure;
            conn.Open();
            return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        void IsConnectionOpen()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
