using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PBO_BENGKEL.konfigurasi
{
    class Koneksi
    {
        public static MySqlConnection GetConn()
        {
            string str = "server=localhost;user=root;database=pbo_bengkel(2);password=;";
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }

        public DataTable eksekusiQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetConn())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    conn.Open();
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eksekusiQuery: " + ex.Message);
            }
            return dt;
        }

        public int eksekusiNonQuery(string query)
        {
            int result = 0;
            try
            {
                using (MySqlConnection conn = GetConn())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eksekusiNonQuery: " + ex.Message);
            }
            return result;
        }
    }
}