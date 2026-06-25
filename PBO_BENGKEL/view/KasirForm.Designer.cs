namespace PBO_BENGKEL.view
{
    partial class KasirForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtIdPart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Location = new System.Drawing.Point(61, 298);
            this.dgvPesanan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.RowHeadersVisible = false;
            this.dgvPesanan.RowHeadersWidth = 51;
            this.dgvPesanan.Size = new System.Drawing.Size(808, 250);
            this.dgvPesanan.TabIndex = 16;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(407, 159);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(157, 28);
            this.btnUbah.TabIndex = 26;
            this.btnUbah.Text = "Update Data";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Hrga Jual (Rp)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Jumlah Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID Barang";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(407, 101);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 28);
            this.btnSimpan.TabIndex = 21;
            this.btnSimpan.Text = "Simpan ke Databae";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(159, 246);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(132, 22);
            this.txtHarga.TabIndex = 20;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(159, 197);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(132, 22);
            this.txtStok.TabIndex = 19;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(159, 148);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(132, 22);
            this.txtNamaBarang.TabIndex = 18;
            // 
            // txtIdPart
            // 
            this.txtIdPart.Location = new System.Drawing.Point(159, 97);
            this.txtIdPart.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPart.Name = "txtIdPart";
            this.txtIdPart.Size = new System.Drawing.Size(132, 22);
            this.txtIdPart.TabIndex = 17;
            // 
            // KasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 590);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtIdPart);
            this.Controls.Add(this.dgvPesanan);
            this.Name = "KasirForm";
            this.Text = "KasirForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtIdPart;
    }
}