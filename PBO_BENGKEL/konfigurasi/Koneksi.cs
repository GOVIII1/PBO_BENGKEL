using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PBO_BENGKEL.konfigurasi
{
    class Koneksi
    {
        public static MySqlConnection GetConn()
        {
            string str = "server=localhost;user=root;database=pbo_bengkel;password=;";
            MySqlConnection conn = new MySqlConnection(str);
            return conn;
        }

        // Method untuk menjalankan query SELECT (Mengembalikan bentuk Tabel / DataTable)
        public DataTable eksekusiQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlConnection conn = GetConn();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eksekusiQuery: " + ex.Message);
            }
            return dt;
        }

        // Method untuk menjalankan query INSERT, UPDATE, DELETE
        // Method untuk menjalankan query INSERT, UPDATE, DELETE dan mengembalikan jumlah baris yang sukses
        public int eksekusiNonQuery(string query)
        {
            int result = 0;
            try
            {
                MySqlConnection conn = GetConn();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                result = cmd.ExecuteNonQuery(); // Eksekusi dan simpan jumlah datanya ke result
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error eksekusiNonQuery: " + ex.Message);
            }
            return result; // Balikin nilai int nya
        }
    }
}