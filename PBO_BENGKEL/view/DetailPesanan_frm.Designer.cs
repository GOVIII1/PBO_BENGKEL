namespace PBO_BENGKEL.view
{
    partial class DetailPesanan_frm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selesai_btn = new System.Windows.Forms.Button();
            this.batal_btn = new System.Windows.Forms.Button();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.sparepart_cmb = new System.Windows.Forms.ComboBox();
            this.jasa_cmb = new System.Windows.Forms.ComboBox();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.namapelanggan_txt = new System.Windows.Forms.TextBox();
            this.keluhan_txt = new System.Windows.Forms.TextBox();
            this.status_cmb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DETAIL PESANAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID PELANGGAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA PELANGGAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "KELUHAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "JASA SERVIS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "SPAREPART";
            // 
            // selesai_btn
            // 
            this.selesai_btn.Location = new System.Drawing.Point(291, 396);
            this.selesai_btn.Name = "selesai_btn";
            this.selesai_btn.Size = new System.Drawing.Size(143, 51);
            this.selesai_btn.TabIndex = 7;
            this.selesai_btn.Text = "SELESAI";
            this.selesai_btn.UseVisualStyleBackColor = true;
            this.selesai_btn.Click += new System.EventHandler(this.selesai_btn_Click);
            // 
            // batal_btn
            // 
            this.batal_btn.Location = new System.Drawing.Point(440, 396);
            this.batal_btn.Name = "batal_btn";
            this.batal_btn.Size = new System.Drawing.Size(143, 51);
            this.batal_btn.TabIndex = 8;
            this.batal_btn.Text = "BATAL";
            this.batal_btn.UseVisualStyleBackColor = true;
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(589, 396);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(143, 51);
            this.tutup_btn.TabIndex = 9;
            this.tutup_btn.Text = "TUTUP";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // sparepart_cmb
            // 
            this.sparepart_cmb.FormattingEnabled = true;
            this.sparepart_cmb.Location = new System.Drawing.Point(291, 319);
            this.sparepart_cmb.Name = "sparepart_cmb";
            this.sparepart_cmb.Size = new System.Drawing.Size(441, 24);
            this.sparepart_cmb.TabIndex = 11;
            // 
            // jasa_cmb
            // 
            this.jasa_cmb.FormattingEnabled = true;
            this.jasa_cmb.Location = new System.Drawing.Point(291, 286);
            this.jasa_cmb.Name = "jasa_cmb";
            this.jasa_cmb.Size = new System.Drawing.Size(441, 24);
            this.jasa_cmb.TabIndex = 12;
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(291, 101);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(147, 22);
            this.id_txt.TabIndex = 13;
            // 
            // namapelanggan_txt
            // 
            this.namapelanggan_txt.Location = new System.Drawing.Point(291, 136);
            this.namapelanggan_txt.Name = "namapelanggan_txt";
            this.namapelanggan_txt.ReadOnly = true;
            this.namapelanggan_txt.Size = new System.Drawing.Size(441, 22);
            this.namapelanggan_txt.TabIndex = 14;
            // 
            // keluhan_txt
            // 
            this.keluhan_txt.Location = new System.Drawing.Point(291, 171);
            this.keluhan_txt.Multiline = true;
            this.keluhan_txt.Name = "keluhan_txt";
            this.keluhan_txt.ReadOnly = true;
            this.keluhan_txt.Size = new System.Drawing.Size(441, 109);
            this.keluhan_txt.TabIndex = 15;
            // 
            // status_cmb
            // 
            this.status_cmb.FormattingEnabled = true;
            this.status_cmb.Location = new System.Drawing.Point(291, 352);
            this.status_cmb.Name = "status_cmb";
            this.status_cmb.Size = new System.Drawing.Size(158, 24);
            this.status_cmb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "STATUS";
            // 
            // DetailPesanan_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 503);
            this.Controls.Add(this.keluhan_txt);
            this.Controls.Add(this.namapelanggan_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.jasa_cmb);
            this.Controls.Add(this.sparepart_cmb);
            this.Controls.Add(this.status_cmb);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.batal_btn);
            this.Controls.Add(this.selesai_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailPesanan_frm";
            this.Text = "DetailPesanan_frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selesai_btn;
        private System.Windows.Forms.Button batal_btn;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.ComboBox sparepart_cmb;
        private System.Windows.Forms.ComboBox jasa_cmb;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox namapelanggan_txt;
        private System.Windows.Forms.TextBox keluhan_txt;
        private System.Windows.Forms.ComboBox status_cmb;
        private System.Windows.Forms.Label label7;
    }
}