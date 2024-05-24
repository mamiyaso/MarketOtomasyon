using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class SatisFormu : Form
    {
        public SatisFormu()
        {
            InitializeComponent();
        }

        private void SatisFormu_Load(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void UrunleriYukle()
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UrunID, UrunAdi, Fiyat FROM Urunler";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            comboBoxUrunler.DataSource = dt;
                            comboBoxUrunler.DisplayMember = "UrunAdi";
                            comboBoxUrunler.ValueMember = "UrunID";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string insertSatisQuery = "INSERT INTO Satislar (SatisTarihi, OdemeYontemi, ToplamTutar) OUTPUT INSERTED.SatisID VALUES (@SatisTarihi, @OdemeYontemi, @ToplamTutar)";
                            int satisID;
                            using (SqlCommand cmd = new SqlCommand(insertSatisQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@SatisTarihi", dateTimePickerSatisTarihi.Value);
                                cmd.Parameters.AddWithValue("@OdemeYontemi", comboBoxOdemeYontemi.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@ToplamTutar", Convert.ToDecimal(textBoxToplamTutar.Text));

                                satisID = (int)cmd.ExecuteScalar();
                            }

                            string insertDetayQuery = "INSERT INTO SatisDetaylari (SatisID, UrunID, Miktar, Fiyat) VALUES (@SatisID, @UrunID, @Miktar, @Fiyat)";
                            using (SqlCommand cmd = new SqlCommand(insertDetayQuery, conn, transaction))
                            {
                                foreach (ListViewItem item in listViewUrunler.Items)
                                {
                                    cmd.Parameters.Clear();
                                    cmd.Parameters.AddWithValue("@SatisID", satisID);
                                    cmd.Parameters.AddWithValue("@UrunID", Convert.ToInt32(item.SubItems[0].Text));
                                    cmd.Parameters.AddWithValue("@Miktar", Convert.ToInt32(item.SubItems[2].Text));
                                    cmd.Parameters.AddWithValue("@Fiyat", Convert.ToDecimal(item.SubItems[3].Text));
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            string updateStokQuery = "UPDATE Urunler SET Stokadedi = Stokadedi - @Miktar WHERE UrunID = @UrunID AND Stokadedi >= @Miktar";
                            using (SqlCommand checkCmd = new SqlCommand("SELECT Stokadedi FROM Urunler WHERE UrunID = @UrunID", conn, transaction))
                            {
                                foreach (ListViewItem item in listViewUrunler.Items)
                                {
                                    int urunID = Convert.ToInt32(item.SubItems[0].Text);
                                    int miktar = Convert.ToInt32(item.SubItems[2].Text);

                                    checkCmd.Parameters.Clear();
                                    checkCmd.Parameters.AddWithValue("@UrunID", urunID);
                                    int stokMiktari = (int)checkCmd.ExecuteScalar();

                                    if (stokMiktari < miktar)
                                    {
                                        throw new Exception("Stok miktarı yetersiz: " + item.SubItems[1].Text);
                                    }

                                    using (SqlCommand updateCmd = new SqlCommand(updateStokQuery, conn, transaction))
                                    {
                                        updateCmd.Parameters.AddWithValue("@UrunID", urunID);
                                        updateCmd.Parameters.AddWithValue("@Miktar", miktar);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Satış başarıyla kaydedildi.");
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxUrunler.SelectedValue != null && !string.IsNullOrWhiteSpace(textBoxMiktar.Text))
            {
                DataRowView selectedItem = comboBoxUrunler.SelectedItem as DataRowView;
                decimal urunFiyati = Convert.ToDecimal(selectedItem["Fiyat"]);
                int miktar = Convert.ToInt32(textBoxMiktar.Text);
                decimal toplamFiyat = urunFiyati * miktar;

                ListViewItem item = new ListViewItem(comboBoxUrunler.SelectedValue.ToString());
                item.SubItems.Add(comboBoxUrunler.Text);
                item.SubItems.Add(miktar.ToString());
                item.SubItems.Add(toplamFiyat.ToString());
                listViewUrunler.Items.Add(item);

                decimal toplamTutar = Convert.ToDecimal(textBoxToplamTutar.Text);
                toplamTutar += toplamFiyat;
                textBoxToplamTutar.Text = toplamTutar.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen ürün ve miktar bilgilerini eksiksiz girin.");
            }
        }
        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (listViewUrunler.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewUrunler.SelectedItems)
                {
                    listViewUrunler.Items.Remove(item);
                }
                double toplamTutar = 0;
                foreach (ListViewItem item in listViewUrunler.Items)
                {
                    double fiyat = Convert.ToDouble(item.SubItems[3].Text);
                    int miktar = Convert.ToInt32(item.SubItems[2].Text);
                    toplamTutar += fiyat * miktar;
                }
                textBoxToplamTutar.Text = toplamTutar.ToString();
            }
        }

        private void comboBoxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUrunler.SelectedValue != null)
            {
                DataRowView selectedItem = comboBoxUrunler.SelectedItem as DataRowView;
                decimal urunFiyati = Convert.ToDecimal(selectedItem["Fiyat"]);

                textBoxFiyat.Text = urunFiyati.ToString();
            }
        }
    }
}
