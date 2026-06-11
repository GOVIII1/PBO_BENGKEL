using System;
using System.Windows.Forms;
using PBO_BENGKEL.model;
using PBO_BENGKEL.service;

namespace PBO_BENGKEL.view
{
    public partial class AdminJasaForm : Form
    {
        // Panggil otak service lu
        AdminJasa_service srv = new AdminJasa_service();

        public AdminJasaForm()
        {
            InitializeComponent();
            MuatData(); // Biar tabel langsung keisi
        }

        private void MuatData()
        {
            dgvJasa.DataSource = srv.TampilkanSemua();
            dgvJasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvJasa.AllowUserToAddRows = false;
            dgvJasa.ReadOnly = true;
            dgvJasa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // # --- TAMBAHAN AUTO ID ---
            txtIdJasa.Text = srv.KodeOtomatis(); // # Narik ID otomatis ke kotak
            txtIdJasa.Enabled = false; // # Kotaknya dikunci biar user ga bisa ngedit
        }

        private void btnSimpanJasa_Click(object sender, EventArgs e)
        {
            try
            {
                Jasa_cls js = new Jasa_cls();
                js.id_jasa = txtIdJasa.Text; // # Otomatis ngambil dari kotak yang dikunci
                js.nama_jasa = txtNamaJasa.Text;
                js.harga_jasa = Convert.ToInt32(txtTarif.Text);

                if (srv.TambahJasa(js))
                {
                    MessageBox.Show("Tarif Jasa sukses diamankan wir!", "Sukses");
                    MuatData(); // Refresh tabel

                    // # Bersihin text box aja (ID ga usah di-clear)
                    txtNamaJasa.Clear();
                    txtTarif.Clear();

                    // # PANGGIL ID BARU BUAT JASA SELANJUTNYA
                    txtIdJasa.Text = srv.KodeOtomatis();
                }
                else
                {
                    MessageBox.Show("Gagal nyimpen data, pastikan ID gak dobel ngab!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tarif harga wajib diisi pake angka ngab!", "Peringatan");
            }
        }

        // ==========================================
        // OBAT PENANGKAL ERROR GA SENGAJA KE-KLIK
        // ==========================================
        private void txtTarif_TextChanged(object sender, EventArgs e)
        {
            // Biarin kosong aja wir
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Biarin kosong juga
        }

        private void dgvJasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = dgvJasa.Rows[e.RowIndex];

                txtIdJasa.Text = baris.Cells["ID Jasa"].Value.ToString();
                txtNamaJasa.Text = baris.Cells["Nama Paketan/Servis"].Value.ToString();
                txtTarif.Text = baris.Cells["Tarif Harga"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}