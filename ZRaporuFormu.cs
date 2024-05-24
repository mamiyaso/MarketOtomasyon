using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class ZRaporuFormu : Form
    {
        public ZRaporuFormu()
        {
            InitializeComponent();
        }
        private void ZRaporuFormu_Load(object sender, EventArgs e)
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString(); string query = @"
                SELECT u.UrunAdi, 
                SUM(sd.Miktar) AS ToplamAdet, 
                SUM(sd.Miktar * sd.Fiyat) AS ToplamSatis
                FROM Satislar s
                INNER JOIN SatisDetaylari sd ON s.SatisID = sd.SatisID
                INNER JOIN Urunler u ON sd.UrunID = u.UrunID
                WHERE s.SatisTarihi BETWEEN @BaslangicTarihi AND @BitisTarihi
                GROUP BY u.UrunAdi;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@BaslangicTarihi", dtpBaslangic.Value);
                    adapter.SelectCommand.Parameters.AddWithValue("@BitisTarihi", dtpBitis.Value);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvZRaporu.DataSource = dt;

                    decimal toplamSatis = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        toplamSatis += Convert.ToDecimal(row["ToplamSatis"]);
                    }

                    txtToplamTutar.Text = toplamSatis.ToString("C2");

                }
            }
        }

        private void btnRaporla_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string querySatisSayisi = "SELECT COUNT(*) AS SatisSayisi FROM Satislar WHERE SatisTarihi BETWEEN @Baslangic AND @Bitis";
                    using (SqlCommand cmdSatisSayisi = new SqlCommand(querySatisSayisi, conn))
                    {
                        cmdSatisSayisi.Parameters.AddWithValue("@Baslangic", dtpBaslangic.Value.Date);
                        cmdSatisSayisi.Parameters.AddWithValue("@Bitis", dtpBitis.Value.Date.AddDays(1));
                        using (SqlDataAdapter daSatisSayisi = new SqlDataAdapter(cmdSatisSayisi))
                        {
                            DataTable dtSatisSayisi = new DataTable();
                            daSatisSayisi.Fill(dtSatisSayisi);

                            if (dtSatisSayisi.Rows.Count > 0)
                            {
                                int satisSayisi = Convert.ToInt32(dtSatisSayisi.Rows[0]["SatisSayisi"]);
                                txtSatisSayisi.Text = satisSayisi.ToString();
                            }
                            else
                            {
                                txtSatisSayisi.Text = "0";
                            }
                        }
                    }
                    string queryToplamTutar = "SELECT SUM(ToplamTutar) AS ToplamTutar FROM Satislar WHERE SatisTarihi BETWEEN @Baslangic AND @Bitis";
                    using (SqlCommand cmdToplamTutar = new SqlCommand(queryToplamTutar, conn))
                    {
                        cmdToplamTutar.Parameters.AddWithValue("@Baslangic", dtpBaslangic.Value.Date);
                        cmdToplamTutar.Parameters.AddWithValue("@Bitis", dtpBitis.Value.Date.AddDays(1));
                        using (SqlDataAdapter daToplamTutar = new SqlDataAdapter(cmdToplamTutar))
                        {
                            DataTable dtToplamTutar = new DataTable();
                            daToplamTutar.Fill(dtToplamTutar);

                            if (dtToplamTutar.Rows.Count > 0)
                            {
                                decimal toplamTutar = Convert.ToDecimal(dtToplamTutar.Rows[0]["ToplamTutar"]);
                                txtToplamTutar.Text = toplamTutar.ToString("C2"); 
                            }
                            else
                            {
                                txtToplamTutar.Text = "0";
                            }
                        }
                    }
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SatisID, SatisTarihi, ToplamTutar FROM Satislar WHERE SatisTarihi BETWEEN @Baslangic AND @Bitis";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Baslangic", dtpBaslangic.Value.Date);
                        cmd.Parameters.AddWithValue("@Bitis", dtpBitis.Value.Date.AddDays(1));
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvZRaporu.DataSource = dt;
                        }
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

