namespace PBO_BENGKEL.view
{
    partial class LihatPesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesanan = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nohp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "List Data Pemesanan";
            // 
            // dgvPesanan
            // 
            this.dgvPesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesanan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.nohp,
            this.plat});
            this.dgvPesanan.Location = new System.Drawing.Point(72, 117);
            this.dgvPesanan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPesanan.Name = "dgvPesanan";
            this.dgvPesanan.RowHeadersVisible = false;
            this.dgvPesanan.RowHeadersWidth = 51;
            this.dgvPesanan.Size = new System.Drawing.Size(559, 307);
            this.dgvPesanan.TabIndex = 15;
            this.dgvPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesanan_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.FillWeight = 70F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Pelanggan";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            // 
            // nohp
            // 
            this.nohp.HeaderText = "Nomor HP";
            this.nohp.MinimumWidth = 6;
            this.nohp.Name = "nohp";
            // 
            // plat
            // 
            this.plat.HeaderText = "Plat Motor";
            this.plat.MinimumWidth = 6;
            this.plat.Name = "plat";
            // 
            // LihatPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(681, 512);
            this.Controls.Add(this.dgvPesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LihatPesanan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.LihatPesanan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn nohp;
        private System.Windows.Forms.DataGridViewTextBoxColumn plat;
    }
}