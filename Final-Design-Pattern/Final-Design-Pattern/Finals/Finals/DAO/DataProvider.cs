using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finals.DAO
{
    internal class DataProvider: DPAbtract
    {// kết nối SQL
        string Ketnoi = "Data Source=DESKTOP-0KEP4GF;Initial Catalog=STORE;Integrated Security=True";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }// Singleton
            private set { DataProvider.instance = value; }
        }
        public DataProvider()
        { }
        
        // 
        public override DataTable ExcuteQuery(string sql)
        {
            SqlConnection connect = new SqlConnection(Ketnoi);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connect.Close();
            return dt;
        }

        // Dùng để trả về kiểu nguyên
        public override int ExcuteNONQuery(string sql)
        {
            int n = 0;
            SqlConnection connect = new SqlConnection(Ketnoi);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            n = cmd.ExecuteNonQuery();
            connect.Close();
            return n;
        }
        // Dùng để trả về kiểu object
        public override object ExcuteScalarQuery(string sql)
        {
            object n = 0;
            SqlConnection connect = new SqlConnection(Ketnoi);
            connect.Open();
            SqlCommand cmd = new SqlCommand(sql, connect);
            n = cmd.ExecuteScalar();
            connect.Close();
            return n;
        }
    }
}
