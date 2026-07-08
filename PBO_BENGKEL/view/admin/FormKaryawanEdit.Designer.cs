namespace PBO_BENGKEL.view.admin
{
    partial class FormKaryawanEdit
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNoHp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            this.lblUsername.AutoSize = true; this.lblUsername.Location = new System.Drawing.Point(20, 22); this.lblUsername.Size = new System.Drawing.Size(73, 16); this.lblUsername.Text = "Username";
            this.lblPassword.AutoSize = true; this.lblPassword.Location = new System.Drawing.Point(20, 52); this.lblPassword.Size = new System.Drawing.Size(70, 16); this.lblPassword.Text = "Password";
            this.lblRole.AutoSize = true; this.lblRole.Location = new System.Drawing.Point(20, 82); this.lblRole.Size = new System.Drawing.Size(37, 16); this.lblRole.Text = "Role";
            this.lblNama.AutoSize = true; this.lblNama.Location = new System.Drawing.Point(20, 112); this.lblNama.Size = new System.Drawing.Size(99, 16); this.lblNama.Text = "Nama Lengkap";
            this.lblNoHp.AutoSize = true; this.lblNoHp.Location = new System.Drawing.Point(20, 142); this.lblNoHp.Size = new System.Drawing.Size(44, 16); this.lblNoHp.Text = "No HP";
            this.lblAlamat.AutoSize = true; this.lblAlamat.Location = new System.Drawing.Point(20, 172); this.lblAlamat.Size = new System.Drawing.Size(51, 16); this.lblAlamat.Text = "Alamat";

            this.txtUsername.Location = new System.Drawing.Point(120, 20); this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.Location = new System.Drawing.Point(120, 50); this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.cmbRole.Items.AddRange(new object[] { "Kasir", "Mekanik", "Admin" }); this.cmbRole.Location = new System.Drawing.Point(120, 80); this.cmbRole.Size = new System.Drawing.Size(200, 24);
            this.txtNama.Location = new System.Drawing.Point(120, 110); this.txtNama.Size = new System.Drawing.Size(200, 22);
            this.txtNoHp.Location = new System.Drawing.Point(120, 140); this.txtNoHp.Size = new System.Drawing.Size(200, 22);
            this.txtAlamat.Location = new System.Drawing.Point(120, 170); this.txtAlamat.Size = new System.Drawing.Size(200, 60); this.txtAlamat.Multiline = true;
            this.pictureBox.Location = new System.Drawing.Point(350, 20); this.pictureBox.Size = new System.Drawing.Size(120, 120); this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFoto.Text = "Pilih Foto"; this.btnFoto.Location = new System.Drawing.Point(350, 150);
            this.btnSimpan.Text = "Simpan"; this.btnSimpan.Location = new System.Drawing.Point(120, 250);
            this.btnBatal.Text = "Batal"; this.btnBatal.Location = new System.Drawing.Point(220, 250);

            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUsername, this.lblPassword, this.lblRole, this.lblNama, this.lblNoHp, this.lblAlamat,
                this.txtUsername, this.txtPassword, this.cmbRole, this.txtNama, this.txtNoHp, this.txtAlamat,
                this.pictureBox, this.btnFoto, this.btnSimpan, this.btnBatal
            });
            this.Text = "Form Karyawan";

            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNoHp;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
