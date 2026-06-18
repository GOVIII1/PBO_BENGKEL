namespace PBO_BENGKEL.view
{
    partial class AdminDashboardForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.karyawan_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvuser = new System.Windows.Forms.DataGridView();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvsparepart = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalpesanan_txbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsparepart)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kelola Katalog Jasa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kelola Stok Sparepart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Main Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.karyawan_btn);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(0, -17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 577);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // karyawan_btn
            // 
            this.karyawan_btn.Location = new System.Drawing.Point(23, 367);
            this.karyawan_btn.Margin = new System.Windows.Forms.Padding(4);
            this.karyawan_btn.Name = "karyawan_btn";
            this.karyawan_btn.Size = new System.Drawing.Size(164, 28);
            this.karyawan_btn.TabIndex = 5;
            this.karyawan_btn.Text = "Kelola Karyawan";
            this.karyawan_btn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 479);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Log-Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 177);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Lihat Pesanan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvuser
            // 
            this.dgvuser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuser.Location = new System.Drawing.Point(766, 64);
            this.dgvuser.Name = "dgvuser";
            this.dgvuser.RowHeadersWidth = 51;
            this.dgvuser.RowTemplate.Height = 24;
            this.dgvuser.Size = new System.Drawing.Size(240, 107);
            this.dgvuser.TabIndex = 4;
            this.dgvuser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvuser_CellContentClick);
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.GridColor = System.Drawing.SystemColors.Control;
            this.dgvPesanan.Location = new System.Drawing.Point(274, 192);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.RowHeadersWidth = 51;
            this.dgvPesanan.RowTemplate.Height = 24;
            this.dgvPesanan.Size = new System.Drawing.Size(341, 317);
            this.dgvPesanan.TabIndex = 5;
            this.dgvPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 42);
            this.label2.TabIndex = 10;
            this.label2.Text = "SIMBEM";
            // 
            // dgvsparepart
            // 
            this.dgvsparepart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvsparepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsparepart.Location = new System.Drawing.Point(665, 192);
            this.dgvsparepart.Name = "dgvsparepart";
            this.dgvsparepart.RowHeadersWidth = 51;
            this.dgvsparepart.RowTemplate.Height = 24;
            this.dgvsparepart.Size = new System.Drawing.Size(341, 317);
            this.dgvsparepart.TabIndex = 11;
            this.dgvsparepart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsparepart_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Bengkel ambem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Total Pesanan:";
            // 
            // totalpesanan_txbox
            // 
            this.totalpesanan_txbox.Location = new System.Drawing.Point(521, 90);
            this.totalpesanan_txbox.Multiline = true;
            this.totalpesanan_txbox.Name = "totalpesanan_txbox";
            this.totalpesanan_txbox.ReadOnly = true;
            this.totalpesanan_txbox.Size = new System.Drawing.Size(136, 47);
            this.totalpesanan_txbox.TabIndex = 20;
            this.totalpesanan_txbox.TextChanged += new System.EventHandler(this.totalpesanan_txbox_TextChanged);
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.totalpesanan_txbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvsparepart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.dgvuser);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsparepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button karyawan_btn;
        private System.Windows.Forms.DataGridView dgvuser;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvsparepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalpesanan_txbox;
    }
}