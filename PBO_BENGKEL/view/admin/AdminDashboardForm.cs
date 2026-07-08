using PBO_BENGKEL.service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.admin
{
    public partial class AdminDashboardForm : Form
    {
        private AdminDashboard_service srv;
        private Form currentChildForm = null;

        public AdminDashboardForm()
        {
            InitializeComponent();
            srv = new AdminDashboard_service();
            this.Load += AdminDashboardForm_Load;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            TampilkanDashboard();
        }

        private void TampilkanDashboard()
        {
            panelContent.Controls.Clear();
            panelContent.Controls.Add(panelDashboard);
            panelDashboard.Dock = DockStyle.Fill;
            panelDashboard.BringToFront();
            MuatDashboard();
        }

        private void MuatDashboard()
        {
            txtTotalKasir.Text = srv.HitungTotalKasir().ToString();
            txtTotalMekanik.Text = srv.HitungTotalMekanik().ToString();
            txtPendapatanHariIni.Text = "Rp " + srv.HitungTotalPendapatanHariIni().ToString("N0");
            txtTotalPendapatan.Text = "Rp " + srv.HitungTotalPendapatan().ToString("N0");
            txtTotalJasa.Text = srv.HitungTotalJenisJasa().ToString();
            txtTotalSparepart.Text = srv.HitungTotalJenisSparepart().ToString();
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
            childForm.FormClosed += (s, args) => TampilkanDashboard();
            panelContent.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e) { TampilkanDashboard(); }
        private void btnSparepart_Click(object sender, EventArgs e) { BukaChildForm(new AdminSparepartForm()); }
        private void btnJasa_Click(object sender, EventArgs e) { BukaChildForm(new AdminJasaForm()); }
        private void btnPesanan_Click(object sender, EventArgs e) { BukaChildForm(new LihatPesanan()); }
        private void btnKaryawan_Click(object sender, EventArgs e) { BukaChildForm(new KelolaKaryawanForm()); }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Session.Clear();
                this.Hide();
                new PBO_BENGKEL.view.LoginForm().Show();
            }
        }

        private void txtTotalKasir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
