namespace PBO_BENGKEL.view
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dgvJasa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJasa.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvJasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJasa.Location = new System.Drawing.Point(141, 186);
            this.dgvJasa.Name = "dgvJasa";
            this.dgvJasa.RowHeadersVisible = false;
            this.dgvJasa.Size = new System.Drawing.Size(326, 150);
            this.dgvJasa.TabIndex = 3;
            this.dgvJasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJasa_CellClick);
            this.dgvJasa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSimpanJasa
            // 
            this.btnSimpanJasa.Location = new System.Drawing.Point(269, 138);
            this.btnSimpanJasa.Name = "btnSimpanJasa";
            this.btnSimpanJasa.Size = new System.Drawing.Size(75, 23);
            this.btnSimpanJasa.TabIndex = 4;
            this.btnSimpanJasa.Text = "SIMPAN";
            this.btnSimpanJasa.UseVisualStyleBackColor = true;
            this.btnSimpanJasa.Click += new System.EventHandler(this.btnSimpanJasa_Click);
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
            // AdminJasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSimpanJasa);
            this.Controls.Add(this.dgvJasa);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.txtNamaJasa);
            this.Controls.Add(this.txtIdJasa);
            this.Name = "AdminJasaForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}