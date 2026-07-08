using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    public class AdminPesanan_service
    {
        public DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_servis AS 'ID Servis', nama_pelanggan AS 'Nama Pelanggan', no_hp AS 'No. HP', keluhan AS 'Keluhan', plat_nomor AS 'Plat Nomor', status AS 'Status' FROM pesanan ORDER BY created_at DESC";
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
                }
            }
            catch (Exception) { }
            return dt;
        }

        public string KodeOtomatis()
        {
            string idBaru = "SRV-0000000001";
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT MAX(CAST(SUBSTRING(id_servis, 5) AS UNSIGNED)) FROM pesanan";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            long maxId = Convert.ToInt64(result) + 1;
                            idBaru = "SRV-" + maxId.ToString("D10");
                        }
                    }
                }
            }
            catch (Exception) { }
            return idBaru;
        }
    }
}
