using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    public class AdminJasa_service
    {
        public bool TambahJasa(Jasa_cls js)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "INSERT INTO jasa (id_jasa, nama_jasa, harga_jasa) VALUES (@id, @nama, @harga)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", js.id_jasa);
                        cmd.Parameters.AddWithValue("@nama", js.nama_jasa);
                        cmd.Parameters.AddWithValue("@harga", js.harga_jasa);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                }
            }
            catch (Exception) { status = false; }
            return status;
        }

        public DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_jasa AS 'ID Jasa', nama_jasa AS 'Nama Paketan/Servis', harga_jasa AS 'Tarif Harga' FROM jasa";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception) { }
            return dt;
        }

        public bool UbahJasa(Jasa_cls js)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "UPDATE jasa SET nama_jasa = @nama, harga_jasa = @harga WHERE id_jasa = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", js.id_jasa);
                        cmd.Parameters.AddWithValue("@nama", js.nama_jasa);
                        cmd.Parameters.AddWithValue("@harga", js.harga_jasa);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                }
            }
            catch (Exception) { status = false; }
            return status;
        }

        public bool HapusJasa(string idJasa)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "DELETE FROM jasa WHERE id_jasa = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idJasa);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                }
            }
            catch (Exception) { status = false; }
            return status;
        }

        public string KodeOtomatis()
        {
            string idBaru = "J01";
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT MAX(RIGHT(id_jasa, 2)) FROM jasa";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            int maxId = Convert.ToInt32(result) + 1;
                            idBaru = "J" + maxId.ToString("D2");
                        }
                    }
                }
            }
            catch (Exception) { }
            return idBaru;
        }
    }
}
