namespace MarketOtomasyon
{
    partial class UrunKayitFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.textBoxUrunKodu = new System.Windows.Forms.TextBox();
            this.numericUpDownFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStokAdedi = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxPaketTipi = new System.Windows.Forms.ComboBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokAdedi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok Adedi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Paket Tipi:";
            // 
            // textBoxUrunAdi
            // 
            this.textBoxUrunAdi.Location = new System.Drawing.Point(165, 18);
            this.textBoxUrunAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrunAdi.Name = "textBoxUrunAdi";
            this.textBoxUrunAdi.Size = new System.Drawing.Size(238, 26);
            this.textBoxUrunAdi.TabIndex = 6;
            // 
            // textBoxUrunKodu
            // 
            this.textBoxUrunKodu.Location = new System.Drawing.Point(165, 65);
            this.textBoxUrunKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUrunKodu.Name = "textBoxUrunKodu";
            this.textBoxUrunKodu.Size = new System.Drawing.Size(238, 26);
            this.textBoxUrunKodu.TabIndex = 7;
            // 
            // numericUpDownFiyat
            // 
            this.numericUpDownFiyat.DecimalPlaces = 2;
            this.numericUpDownFiyat.Location = new System.Drawing.Point(165, 112);
            this.numericUpDownFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownFiyat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownFiyat.Name = "numericUpDownFiyat";
            this.numericUpDownFiyat.Size = new System.Drawing.Size(240, 26);
            this.numericUpDownFiyat.TabIndex = 8;
            // 
            // numericUpDownStokAdedi
            // 
            this.numericUpDownStokAdedi.Location = new System.Drawing.Point(165, 158);
            this.numericUpDownStokAdedi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownStokAdedi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStokAdedi.Name = "numericUpDownStokAdedi";
            this.numericUpDownStokAdedi.Size = new System.Drawing.Size(240, 26);
            this.numericUpDownStokAdedi.TabIndex = 9;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(165, 203);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(238, 28);
            this.comboBoxKategori.TabIndex = 10;
            // 
            // comboBoxPaketTipi
            // 
            this.comboBoxPaketTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaketTipi.FormattingEnabled = true;
            this.comboBoxPaketTipi.Location = new System.Drawing.Point(165, 249);
            this.comboBoxPaketTipi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPaketTipi.Name = "comboBoxPaketTipi";
            this.comboBoxPaketTipi.Size = new System.Drawing.Size(238, 28);
            this.comboBoxPaketTipi.TabIndex = 11;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(292, 308);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(112, 35);
            this.buttonKaydet.TabIndex = 12;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);

            // 
            // UrunKayitFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 371);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.comboBoxPaketTipi);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.numericUpDownStokAdedi);
            this.Controls.Add(this.numericUpDownFiyat);
            this.Controls.Add(this.textBoxUrunKodu);
            this.Controls.Add(this.textBoxUrunAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UrunKayitFormu";
            this.Text = "Ürün Kayıt Formu";
            this.Load += new System.EventHandler(this.UrunKayitFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStokAdedi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUrunAdi;
        private System.Windows.Forms.TextBox textBoxUrunKodu;
        private System.Windows.Forms.NumericUpDown numericUpDownFiyat;
        private System.Windows.Forms.NumericUpDown numericUpDownStokAdedi;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.ComboBox comboBoxPaketTipi;
        private System.Windows.Forms.Button buttonKaydet;
    }
}
