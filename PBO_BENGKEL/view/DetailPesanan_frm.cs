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
    public partial class DetailPesanan_frm : Form
    {
        private string idServis;
        public DetailPesanan_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public DetailPesanan_frm(string idPelanggan, string namaPelanggan, string keluhan)
        {
            InitializeComponent();
            id_txt.Text = idPelanggan;
            namapelanggan_txt.Text = namaPelanggan;
            keluhan_txt.Text = keluhan;

            LoadJasa();
            LoadSparepart();
            LoadStatus();
        }

        private void LoadJasa()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query =
                        "SELECT id_jasa, nama_jasa FROM tabel_jasa";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    jasa_cmb.DataSource = dt;
                    jasa_cmb.DisplayMember = "nama_jasa";
                    jasa_cmb.ValueMember = "id_jasa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load Jasa : " + ex.Message);
            }
        }

        private void LoadSparepart()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query =
                        "SELECT id_sparepart, nama_sparepart FROM tabel_sparepart";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    sparepart_cmb.DataSource = dt;
                    sparepart_cmb.DisplayMember = "nama_sparepart";
                    sparepart_cmb.ValueMember = "id_sparepart";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Load Sparepart : " + ex.Message);
            }
        }

        private void LoadStatus()
        {
            status_cmb.Items.Clear();

            status_cmb.Items.Add("Selesai");

            status_cmb.SelectedIndex = 0;
        }

        private void selesai_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query = @"
            INSERT INTO tabel_servis_selesai
            (
                id_pelanggan,
                nama_pelanggan,
                keluhan,
                id_jasa,
                id_sparepart,
                status
            )
            VALUES
            (
                @id,
                @nama,
                @keluhan,
                @jasa,
                @sparepart,
                @status
            )";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", id_txt.Text);
                    cmd.Parameters.AddWithValue("@nama", namapelanggan_txt.Text);
                    cmd.Parameters.AddWithValue("@keluhan", keluhan_txt.Text);
                    cmd.Parameters.AddWithValue("@jasa", jasa_cmb.SelectedValue);
                    cmd.Parameters.AddWithValue("@sparepart", sparepart_cmb.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", status_cmb.Text);

                    cmd.ExecuteNonQuery();

                    string deletePesanan =
                        "DELETE FROM tabel_pesanan WHERE nama_pelanggan=@nama";

                    MySqlCommand cmdPesanan =
                        new MySqlCommand(deletePesanan, conn);

                    cmdPesanan.Parameters.AddWithValue(
                        "@nama",
                        namapelanggan_txt.Text);

                    cmdPesanan.ExecuteNonQuery();

                    string deletePelanggan =
                        "DELETE FROM tabel_pelanggan WHERE id_pelanggan=@id";

                    MySqlCommand cmdPelanggan =
                        new MySqlCommand(deletePelanggan, conn);

                    cmdPelanggan.Parameters.AddWithValue(
                        "@id",
                        id_txt.Text);

                    cmdPelanggan.ExecuteNonQuery();

                    MessageBox.Show("Pesanan berhasil diselesaikan");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    //ex.Message
                    ex.ToString(),
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tutup_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
