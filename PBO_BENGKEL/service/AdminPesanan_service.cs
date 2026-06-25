using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;
using PBO_BENGKEL.konfigurasi; // Pastiin nama folder Koneksi lu bener ini


namespace PBO_BENGKEL.service
{
    public class AdminPesanan_service
    {
        private MySqlConnection conn;

        public AdminPesanan_service()
        {
            conn = Koneksi.GetConn();
        }

        // # Fungsi HANYA UNTUK MENGAMBIL semua data dari tabel_pesanan ke GridView
        public DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT id_servis AS 'ID Servis', nama_pelanggan AS 'Nama Pelanggan', no_hp AS 'No. HP', keluhan AS 'Keluhan', plat_nomor AS 'Plat Nomor' FROM tabel_pesanan";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                // Mengabaikan error agar aplikasi tidak crash, return DataTable kosong jika gagal
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // # Fungsi HANYA UNTUK MENGAMBIL/generate ID Otomatis berikutnya berdasarkan data di tabel_pesanan
        public string KodeOtomatis()
        {
            string idBaru = "SRV-0000000001"; // Default awal kalau tabel kosong (14 karakter)
            try
            {
                conn.Open();
                string query = "SELECT MAX(RIGHT(id_servis, 10)) FROM tabel_pesanan";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null && result.ToString() != "")
                {
                    long maxId = Convert.ToInt64(result) + 1;
                    idBaru = "SRV-" + maxId.ToString("D10");
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return idBaru;
        }
    }
}
