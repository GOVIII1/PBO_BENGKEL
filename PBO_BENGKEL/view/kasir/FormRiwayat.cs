using PBO_BENGKEL.service;
using System;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.kasir
{
    public partial class FormRiwayat : Form
    {
        private PesananService pesananService = new PesananService();

        public FormRiwayat()
        {
            InitializeComponent();
            this.Load += (s, e) => MuatRiwayat();
            btnCetakRiwayat.Click += BtnCetakRiwayat_Click;
            dgvRiwayat.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) BukaStrukRiwayat(); };
        }

        private void MuatRiwayat()
        {
            dgvRiwayat.AutoGenerateColumns = false;
            dgvRiwayat.DataSource = pesananService.TampilkanLunas();
        }

        private void BtnCetakRiwayat_Click(object sender, EventArgs e)
        {
            BukaStrukRiwayat();
        }

        private void BukaStrukRiwayat()
        {
            if (dgvRiwayat.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Pilih pesanan yang ingin dicetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idServis = dgvRiwayat.SelectedRows[0].Cells["colRiwayatIdServis"].Value.ToString();
            using (Struk formStruk = new Struk(idServis)) { formStruk.ShowDialog(this); }
        }
    }
}
