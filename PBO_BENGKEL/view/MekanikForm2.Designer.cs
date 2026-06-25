namespace PBO_BENGKEL.view
{
    partial class FormMekanik
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
            this.antrianbengkel_dgv = new System.Windows.Forms.DataGridView();
            this.logout_btn = new System.Windows.Forms.Button();
            this.jam_masuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plat_motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.antrianbengkel_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Bengkel ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Daftar Antrian Motor (Status: Proses/Antri) ";
            // 
            // antrianbengkel_dgv
            // 
            this.antrianbengkel_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.antrianbengkel_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jam_masuk,
            this.plat_motor,
            this.keluhan,
            this.aksi});
            this.antrianbengkel_dgv.Location = new System.Drawing.Point(29, 115);
            this.antrianbengkel_dgv.Name = "antrianbengkel_dgv";
            this.antrianbengkel_dgv.RowHeadersWidth = 51;
            this.antrianbengkel_dgv.RowTemplate.Height = 24;
            this.antrianbengkel_dgv.Size = new System.Drawing.Size(978, 150);
            this.antrianbengkel_dgv.TabIndex = 2;
            this.antrianbengkel_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.antrianbengkel_dgv_CellContentClick);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(29, 298);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(153, 46);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "LOGOUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // jam_masuk
            // 
            this.jam_masuk.HeaderText = "Jam Masuk";
            this.jam_masuk.MinimumWidth = 6;
            this.jam_masuk.Name = "jam_masuk";
            this.jam_masuk.Width = 250;
            // 
            // plat_motor
            // 
            this.plat_motor.HeaderText = "Plat Motor";
            this.plat_motor.MinimumWidth = 6;
            this.plat_motor.Name = "plat_motor";
            this.plat_motor.Width = 200;
            // 
            // keluhan
            // 
            this.keluhan.HeaderText = "Keluhan Pelanggan";
            this.keluhan.MinimumWidth = 6;
            this.keluhan.Name = "keluhan";
            this.keluhan.Width = 225;
            // 
            // aksi
            // 
            this.aksi.HeaderText = "Aksi";
            this.aksi.MinimumWidth = 6;
            this.aksi.Name = "aksi";
            this.aksi.Text = "Kerjakan";
            this.aksi.UseColumnTextForButtonValue = true;
            this.aksi.Width = 250;
            // 
            // FormMekanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 618);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.antrianbengkel_dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMekanik";
            this.Text = "MekanikForm2";
            ((System.ComponentModel.ISupportInitialize)(this.antrianbengkel_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView antrianbengkel_dgv;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam_masuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn plat_motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhan;
        private System.Windows.Forms.DataGridViewButtonColumn aksi;
    }
}