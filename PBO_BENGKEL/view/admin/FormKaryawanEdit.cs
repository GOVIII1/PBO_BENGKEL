using PBO_BENGKEL.service;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.admin
{
    public partial class FormKaryawanEdit : Form
    {
        private KaryawanService srv = new KaryawanService();
        private string editUsername = null;
        private string fotoPath = null;

        public FormKaryawanEdit()
        {
            InitializeComponent();
            this.Text = "Tambah Karyawan";
        }

        public FormKaryawanEdit(string username)
        {
            InitializeComponent();
            this.Text = "Edit Karyawan";
            editUsername = username;
            this.Load += (s, e) => LoadData(username);
        }

        private void LoadData(string username)
        {
            DataRow row = srv.GetDetail(username);
            if (row == null) return;
            txtUsername.Text = row["username"].ToString();
            txtUsername.ReadOnly = true;
            txtPassword.Text = row["password"].ToString();
            cmbRole.Text = row["role"].ToString();
            txtNama.Text = row["nama_lengkap"].ToString();
            txtNoHp.Text = row["no_hp"].ToString();
            txtAlamat.Text = row["alamat"].ToString();
            if (row["foto"] != DBNull.Value && !string.IsNullOrEmpty(row["foto"].ToString()))
            {
                fotoPath = row["foto"].ToString();
                if (System.IO.File.Exists(fotoPath))
                    pictureBox.Image = Image.FromFile(fotoPath);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Username & password wajib!"); return; }

            bool ok;
            if (editUsername == null)
                ok = srv.Tambah(txtUsername.Text.Trim(), txtPassword.Text.Trim(), cmbRole.Text,
                                txtNama.Text.Trim(), txtNoHp.Text.Trim(), txtAlamat.Text.Trim(), fotoPath);
            else
                ok = srv.Ubah(editUsername, txtPassword.Text.Trim(), cmbRole.Text,
                              txtNama.Text.Trim(), txtNoHp.Text.Trim(), txtAlamat.Text.Trim(), fotoPath);

            if (ok) { MessageBox.Show("Berhasil!"); this.DialogResult = DialogResult.OK; this.Close(); }
            else MessageBox.Show("Gagal! Username mungkin sudah dipakai.", "Error");
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(ofd.FileName);
                string destDir = System.IO.Path.Combine(Application.StartupPath, "Images");
                System.IO.Directory.CreateDirectory(destDir);
                string destFile = System.IO.Path.Combine(destDir, Guid.NewGuid().ToString() + ext);
                System.IO.File.Copy(ofd.FileName, destFile, true);
                fotoPath = destFile;
                pictureBox.Image = Image.FromFile(destFile);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e) { this.Close(); }
    }
}
