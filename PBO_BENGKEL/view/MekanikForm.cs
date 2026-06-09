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
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.view
{
    public partial class MekanikForm : Form
    {
        public MekanikForm()
        {
            InitializeComponent();
            this.Load += AntrianPesanan_frm_Load;
        }

        private void AntrianPesanan_frm_Load(object sender, EventArgs e)
        {
            LoadMekanik();
            TampilData();
        }

        private void LoadMekanik()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query =
                        "SELECT id_mekanik, nama_mekanik FROM tabel_mekanik";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    namamekanik_cmb.DataSource = dt;
                    namamekanik_cmb.DisplayMember = "nama_mekanik";
                    namamekanik_cmb.ValueMember = "id_mekanik";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detail_btn_Click(object sender, EventArgs e)
        {
            BukaDetailPesanan();
        }

        private void BukaDetailPesanan()
        {
            if (antrian_dgv.SelectedRows.Count > 0)
            {
                string idPelanggan =
                    antrian_dgv.SelectedRows[0].Cells["ID"].Value.ToString();

                string namaPelanggan =
                    antrian_dgv.SelectedRows[0].Cells["Nama"].Value.ToString();

                string keluhan =
                    antrian_dgv.SelectedRows[0].Cells["Keluhan"].Value.ToString();

                DetailPesanan_frm detailForm =
                    new DetailPesanan_frm(
                        idPelanggan,
                        namaPelanggan,
                        keluhan);

                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    TampilData();
                }
            }
            else
            {
                MessageBox.Show(
                    "Silakan pilih salah satu data terlebih dahulu!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void kerjakan_btn_Click(object sender, EventArgs e)
        {

        }

        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query = @"
            SELECT
                p.id_pelanggan,
                p.nama_pelanggan,
                p.plat_motor,
                IFNULL(ps.keluhan,'') AS keluhan
            FROM tabel_pelanggan p
            LEFT JOIN tabel_pesanan ps
                ON p.nama_pelanggan = ps.nama_pelanggan";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    antrian_dgv.AutoGenerateColumns = false;
                    antrian_dgv.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
