using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi; // # TETEP WAJIB ADA BIAR MYSQL NYALA


namespace PBO_BENGKEL.view
{
    // 1. Namanya diganti jadi LoginForm
    public partial class LoginForm : Form
    {
        // 2. Ini juga wajib diganti jadi LoginForm (samain kayak nama class)
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = Koneksi.GetConn();
            try
            {
                conn.Open();
                string query = "SELECT * FROM tabel_user WHERE username=@user AND password=@pass";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string role = dr["role"].ToString();
                    MessageBox.Show("Login Berhasil! Selamat datang " + role, "Sukses");

                    this.Hide();

                    if (role == "Admin")
                    {
                        // # GANTI JADI INI WIR: Panggil AdminDashboardForm punya lu
                        AdminDashboardForm formAdmin = new AdminDashboardForm();
                        formAdmin.Show();
                    }
                    else if (role == "Kasir")
                    {
                        // # Kalo form kasir belum ada, mending di-comment dulu aja depannya pake garis miring dua // biar ga error
                        DashboardKasir kasir = new DashboardKasir();
                        kasir.Show();
                    }
                    else if (role == "Mekanik")
                    {
                        // # Pastiin form MekanikForm beneran udah dibikin sama Arum
                        MekanikForm formMekanik = new MekanikForm();
                        formMekanik.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password salah, Ngab!", "Gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Database: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void namabengkel_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}