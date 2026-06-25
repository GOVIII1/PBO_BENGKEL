namespace PBO_BENGKEL.view
{
    partial class MekanikForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.namamekanik_cmb = new System.Windows.Forms.ComboBox();
            this.antrian_dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Keluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.antrian_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANTRIAN PESANAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Mekanik :";
            // 
            // namamekanik_cmb
            // 
            this.namamekanik_cmb.FormattingEnabled = true;
            this.namamekanik_cmb.Location = new System.Drawing.Point(190, 88);
            this.namamekanik_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namamekanik_cmb.Name = "namamekanik_cmb";
            this.namamekanik_cmb.Size = new System.Drawing.Size(282, 21);
            this.namamekanik_cmb.TabIndex = 3;
            // 
            // antrian_dgv
            // 
            this.antrian_dgv.AllowUserToAddRows = false;
            this.antrian_dgv.AllowUserToDeleteRows = false;
            this.antrian_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antrian_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Plat,
            this.Keluhan});
            this.antrian_dgv.Location = new System.Drawing.Point(82, 120);
            this.antrian_dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.antrian_dgv.Name = "antrian_dgv";
            this.antrian_dgv.RowHeadersWidth = 51;
            this.antrian_dgv.RowTemplate.Height = 24;
            this.antrian_dgv.Size = new System.Drawing.Size(1157, 466);
            this.antrian_dgv.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_pelanggan";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "nama_pelanggan";
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 200;
            // 
            // Plat
            // 
            this.Plat.DataPropertyName = "plat_motor";
            this.Plat.HeaderText = "Plat Motor";
            this.Plat.MinimumWidth = 6;
            this.Plat.Name = "Plat";
            this.Plat.Width = 125;
            // 
            // Keluhan
            // 
            this.Keluhan.DataPropertyName = "keluhan";
            this.Keluhan.HeaderText = "Keluhan";
            this.Keluhan.MinimumWidth = 6;
            this.Keluhan.Name = "Keluhan";
            this.Keluhan.Width = 300;
            // 
            // detail_btn
            // 
            this.detail_btn.Location = new System.Drawing.Point(512, 471);
            this.detail_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detail_btn.Name = "detail_btn";
            this.detail_btn.Size = new System.Drawing.Size(170, 39);
            this.detail_btn.TabIndex = 6;
            this.detail_btn.Text = "DETAIL";
            this.detail_btn.UseVisualStyleBackColor = true;
            this.detail_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // MekanikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 688);
            this.Controls.Add(this.detail_btn);
            this.Controls.Add(this.antrian_dgv);
            this.Controls.Add(this.namamekanik_cmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MekanikForm";
            this.Text = "AntrianPesanan_frm";
            ((System.ComponentModel.ISupportInitialize)(this.antrian_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox namamekanik_cmb;
        private System.Windows.Forms.DataGridView antrian_dgv;
        private System.Windows.Forms.Button detail_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keluhan;
    }
}