namespace PBO_BENGKEL.view.mekanik
{
    partial class FormProfil
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblJudulProfil = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnGantiFoto = new System.Windows.Forms.Button();
            this.lblNamaMekanik = new System.Windows.Forms.Label();
            this.lblRoleMekanik = new System.Windows.Forms.Label();
            this.lblUsernameMekanik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            this.lblJudulProfil.Text = "PROFIL";
            this.lblJudulProfil.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblJudulProfil.Location = new System.Drawing.Point(20, 20);
            this.lblJudulProfil.Size = new System.Drawing.Size(300, 30);

            this.pictureBox.Location = new System.Drawing.Point(40, 80);
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnGantiFoto.Text = "Ganti Foto";
            this.btnGantiFoto.Location = new System.Drawing.Point(40, 240);
            this.btnGantiFoto.Size = new System.Drawing.Size(120, 30);

            this.lblNamaMekanik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNamaMekanik.Location = new System.Drawing.Point(220, 80);
            this.lblNamaMekanik.Size = new System.Drawing.Size(400, 30);

            this.lblRoleMekanik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoleMekanik.Location = new System.Drawing.Point(220, 120);
            this.lblRoleMekanik.Size = new System.Drawing.Size(400, 30);

            this.lblUsernameMekanik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsernameMekanik.Location = new System.Drawing.Point(220, 160);
            this.lblUsernameMekanik.Size = new System.Drawing.Size(400, 30);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblUsernameMekanik);
            this.Controls.Add(this.lblRoleMekanik);
            this.Controls.Add(this.lblNamaMekanik);
            this.Controls.Add(this.btnGantiFoto);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblJudulProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfil";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblJudulProfil;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnGantiFoto;
        private System.Windows.Forms.Label lblNamaMekanik;
        private System.Windows.Forms.Label lblRoleMekanik;
        private System.Windows.Forms.Label lblUsernameMekanik;
    }
}
