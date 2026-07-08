namespace PBO_BENGKEL.view.admin
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.labelMenuTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSparepart = new System.Windows.Forms.Button();
            this.btnJasa = new System.Windows.Forms.Button();
            this.btnPesanan = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.cardTotalKasir = new System.Windows.Forms.GroupBox();
            this.txtTotalKasir = new System.Windows.Forms.TextBox();
            this.cardTotalMekanik = new System.Windows.Forms.GroupBox();
            this.txtTotalMekanik = new System.Windows.Forms.TextBox();
            this.cardPendapatanHariIni = new System.Windows.Forms.GroupBox();
            this.txtPendapatanHariIni = new System.Windows.Forms.TextBox();
            this.cardTotalPendapatan = new System.Windows.Forms.GroupBox();
            this.txtTotalPendapatan = new System.Windows.Forms.TextBox();
            this.cardTotalJasa = new System.Windows.Forms.GroupBox();
            this.txtTotalJasa = new System.Windows.Forms.TextBox();
            this.cardTotalSparepart = new System.Windows.Forms.GroupBox();
            this.txtTotalSparepart = new System.Windows.Forms.TextBox();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.cardTotalKasir.SuspendLayout();
            this.cardTotalMekanik.SuspendLayout();
            this.cardPendapatanHariIni.SuspendLayout();
            this.cardTotalPendapatan.SuspendLayout();
            this.cardTotalJasa.SuspendLayout();
            this.cardTotalSparepart.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.Controls.Add(this.labelMenuTitle);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnSparepart);
            this.panelSidebar.Controls.Add(this.btnJasa);
            this.panelSidebar.Controls.Add(this.btnPesanan);
            this.panelSidebar.Controls.Add(this.btnKaryawan);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(150, 488);
            this.panelSidebar.TabIndex = 1;
            // 
            // labelMenuTitle
            // 
            this.labelMenuTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelMenuTitle.ForeColor = System.Drawing.Color.White;
            this.labelMenuTitle.Location = new System.Drawing.Point(15, 16);
            this.labelMenuTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMenuTitle.Name = "labelMenuTitle";
            this.labelMenuTitle.Size = new System.Drawing.Size(120, 32);
            this.labelMenuTitle.TabIndex = 0;
            this.labelMenuTitle.Text = "ADMIN";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(8, 65);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(135, 32);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnSparepart
            // 
            this.btnSparepart.BackColor = System.Drawing.Color.Transparent;
            this.btnSparepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSparepart.ForeColor = System.Drawing.Color.White;
            this.btnSparepart.Location = new System.Drawing.Point(8, 106);
            this.btnSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSparepart.Name = "btnSparepart";
            this.btnSparepart.Size = new System.Drawing.Size(135, 32);
            this.btnSparepart.TabIndex = 2;
            this.btnSparepart.Text = "   Sparepart";
            this.btnSparepart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSparepart.UseVisualStyleBackColor = false;
            this.btnSparepart.Click += new System.EventHandler(this.btnSparepart_Click);
            // 
            // btnJasa
            // 
            this.btnJasa.BackColor = System.Drawing.Color.Transparent;
            this.btnJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJasa.ForeColor = System.Drawing.Color.White;
            this.btnJasa.Location = new System.Drawing.Point(8, 146);
            this.btnJasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnJasa.Name = "btnJasa";
            this.btnJasa.Size = new System.Drawing.Size(135, 32);
            this.btnJasa.TabIndex = 3;
            this.btnJasa.Text = "   Jasa";
            this.btnJasa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJasa.UseVisualStyleBackColor = false;
            this.btnJasa.Click += new System.EventHandler(this.btnJasa_Click);
            // 
            // btnPesanan
            // 
            this.btnPesanan.BackColor = System.Drawing.Color.Transparent;
            this.btnPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesanan.ForeColor = System.Drawing.Color.White;
            this.btnPesanan.Location = new System.Drawing.Point(8, 187);
            this.btnPesanan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPesanan.Name = "btnPesanan";
            this.btnPesanan.Size = new System.Drawing.Size(135, 32);
            this.btnPesanan.TabIndex = 4;
            this.btnPesanan.Text = "   Pesanan";
            this.btnPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesanan.UseVisualStyleBackColor = false;
            this.btnPesanan.Click += new System.EventHandler(this.btnPesanan_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.BackColor = System.Drawing.Color.Transparent;
            this.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaryawan.ForeColor = System.Drawing.Color.White;
            this.btnKaryawan.Location = new System.Drawing.Point(8, 228);
            this.btnKaryawan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(135, 32);
            this.btnKaryawan.TabIndex = 5;
            this.btnKaryawan.Text = "   Karyawan";
            this.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaryawan.UseVisualStyleBackColor = false;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(8, 406);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(135, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelDashboard);
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(600, 488);
            this.panelContent.TabIndex = 0;
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.labelTitle);
            this.panelDashboard.Controls.Add(this.cardTotalKasir);
            this.panelDashboard.Controls.Add(this.cardTotalMekanik);
            this.panelDashboard.Controls.Add(this.cardPendapatanHariIni);
            this.panelDashboard.Controls.Add(this.cardTotalPendapatan);
            this.panelDashboard.Controls.Add(this.cardTotalJasa);
            this.panelDashboard.Controls.Add(this.cardTotalSparepart);
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(600, 488);
            this.panelDashboard.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(15, 16);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(262, 28);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "DASHBOARD BENGKEL";
            // 
            // cardTotalKasir
            // 
            this.cardTotalKasir.Controls.Add(this.txtTotalKasir);
            this.cardTotalKasir.Location = new System.Drawing.Point(15, 57);
            this.cardTotalKasir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalKasir.Name = "cardTotalKasir";
            this.cardTotalKasir.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalKasir.Size = new System.Drawing.Size(135, 81);
            this.cardTotalKasir.TabIndex = 1;
            this.cardTotalKasir.TabStop = false;
            this.cardTotalKasir.Text = "Total Kasir";
            // 
            // txtTotalKasir
            // 
            this.txtTotalKasir.Location = new System.Drawing.Point(8, 34);
            this.txtTotalKasir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalKasir.Name = "txtTotalKasir";
            this.txtTotalKasir.ReadOnly = true;
            this.txtTotalKasir.Size = new System.Drawing.Size(121, 20);
            this.txtTotalKasir.TabIndex = 0;
            this.txtTotalKasir.TextChanged += new System.EventHandler(this.txtTotalKasir_TextChanged);
            // 
            // cardTotalMekanik
            // 
            this.cardTotalMekanik.Controls.Add(this.txtTotalMekanik);
            this.cardTotalMekanik.Location = new System.Drawing.Point(180, 57);
            this.cardTotalMekanik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalMekanik.Name = "cardTotalMekanik";
            this.cardTotalMekanik.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalMekanik.Size = new System.Drawing.Size(135, 81);
            this.cardTotalMekanik.TabIndex = 2;
            this.cardTotalMekanik.TabStop = false;
            this.cardTotalMekanik.Text = "Total Mekanik";
            // 
            // txtTotalMekanik
            // 
            this.txtTotalMekanik.Location = new System.Drawing.Point(8, 34);
            this.txtTotalMekanik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalMekanik.Name = "txtTotalMekanik";
            this.txtTotalMekanik.ReadOnly = true;
            this.txtTotalMekanik.Size = new System.Drawing.Size(121, 20);
            this.txtTotalMekanik.TabIndex = 0;
            // 
            // cardPendapatanHariIni
            // 
            this.cardPendapatanHariIni.Controls.Add(this.txtPendapatanHariIni);
            this.cardPendapatanHariIni.Location = new System.Drawing.Point(345, 57);
            this.cardPendapatanHariIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardPendapatanHariIni.Name = "cardPendapatanHariIni";
            this.cardPendapatanHariIni.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardPendapatanHariIni.Size = new System.Drawing.Size(135, 81);
            this.cardPendapatanHariIni.TabIndex = 3;
            this.cardPendapatanHariIni.TabStop = false;
            this.cardPendapatanHariIni.Text = "Pendapatan Hari Ini";
            // 
            // txtPendapatanHariIni
            // 
            this.txtPendapatanHariIni.Location = new System.Drawing.Point(8, 34);
            this.txtPendapatanHariIni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPendapatanHariIni.Name = "txtPendapatanHariIni";
            this.txtPendapatanHariIni.ReadOnly = true;
            this.txtPendapatanHariIni.Size = new System.Drawing.Size(121, 20);
            this.txtPendapatanHariIni.TabIndex = 0;
            // 
            // cardTotalPendapatan
            // 
            this.cardTotalPendapatan.Controls.Add(this.txtTotalPendapatan);
            this.cardTotalPendapatan.Location = new System.Drawing.Point(15, 154);
            this.cardTotalPendapatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalPendapatan.Name = "cardTotalPendapatan";
            this.cardTotalPendapatan.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalPendapatan.Size = new System.Drawing.Size(135, 81);
            this.cardTotalPendapatan.TabIndex = 4;
            this.cardTotalPendapatan.TabStop = false;
            this.cardTotalPendapatan.Text = "Total Pendapatan";
            // 
            // txtTotalPendapatan
            // 
            this.txtTotalPendapatan.Location = new System.Drawing.Point(8, 34);
            this.txtTotalPendapatan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalPendapatan.Name = "txtTotalPendapatan";
            this.txtTotalPendapatan.ReadOnly = true;
            this.txtTotalPendapatan.Size = new System.Drawing.Size(121, 20);
            this.txtTotalPendapatan.TabIndex = 0;
            // 
            // cardTotalJasa
            // 
            this.cardTotalJasa.Controls.Add(this.txtTotalJasa);
            this.cardTotalJasa.Location = new System.Drawing.Point(180, 154);
            this.cardTotalJasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalJasa.Name = "cardTotalJasa";
            this.cardTotalJasa.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalJasa.Size = new System.Drawing.Size(135, 81);
            this.cardTotalJasa.TabIndex = 5;
            this.cardTotalJasa.TabStop = false;
            this.cardTotalJasa.Text = "Jenis Jasa";
            // 
            // txtTotalJasa
            // 
            this.txtTotalJasa.Location = new System.Drawing.Point(8, 34);
            this.txtTotalJasa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalJasa.Name = "txtTotalJasa";
            this.txtTotalJasa.ReadOnly = true;
            this.txtTotalJasa.Size = new System.Drawing.Size(121, 20);
            this.txtTotalJasa.TabIndex = 0;
            // 
            // cardTotalSparepart
            // 
            this.cardTotalSparepart.Controls.Add(this.txtTotalSparepart);
            this.cardTotalSparepart.Location = new System.Drawing.Point(345, 154);
            this.cardTotalSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalSparepart.Name = "cardTotalSparepart";
            this.cardTotalSparepart.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardTotalSparepart.Size = new System.Drawing.Size(135, 81);
            this.cardTotalSparepart.TabIndex = 6;
            this.cardTotalSparepart.TabStop = false;
            this.cardTotalSparepart.Text = "Jenis Sparepart";
            // 
            // txtTotalSparepart
            // 
            this.txtTotalSparepart.Location = new System.Drawing.Point(8, 34);
            this.txtTotalSparepart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalSparepart.Name = "txtTotalSparepart";
            this.txtTotalSparepart.ReadOnly = true;
            this.txtTotalSparepart.Size = new System.Drawing.Size(121, 20);
            this.txtTotalSparepart.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.cardTotalKasir.ResumeLayout(false);
            this.cardTotalKasir.PerformLayout();
            this.cardTotalMekanik.ResumeLayout(false);
            this.cardTotalMekanik.PerformLayout();
            this.cardPendapatanHariIni.ResumeLayout(false);
            this.cardPendapatanHariIni.PerformLayout();
            this.cardTotalPendapatan.ResumeLayout(false);
            this.cardTotalPendapatan.PerformLayout();
            this.cardTotalJasa.ResumeLayout(false);
            this.cardTotalJasa.PerformLayout();
            this.cardTotalSparepart.ResumeLayout(false);
            this.cardTotalSparepart.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSparepart;
        private System.Windows.Forms.Button btnJasa;
        private System.Windows.Forms.Button btnPesanan;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelMenuTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox cardTotalKasir;
        private System.Windows.Forms.TextBox txtTotalKasir;
        private System.Windows.Forms.GroupBox cardTotalMekanik;
        private System.Windows.Forms.TextBox txtTotalMekanik;
        private System.Windows.Forms.GroupBox cardPendapatanHariIni;
        private System.Windows.Forms.TextBox txtPendapatanHariIni;
        private System.Windows.Forms.GroupBox cardTotalPendapatan;
        private System.Windows.Forms.TextBox txtTotalPendapatan;
        private System.Windows.Forms.GroupBox cardTotalJasa;
        private System.Windows.Forms.TextBox txtTotalJasa;
        private System.Windows.Forms.GroupBox cardTotalSparepart;
        private System.Windows.Forms.TextBox txtTotalSparepart;
    }
}
