using PBO_BENGKEL.service;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.admin
{
    public partial class KelolaKaryawanForm : Form
    {
        private KaryawanService srv = new KaryawanService();

        public KelolaKaryawanForm()
        {
            InitializeComponent();
            this.Load += (s, e) => MuatData();
        }

        private void MuatData()
        {
            dgvKaryawan.DataSource = srv.TampilkanSemua();
            // # AutoSizeColumnsMode, RowHeadersVisible, SelectionMode pindah ke Designer.cs
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FormKaryawanEdit form = new FormKaryawanEdit();
            if (form.ShowDialog() == DialogResult.OK) MuatData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count == 0) { MessageBox.Show("Pilih karyawan!"); return; }
            string username = dgvKaryawan.SelectedRows[0].Cells["Username"].Value.ToString();
            FormKaryawanEdit form = new FormKaryawanEdit(username);
            if (form.ShowDialog() == DialogResult.OK) MuatData();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.SelectedRows.Count == 0) { MessageBox.Show("Pilih karyawan!"); return; }
            string username = dgvKaryawan.SelectedRows[0].Cells["Username"].Value.ToString();
            if (MessageBox.Show($"Hapus {username}?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (srv.Hapus(username)) MuatData();
                else MessageBox.Show("Gagal hapus!");
            }
        }

    }
}
