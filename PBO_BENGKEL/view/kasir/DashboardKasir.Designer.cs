namespace PBO_BENGKEL.view.kasir
{
    partial class DashboardKasir
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            // === DASHBOARD PAGE ===
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.lblJudulDashboard = new System.Windows.Forms.Label();
            this.dgvSelesai = new System.Windows.Forms.DataGridView();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnTambahPesanan = new System.Windows.Forms.Button();
            this.btnCetak = new System.Windows.Forms.Button();
            this.colIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // === RIWAYAT PAGE ===
            this.panelRiwayat = new System.Windows.Forms.Panel();
            this.lblJudulRiwayat = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.btnCetakRiwayat = new System.Windows.Forms.Button(); // ditambahkan
            this.colRiwayatIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatNoHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // === PROFIL PAGE ===
            this.panelProfil = new System.Windows.Forms.Panel();
            this.lblJudulProfil = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnGantiFoto = new System.Windows.Forms.Button();
            this.lblNamaKasir = new System.Windows.Forms.Label();
            this.lblRoleKasir = new System.Windows.Forms.Label();
            this.lblUsernameKasir = new System.Windows.Forms.Label();

            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.panelRiwayat.SuspendLayout();
            this.panelProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Text = "Dashboard Kasir - Dealer Yaamba";

            // panelSidebar
            this.panelSidebar.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Size = new System.Drawing.Size(200, 600);

            this.lblTitle.Text = "KASIR";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(160, 40);

            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Location = new System.Drawing.Point(10, 80);
            this.btnDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnRiwayat.Text = "   Riwayat";
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.BackColor = System.Drawing.Color.Transparent;
            this.btnRiwayat.Location = new System.Drawing.Point(10, 130);
            this.btnRiwayat.Size = new System.Drawing.Size(180, 40);
            this.btnRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnProfil.Text = "   Profil";
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfil.ForeColor = System.Drawing.Color.White;
            this.btnProfil.BackColor = System.Drawing.Color.Transparent;
            this.btnProfil.Location = new System.Drawing.Point(10, 180);
            this.btnProfil.Size = new System.Drawing.Size(180, 40);
            this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnLogout.Text = "   Logout";
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnLogout.Location = new System.Drawing.Point(10, 500);
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelSidebar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTitle, this.btnDashboard, this.btnRiwayat, this.btnProfil, this.btnLogout
            });

            // panelContent
            this.panelContent.Location = new System.Drawing.Point(200, 0);
            this.panelContent.Size = new System.Drawing.Size(800, 600);

            // === DASHBOARD PAGE ===
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Size = new System.Drawing.Size(800, 600);

            this.lblJudulDashboard.Text = "PESANAN SELESAI";
            this.lblJudulDashboard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulDashboard.Location = new System.Drawing.Point(20, 20);
            this.lblJudulDashboard.Size = new System.Drawing.Size(300, 30);

            this.dgvSelesai.AllowUserToAddRows = false;
            this.dgvSelesai.AllowUserToDeleteRows = false;
            this.dgvSelesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelesai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colIdServis, this.colNama, this.colNoHp, this.colPlat, this.colKeluhan, this.colStatus
            });
            this.dgvSelesai.Location = new System.Drawing.Point(20, 60);
            this.dgvSelesai.Name = "dgvSelesai";
            this.dgvSelesai.ReadOnly = true;
            this.dgvSelesai.RowHeadersVisible = false;
            this.dgvSelesai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelesai.Size = new System.Drawing.Size(760, 400);
            this.dgvSelesai.TabIndex = 0;

            this.colIdServis.DataPropertyName = "id_servis"; this.colIdServis.HeaderText = "ID Servis"; this.colIdServis.Name = "id_servis";
            this.colNama.DataPropertyName = "nama_pelanggan"; this.colNama.HeaderText = "Nama"; this.colNama.Name = "nama";
            this.colNoHp.DataPropertyName = "no_hp"; this.colNoHp.HeaderText = "No HP"; this.colNoHp.Name = "no_hp";
            this.colPlat.DataPropertyName = "plat_nomor"; this.colPlat.HeaderText = "Plat"; this.colPlat.Name = "plat";
            this.colKeluhan.DataPropertyName = "keluhan"; this.colKeluhan.HeaderText = "Keluhan"; this.colKeluhan.Name = "keluhan";
            this.colStatus.DataPropertyName = "status"; this.colStatus.HeaderText = "Status"; this.colStatus.Name = "colStatus";

            this.btnBayar.Text = "Bayar Pesanan Terpilih";
            this.btnBayar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBayar.Location = new System.Drawing.Point(20, 480);
            this.btnBayar.Size = new System.Drawing.Size(200, 45);

            this.btnTambahPesanan.Text = "Tambah Pesanan";
            this.btnTambahPesanan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambahPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahPesanan.ForeColor = System.Drawing.Color.White;
            this.btnTambahPesanan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTambahPesanan.Location = new System.Drawing.Point(230, 480);
            this.btnTambahPesanan.Size = new System.Drawing.Size(200, 45);

            this.btnCetak.Text = "Cetak Struk";
            this.btnCetak.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetak.ForeColor = System.Drawing.Color.White;
            this.btnCetak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCetak.Location = new System.Drawing.Point(440, 480);
            this.btnCetak.Size = new System.Drawing.Size(200, 45);

            this.panelDashboard.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblJudulDashboard, this.dgvSelesai, this.btnBayar, this.btnTambahPesanan, this.btnCetak
            });

            // === RIWAYAT PAGE ===
            this.panelRiwayat.Location = new System.Drawing.Point(0, 0);
            this.panelRiwayat.Size = new System.Drawing.Size(800, 600);
            this.panelRiwayat.Visible = false;

            this.lblJudulRiwayat.Text = "RIWAYAT PEMBAYARAN";
            this.lblJudulRiwayat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulRiwayat.Location = new System.Drawing.Point(20, 20);
            this.lblJudulRiwayat.Size = new System.Drawing.Size(300, 30);

            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colRiwayatIdServis, this.colRiwayatNama, this.colRiwayatNoHp, this.colRiwayatPlat, this.colRiwayatKeluhan, this.colRiwayatStatus
            });
            this.dgvRiwayat.Location = new System.Drawing.Point(20, 60);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersVisible = false;
            this.dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiwayat.Size = new System.Drawing.Size(760, 400);
            this.dgvRiwayat.TabIndex = 0;

            this.colRiwayatIdServis.DataPropertyName = "id_servis"; this.colRiwayatIdServis.HeaderText = "ID Servis"; this.colRiwayatIdServis.Name = "colRiwayatIdServis";
            this.colRiwayatNama.DataPropertyName = "nama_pelanggan"; this.colRiwayatNama.HeaderText = "Nama"; this.colRiwayatNama.Name = "colRiwayatNama";
            this.colRiwayatNoHp.DataPropertyName = "no_hp"; this.colRiwayatNoHp.HeaderText = "No HP"; this.colRiwayatNoHp.Name = "colRiwayatNoHp";
            this.colRiwayatPlat.DataPropertyName = "plat_nomor"; this.colRiwayatPlat.HeaderText = "Plat"; this.colRiwayatPlat.Name = "colRiwayatPlat";
            this.colRiwayatKeluhan.DataPropertyName = "keluhan"; this.colRiwayatKeluhan.HeaderText = "Keluhan"; this.colRiwayatKeluhan.Name = "colRiwayatKeluhan";
            this.colRiwayatStatus.DataPropertyName = "status"; this.colRiwayatStatus.HeaderText = "Status"; this.colRiwayatStatus.Name = "colRiwayatStatus";

            this.btnCetakRiwayat.Text = "Cetak Struk";
            this.btnCetakRiwayat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCetakRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCetakRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnCetakRiwayat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCetakRiwayat.Location = new System.Drawing.Point(20, 480);
            this.btnCetakRiwayat.Size = new System.Drawing.Size(200, 45);

            this.panelRiwayat.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblJudulRiwayat, this.dgvRiwayat, this.btnCetakRiwayat
            });

            // === PROFIL PAGE ===
            this.panelProfil.Location = new System.Drawing.Point(0, 0);
            this.panelProfil.Size = new System.Drawing.Size(800, 600);
            this.panelProfil.Visible = false;

            this.lblJudulProfil.Text = "PROFIL KASIR";
            this.lblJudulProfil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulProfil.Location = new System.Drawing.Point(20, 20);
            this.lblJudulProfil.Size = new System.Drawing.Size(300, 30);

            this.pictureBox.Location = new System.Drawing.Point(40, 80);
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnGantiFoto.Text = "Ganti Foto";
            this.btnGantiFoto.Location = new System.Drawing.Point(40, 240);

            this.lblNamaKasir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNamaKasir.Location = new System.Drawing.Point(220, 80);
            this.lblNamaKasir.Size = new System.Drawing.Size(300, 30);

            this.lblRoleKasir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoleKasir.Location = new System.Drawing.Point(220, 120);
            this.lblRoleKasir.Size = new System.Drawing.Size(300, 30);

            this.lblUsernameKasir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsernameKasir.Location = new System.Drawing.Point(220, 160);
            this.lblUsernameKasir.Size = new System.Drawing.Size(300, 30);

            this.panelProfil.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblJudulProfil, this.pictureBox, this.btnGantiFoto,
                this.lblNamaKasir, this.lblRoleKasir, this.lblUsernameKasir
            });

            // Add pages to content panel
            this.panelContent.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.panelDashboard, this.panelRiwayat, this.panelProfil
            });

            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.panelSidebar, this.panelContent });

            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelRiwayat.ResumeLayout(false);
            this.panelProfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnTambahPesanan;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnCetakRiwayat;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label lblJudulDashboard;
        private System.Windows.Forms.DataGridView dgvSelesai;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeluhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panelRiwayat;
        private System.Windows.Forms.Label lblJudulRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatNoHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatKeluhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatStatus;
        private System.Windows.Forms.Panel panelProfil;
        private System.Windows.Forms.Label lblJudulProfil;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnGantiFoto;
        private System.Windows.Forms.Label lblNamaKasir;
        private System.Windows.Forms.Label lblRoleKasir;
        private System.Windows.Forms.Label lblUsernameKasir;
    }
}
