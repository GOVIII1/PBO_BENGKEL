using PBO_BENGKEL.model;
using PBO_BENGKEL.service;
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
    public partial class LihatPesanan : Form
    {
        private AdminPesanan_service controller = new AdminPesanan_service();

        public LihatPesanan()
        {
            InitializeComponent();
        }

        private void LihatPesanan_Load(object sender, EventArgs e)
        {
            // tampilkan data dari DB ke DataGridView
            dgvPesanan.DataSource = controller.TampilkanSemua();
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LihatPesanan_Load_1(object sender, EventArgs e)
        {

        }
    }
}

