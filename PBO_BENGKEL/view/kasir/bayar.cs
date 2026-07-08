using System;
using System.Windows.Forms;
using PBO_BENGKEL.service;
using PBO_BENGKEL.model;

namespace PBO_BENGKEL.view.kasir
{
    public partial class bayar : Form
    {
        private BayarService _bayarService = new BayarService();
        private string _idServis;
        private decimal _totalTagihan = 0;

        public bayar()
        {
            InitializeComponent();
        }

        public bayar(string idServis)
        {
            InitializeComponent();
            _idServis = idServis;
        }

        private void bayar_Load(object sender, EventArgs e)
        {
            MuatDataPembayaran();

            jumlahuang_txt.GotFocus += (s, ev) =>
            {
                if (jumlahuang_txt.Text == "Ketik jumlah uang...")
                    jumlahuang_txt.Text = "";
            };
            jumlahuang_txt.LostFocus += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(jumlahuang_txt.Text))
                    jumlahuang_txt.Text = "Ketik jumlah uang...";
            };

            btnterima.Click += new EventHandler(btnterima_Click);
            btnBatal.Click += new EventHandler(btnBatal_Click);
        }

        private void MuatDataPembayaran()
        {
            if (string.IsNullOrEmpty(_idServis)) return;

            BayarModel data = _bayarService.GetDetailPembayaran(_idServis);

            if (data == null)
            {
                MessageBox.Show(this, "Data servis tidak ditemukan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            idservis_txt.Text = data.IdServis;
            platnomor_txt.Text = data.PlatNomor;
            idservis_txt.ReadOnly = true;
            platnomor_txt.ReadOnly = true;

            dgvRincian.Rows.Clear();
            foreach (var item in data.RincianNota)
            {
                dgvRincian.Rows.Add(
                    "-",
                    item.NamaItem,
                    item.Qty.ToString(),
                    item.Subtotal.ToString("N0")
                );
            }

            _totalTagihan = data.TotalTagihan;
            tagihan_txt.Text = "Rp " + _totalTagihan.ToString("N0");
            tagihan_txt.ReadOnly = true;
        }

        private void btnterima_Click(object sender, EventArgs e)
        {
            string inputUang = jumlahuang_txt.Text.Trim();
            if (inputUang == "Ketik jumlah uang..." || string.IsNullOrWhiteSpace(inputUang))
            {
                MessageBox.Show(this, "Masukkan jumlah uang yang diterima!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal uangDiterima;
            if (!decimal.TryParse(inputUang, out uangDiterima))
            {
                MessageBox.Show(this, "Jumlah uang harus berupa angka!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (uangDiterima < _totalTagihan)
            {
                MessageBox.Show(this,
                    "Uang tidak cukup!\nKurang: Rp " + (_totalTagihan - uangDiterima).ToString("N0"),
                    "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update status Lunas
            _bayarService.Lunas(_idServis);

            decimal kembalian = uangDiterima - _totalTagihan;

            MessageBox.Show(this,
                $"Pembayaran Lunas!\n\n" +
                $"Total Tagihan : Rp {_totalTagihan:N0}\n" +
                $"Uang Diterima : Rp {uangDiterima:N0}\n" +
                $"Kembalian     : Rp {kembalian:N0}",
                "Pembayaran Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (Struk formStruk = new Struk(_idServis))
            {
                formStruk.ShowDialog(this);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
