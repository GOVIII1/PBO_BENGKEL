namespace PBO_BENGKEL.view.mekanik
{
    partial class FormMekanik
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblJudulDashboard = new System.Windows.Forms.Label();
            this.dgvAntrian = new System.Windows.Forms.DataGridView();
            this.btnKerjakan = new System.Windows.Forms.Button();
            this.colIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSelesai = new System.Windows.Forms.Panel();
            this.lblJudulSelesai = new System.Windows.Forms.Label();
            this.dgvSelesai = new System.Windows.Forms.DataGridView();
            this.colSelesaiIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProfil = new System.Windows.Forms.Panel();
            this.lblJudulProfil = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnGantiFoto = new System.Windows.Forms.Button();
            this.lblNamaMekanik = new System.Windows.Forms.Label();
            this.lblRoleMekanik = new System.Windows.Forms.Label();
            this.lblUsernameMekanik = new System.Windows.Forms.Label();

            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelSelesai.SuspendLayout();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Dashboard Mekanik";

            // Sidebar
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Size = new System.Drawing.Size(200, 600);

            this.lblTitle.Text = "MEKANIK";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(160, 40);

            this.btnDashboard.Text = "   Dashboard"; this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnDashboard.ForeColor = System.Drawing.Color.White; this.btnDashboard.Location = new System.Drawing.Point(10, 80); this.btnDashboard.Size = new System.Drawing.Size(180, 40); this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelesai.Text = "   Selesai"; this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSelesai.ForeColor = System.Drawing.Color.White; this.btnSelesai.Location = new System.Drawing.Point(10, 130); this.btnSelesai.Size = new System.Drawing.Size(180, 40); this.btnSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfil.Text = "   Profil"; this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnProfil.ForeColor = System.Drawing.Color.White; this.btnProfil.Location = new System.Drawing.Point(10, 180); this.btnProfil.Size = new System.Drawing.Size(180, 40); this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Text = "   Logout"; this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLogout.ForeColor = System.Drawing.Color.White; this.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 50, 50); this.btnLogout.Location = new System.Drawing.Point(10, 500); this.btnLogout.Size = new System.Drawing.Size(180, 40); this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelSidebar.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.btnDashboard, this.btnSelesai, this.btnProfil, this.btnLogout });

            // Content
            this.panelContent.Location = new System.Drawing.Point(200, 0); this.panelContent.Size = new System.Drawing.Size(800, 600);

            // Dashboard page
            this.panelDashboard.Location = new System.Drawing.Point(0, 0); this.panelDashboard.Size = new System.Drawing.Size(800, 600);
            this.lblJudulDashboard.Text = "PESANAN MASUK"; this.lblJudulDashboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblJudulDashboard.Location = new System.Drawing.Point(20, 20); this.lblJudulDashboard.Size = new System.Drawing.Size(300, 30);

            this.dgvAntrian.AllowUserToAddRows = false; this.dgvAntrian.AllowUserToDeleteRows = false; this.dgvAntrian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvAntrian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAntrian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colIdServis, this.colNama, this.colPlat, this.colKeluhan });
            this.dgvAntrian.Location = new System.Drawing.Point(20, 60); this.dgvAntrian.Name = "dgvAntrian"; this.dgvAntrian.ReadOnly = true; this.dgvAntrian.RowHeadersVisible = false; this.dgvAntrian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvAntrian.Size = new System.Drawing.Size(760, 400);

            this.colIdServis.DataPropertyName = "id_servis"; this.colIdServis.HeaderText = "ID Servis"; this.colIdServis.Name = "id_servis";
            this.colNama.DataPropertyName = "nama_pelanggan"; this.colNama.HeaderText = "Nama"; this.colNama.Name = "nama";
            this.colPlat.DataPropertyName = "plat_nomor"; this.colPlat.HeaderText = "Plat"; this.colPlat.Name = "plat_nomor";
            this.colKeluhan.DataPropertyName = "keluhan"; this.colKeluhan.HeaderText = "Keluhan"; this.colKeluhan.Name = "keluhan";

            this.btnKerjakan.Text = "Kerjakan"; this.btnKerjakan.BackColor = System.Drawing.Color.DodgerBlue; this.btnKerjakan.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnKerjakan.ForeColor = System.Drawing.Color.White; this.btnKerjakan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.btnKerjakan.Location = new System.Drawing.Point(20, 480); this.btnKerjakan.Size = new System.Drawing.Size(200, 45);

            this.panelDashboard.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblJudulDashboard, this.dgvAntrian, this.btnKerjakan });

            // Selesai page
            this.panelSelesai.Location = new System.Drawing.Point(0, 0); this.panelSelesai.Size = new System.Drawing.Size(800, 600); this.panelSelesai.Visible = false;
            this.lblJudulSelesai.Text = "PESANAN SELESAI"; this.lblJudulSelesai.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblJudulSelesai.Location = new System.Drawing.Point(20, 20); this.lblJudulSelesai.Size = new System.Drawing.Size(300, 30);
            this.dgvSelesai.AllowUserToAddRows = false; this.dgvSelesai.AllowUserToDeleteRows = false; this.dgvSelesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill; this.dgvSelesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelesai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colSelesaiIdServis, this.colSelesaiNama, this.colSelesaiPlat, this.colSelesaiKeluhan });
            this.dgvSelesai.Location = new System.Drawing.Point(20, 60); this.dgvSelesai.Name = "dgvSelesai"; this.dgvSelesai.ReadOnly = true; this.dgvSelesai.RowHeadersVisible = false; this.dgvSelesai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect; this.dgvSelesai.Size = new System.Drawing.Size(760, 400);
            this.colSelesaiIdServis.DataPropertyName = "id_servis"; this.colSelesaiIdServis.HeaderText = "ID Servis"; this.colSelesaiIdServis.Name = "colSelesaiIdServis";
            this.colSelesaiNama.DataPropertyName = "nama_pelanggan"; this.colSelesaiNama.HeaderText = "Nama"; this.colSelesaiNama.Name = "colSelesaiNama";
            this.colSelesaiPlat.DataPropertyName = "plat_nomor"; this.colSelesaiPlat.HeaderText = "Plat"; this.colSelesaiPlat.Name = "colSelesaiPlat";
            this.colSelesaiKeluhan.DataPropertyName = "keluhan"; this.colSelesaiKeluhan.HeaderText = "Keluhan"; this.colSelesaiKeluhan.Name = "colSelesaiKeluhan";
            this.panelSelesai.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblJudulSelesai, this.dgvSelesai });

            // Profil page
            this.panelProfil.Location = new System.Drawing.Point(0, 0); this.panelProfil.Size = new System.Drawing.Size(800, 600); this.panelProfil.Visible = false;
            this.lblJudulProfil.Text = "PROFIL"; this.lblJudulProfil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblJudulProfil.Location = new System.Drawing.Point(20, 20); this.lblJudulProfil.Size = new System.Drawing.Size(300, 30);
            this.pictureBox.Location = new System.Drawing.Point(40, 80); this.pictureBox.Size = new System.Drawing.Size(150, 150); this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGantiFoto.Text = "Ganti Foto"; this.btnGantiFoto.Location = new System.Drawing.Point(40, 240);
            this.lblNamaMekanik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); this.lblNamaMekanik.Location = new System.Drawing.Point(220, 80); this.lblNamaMekanik.Size = new System.Drawing.Size(300, 30);
            this.lblRoleMekanik.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblRoleMekanik.Location = new System.Drawing.Point(220, 120); this.lblRoleMekanik.Size = new System.Drawing.Size(300, 30);
            this.lblUsernameMekanik.Font = new System.Drawing.Font("Segoe UI", 10F); this.lblUsernameMekanik.Location = new System.Drawing.Point(220, 160); this.lblUsernameMekanik.Size = new System.Drawing.Size(300, 30);
            this.panelProfil.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblJudulProfil, this.pictureBox, this.btnGantiFoto, this.lblNamaMekanik, this.lblRoleMekanik, this.lblUsernameMekanik });

            this.panelContent.Controls.AddRange(new System.Windows.Forms.Control[] { this.panelDashboard, this.panelSelesai, this.panelProfil });
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.panelSidebar, this.panelContent });

            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelSelesai.ResumeLayout(false);
            this.panelProfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAntrian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblJudulDashboard;
        private System.Windows.Forms.DataGridView dgvAntrian;
        private System.Windows.Forms.Button btnKerjakan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeluhan;
        private System.Windows.Forms.Panel panelSelesai;
        private System.Windows.Forms.Label lblJudulSelesai;
        private System.Windows.Forms.DataGridView dgvSelesai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiKeluhan;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label lblJudulProfil;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnGantiFoto;
        private System.Windows.Forms.Label lblNamaMekanik;
        private System.Windows.Forms.Label lblRoleMekanik;
        private System.Windows.Forms.Label lblUsernameMekanik;
    }
}
