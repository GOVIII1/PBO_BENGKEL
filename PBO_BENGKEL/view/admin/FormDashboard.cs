using MySql.Data.MySqlClient;
using PBO_BENGKEL.service;
using PBO_BENGKEL.view.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_BENGKEL.view.admin
{
    public partial class FormDashboard : Form
    {
        private AdminDashboard_service srvDashboard;
        public FormDashboard() 
        {
            InitializeComponent();
            srvDashboard = new AdminDashboard_service();
            this.Load += new System.EventHandler(this.FormDashboard_Load);

        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPesanan.DataSource = srvDashboard.TampilkanPesanan();
                dgvsparepart.DataSource = srvDashboard.TampilkanSparepart();
             
                dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvsparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPesanan.RowHeadersVisible = false;
                dgvsparepart.RowHeadersVisible = false;

                dgvPesanan.AutoGenerateColumns = true;
                dgvsparepart.AutoGenerateColumns = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsparepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
