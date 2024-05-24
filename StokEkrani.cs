using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class StokEkrani : Form
    {
        public StokEkrani()
        {
            InitializeComponent();
        }

        private void StokEkrani_Load(object sender, EventArgs e)
        {
            StokListesiniYukle();
        }

        private void StokListesiniYukle(string arama = "")
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UrunID, UrunAdi, UrunKodu, Fiyat, Kategori, StokAdedi FROM Urunler";
                    if (!string.IsNullOrEmpty(arama))
                    {
                        query += " WHERE UrunAdi LIKE @arama";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(arama))
                        {
                            cmd.Parameters.AddWithValue("@arama", "%" + arama + "%");
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewStok.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            StokListesiniYukle(textBoxArama.Text);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewStok.SelectedRows.Count > 0)
            {
                int urunID = Convert.ToInt32(dataGridViewStok.SelectedRows[0].Cells["UrunID"].Value);

                int yeniStokAdedi;
                if (!int.TryParse(textBoxYeniStokAdedi.Text, out yeniStokAdedi))
                {
                    MessageBox.Show("Lütfen geçerli bir stok adedi girin.");
                    return;
                }

                try
                {
                    ConnectionStringProvider provider = new ConnectionStringProvider();
                    string connectionString = provider.GetConnectionString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Urunler SET StokAdedi = @StokAdedi WHERE UrunID = @UrunID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@StokAdedi", yeniStokAdedi);
                            cmd.Parameters.AddWithValue("@UrunID", urunID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Stok başarıyla güncellendi!");
                            StokListesiniYukle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir ürün seçin.");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewStok.SelectedRows.Count > 0)
            {
                int urunID = Convert.ToInt32(dataGridViewStok.SelectedRows[0].Cells["UrunID"].Value);

                try
                {
                    ConnectionStringProvider provider = new ConnectionStringProvider();
                    string connectionString = provider.GetConnectionString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Urunler WHERE UrunID = @UrunID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@UrunID", urunID);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Ürün başarıyla silindi!");
                            StokListesiniYukle();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir ürün seçin.");
            }
        }
    }
}
