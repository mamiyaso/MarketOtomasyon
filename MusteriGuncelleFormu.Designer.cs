namespace MarketOtomasyon
{
    partial class MusteriGuncelleFormu
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
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.lblMusteriSoyadi = new System.Windows.Forms.Label();
            this.txtMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.chkIletisimOnayi = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(30, 30);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(71, 15);
            this.lblMusteriAdi.TabIndex = 0;
            this.lblMusteriAdi.Text = "Müşteri Adı:";
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(120, 27);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(150, 23);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // lblMusteriSoyadi
            // 
            this.lblMusteriSoyadi.AutoSize = true;
            this.lblMusteriSoyadi.Location = new System.Drawing.Point(30, 70);
            this.lblMusteriSoyadi.Name = "lblMusteriSoyadi";
            this.lblMusteriSoyadi.Size = new System.Drawing.Size(88, 15);
            this.lblMusteriSoyadi.TabIndex = 2;
            this.lblMusteriSoyadi.Text = "Müşteri Soyadı:";
            // 
            // txtMusteriSoyadi
            // 
            this.txtMusteriSoyadi.Location = new System.Drawing.Point(120, 67);
            this.txtMusteriSoyadi.Name = "txtMusteriSoyadi";
            this.txtMusteriSoyadi.Size = new System.Drawing.Size(150, 23);
            this.txtMusteriSoyadi.TabIndex = 3;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 110);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(52, 15);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 107);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 23);
            this.txtTelefon.TabIndex = 5;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(30, 150);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(40, 15);
            this.lblAdres.TabIndex = 6;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(120, 147);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 23);
            this.txtAdres.TabIndex = 7;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(30, 190);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(49, 15);
            this.lblEposta.TabIndex = 8;
            this.lblEposta.Text = "E-posta:";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(120, 187);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(150, 23);
            this.txtEposta.TabIndex = 9;
            // 
            // chkIletisimOnayi
            // 
            this.chkIletisimOnayi.AutoSize = true;
            this.chkIletisimOnayi.Location = new System.Drawing.Point(120, 227);
            this.chkIletisimOnayi.Name = "chkIletisimOnayi";
            this.chkIletisimOnayi.Size = new System.Drawing.Size(140, 19);
            this.chkIletisimOnayi.TabIndex = 10;
            this.chkIletisimOnayi.Text = "İletişim Onayı Veriyor";
            this.chkIletisimOnayi.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 270);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 30);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // MusteriGuncelleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.chkIletisimOnayi);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtMusteriSoyadi);
            this.Controls.Add(this.lblMusteriSoyadi);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblMusteriAdi);
            this.Name = "MusteriGuncelleFormu";
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.MusteriGuncelleFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblMusteriSoyadi;
        private System.Windows.Forms.TextBox txtMusteriSoyadi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.CheckBox chkIletisimOnayi;
        private System.Windows.Forms.Button btnGuncelle;
    }
}
