using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PBO_BENGKEL.konfigurasi;

namespace PBO_BENGKEL.view
{
    public partial class FormMekanik : Form
    {
        public FormMekanik()
        {
            InitializeComponent();
        }

        private void FormMekanik_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            try
            {
                using (MySqlConnection conn = Koneksi.GetConn())
                {
                    conn.Open();

                    string query = @"
                    SELECT
                        id_servis,
                        plat_nomor,
                        keluhan
                    FROM tabel_pesanan";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    antrianbengkel_dgv.AutoGenerateColumns = false;

                    antrianbengkel_dgv.DataSource = dt;

                    //sembunyikan id_servis
                    antrianbengkel_dgv.Columns["id_servis"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void antrianbengkel_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                antrianbengkel_dgv.Columns[e.ColumnIndex].Name == "Aksi")
            {
                string idServis =
                    antrianbengkel_dgv.Rows[e.RowIndex]
                    .Cells["id_servis"]
                    .Value.ToString();

                string platMotor =
                    antrianbengkel_dgv.Rows[e.RowIndex]
                    .Cells["PlatMotor"]
                    .Value.ToString();

                string keluhan =
                    antrianbengkel_dgv.Rows[e.RowIndex]
                    .Cells["Keluhan"]
                    .Value.ToString();

                FormTindakanMekanik frm =
                    new FormTindakanMekanik(
                        idServis,
                        platMotor,
                        keluhan);

                frm.ShowDialog();
            }
        }
    }
}
