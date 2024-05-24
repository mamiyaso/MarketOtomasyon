namespace MarketOtomasyon
{
    partial class SiparisDetayFormu
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
        private System.Windows.Forms.DataGridView dataGridViewSiparisDetaylari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSiparisID;
        private System.Windows.Forms.Label labelToplamTutar; // Yeni eklenen label

        private void InitializeComponent()
        {
            this.dataGridViewSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSiparisID = new System.Windows.Forms.TextBox();
            this.labelToplamTutar = new System.Windows.Forms.Label(); // Yeni eklenen label

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetaylari)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewSiparisDetaylari
            // 
            this.dataGridViewSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparisDetaylari.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewSiparisDetaylari.Name = "dataGridViewSiparisDetaylari";
            this.dataGridViewSiparisDetaylari.Size = new System.Drawing.Size(760, 300);
            this.dataGridViewSiparisDetaylari.TabIndex = 0;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sipariş ID:";

            // 
            // textBoxSiparisID
            // 
            this.textBoxSiparisID.Location = new System.Drawing.Point(75, 12);
            this.textBoxSiparisID.Name = "textBoxSiparisID";
            this.textBoxSiparisID.ReadOnly = true;
            this.textBoxSiparisID.Size = new System.Drawing.Size(100, 20);
            this.textBoxSiparisID.TabIndex = 2;

            // 
            // labelToplamTutar
            // 
            this.labelToplamTutar.AutoSize = true;
            this.labelToplamTutar.Location = new System.Drawing.Point(200, 15);
            this.labelToplamTutar.Name = "labelToplamTutar";
            this.labelToplamTutar.Size = new System.Drawing.Size(80, 13);
            this.labelToplamTutar.TabIndex = 3;
            this.labelToplamTutar.Text = "Toplam Tutar: 0"; // Başlangıç değeri

            // 
            // SiparisDetayFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.labelToplamTutar); // Yeni eklenen label
            this.Controls.Add(this.textBoxSiparisID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSiparisDetaylari);
            this.Name = "SiparisDetayFormu";
            this.Text = "Sipariş Detay Formu";
            this.Load += new System.EventHandler(this.SiparisDetayFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}