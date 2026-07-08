using PBO_BENGKEL.service;
using System;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.kasir
{
    public partial class DashboardKasir : Form
    {
        private PesananService pesananService = new PesananService();
        private Form currentChildForm = null;

        public DashboardKasir()
        {
            InitializeComponent();
            this.Load += DashboardKasir_Load;
            btnDashboard.Click += (s, e) => TampilkanDashboard();
            btnRiwayat.Click += (s, e) => BukaChildForm(new FormRiwayat());
            btnProfil.Click += (s, e) => BukaChildForm(new FormProfilKasir());
            btnLogout.Click += BtnLogout_Click;
            btnBayar.Click += BtnBayar_Click;
            btnTambahPesanan.Click += (s, e) => { new FormTambahPesanan().ShowDialog(); MuatSelesai(); };
            btnCetak.Click += BtnCetakSelesai_Click;
        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
            TampilkanDashboard();
        }

        private void TampilkanDashboard()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(panelDashboard);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.BringToFront();
            MuatSelesai();
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

        private void MuatSelesai()
        {
            dgvSelesai.AutoGenerateColumns = false;
            dgvSelesai.DataSource = pesananService.TampilkanSelesai();
        }

        private void BtnBayar_Click(object sender, EventArgs e)
        {
            if (dgvSelesai.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Pilih pesanan yang ingin dibayar!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idServis = dgvSelesai.SelectedRows[0].Cells["id_servis"].Value.ToString();
            using (bayar formBayar = new bayar(idServis))
            {
                formBayar.ShowDialog(this);
            }
            MuatSelesai();
        }

        private void BtnCetakSelesai_Click(object sender, EventArgs e)
        {
            if (dgvSelesai.SelectedRows.Count == 0)
            {
                MessageBox.Show(this, "Pilih pesanan yang ingin dicetak!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string idServis = dgvSelesai.SelectedRows[0].Cells["id_servis"].Value.ToString();
            using (Struk formStruk = new Struk(idServis)) { formStruk.ShowDialog(this); }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
