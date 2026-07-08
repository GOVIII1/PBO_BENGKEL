namespace PBO_BENGKEL.view.admin
{
    partial class AdminJasaForm
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
            this.txtIdJasa = new System.Windows.Forms.TextBox();
            this.txtNamaJasa = new System.Windows.Forms.TextBox();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.dgvJasa = new System.Windows.Forms.DataGridView();
            this.btnSimpanJasa = new System.Windows.Forms.Button();
            this.btnUbahJasa = new System.Windows.Forms.Button();
            this.btnHapusJasa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdJasa
            // 
            this.txtIdJasa.Location = new System.Drawing.Point(141, 61);
            this.txtIdJasa.Name = "txtIdJasa";
            this.txtIdJasa.Size = new System.Drawing.Size(100, 20);
            this.txtIdJasa.TabIndex = 0;
            // 
            // txtNamaJasa
            // 
            this.txtNamaJasa.Location = new System.Drawing.Point(141, 99);
            this.txtNamaJasa.Name = "txtNamaJasa";
            this.txtNamaJasa.Size = new System.Drawing.Size(100, 20);
            this.txtNamaJasa.TabIndex = 1;
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(141, 140);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(100, 20);
            this.txtTarif.TabIndex = 2;
            this.txtTarif.TextChanged += new System.EventHandler(this.txtTarif_TextChanged);
            // 
            // dgvJasa
            // 
            this.dgvJasa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJasa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJasa.Location = new System.Drawing.Point(15, 186);
            this.dgvJasa.Name = "dgvJasa";
            this.dgvJasa.RowHeadersVisible = false;
            this.dgvJasa.RowHeadersWidth = 51;
            this.dgvJasa.Size = new System.Drawing.Size(570, 284);
            this.dgvJasa.TabIndex = 3;
            this.dgvJasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJasa_CellClick);
            this.dgvJasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSimpanJasa
            // 
            this.btnSimpanJasa.Location = new System.Drawing.Point(269, 99);
            this.btnSimpanJasa.Name = "btnSimpanJasa";
            this.btnSimpanJasa.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanJasa.TabIndex = 4;
            this.btnSimpanJasa.Text = "SIMPAN";
            this.btnSimpanJasa.UseVisualStyleBackColor = true;
            this.btnSimpanJasa.Click += new System.EventHandler(this.btnSimpanJasa_Click);
            // 
            // btnUbahJasa
            // 
            this.btnUbahJasa.Location = new System.Drawing.Point(269, 59);
            this.btnUbahJasa.Name = "btnUbahJasa";
            this.btnUbahJasa.Size = new System.Drawing.Size(75, 23);
            this.btnUbahJasa.TabIndex = 9;
            this.btnUbahJasa.Text = "UBAH";
            this.btnUbahJasa.UseVisualStyleBackColor = true;
            this.btnUbahJasa.Click += new System.EventHandler(this.btnUbahJasa_Click);
            // 
            // btnHapusJasa
            // 
            this.btnHapusJasa.Location = new System.Drawing.Point(269, 138);
            this.btnHapusJasa.Name = "btnHapusJasa";
            this.btnHapusJasa.Size = new System.Drawing.Size(75, 23);
            this.btnHapusJasa.TabIndex = 10;
            this.btnHapusJasa.Text = "HAPUS";
            this.btnHapusJasa.UseVisualStyleBackColor = true;
            this.btnHapusJasa.Click += new System.EventHandler(this.btnHapusJasa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Jasa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama Jasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tarif Harga (Rp)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Katalog Jasa";
            // 
            // AdminJasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpanJasa);
            this.Controls.Add(this.btnUbahJasa);
            this.Controls.Add(this.btnHapusJasa);
            this.Controls.Add(this.dgvJasa);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtNamaJasa);
            this.Controls.Add(this.txtIdJasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminJasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdminJasaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdJasa;
        private System.Windows.Forms.TextBox txtNamaJasa;
        private System.Windows.Forms.TextBox txtTarif;
        private System.Windows.Forms.DataGridView dgvJasa;
        private System.Windows.Forms.Button btnSimpanJasa;
        private System.Windows.Forms.Button btnUbahJasa;
        private System.Windows.Forms.Button btnHapusJasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
