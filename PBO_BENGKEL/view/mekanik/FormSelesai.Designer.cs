namespace PBO_BENGKEL.view.mekanik
{
    partial class FormSelesai
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblJudulSelesai = new System.Windows.Forms.Label();
            this.dgvSelesai = new System.Windows.Forms.DataGridView();
            this.colSelesaiIdServis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiPlat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelesaiKeluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).BeginInit();
            this.SuspendLayout();

            this.lblJudulSelesai.Text = "PESANAN SELESAI";
            this.lblJudulSelesai.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulSelesai.Location = new System.Drawing.Point(20, 20);
            this.lblJudulSelesai.Size = new System.Drawing.Size(300, 30);

            this.dgvSelesai.AllowUserToAddRows = false;
            this.dgvSelesai.AllowUserToDeleteRows = false;
            this.dgvSelesai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelesai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelesai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colSelesaiIdServis, this.colSelesaiNama, this.colSelesaiPlat, this.colSelesaiKeluhan });
            this.dgvSelesai.Location = new System.Drawing.Point(20, 60);
            this.dgvSelesai.Name = "dgvSelesai";
            this.dgvSelesai.ReadOnly = true;
            this.dgvSelesai.RowHeadersVisible = false;
            this.dgvSelesai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelesai.Size = new System.Drawing.Size(760, 500);

            this.colSelesaiIdServis.DataPropertyName = "id_servis";
            this.colSelesaiIdServis.HeaderText = "ID Servis";
            this.colSelesaiIdServis.Name = "colSelesaiIdServis";
            this.colSelesaiNama.DataPropertyName = "nama_pelanggan";
            this.colSelesaiNama.HeaderText = "Nama";
            this.colSelesaiNama.Name = "colSelesaiNama";
            this.colSelesaiPlat.DataPropertyName = "plat_nomor";
            this.colSelesaiPlat.HeaderText = "Plat";
            this.colSelesaiPlat.Name = "colSelesaiPlat";
            this.colSelesaiKeluhan.DataPropertyName = "keluhan";
            this.colSelesaiKeluhan.HeaderText = "Keluhan";
            this.colSelesaiKeluhan.Name = "colSelesaiKeluhan";

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvSelesai);
            this.Controls.Add(this.lblJudulSelesai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSelesai";
            this.Text = "Selesai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelesai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudulSelesai;
        private System.Windows.Forms.DataGridView dgvSelesai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiIdServis;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiNama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiPlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSelesaiKeluhan;
    }
}
