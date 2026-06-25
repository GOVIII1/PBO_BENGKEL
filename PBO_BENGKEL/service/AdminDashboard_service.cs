using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_BENGKEL.service
{
    internal class AdminDashboard_service
    {
        private MySqlConnection conn;


        public AdminDashboard_service()
        {
            conn = Koneksi.GetConn(); // Pastikan class Koneksi kamu udah ada
        }


        public int HitungTotalPesanan()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM tabel_pesanan";
                using (var conn = Koneksi.GetConn())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return 0;
            }
        }

        public DataTable TampilkanSparepart()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConn())
            {
                conn.Open();
                string query = "SELECT id_sparepart AS 'ID Part', nama_sparepart AS 'Nama Barang', stok AS 'Sisa Stok',harga_part AS 'Harga' FROM tabel_sparepart";
                new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
            }
            return dt;
        }

        public DataTable TampilkanPesanan()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConn())
            {
                conn.Open();
                string query = "SELECT id_servis AS 'ID Servis', nama_pelanggan AS 'Nama Pelanggan', no_hp AS 'No. HP',keluhan AS 'Keluhan', plat_nomor AS 'Plat Nomor' FROM tabel_pesanan";
                new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
            }
            return dt;
        }

        public DataTable TampilkanUser()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConn())
            {
                conn.Open();
                string query = "SELECT username AS 'Nama User', role AS 'Role' FROM tabel_user";
                new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
            }
            return dt;
        }

    }
}
