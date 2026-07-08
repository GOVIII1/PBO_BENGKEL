using PBO_BENGKEL.konfigurasi;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.kasir
{
    public partial class FormProfilKasir : Form
    {
        public FormProfilKasir()
        {
            InitializeComponent();
            this.Load += (s, e) => MuatProfil();
            btnGantiFoto.Click += BtnGantiFoto_Click;
        }

        private void MuatProfil()
        {
            lblNamaKasir.Text = "Nama: " + (Session.NamaLengkap ?? Session.Username);
            lblRoleKasir.Text = "Role: " + Session.Role;
            lblUsernameKasir.Text = "Username: " + Session.Username;
            if (!string.IsNullOrEmpty(Session.FotoPath) && File.Exists(Session.FotoPath))
                pictureBox.Image = Image.FromFile(Session.FotoPath);
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
                catch (Exception ex) { MessageBox.Show(this, "Gagal: " + ex.Message); }
            }
        }
    }
}
