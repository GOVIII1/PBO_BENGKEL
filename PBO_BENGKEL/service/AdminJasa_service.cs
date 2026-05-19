using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.service
{
    public class AdminJasa_service
    {
        private MySqlConnection conn;

        public AdminJasa_service()
        {
            conn = Koneksi.GetConn();
        }

        public bool TambahJasa(Jasa_cls js)
        {
            bool status = false;
            try
            {
                conn.Open();
                string query = "INSERT INTO tabel_jasa (id_jasa, nama_jasa, harga_jasa) VALUES (@id, @nama, @harga)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", js.id_jasa);
                cmd.Parameters.AddWithValue("@nama", js.nama_jasa);
                cmd.Parameters.AddWithValue("@harga", js.harga_jasa);

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

        public DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT id_jasa AS 'ID Jasa', nama_jasa AS 'Nama Paketan/Servis', harga_jasa AS 'Tarif Harga' FROM tabel_jasa";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // # Fungsi bikin ID Otomatis buat Jasa
        public string KodeOtomatis()
        {
            string idBaru = "J01";
            try
            {
                conn.Open();
                // # Ngambil angka paling gede dari ID Jasa
                string query = "SELECT MAX(RIGHT(id_jasa, 2)) FROM tabel_jasa";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value && result != null)
                {
                    // # Tambah 1 dari ID terakhir
                    int maxId = Convert.ToInt32(result) + 1;
                    idBaru = "J" + maxId.ToString("D2"); // # Hasilnya misal: J05, J06
                }
            }
            catch (Exception)
            {
                // # Kalo error atau tabel masih kosong, biarin tetep J01
            }
            finally
            {
                conn.Close();
            }
            return idBaru;
        }
    }
}