using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
       
        public SqlConnection conn;
        public SqlDataAdapter da;
        public SqlCommand cmd;
        public DataTable dt;

        

        public SqlConnection KetNoi()
        {
            string sqlconn = @"Data Source=LAPTOP-05HPDT8G;Initial Catalog=QLHTRapChieuPhim;Integrated Security=True";
            return new SqlConnection(sqlconn);
        }

        //
        public DataTable LayDS(string store)
        {
            dt = new DataTable();
            conn = KetNoi();
            try
            {
                conn.Open();

                cmd = new SqlCommand();

                cmd.CommandText = store;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                da = new SqlDataAdapter(cmd);

                da.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
