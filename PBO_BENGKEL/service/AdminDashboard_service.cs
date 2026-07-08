using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    internal class AdminDashboard_service
    {
        public int HitungTotalPesanan()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM pesanan";
                    using (var cmd = new MySqlCommand(query, conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalPendapatanHariIni()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(ds.subtotal), 0) FROM detail_servis ds " +
                                   "INNER JOIN pesanan p ON ds.id_servis = p.id_servis " +
                                   "WHERE p.status = 'Lunas' AND DATE(p.updated_at) = CURDATE()";
                    using (var cmd = new MySqlCommand(query, conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalPendapatan()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT COALESCE(SUM(subtotal), 0) FROM detail_servis ds " +
                                   "INNER JOIN pesanan p ON ds.id_servis = p.id_servis WHERE p.status = 'Lunas'";
                    using (var cmd = new MySqlCommand(query, conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalKasir()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE role = 'Kasir'", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalMekanik()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM users WHERE role = 'Mekanik'", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalJenisJasa()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM jasa", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public int HitungTotalJenisSparepart()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM sparepart", conn))
                        return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch { return 0; }
        }

        public DataTable TampilkanPesanan()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConn())
            {
                conn.Open();
                string query = "SELECT id_servis AS 'ID Servis', nama_pelanggan AS 'Nama Pelanggan', no_hp AS 'No. HP', keluhan AS 'Keluhan', plat_nomor AS 'Plat Nomor', status AS 'Status' FROM pesanan ORDER BY created_at DESC";
                new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
            }
            return dt;
        }

        public DataTable TampilkanSparepart()
        {
            DataTable dt = new DataTable();
            using (var conn = Koneksi.GetConn())
            {
                conn.Open();
                string query = "SELECT id_sparepart AS 'ID Part', nama_sparepart AS 'Nama Barang', stok AS 'Sisa Stok', harga_part AS 'Harga' FROM sparepart";
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
                string query = "SELECT u.username AS 'Username', u.role AS 'Role', k.nama_lengkap AS 'Nama', k.no_hp AS 'No. HP' FROM users u LEFT JOIN karyawan k ON u.username = k.username";
                new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
            }
            return dt;
        }
    }
}
