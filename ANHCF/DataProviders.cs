using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AnhCF
{
    internal class DataProviders
    {
        // Change the connection string for MySQL
        static string chuoiKetNoi = @"Server=localhost;Database=ANHCF;Uid=root;Pwd=password;"; 
        static MySqlConnection conn = new MySqlConnection(chuoiKetNoi);
        static MySqlDataAdapter da = new MySqlDataAdapter();

        // Mở kết nối và in tên cơ sở dữ liệu
        public static MySqlConnection OpenConnecttion()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }

            // Lấy tên cơ sở dữ liệu sau khi kết nối
            string query = "SELECT DATABASE() AS DatabaseName"; // MySQL query to get the current database name
            MySqlCommand cmd = new MySqlCommand(query, conn);
            string dbName = (string)cmd.ExecuteScalar(); // Thực thi câu lệnh và lấy tên cơ sở dữ liệu

            // In tên cơ sở dữ liệu (console hoặc MessageBox)
            Console.WriteLine($"Kết nối thành công với cơ sở dữ liệu: {dbName}"); // In ra console nếu cần thiết

            return conn;
        }

        // Các phương thức khác như ExecuteQuery, ExecuteDataView v.v. giữ nguyên

    }
}
