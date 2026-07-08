using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    public class AdminSparepart_service
    {
        public bool TambahSparepart(Sparepart_cls sp)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "INSERT INTO sparepart (id_sparepart, nama_sparepart, stok, harga_part) VALUES (@id, @nama, @stok, @harga)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", sp.id_sparepart);
                        cmd.Parameters.AddWithValue("@nama", sp.nama_sparepart);
                        cmd.Parameters.AddWithValue("@stok", sp.stok);
                        cmd.Parameters.AddWithValue("@harga", sp.harga_part);
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
                    string query = "SELECT id_sparepart AS 'ID Part', nama_sparepart AS 'Nama Barang', stok AS 'Sisa Stok', harga_part AS 'Harga' FROM sparepart";
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

        public string KodeOtomatis()
        {
            string idBaru = "S01";
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT MAX(RIGHT(id_sparepart, 2)) FROM sparepart";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            int maxId = Convert.ToInt32(result) + 1;
                            idBaru = "S" + maxId.ToString("D2");
                        }
                    }
                }
            }
            catch (Exception) { }
            return idBaru;
        }

        public bool HapusSparepart(string idSparepart)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "DELETE FROM sparepart WHERE id_sparepart = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idSparepart);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                }
            }
            catch (Exception) { status = false; }
            return status;
        }

        public bool UbahSparepart(Sparepart_cls sp)
        {
            bool status = false;
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "UPDATE sparepart SET nama_sparepart = @nama, stok = @stok, harga_part = @harga WHERE id_sparepart = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", sp.id_sparepart);
                        cmd.Parameters.AddWithValue("@nama", sp.nama_sparepart);
                        cmd.Parameters.AddWithValue("@stok", sp.stok);
                        cmd.Parameters.AddWithValue("@harga", sp.harga_part);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0) status = true;
                    }
                }
            }
            catch (Exception) { status = false; }
            return status;
        }
    }
}
