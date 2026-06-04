using System;
using System.Windows.Forms;
using Projek.model;   // Memanggil folder model
using Projek.service; // Memanggil folder service
using Projek.model;   // Memanggil folder model
using Projek.service; // Memanggil folder service

namespace Projek.view
{
    public partial class FormTambahPesanan : Form
    {
        // Membuat objek dari PesananService untuk mengakses database
        private PesananService _pesananService;
        
        // Variabel internal untuk menampung ID otomatis di latar belakang (tidak ditampilkan ke user)
        private string _idServisOtomatis;

        public FormTambahPesanan()
        {
            InitializeComponent();
            _pesananService = new PesananService();
        }

        private void FormTambahPesanan_Load(object sender, EventArgs e)
        {
            // 1. Ambil nilai ID otomatis terakhir dari database dan simpan ke variabel
            _idServisOtomatis = _pesananService.GenerateAutoId().ToString();

            // 2. Menyembunyikan TextBox dan Label ID Servis agar tidak tampil di layar kasir
            // Properti .Visible = false membuat komponen tersebut tidak terlihat saat aplikasi running
            txtIdServis.Visible = false;
            lblIdServis.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // 1. Validasi input untuk memastikan data penting tidak dikosongkan oleh kasir
            if (string.IsNullOrWhiteSpace(txtNama.Text) || 
                string.IsNullOrWhiteSpace(txtNoHp.Text) || 
                string.IsNullOrWhiteSpace(txtPlat.Text))
            {
                MessageBox.Show("Data Nama, Nomor Handphone, dan Plat Nomor wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Memasukkan data dari setiap inputan Form ke dalam objek PesananModel
            PesananModel dataPesanan = new PesananModel
            {
                IdServis = _idServisOtomatis, // Menggunakan ID yang disimpan di latar belakang tadi
                NamaPelanggan = txtNama.Text.Trim(),
                NoHp = txtNoHp.Text.Trim(),
                PlatNomor = txtPlat.Text.Trim(),
                Keluhan = txtKeluhan.Text.Trim()
            };

            // 3. Mengirim objek data ke lapisan Service untuk dieksekusi ke database
            bool berhasilSimpan = _pesananService.TambahPesanan(dataPesanan);

            if (berhasilSimpan)
            {
                MessageBox.Show("Data pesanan kasir berhasil disimpan ke database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Set DialogResult ke OK untuk memberi sinyal ke Form Utama agar melakukan refresh data pada DataGridView
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data ke database. Silakan coba kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtIdServis_TextChanged(object sender, EventArgs e)
        {
            // Tetap dikosongkan karena textbox sudah disembunyikan
        }
    }
}