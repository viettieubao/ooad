using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace QuanLiVatLieuXayDung.Model
{
    class Connection
    {
        public static SqlConnection sqlConnection;
        public static SqlCommand sqlCommand;
        public static SqlDataAdapter sqlDataAdapter;
        public static DataTable dataTable;

        public static string conn = @"Data Source=DESKTOP-UD95KR6;Initial Catalog=OOAD;Integrated Security=True";
        public static DataTable getData(String sql)
        {
            sqlConnection = new SqlConnection(conn);
            dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter(sql,sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public static int ExcuteNonQuery(String sql)
        {
            int result = 0;
            try
            {
                sqlConnection = new SqlConnection(conn);
                sqlConnection.Open();
                sqlCommand = new SqlCommand(sql, sqlConnection);
                result = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch
            {
                
            }
            return result;
        }
    }
}
