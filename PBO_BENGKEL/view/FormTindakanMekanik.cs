using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_BENGKEL.view
{
    public partial class FormTindakanMekanik : Form
    {
        private string idServis;
        private string platMotor;
        private string keluhan;

        public FormTindakanMekanik()
        {
            InitializeComponent();
        }

        public FormTindakanMekanik(string idServis, string platMotor, string keluhan)
        {
            InitializeComponent();

            this.idServis = idServis;
            this.platMotor = platMotor;
            this.keluhan = keluhan;
        }

        private void FormTindakanMekanik_Load(object sender, EventArgs e)
        {
            lblMekanik.Text = "Mekanik Bertugas : Figo";

            lblMotor.Text =
                "Motor Dikerjakan : " + platMotor;

            lblKeluhan.Text =
                "Keluhan : " + keluhan;

            lblIdServis.Text =
                "ID Servis : " + idServis;

            LoadJasa();
            SetupGrid();
        }

        private void LoadJasa()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query =
                    "SELECT id_jasa,nama_jasa FROM tabel_jasa";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    pilihmenu_cmb.DataSource = dt;
                    pilihmenu_cmb.DisplayMember = "nama_jasa";
                    pilihmenu_cmb.ValueMember = "id_jasa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tambahJasa_pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SetupGrid()
        {
            daftarselesai_dgv.Columns.Clear();

            daftarselesai_dgv.Columns.Add("nama", "Nama Tindakan / Barang");
            daftarselesai_dgv.Columns.Add("harga", "Harga Satuan");
            daftarselesai_dgv.Columns.Add("qty", "Qty");
            daftarselesai_dgv.Columns.Add("subtotal", "Subtotal");

            daftarselesai_dgv.AllowUserToAddRows = false;
            daftarselesai_dgv.RowHeadersVisible = false;
        }

        private void masukkan_btn_Click(object sender, EventArgs e)
        {
            DataRowView drv =
                (DataRowView)pilihmenu_cmb.SelectedItem;

            string namaJasa =
                drv["nama_jasa"].ToString();

            int harga =
                Convert.ToInt32(drv["harga"]);

            int qty =
                Convert.ToInt32(jumlah_cmb.Text);

            int subtotal =
                harga * qty;

            daftarselesai_dgv.Rows.Add(
                namaJasa,
                harga.ToString("N0"),
                qty,
                subtotal.ToString("N0")
            );

            HitungTotal();
        }

        private void HitungTotal()
        {
            int total = 0;

            foreach (DataGridViewRow row in daftarselesai_dgv.Rows)
            {
                total += Convert.ToInt32(
                    row.Cells["subtotal"].Value
                        .ToString()
                        .Replace(".", "")
                );
            }

            lblTotal.Text =
                "TOTAL SEMENTARA : Rp " +
                total.ToString("N0");
        }

        private void pekerjaanselesai_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn =
                    Koneksi.GetConn())
                {
                    conn.Open();

                    foreach (DataGridViewRow row in daftarselesai_dgv.Rows)
                    {
                        string query = @"
                            INSERT INTO tabel_tindakan_servis
                            (
                                id_servis,
                                nama_jasa,
                                harga,
                                qty,
                                subtotal,
                                status
                            )
                            VALUES
                            (
                                @id_servis,
                                @nama_jasa,
                                @harga,
                                @qty,
                                @subtotal,
                                'SELESAI'
                            )";

                        MySqlCommand cmd =
                            new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue(
                            "@id_servis",
                            idServis);

                        cmd.Parameters.AddWithValue(
                            "@nama_jasa",
                            row.Cells["nama"].Value);

                        cmd.Parameters.AddWithValue(
                            "@harga",
                            row.Cells["harga"].Value
                                .ToString()
                                .Replace(".", ""));

                        cmd.Parameters.AddWithValue(
                            "@qty",
                            row.Cells["qty"].Value);

                        cmd.Parameters.AddWithValue(
                            "@subtotal",
                            row.Cells["subtotal"].Value
                                .ToString()
                                .Replace(".", ""));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Data berhasil dikirim ke kasir");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
