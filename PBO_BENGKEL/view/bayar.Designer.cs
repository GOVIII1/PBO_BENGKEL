namespace Projek.view
{
    partial class bayar
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnterima = new System.Windows.Forms.Button();
            this.jumlahuang_txt = new System.Windows.Forms.TextBox();
            this.lblUangDiterimaTitle = new System.Windows.Forms.Label();
            this.pnlTotalTagihan = new System.Windows.Forms.Panel();
            this.dgvRincian = new System.Windows.Forms.DataGridView();
            this.lblRincianTitle = new System.Windows.Forms.Label();
            this.lblIdServis = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.colNamaTindakan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tagihan_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idservis_txt = new System.Windows.Forms.TextBox();
            this.platnomor_txt = new System.Windows.Forms.TextBox();
            this.pnlCard.SuspendLayout();
            this.pnlTotalTagihan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRincian)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTitle.Location = new System.Drawing.Point(402, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pembayaran";
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.platnomor_txt);
            this.pnlCard.Controls.Add(this.idservis_txt);
            this.pnlCard.Controls.Add(this.label2);
            this.pnlCard.Controls.Add(this.lblLine);
            this.pnlCard.Controls.Add(this.btnterima);
            this.pnlCard.Controls.Add(this.jumlahuang_txt);
            this.pnlCard.Controls.Add(this.lblUangDiterimaTitle);
            this.pnlCard.Controls.Add(this.pnlTotalTagihan);
            this.pnlCard.Controls.Add(this.dgvRincian);
            this.pnlCard.Controls.Add(this.lblRincianTitle);
            this.pnlCard.Controls.Add(this.lblIdServis);
            this.pnlCard.Location = new System.Drawing.Point(277, 59);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(426, 615);
            this.pnlCard.TabIndex = 1;
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(21, 84);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(381, 2);
            this.lblLine.TabIndex = 2;
            // 
            // btnterima
            // 
            this.btnterima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnterima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnterima.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnterima.ForeColor = System.Drawing.Color.White;
            this.btnterima.Location = new System.Drawing.Point(21, 455);
            this.btnterima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnterima.Name = "btnterima";
            this.btnterima.Size = new System.Drawing.Size(381, 55);
            this.btnterima.TabIndex = 8;
            this.btnterima.Text = "Terima Uang & Cetak Lunas";
            this.btnterima.UseVisualStyleBackColor = false;
            // 
            // jumlahuang_txt
            // 
            this.jumlahuang_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlahuang_txt.ForeColor = System.Drawing.Color.Gray;
            this.jumlahuang_txt.Location = new System.Drawing.Point(21, 398);
            this.jumlahuang_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jumlahuang_txt.Name = "jumlahuang_txt";
            this.jumlahuang_txt.Size = new System.Drawing.Size(380, 32);
            this.jumlahuang_txt.TabIndex = 7;
            this.jumlahuang_txt.Text = "Ketik jumlah uang...";
            // 
            // lblUangDiterimaTitle
            // 
            this.lblUangDiterimaTitle.AutoSize = true;
            this.lblUangDiterimaTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUangDiterimaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblUangDiterimaTitle.Location = new System.Drawing.Point(21, 369);
            this.lblUangDiterimaTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUangDiterimaTitle.Name = "lblUangDiterimaTitle";
            this.lblUangDiterimaTitle.Size = new System.Drawing.Size(258, 20);
            this.lblUangDiterimaTitle.TabIndex = 6;
            this.lblUangDiterimaTitle.Text = "Uang Diterima dari Pelanggan (Rp):";
            // 
            // pnlTotalTagihan
            // 
            this.pnlTotalTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pnlTotalTagihan.Controls.Add(this.tagihan_txt);
            this.pnlTotalTagihan.Controls.Add(this.label1);
            this.pnlTotalTagihan.Location = new System.Drawing.Point(21, 294);
            this.pnlTotalTagihan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTotalTagihan.Name = "pnlTotalTagihan";
            this.pnlTotalTagihan.Size = new System.Drawing.Size(381, 49);
            this.pnlTotalTagihan.TabIndex = 5;
            // 
            // dgvRincian
            // 
            this.dgvRincian.AllowUserToAddRows = false;
            this.dgvRincian.AllowUserToDeleteRows = false;
            this.dgvRincian.BackgroundColor = System.Drawing.Color.White;
            this.dgvRincian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRincian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRincian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNamaTindakan,
            this.colQty,
            this.colSubtotal});
            this.dgvRincian.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRincian.Location = new System.Drawing.Point(21, 138);
            this.dgvRincian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRincian.Name = "dgvRincian";
            this.dgvRincian.ReadOnly = true;
            this.dgvRincian.RowHeadersVisible = false;
            this.dgvRincian.RowHeadersWidth = 51;
            this.dgvRincian.Size = new System.Drawing.Size(381, 135);
            this.dgvRincian.TabIndex = 4;
            // 
            // lblRincianTitle
            // 
            this.lblRincianTitle.AutoSize = true;
            this.lblRincianTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRincianTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblRincianTitle.Location = new System.Drawing.Point(21, 101);
            this.lblRincianTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRincianTitle.Name = "lblRincianTitle";
            this.lblRincianTitle.Size = new System.Drawing.Size(197, 23);
            this.lblRincianTitle.TabIndex = 3;
            this.lblRincianTitle.Text = "Rincian Tagihan (Nota):";
            // 
            // lblIdServis
            // 
            this.lblIdServis.AutoSize = true;
            this.lblIdServis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdServis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblIdServis.Location = new System.Drawing.Point(21, 20);
            this.lblIdServis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdServis.Name = "lblIdServis";
            this.lblIdServis.Size = new System.Drawing.Size(93, 23);
            this.lblIdServis.TabIndex = 0;
            this.lblIdServis.Text = "ID Servis: ";
            // 
            // btnBatal
            // 
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBatal.Location = new System.Drawing.Point(32, 714);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(240, 37);
            this.btnBatal.TabIndex = 2;
            this.btnBatal.Text = "⬅ Batal / Kembali ke Dashboard";
            this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // colNamaTindakan
            // 
            this.colNamaTindakan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNamaTindakan.HeaderText = "Jasa/SparePart";
            this.colNamaTindakan.MinimumWidth = 6;
            this.colNamaTindakan.Name = "colNamaTindakan";
            this.colNamaTindakan.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty.HeaderText = "Jumlah";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colSubtotal
            // 
            this.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubtotal.HeaderText = "Total";
            this.colSubtotal.MinimumWidth = 6;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL TAGIHAN:";
            // 
            // tagihan_txt
            // 
            this.tagihan_txt.Location = new System.Drawing.Point(180, 14);
            this.tagihan_txt.Name = "tagihan_txt";
            this.tagihan_txt.Size = new System.Drawing.Size(184, 22);
            this.tagihan_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plat Motor:";
            // 
            // idservis_txt
            // 
            this.idservis_txt.Location = new System.Drawing.Point(159, 20);
            this.idservis_txt.Name = "idservis_txt";
            this.idservis_txt.Size = new System.Drawing.Size(242, 22);
            this.idservis_txt.TabIndex = 3;
            // 
            // platnomor_txt
            // 
            this.platnomor_txt.Location = new System.Drawing.Point(159, 55);
            this.platnomor_txt.Name = "platnomor_txt";
            this.platnomor_txt.Size = new System.Drawing.Size(243, 22);
            this.platnomor_txt.TabIndex = 10;
            // 
            // bayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1344, 814);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "bayar";
            this.Text = "Meja Kasir Bengkel";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlTotalTagihan.ResumeLayout(false);
            this.pnlTotalTagihan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRincian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblIdServis;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblRincianTitle;
        private System.Windows.Forms.DataGridView dgvRincian;
        private System.Windows.Forms.Panel pnlTotalTagihan;
        private System.Windows.Forms.Label lblUangDiterimaTitle;
        private System.Windows.Forms.TextBox jumlahuang_txt;
        private System.Windows.Forms.Button btnterima;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamaTindakan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.TextBox tagihan_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox platnomor_txt;
        private System.Windows.Forms.TextBox idservis_txt;
        private System.Windows.Forms.Label label2;
    }
}