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
            formJasa.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminSparepartForm formPart = new AdminSparepartForm();
            formPart.ShowDialog();
        }
    }
}
