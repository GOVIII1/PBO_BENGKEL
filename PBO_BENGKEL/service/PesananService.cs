using Projek.konfigurasi;
using Projek.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek.service
{
    internal class PesananService : koneksi_cls.Koneksi_cls
    {
        // 1. LOGIKA GENERATE ID OTOMATIS (Mencari nilai ID tertinggi + 1)
        public int GenerateAutoId()
        {
            int nextId = 1; // Nilai awal jika tabel masih kosong
            string query = "SELECT MAX(id_servis) FROM tabel_pesanan";

            // Memanggil fungsi dari dasar koneksi_cls
            DataTable dt = eksekusiQuery(query);

            if (dt != null && dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                nextId = Convert.ToInt32(dt.Rows[0][0]) + 1;
            }

            return nextId;
        }

        // 2. LOGIKA MENAMPILKAN DATA KE TABEL UTAMA KASIR
        public DataTable TampilkanSemua()
        {
            //string query = "SELECT * FROM tabel_pesanan";
            //return eksekusiQuery(query);


            // Menggunakan alias (AS) agar judul kolom di DataGridView tampil rapi sesuai desain dashboard
            string query = "SELECT * FROM tabel_pesanan";
            return eksekusiQuery(query);
        }

        // 3. LOGIKA TAMBAH DATA PESANAN
        public bool TambahPesanan(PesananModel pesanan)
        {
            // Menyusun query string string interpolation
            string query = $"INSERT INTO tabel_pesanan (id_servis, nama_pelanggan, no_hp, plat_nomor, keluhan) " +
                           $"VALUES ({pesanan.IdServis}, '{pesanan.NamaPelanggan}', '{pesanan.NoHp}', '{pesanan.PlatNomor}', '{pesanan.Keluhan}')";

            // Menjalankan perintah non-query
            int hasil = eksekusiNonQuery(query);

            // Jika hasil lebih dari 0 berarti data berhasil masuk
            return hasil > 0;
        }
    }
}
