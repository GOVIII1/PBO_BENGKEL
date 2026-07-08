using PBO_BENGKEL.service;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.view.mekanik
{
    public partial class FormMekanik : Form
    {
        public FormMekanik()
        {
            InitializeComponent();
            this.Load += FormMekanik_Load;
            btnDashboard.Click += (s, e) => ShowPage(panelDashboard);
            btnSelesai.Click += (s, e) => ShowPage(panelSelesai);
            btnProfil.Click += (s, e) => ShowPage(panelProfil);
            btnLogout.Click += BtnLogout_Click;
            btnKerjakan.Click += BtnKerjakan_Click;
            btnGantiFoto.Click += BtnGantiFoto_Click;
        }

        private void FormMekanik_Load(object sender, EventArgs e)
        {
            ShowPage(panelDashboard);
            TampilAntrian();
            TampilSelesai();
            MuatProfil();
        }

        private void ShowPage(Panel page)
        {
            panelDashboard.Visible = false;
            panelSelesai.Visible = false;
            panelProfil.Visible = false;
            page.Visible = true;
            page.BringToFront();
        }

        private void TampilAntrian()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_servis, nama_pelanggan, plat_nomor, keluhan FROM pesanan WHERE status = 'Dikirim' ORDER BY id_servis";
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
                    dgvAntrian.AutoGenerateColumns = false;
                    dgvAntrian.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void TampilSelesai()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_servis, nama_pelanggan, plat_nomor, keluhan FROM pesanan WHERE status IN ('Selesai','Lunas') AND dikerjakan_oleh = @u ORDER BY id_servis";
                    DataTable dt = new DataTable();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@u", Session.Username);
                    new MySqlDataAdapter(cmd).Fill(dt);
                    dgvSelesai.AutoGenerateColumns = false;
                    dgvSelesai.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void MuatProfil()
        {
            lblNamaMekanik.Text = "Nama: " + (Session.NamaLengkap ?? Session.Username);
            lblRoleMekanik.Text = "Role: " + Session.Role;
            lblUsernameMekanik.Text = "Username: " + Session.Username;
            if (!string.IsNullOrEmpty(Session.FotoPath) && File.Exists(Session.FotoPath))
                pictureBox.Image = Image.FromFile(Session.FotoPath);
        }

        private void BtnKerjakan_Click(object sender, EventArgs e)
        {
            if (dgvAntrian.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih antrian motor!", "Peringatan");
                return;
            }
            DataGridViewRow row = dgvAntrian.SelectedRows[0];
            string idServis = row.Cells["id_servis"].Value?.ToString() ?? "";
            string platMotor = row.Cells["plat_nomor"].Value?.ToString() ?? "";
            string keluhan = row.Cells["keluhan"].Value?.ToString() ?? "";

            FormTindakanMekanik form = new FormTindakanMekanik(idServis, platMotor, keluhan);
            if (form.ShowDialog() == DialogResult.OK)
            {
                TampilAntrian();
                TampilSelesai();
            }
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
                    MessageBox.Show("Foto berhasil diupdate!");
                }
                catch (Exception ex) { MessageBox.Show("Gagal: " + ex.Message); }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new PBO_BENGKEL.view.LoginForm().Show();
            }
        }
    }
}
