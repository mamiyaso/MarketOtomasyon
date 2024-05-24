namespace MarketOtomasyon
{
    partial class StokEkrani
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
            this.dataGridViewStok = new System.Windows.Forms.DataGridView();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.textBoxYeniStokAdedi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStok
            // 
            this.dataGridViewStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStok.Location = new System.Drawing.Point(18, 63);
            this.dataGridViewStok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewStok.Name = "dataGridViewStok";
            this.dataGridViewStok.RowHeadersWidth = 62;
            this.dataGridViewStok.Size = new System.Drawing.Size(1027, 615);
            this.dataGridViewStok.TabIndex = 0;
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(96, 18);
            this.textBoxArama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(298, 26);
            this.textBoxArama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Arama:";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(405, 15);
            this.buttonAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(112, 35);
            this.buttonAra.TabIndex = 3;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(911, 15);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(112, 35);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(789, 15);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(112, 35);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // textBoxYeniStokAdedi
            // 
            this.textBoxYeniStokAdedi.Location = new System.Drawing.Point(670, 20);
            this.textBoxYeniStokAdedi.Name = "textBoxYeniStokAdedi";
            this.textBoxYeniStokAdedi.Size = new System.Drawing.Size(112, 26);
            this.textBoxYeniStokAdedi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yeni Stok Adeti";
            // 
            // StokEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYeniStokAdedi);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.dataGridViewStok);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StokEkrani";
            this.Text = "Stok Ekranı";
            this.Load += new System.EventHandler(this.StokEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewStok;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.TextBox textBoxYeniStokAdedi;
        private System.Windows.Forms.Label label2;
    }
}
