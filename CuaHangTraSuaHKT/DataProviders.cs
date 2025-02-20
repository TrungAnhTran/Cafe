using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnhCF
{
    internal class DataProviders
    {
        static string chuoiKetNoi = @"data source=LAPTOPCAOCAP;Initial Catalog=ANHCF;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(chuoiKetNoi);
        static SqlDataAdapter da = new SqlDataAdapter();

        // Mở kết nối và in tên cơ sở dữ liệu
        public static SqlConnection OpenConnecttion()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }

            // Lấy tên cơ sở dữ liệu sau khi kết nối
            string query = "SELECT DB_NAME() AS DatabaseName";
            SqlCommand cmd = new SqlCommand(query, conn);
            string dbName = (string)cmd.ExecuteScalar(); // Thực thi câu lệnh và lấy tên cơ sở dữ liệu

            // In tên cơ sở dữ liệu (console hoặc MessageBox)
            Console.WriteLine($"Kết nối thành công với cơ sở dữ liệu: {dbName}"); // In ra console nếu cần thiết

            return conn;
        }

        // Các phương thức khác như ExecuteQuery, ExecuteDataView v.v. giữ nguyên

    }
}
