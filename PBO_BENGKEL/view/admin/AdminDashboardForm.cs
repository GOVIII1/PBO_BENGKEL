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
        public AdminDashboardForm()
        {
            InitializeComponent();
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
            formPart.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            // Munculkan kembali form login
            LoginForm formLogin = new LoginForm();
            formLogin.Show();
        }
    }
}
