namespace PBO_BENGKEL.view
{
    partial class FormTindakanMekanik
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKeluhan = new System.Windows.Forms.Label();
            this.lblIdServis = new System.Windows.Forms.Label();
            this.lblMotor = new System.Windows.Forms.Label();
            this.lblMekanik = new System.Windows.Forms.Label();
            this.tambahJasa_pnl = new System.Windows.Forms.Panel();
            this.masukkan_btn = new System.Windows.Forms.Button();
            this.jumlah_cmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pilihmenu_cmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pekerjaanselesai_btn = new System.Windows.Forms.Button();
            this.daftarselesai_dgv = new System.Windows.Forms.DataGridView();
            this.nama_tindakan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tambahJasa_pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarselesai_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Tindakan Mekanik Bengkel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblKeluhan);
            this.panel1.Controls.Add(this.lblIdServis);
            this.panel1.Controls.Add(this.lblMotor);
            this.panel1.Controls.Add(this.lblMekanik);
            this.panel1.Location = new System.Drawing.Point(47, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1624, 136);
            this.panel1.TabIndex = 1;
            // 
            // lblKeluhan
            // 
            this.lblKeluhan.AutoSize = true;
            this.lblKeluhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKeluhan.Location = new System.Drawing.Point(15, 67);
            this.lblKeluhan.Name = "lblKeluhan";
            this.lblKeluhan.Size = new System.Drawing.Size(84, 23);
            this.lblKeluhan.TabIndex = 7;
            this.lblKeluhan.Text = "Keluhan :";
            // 
            // lblIdServis
            // 
            this.lblIdServis.AutoSize = true;
            this.lblIdServis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdServis.Location = new System.Drawing.Point(14, 93);
            this.lblIdServis.Name = "lblIdServis";
            this.lblIdServis.Size = new System.Drawing.Size(91, 23);
            this.lblIdServis.TabIndex = 6;
            this.lblIdServis.Text = "ID Servis :";
            // 
            // lblMotor
            // 
            this.lblMotor.AutoSize = true;
            this.lblMotor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMotor.Location = new System.Drawing.Point(14, 40);
            this.lblMotor.Name = "lblMotor";
            this.lblMotor.Size = new System.Drawing.Size(162, 23);
            this.lblMotor.TabIndex = 5;
            this.lblMotor.Text = "Motor Dikerjakan :";
            // 
            // lblMekanik
            // 
            this.lblMekanik.AutoSize = true;
            this.lblMekanik.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMekanik.Location = new System.Drawing.Point(14, 12);
            this.lblMekanik.Name = "lblMekanik";
            this.lblMekanik.Size = new System.Drawing.Size(165, 23);
            this.lblMekanik.TabIndex = 4;
            this.lblMekanik.Text = "Mekanik Bertugas :";
            // 
            // tambahJasa_pnl
            // 
            this.tambahJasa_pnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tambahJasa_pnl.Controls.Add(this.masukkan_btn);
            this.tambahJasa_pnl.Controls.Add(this.jumlah_cmb);
            this.tambahJasa_pnl.Controls.Add(this.label4);
            this.tambahJasa_pnl.Controls.Add(this.pilihmenu_cmb);
            this.tambahJasa_pnl.Controls.Add(this.label3);
            this.tambahJasa_pnl.Controls.Add(this.label2);
            this.tambahJasa_pnl.Location = new System.Drawing.Point(47, 231);
            this.tambahJasa_pnl.Name = "tambahJasa_pnl";
            this.tambahJasa_pnl.Size = new System.Drawing.Size(697, 248);
            this.tambahJasa_pnl.TabIndex = 2;
            this.tambahJasa_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.tambahJasa_pnl_Paint);
            // 
            // masukkan_btn
            // 
            this.masukkan_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.masukkan_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masukkan_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masukkan_btn.Location = new System.Drawing.Point(17, 182);
            this.masukkan_btn.Name = "masukkan_btn";
            this.masukkan_btn.Size = new System.Drawing.Size(641, 44);
            this.masukkan_btn.TabIndex = 5;
            this.masukkan_btn.TabStop = false;
            this.masukkan_btn.Text = "+ Masukkan ke Daftar";
            this.masukkan_btn.UseVisualStyleBackColor = false;
            this.masukkan_btn.Click += new System.EventHandler(this.masukkan_btn_Click);
            // 
            // jumlah_cmb
            // 
            this.jumlah_cmb.FormattingEnabled = true;
            this.jumlah_cmb.Location = new System.Drawing.Point(17, 134);
            this.jumlah_cmb.Name = "jumlah_cmb";
            this.jumlah_cmb.Size = new System.Drawing.Size(641, 24);
            this.jumlah_cmb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah (Qty)";
            // 
            // pilihmenu_cmb
            // 
            this.pilihmenu_cmb.FormattingEnabled = true;
            this.pilihmenu_cmb.Location = new System.Drawing.Point(17, 70);
            this.pilihmenu_cmb.Name = "pilihmenu_cmb";
            this.pilihmenu_cmb.Size = new System.Drawing.Size(641, 24);
            this.pilihmenu_cmb.TabIndex = 2;
            this.pilihmenu_cmb.Text = "- Pilih Jasa / Part -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pilih Menu Bengkel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tambah Jasa / Barang";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.pekerjaanselesai_btn);
            this.panel3.Controls.Add(this.daftarselesai_dgv);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(774, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(897, 248);
            this.panel3.TabIndex = 3;
            // 
            // pekerjaanselesai_btn
            // 
            this.pekerjaanselesai_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pekerjaanselesai_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pekerjaanselesai_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pekerjaanselesai_btn.Location = new System.Drawing.Point(23, 189);
            this.pekerjaanselesai_btn.Name = "pekerjaanselesai_btn";
            this.pekerjaanselesai_btn.Size = new System.Drawing.Size(831, 44);
            this.pekerjaanselesai_btn.TabIndex = 6;
            this.pekerjaanselesai_btn.TabStop = false;
            this.pekerjaanselesai_btn.Text = "Semua Pekerjaan Selesai";
            this.pekerjaanselesai_btn.UseVisualStyleBackColor = false;
            this.pekerjaanselesai_btn.Click += new System.EventHandler(this.pekerjaanselesai_btn_Click);
            // 
            // daftarselesai_dgv
            // 
            this.daftarselesai_dgv.AllowUserToAddRows = false;
            this.daftarselesai_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.daftarselesai_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daftarselesai_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_tindakan,
            this.harga_satuan,
            this.qty,
            this.subtotal});
            this.daftarselesai_dgv.Location = new System.Drawing.Point(23, 51);
            this.daftarselesai_dgv.Name = "daftarselesai_dgv";
            this.daftarselesai_dgv.ReadOnly = true;
            this.daftarselesai_dgv.RowHeadersVisible = false;
            this.daftarselesai_dgv.RowHeadersWidth = 51;
            this.daftarselesai_dgv.RowTemplate.Height = 24;
            this.daftarselesai_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.daftarselesai_dgv.Size = new System.Drawing.Size(831, 107);
            this.daftarselesai_dgv.TabIndex = 7;
            // 
            // nama_tindakan
            // 
            this.nama_tindakan.HeaderText = "Nama Tindakan / Barang";
            this.nama_tindakan.MinimumWidth = 6;
            this.nama_tindakan.Name = "nama_tindakan";
            this.nama_tindakan.ReadOnly = true;
            // 
            // harga_satuan
            // 
            this.harga_satuan.HeaderText = "Harga Satuan";
            this.harga_satuan.MinimumWidth = 6;
            this.harga_satuan.Name = "harga_satuan";
            this.harga_satuan.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Daftar yang Sudah Dikerjakan:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(464, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(159, 18);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL SEMENTARA :";
            // 
            // FormTindakanMekanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1713, 1027);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tambahJasa_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormTindakanMekanik";
            this.Text = "FormTindakanMekanik";
            this.Load += new System.EventHandler(this.FormTindakanMekanik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tambahJasa_pnl.ResumeLayout(false);
            this.tambahJasa_pnl.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daftarselesai_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel tambahJasa_pnl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox pilihmenu_cmb;
        private System.Windows.Forms.Button masukkan_btn;
        private System.Windows.Forms.ComboBox jumlah_cmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView daftarselesai_dgv;
        private System.Windows.Forms.Button pekerjaanselesai_btn;
        private System.Windows.Forms.Label lblMekanik;
        private System.Windows.Forms.Label lblIdServis;
        private System.Windows.Forms.Label lblMotor;
        private System.Windows.Forms.Label lblKeluhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_tindakan;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label lblTotal;
    }
}