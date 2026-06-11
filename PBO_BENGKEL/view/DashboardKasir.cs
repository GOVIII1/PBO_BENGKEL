using PBO_BENGKEL.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_BENGKEL.view
{
    public partial class DashboardKasir : Form
    {
        // Menggunakan penamaan objek yang lebih deskriptif
        PesananService pesananService = new PesananService();

        public DashboardKasir()
        {
            InitializeComponent();
            // Menghubungkan event Load secara programmatic agar aman jika belum di-double click di designer
            this.Load += new EventHandler(DashboardKasir_Load);
        }

        // 1. EVENT LOAD: Berjalan otomatis saat form pertama kali terbuka layar
        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            tampilGrid(); // Memunculkan data dari database langsung saat aplikasi start
        }

        // Fungsi penampil data ke DataGridView
        void tampilGrid()
        {
            //pesanan_dgv.DataSource = pesananService.TampilkanSemua();
            // 1. Matikan fitur pembuat kolom otomatis dari C#
            pesanan_dgv.AutoGenerateColumns = false;

            // 2. Panggil datanya
            pesanan_dgv.DataSource = pesananService.TampilkanSemua();
        }

        // 2. TOMBOL TAMBAH PESANAN (Asumsi button1 adalah tombol "Tambah Pesanan")
        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahPesanan formTambah = new FormTambahPesanan();

            // Jika FormTambahPesanan ditutup dengan menekan tombol Tambah (DialogResult.OK)
            if (formTambah.ShowDialog() == DialogResult.OK)
            {
                tampilGrid(); // Refresh DataGridView agar pesanan yang baru langsung muncul
            }
        }

        private void pesanan_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tempat aksi jika cell dgv diklik (bisa dikosongkan dulu)
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}