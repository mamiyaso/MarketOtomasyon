namespace MarketOtomasyon
{
    partial class SatisFormu
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
            this.dateTimePickerSatisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxToplamTutar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUrunler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.columnUrunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Tarihi:";
            // 
            // dateTimePickerSatisTarihi
            // 
            this.dateTimePickerSatisTarihi.Location = new System.Drawing.Point(123, 18);
            this.dateTimePickerSatisTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerSatisTarihi.Name = "dateTimePickerSatisTarihi";
            this.dateTimePickerSatisTarihi.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerSatisTarihi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ödeme Türü:";
            // 
            // comboBoxOdemeYontemi
            // 
            this.comboBoxOdemeYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdemeYontemi.FormattingEnabled = true;
            this.comboBoxOdemeYontemi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboBoxOdemeYontemi.Location = new System.Drawing.Point(558, 18);
            this.comboBoxOdemeYontemi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOdemeYontemi.Name = "comboBoxOdemeYontemi";
            this.comboBoxOdemeYontemi.Size = new System.Drawing.Size(180, 28);
            this.comboBoxOdemeYontemi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Tutar:";
            // 
            // textBoxToplamTutar
            // 
            this.textBoxToplamTutar.Location = new System.Drawing.Point(558, 104);
            this.textBoxToplamTutar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxToplamTutar.Name = "textBoxToplamTutar";
            this.textBoxToplamTutar.ReadOnly = true;
            this.textBoxToplamTutar.Size = new System.Drawing.Size(148, 26);
            this.textBoxToplamTutar.TabIndex = 5;
            this.textBoxToplamTutar.Text = "0";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(770, 95);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 35);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürünler";
            // 
            // comboBoxUrunler
            // 
            this.comboBoxUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUrunler.FormattingEnabled = true;
            this.comboBoxUrunler.Location = new System.Drawing.Point(123, 61);
            this.comboBoxUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxUrunler.Name = "comboBoxUrunler";
            this.comboBoxUrunler.Size = new System.Drawing.Size(298, 28);
            this.comboBoxUrunler.TabIndex = 8;
            this.comboBoxUrunler.SelectedIndexChanged += new System.EventHandler(this.comboBoxUrunler_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Miktar:";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(82, 113);
            this.textBoxMiktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.Size = new System.Drawing.Size(73, 26);
            this.textBoxMiktar.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birim Fiyatı:";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(309, 104);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(112, 35);
            this.btnUrunSil.TabIndex = 16;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(558, 63);
            this.textBoxFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.ReadOnly = true;
            this.textBoxFiyat.Size = new System.Drawing.Size(73, 26);
            this.textBoxFiyat.TabIndex = 12;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(176, 104);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(112, 35);
            this.btnUrunEkle.TabIndex = 13;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUrunID,
            this.columnUrunAdi,
            this.columnMiktar,
            this.columnFiyat});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.GridLines = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(22, 158);
            this.listViewUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(860, 306);
            this.listViewUrunler.TabIndex = 14;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnUrunID
            // 
            this.columnUrunID.Text = "Ürün ID";
            this.columnUrunID.Width = 80;
            // 
            // columnUrunAdi
            // 
            this.columnUrunAdi.Text = "Ürün Adı";
            this.columnUrunAdi.Width = 200;
            // 
            // columnMiktar
            // 
            this.columnMiktar.Text = "Miktar";
            this.columnMiktar.Width = 80;
            // 
            // columnFiyat
            // 
            this.columnFiyat.Text = "Fiyat";
            this.columnFiyat.Width = 100;
            // 
            // SatisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 495);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxUrunler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.textBoxToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOdemeYontemi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerSatisTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUrunSil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SatisFormu";
            this.Text = "Satış Formu";
            this.Load += new System.EventHandler(this.SatisFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerSatisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOdemeYontemi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxToplamTutar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUrunler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.ColumnHeader columnUrunID;
        private System.Windows.Forms.ColumnHeader columnUrunAdi;
        private System.Windows.Forms.ColumnHeader columnMiktar;
        private System.Windows.Forms.ColumnHeader columnFiyat;
    }
}
