using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_BENGKEL.model;   // # Tambahan wajib buat manggil wadah data
using PBO_BENGKEL.service; // # Tambahan wajib buat manggil otak database

namespace PBO_BENGKEL.view.admin
{
    public partial class AdminSparepartForm : Form
    {
        // # Panggil service punya lu
        AdminSparepart_service srv = new AdminSparepart_service();

        public AdminSparepartForm()
        {
            InitializeComponent();
            MuatData(); // # Panggil fungsi nampilin data pas form pertama dibuka
        }

        // # Bikin fungsi khusus buat refresh tabel
        private void MuatData()
        {
            dgvSparepart.DataSource = srv.TampilkanSemua();

            // --- KODINGAN MAGIC BUAT NGERAPIHIN TABEL ---
            dgvSparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Biar lebar kolom otomatis full sejajar layar
            dgvSparepart.AllowUserToAddRows = false; // Ngilangin baris kosong nyebelin di paling bawah
            dgvSparepart.ReadOnly = true; // Biar user ga bisa iseng ngetik/ngubah isi tabel langsung
            dgvSparepart.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Kalo diklik langsung ke-blok 1 baris full (estetik)

            txtIdPart.Text = srv.KodeOtomatis(); // # Narik ID otomatis ke kotak
            txtIdPart.Enabled = false; // # Kotaknya dikunci biar user ga bisa ngedit ID-nya
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // # Biarin kosong, ini ga sengaja kepencet doang di desain
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // # Ini tombol simpan lu (button1)
            try
            {
                Sparepart_cls sp = new Sparepart_cls();

                // # PASTIIN NAMA TEXTBOX DI DESAIN LU UDAH SESUAI SAMA INI YA WIR
                sp.id_sparepart = txtIdPart.Text;
                sp.nama_sparepart = txtNamaBarang.Text;
                sp.stok = Convert.ToInt32(txtStok.Text);
                sp.harga_part = Convert.ToInt32(txtHarga.Text);

                if (srv.TambahSparepart(sp))
                {
                    MessageBox.Show("Barang berhasil masuk gudang, ngab!", "Sukses");
                    MuatData(); // # Refresh tabel otomatis

                    // # Bersihin kotak isian abis nyimpen
                    txtNamaBarang.Clear();
                    txtStok.Clear();
                    txtHarga.Clear();

                    // # PANGGIL ID BARU BUAT BARANG SELANJUTNYA
                    txtIdPart.Text = srv.KodeOtomatis();
                }
                else
                {
                    MessageBox.Show("Gagal nyimpen data, cek lagi ID-nya ngab!", "Error");
                }
            }
            catch (Exception)
            {
                // # Jaga-jaga kalau lu iseng ngetik huruf di kotak stok/harga
                MessageBox.Show("Stok sama harga wajib diisi pake angka woi!", "Peringatan");
            }
        }

        private void dgvSparepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // # Biarin kosong juga
        }

        private void dgvSparepart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cek biar ga error kalau user iseng ngeklik *header* tabel
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = dgvSparepart.Rows[e.RowIndex];

                // Narik data dari tabel ke TextBox. Pastiin nama string di dalem kurung siku SAMA PERSIS sama nama kolom di tabel lu
                txtIdPart.Text = baris.Cells["ID Part"].Value.ToString();
                txtNamaBarang.Text = baris.Cells["Nama Barang"].Value.ToString();
                txtStok.Text = baris.Cells["Sisa Stok"].Value.ToString();
                txtHarga.Text = baris.Cells["Harga"].Value.ToString();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdPart.Text) || txtIdPart.Text == srv.KodeOtomatis())
            {
                MessageBox.Show("Pilih barang di tabel dulu sebelum hapus!", "Peringatan");
                return;
            }
            if (MessageBox.Show($"Yakin hapus {txtNamaBarang.Text}?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (srv.HapusSparepart(txtIdPart.Text))
                {
                    MessageBox.Show("Barang berhasil dihapus!", "Sukses");
                    MuatData();
                    txtNamaBarang.Clear();
                    txtStok.Clear();
                    txtHarga.Clear();
                }
                else
                {
                    MessageBox.Show("Gagal hapus data!", "Error");
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                // # Wadah data
                Sparepart_cls sp = new Sparepart_cls();

                // # Ambil data dari kotak isian (termasuk ID yang kekunci)
                sp.id_sparepart = txtIdPart.Text;
                sp.nama_sparepart = txtNamaBarang.Text;
                sp.stok = Convert.ToInt32(txtStok.Text);
                sp.harga_part = Convert.ToInt32(txtHarga.Text);

                // # Lempar ke otak Update di Service
                if (srv.UbahSparepart(sp))
                {
                    MessageBox.Show("Data barang sukses di-update ngab!", "Sukses");
                    MuatData(); // # Refresh tabel otomatis biar langsung keliatan

                    // # Bersihin kotak isian
                    txtNamaBarang.Clear();
                    txtStok.Clear();
                    txtHarga.Clear();

                    // # Panggil ID otomatis yang baru lagi biar siap nerima barang baru
                    txtIdPart.Text = srv.KodeOtomatis();
                }
                else
                {
                    MessageBox.Show("Gagal update, pastiin lu udah milih barang di tabel dulu!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Jumlah stok sama harga wajib angka ngab!", "Peringatan");
            }
        }

        private void txtIdPart_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
