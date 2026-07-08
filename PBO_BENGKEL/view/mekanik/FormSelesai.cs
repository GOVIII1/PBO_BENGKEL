using PBO_BENGKEL.konfigurasi;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.mekanik
{
    public partial class FormSelesai : Form
    {
        public FormSelesai()
        {
            InitializeComponent();
            this.Load += (s, e) => MuatData();
        }

        private void MuatData()
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
                MessageBox.Show("Gagal muat data selesai: " + ex.Message);
            }
        }
    }
}
