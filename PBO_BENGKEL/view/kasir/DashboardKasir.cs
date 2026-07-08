using PBO_BENGKEL.service;
using PBO_BENGKEL.view;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PBO_BENGKEL.konfigurasi;
using MySql.Data.MySqlClient;

namespace PBO_BENGKEL.view.kasir
{
    public partial class DashboardKasir : Form
    {
        private PesananService pesananService = new PesananService();

        public DashboardKasir()
        {
            InitializeComponent();
            this.Load += DashboardKasir_Load;
            btnDashboard.Click += (s, e) => ShowPage(panelDashboard);
            btnRiwayat.Click += (s, e) => ShowPage(panelRiwayat);
            btnProfil.Click += (s, e) => ShowPage(panelProfil);
            btnLogout.Click += BtnLogout_Click;
            btnBayar.Click += BtnBayar_Click;
            btnTambahPesanan.Click += (s, e) => { new FormTambahPesanan().ShowDialog(); MuatSelesai(); };
            btnCetak.Click += BtnCetakSelesai_Click;
            btnCetakRiwayat.Click += BtnCetakRiwayat_Click;
            btnGantiFoto.Click += BtnGantiFoto_Click;
            dgvRiwayat.CellDoubleClick += (s, e) => { if (e.RowIndex >= 0) BukaStrukRiwayat(); };
        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            ShowPage(panelDashboard);
            MuatSelesai();
            MuatRiwayat();
            MuatProfil();
        }

        private void ShowPage(Panel page)
        {
            panelDashboard.Visible = false;
            panelRiwayat.Visible = false;
            panelProfil.Visible = false;
            page.Visible = true;
            page.BringToFront();
        }

        private void MuatSelesai()
        {
            dgvSelesai.AutoGenerateColumns = false;
            dgvSelesai.DataSource = pesananService.TampilkanSelesai();
        }

        private void MuatRiwayat()
        {
            dgvRiwayat.AutoGenerateColumns = false;
            dgvRiwayat.DataSource = pesananService.TampilkanLunas();
        }

        private void MuatProfil()
        {
            lblNamaKasir.Text = "Nama: " + (Session.NamaLengkap ?? Session.Username);
            lblRoleKasir.Text = "Role: " + Session.Role;
            lblUsernameKasir.Text = "Username: " + Session.Username;
            if (!string.IsNullOrEmpty(Session.FotoPath) && File.Exists(Session.FotoPath))
            {
                pictureBox.Image = Image.FromFile(Session.FotoPath);
            }
        }

        private void BtnBayar_Click(object sender, EventArgs e)
        {
            if (dgvSelesai.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Pilih pesanan yang ingin dibayar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idServis = dgvSelesai.SelectedRows[0].Cells["id_servis"].Value.ToString();
            using (bayar formBayar = new bayar(idServis))
            {
                formBayar.ShowDialog(this);
            }
            MuatSelesai();
            MuatRiwayat();
        }

        private void BtnGantiFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fotoPath = ofd.FileName;
                    using (var conn = Koneksi.GetConn())
                    {
                        conn.Open();
                        string query = "UPDATE karyawan SET foto = @foto WHERE username = @u";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@foto", fotoPath);
                            cmd.Parameters.AddWithValue("@u", Session.Username);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Session.FotoPath = fotoPath;
                    pictureBox.Image = Image.FromFile(fotoPath);
                    MessageBox.Show(this, "Foto berhasil diupdate!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Gagal: " + ex.Message);
                }
            }
        }

        private void BtnCetakSelesai_Click(object sender, EventArgs e)
        {
            if (dgvSelesai.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Pilih pesanan yang ingin dicetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idServis = dgvSelesai.SelectedRows[0].Cells["id_servis"].Value.ToString();
            using (Struk formStruk = new Struk(idServis)) { formStruk.ShowDialog(this); }
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
