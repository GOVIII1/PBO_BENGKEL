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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Stok Sparepart";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdPart
            // 
            this.txtIdPart.Location = new System.Drawing.Point(115, 75);
            this.txtIdPart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPart.Name = "txtIdPart";
            this.txtIdPart.Size = new System.Drawing.Size(132, 22);
            this.txtIdPart.TabIndex = 1;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(115, 126);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(132, 22);
            this.txtNamaBarang.TabIndex = 2;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(115, 175);
            this.txtStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(132, 22);
            this.txtStok.TabIndex = 3;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(115, 224);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(132, 22);
            this.txtHarga.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(115, 256);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(157, 28);
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
            this.dgvSparepart.Location = new System.Drawing.Point(115, 303);
            this.dgvSparepart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSparepart.Name = "dgvSparepart";
            this.dgvSparepart.RowHeadersVisible = false;
            this.dgvSparepart.RowHeadersWidth = 51;
            this.dgvSparepart.Size = new System.Drawing.Size(517, 185);
            this.dgvSparepart.TabIndex = 6;
            this.dgvSparepart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparepart_CellClick);
            this.dgvSparepart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSparepart_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jumlah Stok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hrga Jual (Rp)";
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(280, 256);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(157, 28);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Update Data";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminSparepartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(681, 512);
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminSparepartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.Button button1;
    }
}