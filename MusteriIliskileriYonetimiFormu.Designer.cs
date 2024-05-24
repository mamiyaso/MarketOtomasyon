namespace MarketOtomasyon
{
    partial class MusteriIliskileriYonetimiFormu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMusteriListesi = new System.Windows.Forms.DataGridView();
            this.txtMusteriArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.lblArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriListesi
            // 
            this.dgvMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListesi.Location = new System.Drawing.Point(39, 80);
            this.dgvMusteriListesi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMusteriListesi.Name = "dgvMusteriListesi";
            this.dgvMusteriListesi.RowHeadersWidth = 62;
            this.dgvMusteriListesi.Size = new System.Drawing.Size(643, 333);
            this.dgvMusteriListesi.TabIndex = 0;
            // 
            // txtMusteriArama
            // 
            this.txtMusteriArama.Location = new System.Drawing.Point(103, 27);
            this.txtMusteriArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriArama.Name = "txtMusteriArama";
            this.txtMusteriArama.Size = new System.Drawing.Size(192, 26);
            this.txtMusteriArama.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(321, 27);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(103, 33);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(39, 427);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(129, 40);
            this.btnMusteriEkle.TabIndex = 3;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(193, 427);
            this.btnMusteriGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(129, 40);
            this.btnMusteriGuncelle.TabIndex = 4;
            this.btnMusteriGuncelle.Text = "Müşteri Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(347, 427);
            this.btnMusteriSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(129, 40);
            this.btnMusteriSil.TabIndex = 5;
            this.btnMusteriSil.Text = "Müşteri Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(39, 31);
            this.lblArama.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(60, 20);
            this.lblArama.TabIndex = 6;
            this.lblArama.Text = "Arama:";
            // 
            // MusteriIliskileriYonetimiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 493);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.btnMusteriSil);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtMusteriArama);
            this.Controls.Add(this.dgvMusteriListesi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriIliskileriYonetimiFormu";
            this.Text = "Müşteri İlişkileri Yönetimi";
            this.Load += new System.EventHandler(this.MusteriIliskileriYonetimiFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvMusteriListesi;
        private System.Windows.Forms.TextBox txtMusteriArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Label lblArama;
    }
}
