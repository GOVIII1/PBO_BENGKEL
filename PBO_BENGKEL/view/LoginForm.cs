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
                        AdminForm formAdmin = new AdminForm();
                        formAdmin.Show();
                    }
                    else if (role == "Kasir")
                    {
                        KasirForm formKasir = new KasirForm();
                        formKasir.Show();
                    }
                    else if (role == "Mekanik")
                    {
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

        private void label99_Click(object sender, EventArgs e)
        {

        }
    }
}