namespace MarketOtomasyon
{
    partial class AnaEkranFormu
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
            this.btnUrunKayit = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnZRaporu = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunKayit
            // 
            this.btnUrunKayit.Location = new System.Drawing.Point(64, 67);
            this.btnUrunKayit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUrunKayit.Name = "btnUrunKayit";
            this.btnUrunKayit.Size = new System.Drawing.Size(193, 67);
            this.btnUrunKayit.TabIndex = 0;
            this.btnUrunKayit.Text = "Ürün Kayıt";
            this.btnUrunKayit.UseVisualStyleBackColor = true;
            this.btnUrunKayit.Click += new System.EventHandler(this.btnUrunKayit_Click);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(321, 67);
            this.btnStok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(193, 67);
            this.btnStok.TabIndex = 1;
            this.btnStok.Text = "Stok";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(579, 67);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(193, 67);
            this.btnSiparis.TabIndex = 2;
            this.btnSiparis.Text = "Sipariş";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(64, 200);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(193, 67);
            this.btnSatis.TabIndex = 3;
            this.btnSatis.Text = "Satış";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnZRaporu
            // 
            this.btnZRaporu.Location = new System.Drawing.Point(321, 200);
            this.btnZRaporu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZRaporu.Name = "btnZRaporu";
            this.btnZRaporu.Size = new System.Drawing.Size(193, 67);
            this.btnZRaporu.TabIndex = 4;
            this.btnZRaporu.Text = "Z Raporu";
            this.btnZRaporu.UseVisualStyleBackColor = true;
            this.btnZRaporu.Click += new System.EventHandler(this.btnZRaporu_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(579, 200);
            this.btnMusteriYonetimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(193, 67);
            this.btnMusteriYonetimi.TabIndex = 5;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // AnaEkranFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 352);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnZRaporu);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnUrunKayit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnaEkranFormu";
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.AnaEkranFormu_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnUrunKayit;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnZRaporu;
        private System.Windows.Forms.Button btnMusteriYonetimi;
    }
}
