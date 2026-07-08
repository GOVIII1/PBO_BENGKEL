using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.mekanik
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
            lblMekanik.Text = "Mekanik Bertugas : " + (Session.NamaLengkap ?? Session.Username);
            lblMotor.Text = "Motor Dikerjakan : " + platMotor;
            lblKeluhan.Text = "Keluhan : " + keluhan;
            lblIdServis.Text = "ID Servis : " + idServis;

            LoadJasa();
            LoadSparepart();
            SetupGrid();

            // Update status jadi Dikerjakan
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string q = "UPDATE pesanan SET status = 'Dikerjakan', dikerjakan_oleh = @u WHERE id_servis = @id";
                    using (var cmd = new MySqlCommand(q, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", Session.Username);
                        cmd.Parameters.AddWithValue("@id", idServis);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }

        private void LoadJasa()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_jasa, nama_jasa, harga_jasa FROM jasa";
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);

                    DataRow kosong = dt.NewRow();
                    kosong["id_jasa"] = ""; kosong["nama_jasa"] = "- Pilih Jasa -"; kosong["harga_jasa"] = 0;
                    dt.Rows.InsertAt(kosong, 0);

                    pilihmenu_cmb.DataSource = dt;
                    pilihmenu_cmb.DisplayMember = "nama_jasa";
                    pilihmenu_cmb.ValueMember = "id_jasa";
                    pilihmenu_cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat jasa: " + ex.Message);
            }
        }

        private void LoadSparepart()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_sparepart, nama_sparepart, harga_part FROM sparepart";
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);

                    DataRow kosong = dt.NewRow();
                    kosong["id_sparepart"] = ""; kosong["nama_sparepart"] = "- Pilih Sparepart -"; kosong["harga_part"] = 0;
                    dt.Rows.InsertAt(kosong, 0);

                    sparepart_cmb.DataSource = dt;
                    sparepart_cmb.DisplayMember = "nama_sparepart";
                    sparepart_cmb.ValueMember = "id_sparepart";
                    sparepart_cmb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat sparepart: " + ex.Message);
            }
        }

        private void SetupGrid()
        {
            daftarselesai_dgv.Columns.Clear();
            daftarselesai_dgv.Columns.Add("id_item", "ID Item");
            daftarselesai_dgv.Columns.Add("jenis", "Jenis");
            daftarselesai_dgv.Columns.Add("nama", "Nama");
            daftarselesai_dgv.Columns.Add("harga", "Harga");
            daftarselesai_dgv.Columns.Add("qty", "Qty");
            daftarselesai_dgv.Columns.Add("subtotal", "Subtotal");
            daftarselesai_dgv.Columns[0].Visible = false;
            daftarselesai_dgv.AllowUserToAddRows = false;
            daftarselesai_dgv.RowHeadersVisible = false;
        }

        private void masukkan_btn_Click(object sender, EventArgs e)
        {
            bool pilihJasa = pilihmenu_cmb.SelectedIndex > 0;
            bool pilihSparepart = sparepart_cmb.SelectedIndex > 0;

            if (!pilihJasa && !pilihSparepart)
            {
                MessageBox.Show("Pilih Jasa atau Sparepart!", "Peringatan");
                return;
            }

            int qty;
            if (!int.TryParse(jumlah_cmb.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Jumlah harus angka positif!", "Peringatan");
                return;
            }

            string idItem, namaItem, jenis;
            int harga;

            if (pilihJasa)
            {
                DataRowView drv = (DataRowView)pilihmenu_cmb.SelectedItem;
                idItem = drv["id_jasa"].ToString();
                namaItem = drv["nama_jasa"].ToString();
                harga = Convert.ToInt32(drv["harga_jasa"]);
                jenis = "Jasa";
            }
            else
            {
                DataRowView drv = (DataRowView)sparepart_cmb.SelectedItem;
                idItem = drv["id_sparepart"].ToString();
                namaItem = drv["nama_sparepart"].ToString();
                harga = Convert.ToInt32(drv["harga_part"]);
                jenis = "Sparepart";
            }

            int subtotal = harga * qty;

            daftarselesai_dgv.Rows.Add(idItem, jenis, namaItem, harga.ToString("N0"), qty, subtotal.ToString("N0"));

            pilihmenu_cmb.SelectedIndex = 0;
            sparepart_cmb.SelectedIndex = 0;
            jumlah_cmb.SelectedIndex = -1;
            jumlah_cmb.Text = "";
            HitungTotal();
        }

        private void HitungTotal()
        {
            int total = 0;
            foreach (DataGridViewRow row in daftarselesai_dgv.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    string s = row.Cells["subtotal"].Value.ToString().Replace(".", "").Replace(",", "");
                    if (int.TryParse(s, out int sub)) total += sub;
                }
            }
            lblTotal.Text = "TOTAL : Rp " + total.ToString("N0");
        }

        private void pekerjaanselesai_btn_Click(object sender, EventArgs e)
        {
            if (daftarselesai_dgv.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada tindakan!", "Peringatan");
                return;
            }

            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    using (var tx = conn.BeginTransaction())
                    {
                        foreach (DataGridViewRow row in daftarselesai_dgv.Rows)
                        {
                            string query = @"INSERT INTO detail_servis (id_servis, jenis, id_item, nama_item, harga, qty, subtotal)
                                             VALUES (@id_servis, @jenis, @id_item, @nama_item, @harga, @qty, @subtotal)";
                            using (var cmd = new MySqlCommand(query, conn, tx))
                            {
                                string h = row.Cells["harga"].Value?.ToString().Replace(".", "").Replace(",", "") ?? "0";
                                string s = row.Cells["subtotal"].Value?.ToString().Replace(".", "").Replace(",", "") ?? "0";

                                cmd.Parameters.AddWithValue("@id_servis", idServis);
                                cmd.Parameters.AddWithValue("@jenis", row.Cells["jenis"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@id_item", row.Cells["id_item"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@nama_item", row.Cells["nama"].Value?.ToString() ?? "");
                                cmd.Parameters.AddWithValue("@harga", h);
                                cmd.Parameters.AddWithValue("@qty", row.Cells["qty"].Value?.ToString() ?? "1");
                                cmd.Parameters.AddWithValue("@subtotal", s);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        // Update status ke Selesai
                        using (var cmd = new MySqlCommand("UPDATE pesanan SET status = 'Selesai' WHERE id_servis = @id", conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@id", idServis);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                    }
                }

                MessageBox.Show("Data berhasil dikirim ke kasir!", "Sukses");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal simpan: " + ex.Message, "Error");
            }
        }
    }
}
