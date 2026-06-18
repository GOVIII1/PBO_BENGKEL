using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;
using PBO_BENGKEL.model;
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
    public partial class FormTindakanMekanik : Form
    {
        private string idServis;
        private string platMotor;
        private string keluhan;
        public FormTindakanMekanik(string idServis, string platMotor, string keluhan)
        {
            InitializeComponent();

            this.idServis = idServis;
            this.platMotor = platMotor;
            this.keluhan = keluhan;
        }

        private void FormTindakanMekanik_Load(object sender, EventArgs e)
        {
            lblMekanik.Text = "Mekanik Bertugas : Figo";

            lblMotor.Text =
                "Motor Dikerjakan : " + platMotor;

            lblKeluhan.Text =
                "Keluhan : " + keluhan;

            lblIdServis.Text =
                "ID Servis : " + idServis;

            LoadJasa();
        }

        private void LoadJasa()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query =
                    "SELECT id_jasa,nama_jasa FROM tabel_jasa";

                    MySqlDataAdapter da =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    pilihmenu_cmb.DataSource = dt;
                    pilihmenu_cmb.DisplayMember = "nama_jasa";
                    pilihmenu_cmb.ValueMember = "id_jasa";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
