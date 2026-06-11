using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.model;

namespace PBO_BENGKEL.service
{
    public class BayarService
    {
        private readonly string _connectionString = "server=localhost;port=3306;username=root;password=;database=pbo_bengkel;";

        public BayarModel GetDetailPembayaranReal(string idServis)
        {
            BayarModel pesanan = null;

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Ambil data Header dari tabel_pesanan
                    string queryHeader = "SELECT id_servis, plat_nomor, nama_pelanggan FROM tabel_pesanan WHERE id_servis = @id_servis LIMIT 1";
                    using (MySqlCommand cmdHeader = new MySqlCommand(queryHeader, conn))
                    {
                        cmdHeader.Parameters.AddWithValue("@id_servis", idServis);
                        using (MySqlDataReader reader = cmdHeader.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                pesanan = new BayarModel
                                {
                                    IdServis = reader["id_servis"].ToString(),
                                    PlatNomor = reader["plat_nomor"].ToString(),
                                    NamaPelanggan = reader["nama_pelanggan"].ToString(),
                                    TotalTagihan = 0
                                };
                            }
                        }
                    }

                    // 2. Ambil detail sparepart dari tabel_transaksi_detail di-JOIN ke tabel_sparepart
                    if (pesanan != null)
                    {
                        string queryDetail = @"SELECT sp.nama_sparepart, td.qty, sp.harga_part 
                                               FROM tabel_transaksi_detail td
                                               INNER JOIN tabel_sparepart sp ON td.id_sparepart = sp.id_sparepart
                                               WHERE td.id_servis = @id_servis";

                        using (MySqlCommand cmdDetail = new MySqlCommand(queryDetail, conn))
                        {
                            cmdDetail.Parameters.AddWithValue("@id_servis", idServis);
                            using (MySqlDataReader readerDetail = cmdDetail.ExecuteReader())
                            {
                                while (readerDetail.Read())
                                {
                                    var detail = new DetailTagihan
                                    {
                                        NamaItem = readerDetail["nama_sparepart"].ToString(),
                                        Qty = Convert.ToInt32(readerDetail["qty"]),
                                        HargaSatuan = Convert.ToDecimal(readerDetail["harga_part"])
                                    };

                                    pesanan.RincianNota.Add(detail);
                                    pesanan.TotalTagihan += detail.Subtotal;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Gagal mengambil data dari database: " + ex.Message);
                }
            }

            return pesanan;
        }
    }
}