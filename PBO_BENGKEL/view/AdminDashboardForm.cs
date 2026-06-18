using MySql.Data.MySqlClient;
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
    public partial class AdminDashboardForm : Form
    {
        private AdminDashboard_service srvDashboard;
        public AdminDashboardForm()
        {
            InitializeComponent();
            srvDashboard = new AdminDashboard_service();
        }


        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Isi DataGridView Pesanan
            dgvPesanan.DataSource = srvDashboard.TampilkanPesanan();

            // Isi DataGridView Sparepart
            dgvsparepart.DataSource = srvDashboard.TampilkanSparepart();

            // Isi DataGridView User
            dgvuser.DataSource = srvDashboard.TampilkanUser();

            // Isi total pesanan ke TextBox/Label
            totalpesanan_txbox.Text = srvDashboard.HitungTotalPesanan().ToString();

            MessageBox.Show("Total pesanan: " + srvDashboard.HitungTotalPesanan());

            dgvPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsparepart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminJasaForm formJasa = new AdminJasaForm();
            formJasa.StartPosition = FormStartPosition.Manual;
            formJasa.Location = new Point(this.Location.X + 200, this.Location.Y + 50);
            formJasa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSparepartForm formPart = new AdminSparepartForm();
            formPart.StartPosition = FormStartPosition.Manual;
            formPart.Location = new Point(this.Location.X + 200, this.Location.Y + 50);
            formPart.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            // Munculkan kembali form login
            LoginForm formLogin = new LoginForm();
            formLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LihatPesanan pesanan = new LihatPesanan();
            pesanan.StartPosition = FormStartPosition.Manual;
            pesanan.Location = new Point(this.Location.X + 200, this.Location.Y + 50);
            pesanan.Show();
        }
        private void totalpesanan_txbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvsparepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
