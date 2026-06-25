namespace Projek.view
{
    partial class DashboardKasir
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
            this.lblJudulTop = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pesanan_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.id_servis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesanan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulTop
            // 
            this.lblJudulTop.AutoSize = true;
            this.lblJudulTop.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTop.ForeColor = System.Drawing.Color.White;
            this.lblJudulTop.Location = new System.Drawing.Point(387, 18);
            this.lblJudulTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJudulTop.Name = "lblJudulTop";
            this.lblJudulTop.Size = new System.Drawing.Size(237, 37);
            this.lblJudulTop.TabIndex = 0;
            this.lblJudulTop.Text = "DEALER YAAMBA";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelHeader.Controls.Add(this.lblJudulTop);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(932, 74);
            this.panelHeader.TabIndex = 1;
            // 
            // pesanan_dgv
            // 
            this.pesanan_dgv.AllowUserToAddRows = false;
            this.pesanan_dgv.AllowUserToDeleteRows = false;
            this.pesanan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pesanan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_servis,
            this.nama,
            this.no_hp,
            this.keluhan,
            this.status});
            this.pesanan_dgv.Location = new System.Drawing.Point(0, 267);
            this.pesanan_dgv.Name = "pesanan_dgv";
            this.pesanan_dgv.ReadOnly = true;
            this.pesanan_dgv.RowHeadersWidth = 51;
            this.pesanan_dgv.RowTemplate.Height = 24;
            this.pesanan_dgv.Size = new System.Drawing.Size(932, 340);
            this.pesanan_dgv.TabIndex = 2;
            this.pesanan_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pesanan_dgv_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tambah Pesanan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Selesai Pesanan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // id_servis
            // 
            this.id_servis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_servis.DataPropertyName = "id_servis";
            this.id_servis.HeaderText = "ID Servis";
            this.id_servis.MinimumWidth = 6;
            this.id_servis.Name = "id_servis";
            this.id_servis.ReadOnly = true;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama_pelanggan";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // no_hp
            // 
            this.no_hp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.no_hp.DataPropertyName = "no_hp";
            this.no_hp.HeaderText = "Nomor HP";
            this.no_hp.MinimumWidth = 6;
            this.no_hp.Name = "no_hp";
            this.no_hp.ReadOnly = true;
            // 
            // keluhan
            // 
            this.keluhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keluhan.DataPropertyName = "keluhan";
            this.keluhan.HeaderText = "Keluhan";
            this.keluhan.MinimumWidth = 6;
            this.keluhan.Name = "keluhan";
            this.keluhan.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // DashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesanan_dgv);
            this.Controls.Add(this.panelHeader);
            this.Name = "DashboardKasir";
            this.Text = "DashboardKasir";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesanan_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJudulTop;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView pesanan_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servis;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}