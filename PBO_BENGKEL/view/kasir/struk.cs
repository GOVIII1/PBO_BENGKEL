using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using PBO_BENGKEL.model;
using PBO_BENGKEL.service;

namespace PBO_BENGKEL.view.kasir
{
    public partial class Struk : Form
    {
        private Struk_service _strukService = new Struk_service();
        private string _idServis;
        private Struk_clz _dataStruk; // simpan data untuk dipakai saat print

        public Struk()
        {
            InitializeComponent();
        }

        public Struk(string idServis)
        {
            InitializeComponent();
            _idServis = idServis;
        }

        private void Struk_Load(object sender, EventArgs e)
        {
            TampilStruk();
            button1.Click += new EventHandler(btnCetak_Click);
        }

        private void TampilStruk()
        {
            if (string.IsNullOrEmpty(_idServis)) return;

            _dataStruk = _strukService.GetDataStruk(_idServis);

            if (_dataStruk == null)
            {
                MessageBox.Show("Data struk tidak ditemukan!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Isi semua field di form
            textBox1.Text = _dataStruk.IdServis;       // Id Struk
            textBox1.ReadOnly = true;
            textBox2.Text = _dataStruk.NamaKasir;      // Kasir
            textBox2.ReadOnly = true;
            textBox3.Text = _dataStruk.TanggalServis.ToString("dd/MM/yyyy HH:mm"); // Tanggal
            textBox3.ReadOnly = true;
            label13.Text = _dataStruk.Status == "Lunas" ? "Lunas" : "Belum Bayar";
            label13.ForeColor = _dataStruk.Status == "Lunas" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            label12.Text = "Total: Rp " + _dataStruk.TotalTagihan.ToString("N0");

            dgvPesanan.Rows.Clear();
            foreach (var item in _dataStruk.DaftarItem)
            {
                dgvPesanan.Rows.Add(
                    item.NamaItem + " (x" + item.Qty + ")",
                    "Rp " + item.Subtotal.ToString("N0")
                );
            }
            dgvPesanan.Rows.Add("TOTAL", "Rp " + _dataStruk.TotalTagihan.ToString("N0"));
        }

        // =============================================
        // TOMBOL CETAK — print ke printer beneran
        // =============================================
        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (_dataStruk == null)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan dialog pilih printer
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            // Ukuran kertas struk kecil (80mm thermal printer)
            printDoc.DefaultPageSettings.PaperSize =
                new PaperSize("Custom", 315, 700); // satuan 1/100 inch, ~80mm lebar

            printDoc.PrintPage += new PrintPageEventHandler(PrintStruk);

            printDlg.Document = printDoc;

            DialogResult hasil = printDlg.ShowDialog();
            if (hasil == DialogResult.OK)
            {
                printDoc.Print();
                MessageBox.Show("Struk berhasil dicetak!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // =============================================
        // LOGIKA GAMBAR ISI STRUK KE PRINTER
        // =============================================
        private void PrintStruk(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 10;    // margin kiri
            int y = 10;    // posisi Y berjalan
            int lebar = 280; // lebar area cetak

            Font fontJudul = new Font("Courier New", 11, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 8);
            Font fontBold = new Font("Courier New", 9, FontStyle.Bold);
            Brush hitam = Brushes.Black;

            // ---- HEADER ----
            string judul = "BENGKEL AMBEBM";
            SizeF ukuranJudul = g.MeasureString(judul, fontJudul);
            g.DrawString(judul, fontJudul, hitam, x + (lebar - ukuranJudul.Width) / 2, y);
            y += 18;

            g.DrawString("Jl. Alamat No.3, Kab. Kecamatan", fontNormal, hitam, x, y);
            y += 14;
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;

            // ---- INFO NOTA ----
            g.DrawString("ID Servis : " + _dataStruk.IdServis, fontNormal, hitam, x, y);
            y += 14;
            g.DrawString("Plat Motor: " + _dataStruk.PlatNomor, fontNormal, hitam, x, y);
            y += 14;
            g.DrawString("Kasir     : " + _dataStruk.NamaKasir, fontNormal, hitam, x, y);
            y += 14;
            g.DrawString("Tanggal   : " + _dataStruk.TanggalServis.ToString("dd/MM/yyyy HH:mm"), fontNormal, hitam, x, y);
            y += 14;
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;

            // ---- HEADER KOLOM ----
            g.DrawString("Item                    Harga", fontBold, hitam, x, y);
            y += 14;
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;

            // ---- DAFTAR ITEM ----
            foreach (var item in _dataStruk.DaftarItem)
            {
                string namaItem = (item.NamaItem.Length > 16)
                    ? item.NamaItem.Substring(0, 16)
                    : item.NamaItem.PadRight(16);

                string hargaStr = ("Rp " + item.Subtotal.ToString("N0")).PadLeft(14);
                g.DrawString(namaItem + hargaStr, fontNormal, hitam, x, y);
                y += 13;

                // Baris qty kalau lebih dari 1
                if (item.Qty > 1)
                {
                    g.DrawString("  " + item.Qty + " x Rp " + item.HargaSatuan.ToString("N0"),
                        fontNormal, hitam, x, y);
                    y += 13;
                }
            }

            // ---- TOTAL ----
            y += 4;
            g.DrawString(new string('=', 42), fontNormal, hitam, x, y);
            y += 14;
            string totalStr = "TOTAL: Rp " + _dataStruk.TotalTagihan.ToString("N0");
            SizeF ukuranTotal = g.MeasureString(totalStr, fontBold);
            g.DrawString(totalStr, fontBold, hitam, x + (lebar - ukuranTotal.Width) / 2, y);
            y += 20;

            // ---- FOOTER ----
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;
            g.DrawString("Terima kasih sudah menggunakan", fontNormal, hitam, x, y);
            y += 13;
            g.DrawString("jasa kami! Hubungi: (1123)44536", fontNormal, hitam, x, y);
            y += 13;
            g.DrawString("untuk keluhan, kesan dan pesan.", fontNormal, hitam, x, y);

            e.HasMorePages = false;
        }
    }
}
