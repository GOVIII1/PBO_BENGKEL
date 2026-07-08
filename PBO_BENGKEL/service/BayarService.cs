using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.model;

namespace PBO_BENGKEL.service
{
    public class BayarService
    {
        public BayarModel GetDetailPembayaran(string idServis)
        {
            BayarModel pesanan = null;
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string queryHeader = "SELECT id_servis, plat_nomor, nama_pelanggan FROM pesanan WHERE id_servis = @id LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(queryHeader, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idServis);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                pesanan = new BayarModel
                                {
                                    IdServis = r["id_servis"].ToString(),
                                    PlatNomor = r["plat_nomor"].ToString(),
                                    NamaPelanggan = r["nama_pelanggan"].ToString(),
                                    TotalTagihan = 0
                                };
                            }
                        }
                    }

                    if (pesanan != null)
                    {
                        string queryDetail = "SELECT nama_item, qty, harga, subtotal FROM detail_servis WHERE id_servis = @id";
                        using (MySqlCommand cmd = new MySqlCommand(queryDetail, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idServis);
                            using (MySqlDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    var item = new DetailTagihan
                                    {
                                        NamaItem = r["nama_item"].ToString(),
                                        Qty = Convert.ToInt32(r["qty"]),
                                        HargaSatuan = Convert.ToDecimal(r["harga"])
                                    };
                                    pesanan.RincianNota.Add(item);
                                    pesanan.TotalTagihan += item.Subtotal;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Gagal ambil data bayar: " + ex.Message);
            }
            return pesanan;
        }

        public bool Lunas(string idServis)
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "UPDATE pesanan SET status = 'Lunas' WHERE id_servis = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idServis);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch { return false; }
        }
    }
}
