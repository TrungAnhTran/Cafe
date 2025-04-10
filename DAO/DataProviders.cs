using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DataProviders
    {
        static string chuoiKetNoi = @"Server=localhost;Database=anhcf;UserID=root;Password=admin;";
        static MySqlConnection conn = new MySqlConnection(chuoiKetNoi);
        static MySqlDataAdapter da = new MySqlDataAdapter();

        public static MySqlConnection OpenConnecttion()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public static DataView ExecuteDataView(string query)
        {
            DataView dv = new DataView();
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Connection = OpenConnecttion();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "tbl");
            dv = ds.Tables["tbl"].DefaultView;

            conn.Close();
            return dv;
        }

        public static DataTable ExcuteSelectCommand(string query, MySqlParameter[] parameters = null)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            DataTable tbl = new DataTable();
            cmd.Connection = OpenConnecttion();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            da.SelectCommand = cmd;
            da.Fill(tbl);

            conn.Close();
            return tbl;
        }

        public static int inSertIntoCommand(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            int rows = 0;
            cmd.Connection = OpenConnecttion();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public static int deleteCommand(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            int rows = 0;
            cmd.Connection = OpenConnecttion();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public static int UpdateCommand(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            int rows = 0;
            cmd.Connection = OpenConnecttion();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public static int SelectCommand(string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            int rows = 0;
            cmd.Connection = OpenConnecttion();

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            rows = Convert.ToInt32(cmd.ExecuteScalar());
            return rows;
        }

        public static int SelectCommand(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query);
            int rows = 0;
            cmd.Connection = OpenConnecttion();

            rows = Convert.ToInt32(cmd.ExecuteScalar());
            return rows;
        }
    }
}