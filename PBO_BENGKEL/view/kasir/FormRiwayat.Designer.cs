namespace PBO_BENGKEL.view.kasir
{
    partial class FormRiwayat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblJudulRiwayat = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.btnCetakRiwayat = new System.Windows.Forms.Button();
            this.colRiwayatIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatNoHp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRiwayatStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();

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
            this.dgvRiwayat.Size = new System.Drawing.Size(760, 460);

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
            this.btnCetakRiwayat.Location = new System.Drawing.Point(20, 540);
            this.btnCetakRiwayat.Size = new System.Drawing.Size(200, 45);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnCetakRiwayat);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.lblJudulRiwayat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRiwayat";
            this.Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudulRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Button btnCetakRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatNoHp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatKeluhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRiwayatStatus;
    }
}
