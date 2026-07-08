using System;
using System.Data;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.model;

namespace PBO_BENGKEL.service
{
    internal class Struk_service
    {
        public Struk_clz GetDataStruk(string idServis)
        {
            Struk_clz struk = null;
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string queryHeader = "SELECT id_servis, nama_pelanggan, plat_nomor, status FROM pesanan WHERE id_servis = @id LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(queryHeader, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idServis);
                        using (MySqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                struk = new Struk_clz
                                {
                                    IdServis = r["id_servis"].ToString(),
                                    NamaPelanggan = r["nama_pelanggan"].ToString(),
                                    PlatNomor = r["plat_nomor"].ToString(),
                                    Status = r["status"].ToString(),
                                    NamaKasir = Session.NamaLengkap ?? "Kasir",
                                    TanggalServis = DateTime.Now
                                };
                            }
                        }
                    }

                    if (struk != null)
                    {
                        string queryDetail = "SELECT nama_item, qty, harga, subtotal FROM detail_servis WHERE id_servis = @id";
                        using (MySqlCommand cmd = new MySqlCommand(queryDetail, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idServis);
                            using (MySqlDataReader r = cmd.ExecuteReader())
                            {
                                while (r.Read())
                                {
                                    struk.DaftarItem.Add(new StrukItemModel
                                    {
                                        NamaItem = r["nama_item"].ToString(),
                                        Qty = Convert.ToInt32(r["qty"]),
                                        HargaSatuan = Convert.ToDecimal(r["harga"])
                                    });
                                    struk.TotalTagihan += Convert.ToDecimal(r["subtotal"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Gagal ambil data struk: " + ex.Message, "Error",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return struk;
        }
    }
}
