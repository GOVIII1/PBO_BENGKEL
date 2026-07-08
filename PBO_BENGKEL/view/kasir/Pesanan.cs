using System;
using System.Windows.Forms;
using PBO_BENGKEL.model;
using PBO_BENGKEL.service;

namespace PBO_BENGKEL.view.kasir
{
    public partial class FormTambahPesanan : Form
    {
        private PesananService _pesananService;
        private string _idServisOtomatis;

        public FormTambahPesanan()
        {
            InitializeComponent();
            _pesananService = new PesananService();
        }

        private void FormTambahPesanan_Load(object sender, EventArgs e)
        {
            _idServisOtomatis = _pesananService.GenerateAutoId();
            txtIdServis.Visible = false;
            lblIdServis.Visible = false;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) ||
                string.IsNullOrWhiteSpace(txtNoHp.Text) ||
                string.IsNullOrWhiteSpace(txtPlat.Text))
            {
                MessageBox.Show("Data Nama, Nomor Handphone, dan Plat Nomor wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PesananModel dataPesanan = new PesananModel
            {
                IdServis = _idServisOtomatis,
                NamaPelanggan = txtNama.Text.Trim(),
                NoHp = txtNoHp.Text.Trim(),
                PlatNomor = txtPlat.Text.Trim(),
                Keluhan = txtKeluhan.Text.Trim()
            };

            bool berhasilSimpan = _pesananService.TambahPesanan(dataPesanan);

            if (berhasilSimpan)
            {
                MessageBox.Show("Data pesanan berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data. Silakan coba kembali.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdServis_TextChanged(object sender, EventArgs e) { }
        private void lblJudulForm_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
