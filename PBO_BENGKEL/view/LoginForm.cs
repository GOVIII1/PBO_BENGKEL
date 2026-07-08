using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.view.kasir;
using PBO_BENGKEL.view.mekanik;
using PBO_BENGKEL.view.admin;

namespace PBO_BENGKEL.view
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = null;
                string role = null;

                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username=@user AND password=@pass";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read())
                            {
                                MessageBox.Show("Username atau Password salah, Ngab!", "Gagal");
                                return;
                            }
                            username = dr["username"].ToString();
                            role = dr["role"].ToString();
                        }
                    }
                }

                Session.Username = username;
                Session.Role = role;

                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string qKaryawan = "SELECT nama_lengkap, foto FROM karyawan WHERE username = @u";
                    using (var cmd = new MySqlCommand(qKaryawan, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        using (var r2 = cmd.ExecuteReader())
                        {
                            if (r2.Read())
                            {
                                Session.NamaLengkap = r2["nama_lengkap"].ToString();
                                Session.FotoPath = r2["foto"] == DBNull.Value ? null : r2["foto"].ToString();
                            }
                        }
                    }
                }

                MessageBox.Show("Login Berhasil! Selamat datang " + role, "Sukses");
                this.Hide();

                if (role == "Admin")
                    new AdminDashboardForm().Show();
                else if (role == "Kasir")
                    new DashboardKasir().Show();
                else if (role == "Mekanik")
                    new FormMekanik().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void namabengkel_Click(object sender, EventArgs e) { }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
