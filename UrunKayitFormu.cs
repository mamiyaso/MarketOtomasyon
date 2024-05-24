using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class UrunKayitFormu : Form
    {
        public UrunKayitFormu()
        {
            InitializeComponent();
        }

        private void UrunKayitFormu_Load(object sender, EventArgs e)
        {
            comboBoxKategori.Items.AddRange(new string[] { "Meyve Sebze",
                "Süt Ürünleri",
                "Tahıl Ürünleri",
                "Et ve Et Ürünleri",
                "Bakliyat",
                "Şekerleme ve Çikolata",
                "İçecekler",
                "Temizlik Ürünleri",
                "Kişisel Bakım Ürünleri"  });
            comboBoxPaketTipi.Items.AddRange(new string[] { "kg", "gr", "adet", "litre", "ml" });

            comboBoxKategori.SelectedIndex = 0;
            comboBoxPaketTipi.SelectedIndex = 0;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Urunler (UrunAdi, UrunKodu, Fiyat, StokAdedi, Kategori, PaketTipi) VALUES (@UrunAdi, @UrunKodu, @Fiyat, @StokAdedi, @Kategori, @PaketTipi)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunAdi", textBoxUrunAdi.Text);
                        cmd.Parameters.AddWithValue("@UrunKodu", textBoxUrunKodu.Text);
                        cmd.Parameters.AddWithValue("@Fiyat", numericUpDownFiyat.Value);
                        cmd.Parameters.AddWithValue("@StokAdedi", numericUpDownStokAdedi.Value);
                        cmd.Parameters.AddWithValue("@Kategori", comboBoxKategori.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PaketTipi", comboBoxPaketTipi.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklendi!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
