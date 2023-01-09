using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QLThuVien.DataAccessLayer
{
    class DataProvider
    {
        private static SqlConnection conn;
        public static string connectionStr= @"Data Source=DESKTOP-419TDTA;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        //tao ket noi vs sql
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=DESKTOP-419TDTA;Initial Catalog=QuanLyThuVien;Integrated Security=True";
                SqlConnection conn = new SqlConnection(sql);
                conn.Open();

                return conn;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối!!!", "Error",MessageBoxButtons.OK);
                return null;
            }
        }

        //Dua du lieu vao bang
        public static DataTable GetData(string proc)
        {
            try
            {
                conn = Connect();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(proc, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                conn.Close();
                return null;
            }
        }

        //thuc hien thu tuc
        public static int ExecuteNonQuery(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);

                int val = cmd.ExecuteNonQuery();
                conn.Close();
                return val;
            }
            catch (SqlException)
            {
                return 0;
            }
          
        }

        public static void ExecuteQuery(string query)
        {
            try
            {
                conn = Connect();
                SqlCommand sqlDa = new SqlCommand(query, conn);
                sqlDa.ExecuteNonQuery();

                //int val = sqlDa.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException)
            {
            }

        }

    }
}
