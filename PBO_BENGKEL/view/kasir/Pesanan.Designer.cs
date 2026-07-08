namespace PBO_BENGKEL.view.kasir
{
    partial class FormTambahPesanan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblJudulTop = new System.Windows.Forms.Label();
            this.lblJudulForm = new System.Windows.Forms.Label();

            this.lblIdServis = new System.Windows.Forms.Label();
            this.txtIdServis = new System.Windows.Forms.TextBox();

            this.lblNama = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();

            this.lblNoHp = new System.Windows.Forms.Label();
            this.txtNoHp = new System.Windows.Forms.TextBox();

            this.lblPlat = new System.Windows.Forms.Label();
            this.txtPlat = new System.Windows.Forms.TextBox();

            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();

            this.lblKeluhan = new System.Windows.Forms.Label();
            this.txtKeluhan = new System.Windows.Forms.TextBox();

            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // =====================
            // panelHeader (biru atas)
            // =====================
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.lblJudulTop);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(560, 60);
            this.panelHeader.TabIndex = 0;

            // lblJudulTop (di dalam panel biru)
            this.lblJudulTop.AutoSize = true;
            this.lblJudulTop.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblJudulTop.ForeColor = System.Drawing.Color.White;
            this.lblJudulTop.Location = new System.Drawing.Point(150, 13);
            this.lblJudulTop.Name = "lblJudulTop";
            this.lblJudulTop.TabIndex = 0;
            this.lblJudulTop.Text = "DEALER YAAMBA";

            // =====================
            // Judul form
            // =====================
            this.lblJudulForm.AutoSize = true;
            this.lblJudulForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulForm.Location = new System.Drawing.Point(170, 80);
            this.lblJudulForm.Name = "lblJudulForm";
            this.lblJudulForm.TabIndex = 1;
            this.lblJudulForm.Text = "Tambah Pesanan";
            this.lblJudulForm.Click += new System.EventHandler(this.lblJudulForm_Click);

            // =====================
            // ID Servis (disembunyikan via code)
            // =====================
            this.lblIdServis.AutoSize = true;
            this.lblIdServis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIdServis.Location = new System.Drawing.Point(50, 130);
            this.lblIdServis.Name = "lblIdServis";
            this.lblIdServis.TabIndex = 2;
            this.lblIdServis.Text = "ID Servis :";

            this.txtIdServis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdServis.Location = new System.Drawing.Point(200, 127);
            this.txtIdServis.Name = "txtIdServis";
            this.txtIdServis.ReadOnly = true;
            this.txtIdServis.Size = new System.Drawing.Size(280, 25);
            this.txtIdServis.TabIndex = 3;
            this.txtIdServis.TextChanged += new System.EventHandler(this.txtIdServis_TextChanged);

            // =====================
            // Nama
            // =====================
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNama.Location = new System.Drawing.Point(50, 175);
            this.lblNama.Name = "lblNama";
            this.lblNama.TabIndex = 4;
            this.lblNama.Text = "Nama :";

            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNama.Location = new System.Drawing.Point(200, 172);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(280, 25);
            this.txtNama.TabIndex = 5;

            // =====================
            // Nomor HP
            // =====================
            this.lblNoHp.AutoSize = true;
            this.lblNoHp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNoHp.Location = new System.Drawing.Point(50, 220);
            this.lblNoHp.Name = "lblNoHp";
            this.lblNoHp.TabIndex = 6;
            this.lblNoHp.Text = "Nomor HP :";

            this.txtNoHp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNoHp.Location = new System.Drawing.Point(200, 217);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(280, 25);
            this.txtNoHp.TabIndex = 7;

            // =====================
            // Plat Nomor
            // =====================
            this.lblPlat.AutoSize = true;
            this.lblPlat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPlat.Location = new System.Drawing.Point(50, 265);
            this.lblPlat.Name = "lblPlat";
            this.lblPlat.TabIndex = 8;
            this.lblPlat.Text = "Plat Nomor :";

            this.txtPlat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPlat.Location = new System.Drawing.Point(200, 262);
            this.txtPlat.Name = "txtPlat";
            this.txtPlat.Size = new System.Drawing.Size(280, 25);
            this.txtPlat.TabIndex = 9;

            // =====================
            // Tanggal
            // =====================
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(50, 310);
            this.label1.Name = "label1";
            this.label1.TabIndex = 14;
            this.label1.Text = "Tanggal :";
            this.label1.Click += new System.EventHandler(this.label1_Click);

            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 307);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 25);
            this.dateTimePicker1.TabIndex = 15;

            // =====================
            // Keluhan
            // =====================
            this.lblKeluhan.AutoSize = true;
            this.lblKeluhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKeluhan.Location = new System.Drawing.Point(50, 355);
            this.lblKeluhan.Name = "lblKeluhan";
            this.lblKeluhan.TabIndex = 10;
            this.lblKeluhan.Text = "Keluhan :";

            this.txtKeluhan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKeluhan.Location = new System.Drawing.Point(200, 352);
            this.txtKeluhan.Multiline = true;
            this.txtKeluhan.Name = "txtKeluhan";
            this.txtKeluhan.Size = new System.Drawing.Size(280, 80);
            this.txtKeluhan.TabIndex = 11;

            // =====================
            // Tombol Batal & Tambah
            // =====================
            this.btnBatal.BackColor = System.Drawing.Color.LightGray;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.Location = new System.Drawing.Point(200, 455);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(120, 35);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);

            this.btnTambah.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(360, 455);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(120, 35);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);

            // =====================
            // Form Utama
            // =====================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 520);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtKeluhan);
            this.Controls.Add(this.lblKeluhan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlat);
            this.Controls.Add(this.lblPlat);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.lblNoHp);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.txtIdServis);
            this.Controls.Add(this.lblIdServis);
            this.Controls.Add(this.lblJudulForm);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTambahPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Pesanan";
            this.Load += new System.EventHandler(this.FormTambahPesanan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblJudulTop;
        private System.Windows.Forms.Label lblJudulForm;
        private System.Windows.Forms.Label lblIdServis;
        private System.Windows.Forms.TextBox txtIdServis;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.Label lblPlat;
        private System.Windows.Forms.TextBox txtPlat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKeluhan;
        private System.Windows.Forms.TextBox txtKeluhan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
    }
}
