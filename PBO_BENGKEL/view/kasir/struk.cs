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
        private Struk_clz _dataStruk; //simpan data

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
            textBox1.Text = _dataStruk.IdServis;//id
            textBox1.ReadOnly = true;
            textBox2.Text = _dataStruk.NamaKasir;  
            textBox2.ReadOnly = true;
            textBox3.Text = _dataStruk.TanggalServis.ToString("dd/MM/yyyy HH:mm");
            textBox3.ReadOnly = true;
            label13.Text = _dataStruk.Status == "Lunas" ? "Lunas" : "Belum Bayar";
            label13.ForeColor = _dataStruk.Status == "Lunas" ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            label12.Text = "Total: Rp " + _dataStruk.TotalTagihan.ToString("N0");

            dgvPesanan.Rows.Clear();
            foreach (var item in _dataStruk.DaftarItem)//hitung
            {
                dgvPesanan.Rows.Add(
                    item.NamaItem + " (x" + item.Qty + ")",
                    "Rp " + item.Subtotal.ToString("N0")
                );
            }
            dgvPesanan.Rows.Add("TOTAL", "Rp " + _dataStruk.TotalTagihan.ToString("N0"));
        }

        private void btnCetak_Click(object sender, EventArgs e)//cetak
        {
            if (_dataStruk == null)
            {
                MessageBox.Show("Tidak ada data untuk dicetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.DefaultPageSettings.PaperSize =
                new PaperSize("Custom", 315, 700);//ukkuran

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

       
        private void PrintStruk(object sender, PrintPageEventArgs e)//print
        {
            Graphics g = e.Graphics;
            int x = 10;  
            int y = 10;    
            int lebar = 280; 

            Font fontJudul = new Font("Courier New", 11, FontStyle.Bold);
            Font fontNormal = new Font("Courier New", 8);
            Font fontBold = new Font("Courier New", 9, FontStyle.Bold);
            Brush hitam = Brushes.Black;

           
            string judul = "BENGKEL SIMBEM";//h
            SizeF ukuranJudul = g.MeasureString(judul, fontJudul);
            g.DrawString(judul, fontJudul, hitam, x + (lebar - ukuranJudul.Width) / 2, y);
            y += 18;

            g.DrawString("Jl. Alamat No.3, Kab. Kecamatan", fontNormal, hitam, x, y);
            y += 14;
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;
            
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
         
            g.DrawString("Item                    Harga", fontBold, hitam, x, y);
            y += 14;
            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);
            y += 14;

            foreach (var item in _dataStruk.DaftarItem)
            {
                string namaItem = (item.NamaItem.Length > 16)
                    ? item.NamaItem.Substring(0, 16)
                    : item.NamaItem.PadRight(16);

                string hargaStr = ("Rp " + item.Subtotal.ToString("N0")).PadLeft(14);
                g.DrawString(namaItem + hargaStr, fontNormal, hitam, x, y);
                y += 13;

                if (item.Qty > 1)
                {
                    g.DrawString("  " + item.Qty + " x Rp " + item.HargaSatuan.ToString("N0"),
                        fontNormal, hitam, x, y);
                    y += 13;
                }
            }

            y += 4;
            g.DrawString(new string('=', 42), fontNormal, hitam, x, y);
            y += 14;
            string totalStr = "TOTAL: Rp " + _dataStruk.TotalTagihan.ToString("N0");
            SizeF ukuranTotal = g.MeasureString(totalStr, fontBold);
            g.DrawString(totalStr, fontBold, hitam, x + (lebar - ukuranTotal.Width) / 2, y);
            y += 20;

            g.DrawString(new string('-', 42), fontNormal, hitam, x, y);//footer
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
