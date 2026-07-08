using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.model;
using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace PBO_BENGKEL.service
{
    internal class PesananService : Koneksi
    {
        public string GenerateAutoId()
        {
            int nextId = 1;
            string query = "SELECT MAX(CAST(SUBSTRING(id_servis, 5) AS UNSIGNED)) FROM pesanan";
            DataTable dt = eksekusiQuery(query);
            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                nextId = Convert.ToInt32(dt.Rows[0][0]) + 1;
            return "SRV " + nextId;
        }

        public DataTable TampilkanSelesai()
        {
            return eksekusiQuery("SELECT * FROM pesanan WHERE status != 'Lunas' ORDER BY id_servis");
        }

        public DataTable TampilkanLunas()
        {
            return eksekusiQuery("SELECT * FROM pesanan WHERE status = 'Lunas' ORDER BY id_servis");
        }

        public bool TambahPesanan(PesananModel pesanan)
        {
            int hasil = 0;
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = @"INSERT INTO pesanan (id_servis, nama_pelanggan, no_hp, plat_nomor, keluhan, dibuat_oleh, status)
                                     VALUES (@id_servis, @nama_pelanggan, @no_hp, @plat_nomor, @keluhan, @dibuat_oleh, 'Dikirim')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_servis", pesanan.IdServis);
                        cmd.Parameters.AddWithValue("@nama_pelanggan", pesanan.NamaPelanggan);
                        cmd.Parameters.AddWithValue("@no_hp", pesanan.NoHp);
                        cmd.Parameters.AddWithValue("@plat_nomor", pesanan.PlatNomor);
                        cmd.Parameters.AddWithValue("@keluhan", pesanan.Keluhan ?? "");
                        cmd.Parameters.AddWithValue("@dibuat_oleh", Session.Username ?? "");
                        hasil = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Gagal simpan pesanan: " + ex.Message, "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return hasil > 0;
        }

        public bool UpdateStatus(string idServis, string statusBaru)
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "UPDATE pesanan SET status = @status WHERE id_servis = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@id", idServis);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }

        public bool UpdateStatusDikerjakan(string idServis, string dikerjakanOleh)
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "UPDATE pesanan SET status = 'Dikerjakan', dikerjakan_oleh = @mekanik WHERE id_servis = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mekanik", dikerjakanOleh);
                        cmd.Parameters.AddWithValue("@id", idServis);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }
    }
}
