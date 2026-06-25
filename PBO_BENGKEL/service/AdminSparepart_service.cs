using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;
using PBO_BENGKEL.konfigurasi; // Pastiin nama folder Koneksi lu bener ini

namespace PBO_BENGKEL.service
{
    public class AdminSparepart_service
    {
        private MySqlConnection conn;

        public AdminSparepart_service()
        {
            conn = Koneksi.GetConn();
        }

        // Fungsi nyimpen barang baru ke database
        public bool TambahSparepart(Sparepart_cls sp)
        {
            bool status = false;
            try
            {
                conn.Open();
                string query = "INSERT INTO tabel_sparepart (id_sparepart, nama_sparepart, stok, harga_part) VALUES (@id, @nama, @stok, @harga)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", sp.id_sparepart);
                cmd.Parameters.AddWithValue("@nama", sp.nama_sparepart);
                cmd.Parameters.AddWithValue("@stok", sp.stok);
                cmd.Parameters.AddWithValue("@harga", sp.harga_part);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }

        // Fungsi nampilin data ke DataGridView di Form
        public DataTable TampilkanSemua()
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

        // # Fungsi bikin ID Otomatis
        public string KodeOtomatis()
        {
            string idBaru = "S01";
            try
            {
                conn.Open();
                // ambil angka terbesar
                string query = "SELECT MAX(RIGHT(id_sparepart, 2)) FROM tabel_sparepart";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    // # Kalau udah ada data, angkanya ditambah 1
                    int maxId = Convert.ToInt32(result) + 1;
                    idBaru = "S" + maxId.ToString("D2"); 
                }
            }
            catch (Exception)
            {
                // # Kalo error, biarin tetep S01
            }
            finally
            {
                conn.Close();
            }
            return idBaru;
        }

        // # Fungsi buat ngedit / update data stok atau harga yang udah ada
        public bool UbahSparepart(Sparepart_cls sp)
        {
            bool status = false;
            try
            {
                conn.Open();
                // # Kodingan SQL buat UPDATE berdasarkan ID Sparepart
                string query = "UPDATE tabel_sparepart SET nama_sparepart = @nama, stok = @stok, harga_part = @harga WHERE id_sparepart = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", sp.id_sparepart);
                cmd.Parameters.AddWithValue("@nama", sp.nama_sparepart);
                cmd.Parameters.AddWithValue("@stok", sp.stok);
                cmd.Parameters.AddWithValue("@harga", sp.harga_part);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
    }
}