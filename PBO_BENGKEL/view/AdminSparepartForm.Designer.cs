namespace PBO_BENGKEL.view
{
    partial class AdminSparepartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdPart = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dgvSparepart = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUbah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Stok Sparepart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdPart
            // 
            this.txtIdPart.Location = new System.Drawing.Point(86, 61);
            this.txtIdPart.Name = "txtIdPart";
            this.txtIdPart.Size = new System.Drawing.Size(100, 20);
            this.txtIdPart.TabIndex = 1;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(86, 102);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(100, 20);
            this.txtNamaBarang.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(86, 142);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 3;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(86, 182);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(100, 20);
            this.txtHarga.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(86, 208);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(118, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan ke Databae";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSparepart
            // 
            this.dgvSparepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSparepart.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvSparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSparepart.Location = new System.Drawing.Point(86, 246);
            this.dgvSparepart.Name = "dgvSparepart";
            this.dgvSparepart.RowHeadersVisible = false;
            this.dgvSparepart.Size = new System.Drawing.Size(388, 150);
            this.dgvSparepart.TabIndex = 6;
            this.dgvSparepart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparepart_CellClick);
            this.dgvSparepart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparepart_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jumlah Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hrga Jual (Rp)";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(210, 208);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(118, 23);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Update Data";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // AdminSparepartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSparepart);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtIdPart);
            this.Controls.Add(this.label1);
            this.Name = "AdminSparepartForm";
            this.Text = "AdminSparepartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdPart;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DataGridView dgvSparepart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUbah;
    }
}