using PBO_BENGKEL.service;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.admin
{
    public partial class LihatPesanan : Form
    {
        private AdminPesanan_service srv = new AdminPesanan_service();

        public LihatPesanan()
        {
            InitializeComponent();
            MuatData();
        }

        private void MuatData()
        {
            dgvPesanan.DataSource = srv.TampilkanSemua();
            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPesanan.AllowUserToAddRows = false;
            dgvPesanan.ReadOnly = true;
            dgvPesanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void LihatPesanan_Load_1(object sender, System.EventArgs e) { }
    }
}
