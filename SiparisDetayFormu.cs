using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class SiparisDetayFormu : Form
    {
        private int siparisID;

        public SiparisDetayFormu(int siparisID)
        {
            this.siparisID = siparisID;
            InitializeComponent();
        }

        private void SiparisDetayFormu_Load(object sender, EventArgs e)
        {
            textBoxSiparisID.Text = siparisID.ToString();
            SiparisDetaylariniYukle();
        }

        private void SiparisDetaylariniYukle()
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UrunID, Miktar, Fiyat, (Miktar * Fiyat) AS Tutar FROM SiparisDetaylari WHERE SiparisID = @SiparisID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SiparisID", siparisID);
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewSiparisDetaylari.DataSource = dt;
                            decimal toplamTutar = 0;

                            foreach (DataRow row in dt.Rows)
                            {
                                toplamTutar += Convert.ToDecimal(row["Tutar"]);
                            }

                            labelToplamTutar.Text = "Toplam Tutar: " + toplamTutar.ToString("C2");
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
