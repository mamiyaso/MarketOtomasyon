namespace MarketOtomasyon
{
    partial class SiparisFormu
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
            this.dataGridViewSiparisler = new System.Windows.Forms.DataGridView();
            this.comboBoxMusteriID = new System.Windows.Forms.ComboBox();
            this.textBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.textBoxMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.dateTimePickerSiparisTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.buttonSiparisiKaydet = new System.Windows.Forms.Button();
            this.buttonSiparisDetayGoruntule = new System.Windows.Forms.Button();
            this.comboBoxUrun = new System.Windows.Forms.ComboBox();
            this.buttonUrunEkle = new System.Windows.Forms.Button();
            this.listViewUrunler = new System.Windows.Forms.ListView();
            this.columnHeaderUrunID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxUrunAdeti = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSiparisler
            // 
            this.dataGridViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisler.Location = new System.Drawing.Point(18, 300);
            this.dataGridViewSiparisler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            this.dataGridViewSiparisler.RowHeadersWidth = 62;
            this.dataGridViewSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSiparisler.Size = new System.Drawing.Size(1164, 374);
            this.dataGridViewSiparisler.TabIndex = 0;
            // 
            // comboBoxMusteriID
            // 
            this.comboBoxMusteriID.FormattingEnabled = true;
            this.comboBoxMusteriID.Location = new System.Drawing.Point(172, 18);
            this.comboBoxMusteriID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxMusteriID.Name = "comboBoxMusteriID";
            this.comboBoxMusteriID.Size = new System.Drawing.Size(298, 28);
            this.comboBoxMusteriID.TabIndex = 1;
            this.comboBoxMusteriID.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusteriID_SelectedIndexChanged);
            // 
            // textBoxMusteriAdi
            // 
            this.textBoxMusteriAdi.Location = new System.Drawing.Point(172, 60);
            this.textBoxMusteriAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMusteriAdi.Name = "textBoxMusteriAdi";
            this.textBoxMusteriAdi.Size = new System.Drawing.Size(298, 26);
            this.textBoxMusteriAdi.TabIndex = 2;
            // 
            // textBoxMusteriSoyadi
            // 
            this.textBoxMusteriSoyadi.Location = new System.Drawing.Point(172, 100);
            this.textBoxMusteriSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMusteriSoyadi.Name = "textBoxMusteriSoyadi";
            this.textBoxMusteriSoyadi.Size = new System.Drawing.Size(298, 26);
            this.textBoxMusteriSoyadi.TabIndex = 3;
            // 
            // dateTimePickerSiparisTarihi
            // 
            this.dateTimePickerSiparisTarihi.Location = new System.Drawing.Point(172, 140);
            this.dateTimePickerSiparisTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerSiparisTarihi.Name = "dateTimePickerSiparisTarihi";
            this.dateTimePickerSiparisTarihi.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerSiparisTarihi.TabIndex = 4;
            // 
            // comboBoxOdemeYontemi
            // 
            this.comboBoxOdemeYontemi.FormattingEnabled = true;
            this.comboBoxOdemeYontemi.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.comboBoxOdemeYontemi.Location = new System.Drawing.Point(172, 180);
            this.comboBoxOdemeYontemi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxOdemeYontemi.Name = "comboBoxOdemeYontemi";
            this.comboBoxOdemeYontemi.Size = new System.Drawing.Size(298, 28);
            this.comboBoxOdemeYontemi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sipariş Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Yöntemi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ürün:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(900, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ürün Sil:";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(980, 62);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(112, 35);
            this.btnUrunSil.TabIndex = 16;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // buttonSiparisiKaydet
            // 
            this.buttonSiparisiKaydet.Location = new System.Drawing.Point(21, 232);
            this.buttonSiparisiKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSiparisiKaydet.Name = "buttonSiparisiKaydet";
            this.buttonSiparisiKaydet.Size = new System.Drawing.Size(164, 35);
            this.buttonSiparisiKaydet.TabIndex = 13;
            this.buttonSiparisiKaydet.Text = "Siparişi Kaydet";
            this.buttonSiparisiKaydet.UseVisualStyleBackColor = true;
            this.buttonSiparisiKaydet.Click += new System.EventHandler(this.buttonSiparisiKaydet_Click);
            // 
            // buttonSiparisDetayGoruntule
            // 
            this.buttonSiparisDetayGoruntule.Location = new System.Drawing.Point(194, 232);
            this.buttonSiparisDetayGoruntule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSiparisDetayGoruntule.Name = "buttonSiparisDetayGoruntule";
            this.buttonSiparisDetayGoruntule.Size = new System.Drawing.Size(164, 35);
            this.buttonSiparisDetayGoruntule.TabIndex = 14;
            this.buttonSiparisDetayGoruntule.Text = "Sipariş Detayını Görüntüle";
            this.buttonSiparisDetayGoruntule.UseVisualStyleBackColor = true;
            this.buttonSiparisDetayGoruntule.Click += new System.EventHandler(this.buttonSiparisDetayGoruntule_Click);
            // 
            // comboBoxUrun
            // 
            this.comboBoxUrun.FormattingEnabled = true;
            this.comboBoxUrun.Location = new System.Drawing.Point(592, 18);
            this.comboBoxUrun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxUrun.Name = "comboBoxUrun";
            this.comboBoxUrun.Size = new System.Drawing.Size(298, 28);
            this.comboBoxUrun.TabIndex = 15;
            // 
            // buttonUrunEkle
            // 
            this.buttonUrunEkle.Location = new System.Drawing.Point(366, 232);
            this.buttonUrunEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUrunEkle.Name = "buttonUrunEkle";
            this.buttonUrunEkle.Size = new System.Drawing.Size(112, 35);
            this.buttonUrunEkle.TabIndex = 17;
            this.buttonUrunEkle.Text = "Ürün Ekle";
            this.buttonUrunEkle.UseVisualStyleBackColor = true;
            this.buttonUrunEkle.Click += new System.EventHandler(this.buttonUrunEkle_Click);
            // 
            // listViewUrunler
            // 
            this.listViewUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUrunID,
            this.columnHeaderUrunAdi,
            this.columnHeaderAdet});
            this.listViewUrunler.FullRowSelect = true;
            this.listViewUrunler.GridLines = true;
            this.listViewUrunler.HideSelection = false;
            this.listViewUrunler.Location = new System.Drawing.Point(558, 120);
            this.listViewUrunler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewUrunler.Name = "listViewUrunler";
            this.listViewUrunler.Size = new System.Drawing.Size(588, 147);
            this.listViewUrunler.TabIndex = 18;
            this.listViewUrunler.UseCompatibleStateImageBehavior = false;
            this.listViewUrunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUrunID
            // 
            this.columnHeaderUrunID.Text = "Ürün ID";
            this.columnHeaderUrunID.Width = 100;
            // 
            // columnHeaderUrunAdi
            // 
            this.columnHeaderUrunAdi.Text = "Ürün Adı";
            this.columnHeaderUrunAdi.Width = 200;
            // 
            // columnHeaderAdet
            // 
            this.columnHeaderAdet.Text = "Adet";
            this.columnHeaderAdet.Width = 89;
            // 
            // textBoxUrunAdeti
            // 
            this.textBoxUrunAdeti.Location = new System.Drawing.Point(592, 65);
            this.textBoxUrunAdeti.Name = "textBoxUrunAdeti";
            this.textBoxUrunAdeti.Size = new System.Drawing.Size(298, 26);
            this.textBoxUrunAdeti.TabIndex = 19;
            // 
            // SiparisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.textBoxUrunAdeti);
            this.Controls.Add(this.listViewUrunler);
            this.Controls.Add(this.buttonUrunEkle);
            this.Controls.Add(this.comboBoxUrun);
            this.Controls.Add(this.buttonSiparisDetayGoruntule);
            this.Controls.Add(this.buttonSiparisiKaydet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOdemeYontemi);
            this.Controls.Add(this.dateTimePickerSiparisTarihi);
            this.Controls.Add(this.textBoxMusteriSoyadi);
            this.Controls.Add(this.textBoxMusteriAdi);
            this.Controls.Add(this.comboBoxMusteriID);
            this.Controls.Add(this.dataGridViewSiparisler);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SiparisFormu";
            this.Text = "Sipariş Formu";
            this.Load += new System.EventHandler(this.SiparisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridViewSiparisler;
        private System.Windows.Forms.ComboBox comboBoxMusteriID;
        private System.Windows.Forms.TextBox textBoxMusteriAdi;
        private System.Windows.Forms.TextBox textBoxMusteriSoyadi;
        private System.Windows.Forms.DateTimePicker dateTimePickerSiparisTarihi;
        private System.Windows.Forms.ComboBox comboBoxOdemeYontemi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSiparisiKaydet;
        private System.Windows.Forms.Button buttonSiparisDetayGoruntule;
        private System.Windows.Forms.ComboBox comboBoxUrun;
        private System.Windows.Forms.Button buttonUrunEkle;
        private System.Windows.Forms.ListView listViewUrunler;
        private System.Windows.Forms.ColumnHeader columnHeaderUrunID;
        private System.Windows.Forms.ColumnHeader columnHeaderUrunAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderAdet;
        private System.Windows.Forms.TextBox textBoxUrunAdeti;
    }
}