using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using System;
using System.Data;

namespace PBO_BENGKEL.service
{
    internal class AdminDashboard_service
    {
        private MySqlConnection conn;


        public AdminDashboard_service()
        {
            conn = Koneksi.GetConn(); // Pastikan class Koneksi kamu udah ada
        }


        // Hitung total pesanan
        public int HitungTotalPesanan()
        {
            int total = 0;
            string query = "SELECT COUNT(*) FROM tabel_pesanan";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            conn.Open();
            total = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return total;
        }

        public DataTable TampilkanSparepart()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT id_sparepart AS 'ID Part', nama_sparepart AS 'Nama Barang', stok AS 'Sisa Stok', harga_part AS 'Harga' FROM tabel_sparepart";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                // Kalo error biarin kosong aja
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable TampilkanPesanan()
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
        public DataTable TampilkanUser()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT username AS 'Nama User', role AS 'Role' FROM tabel_user";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                // Kalo error biarin kosong aja
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

    }
}
