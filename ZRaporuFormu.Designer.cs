namespace MarketOtomasyon
{
    partial class ZRaporuFormu
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
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dgvZRaporu = new System.Windows.Forms.DataGridView();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtSatisSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZRaporu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(141, 20);
            this.dtpBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(256, 26);
            this.dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(141, 60);
            this.dtpBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(256, 26);
            this.dtpBitis.TabIndex = 1;
            // 
            // btnRaporla
            // 
            this.btnRaporla.Location = new System.Drawing.Point(424, 40);
            this.btnRaporla.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(129, 40);
            this.btnRaporla.TabIndex = 2;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = true;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dgvZRaporu
            // 
            this.dgvZRaporu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZRaporu.Location = new System.Drawing.Point(19, 111);
            this.dgvZRaporu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZRaporu.Name = "dgvZRaporu";
            this.dgvZRaporu.RowHeadersWidth = 62;
            this.dgvZRaporu.Size = new System.Drawing.Size(977, 467);
            this.dgvZRaporu.TabIndex = 3;
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(15, 28);
            this.lblBaslangic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(124, 20);
            this.lblBaslangic.TabIndex = 4;
            this.lblBaslangic.Text = "Başlangıç Tarihi:";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(15, 68);
            this.lblBitis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(85, 20);
            this.lblBitis.TabIndex = 5;
            this.lblBitis.Text = "Bitiş Tarihi:";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(15, 613);
            this.lblToplamSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(105, 20);
            this.lblToplamSatis.TabIndex = 6;
            this.lblToplamSatis.Text = "Toplam Satış:";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(141, 609);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(256, 26);
            this.txtToplamTutar.TabIndex = 7;
            // 
            // txtSatisSayisi
            // 
            this.txtSatisSayisi.Location = new System.Drawing.Point(608, 610);
            this.txtSatisSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatisSayisi.Name = "txtSatisSayisi";
            this.txtSatisSayisi.ReadOnly = true;
            this.txtSatisSayisi.Size = new System.Drawing.Size(256, 26);
            this.txtSatisSayisi.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 615);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Günlük Satış Sayısı";
            // 
            // ZRaporuFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSatisSayisi);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.dgvZRaporu);
            this.Controls.Add(this.btnRaporla);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZRaporuFormu";
            this.Text = "Z Raporu";
            this.Load += new System.EventHandler(this.ZRaporuFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZRaporu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.DataGridView dgvZRaporu;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtSatisSayisi;
        private System.Windows.Forms.Label label1;
    }
}
