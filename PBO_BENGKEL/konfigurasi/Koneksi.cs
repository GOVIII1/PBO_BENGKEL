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
    }
}