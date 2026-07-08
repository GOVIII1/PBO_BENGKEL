using PBO_BENGKEL.konfigurasi;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.mekanik
{
    public partial class FormMekanik : Form
    {
        private Form currentChildForm = null;

        public FormMekanik()
        {
            InitializeComponent();
            this.Load += FormMekanik_Load;
            btnDashboard.Click += (s, e) => TampilkanDashboard();
            btnSelesai.Click += (s, e) => BukaChildForm(new FormSelesai());
            btnProfil.Click += (s, e) => BukaChildForm(new FormProfil());
            btnLogout.Click += BtnLogout_Click;
            btnKerjakan.Click += BtnKerjakan_Click;
        }

        private void FormMekanik_Load(object sender, EventArgs e)
        {
            TampilkanDashboard();
        }

        private void TampilkanDashboard()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(panelDashboard);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.BringToFront();
            TampilAntrian();
        }

        private void BukaChildForm(Form childForm)
        {
            panelContent.Controls.Clear();
            if (currentChildForm != null)
                currentChildForm.Dispose();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void TampilAntrian()
        {
            try
            {
                using (var conn = Koneksi.GetConn())
                {
                    conn.Open();
                    string query = "SELECT id_servis, nama_pelanggan, plat_nomor, keluhan FROM pesanan WHERE status = 'Dikirim' ORDER BY id_servis";
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(new MySqlCommand(query, conn)).Fill(dt);
                    dgvAntrian.AutoGenerateColumns = false;
                    dgvAntrian.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal: " + ex.Message);
            }
        }

        private void BtnKerjakan_Click(object sender, EventArgs e)
        {
            if (dgvAntrian.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih antrian motor!", "Peringatan");
                return;
            }
            DataGridViewRow row = dgvAntrian.SelectedRows[0];
            string idServis = row.Cells["id_servis"].Value?.ToString() ?? "";
            string platMotor = row.Cells["plat_nomor"].Value?.ToString() ?? "";
            string keluhan = row.Cells["keluhan"].Value?.ToString() ?? "";

            FormTindakanMekanik form = new FormTindakanMekanik(idServis, platMotor, keluhan);
            if (form.ShowDialog() == DialogResult.OK)
            {
                TampilAntrian();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new PBO_BENGKEL.view.LoginForm().Show();
            }
        }
    }
}
