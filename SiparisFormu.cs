using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class SiparisFormu : Form
    {
        public SiparisFormu()
        {
            InitializeComponent();
        }

        private void SiparisFormu_Load(object sender, EventArgs e)
        {
            SiparisListesiniYukle();
            MusteriBilgileriniYukle();
            UrunBilgileriniYukle();
        }

        private void MusteriBilgileriniYukle()
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MusteriID FROM Musteriler";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBoxMusteriID.Items.Add(dr["MusteriID"].ToString());
                        }
                    }
                }
            }
        }
        private void SiparisListesiniYukle()
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SiparisID, MusteriID, SiparisTarihi, OdemeYontemi FROM Siparisler";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewSiparisler.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void UrunBilgileriniYukle()
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT UrunID, UrunAdi FROM Urunler";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBoxUrun.Items.Add(new ComboBoxItem { Text = dr["UrunAdi"].ToString(), Value = dr["UrunID"].ToString() });
                        }
                    }
                }
            }
        }

        private void comboBoxMusteriID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string musteriID = comboBoxMusteriID.SelectedItem.ToString();
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MusteriAdi, MusteriSoyadi FROM Musteriler WHERE MusteriID = @MusteriID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            textBoxMusteriAdi.Text = dr["MusteriAdi"].ToString();
                            textBoxMusteriSoyadi.Text = dr["MusteriSoyadi"].ToString();
                        }
                    }
                }
            }
        }

        private void buttonUrunEkle_Click(object sender, EventArgs e)
        {
            var selectedItem = comboBoxUrun.SelectedItem as ComboBoxItem;
            if (selectedItem != null)
            {
                string urunID = selectedItem.Value;
                string urunAdi = selectedItem.Text;
                string adet = textBoxUrunAdeti.Text;

                ListViewItem item = new ListViewItem(urunID);
                item.SubItems.Add(urunAdi);
                item.SubItems.Add(adet);
                listViewUrunler.Items.Add(item);

                comboBoxUrun.SelectedIndex = -1;
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
            }
        }

        private void buttonSiparisiKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string siparisQuery = "INSERT INTO Siparisler (MusteriID, SiparisTarihi, OdemeYontemi) OUTPUT INSERTED.SiparisID VALUES (@MusteriID, @SiparisTarihi, @OdemeYontemi)";
                    int siparisID;
                    using (SqlCommand siparisCmd = new SqlCommand(siparisQuery, conn))
                    {
                        siparisCmd.Parameters.AddWithValue("@MusteriID", comboBoxMusteriID.SelectedItem.ToString());
                        siparisCmd.Parameters.AddWithValue("@SiparisTarihi", dateTimePickerSiparisTarihi.Value);
                        siparisCmd.Parameters.AddWithValue("@OdemeYontemi", comboBoxOdemeYontemi.SelectedItem.ToString());
                        siparisID = (int)siparisCmd.ExecuteScalar();
                    }

                    foreach (ListViewItem item in listViewUrunler.Items)
                    {
                        string urunID = item.SubItems[0].Text;
                        int miktar = int.Parse(item.SubItems[2].Text);

                        // Ürünün fiyatını veritabanından alın
                        decimal fiyat;
                        string fiyatQuery = "SELECT Fiyat FROM Urunler WHERE UrunID = @UrunID";
                        using (SqlCommand fiyatCmd = new SqlCommand(fiyatQuery, conn))
                        {
                            fiyatCmd.Parameters.AddWithValue("@UrunID", urunID);
                            fiyat = (decimal)fiyatCmd.ExecuteScalar();
                        }

                        string siparisDetayQuery = "INSERT INTO SiparisDetaylari (SiparisID, UrunID, Miktar, Fiyat) VALUES (@SiparisID, @UrunID, @Miktar, @Fiyat)";
                        using (SqlCommand siparisDetayCmd = new SqlCommand(siparisDetayQuery, conn))
                        {
                            siparisDetayCmd.Parameters.AddWithValue("@SiparisID", siparisID);
                            siparisDetayCmd.Parameters.AddWithValue("@UrunID", urunID);
                            siparisDetayCmd.Parameters.AddWithValue("@Miktar", miktar);
                            siparisDetayCmd.Parameters.AddWithValue("@Fiyat", fiyat);
                            siparisDetayCmd.ExecuteNonQuery();
                        }
                    }

                    string updateStokQuery = "UPDATE Urunler SET Stokadedi = Stokadedi - @Miktar WHERE UrunID = @UrunID AND Stokadedi >= @Miktar";
                    string checkStokQuery = "SELECT Stokadedi FROM Urunler WHERE UrunID = @UrunID";
                    using (SqlCommand cmd = new SqlCommand(checkStokQuery, conn))
                    {
                        foreach (ListViewItem item in listViewUrunler.Items)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@UrunID", item.SubItems[0].Text);
                            int stokMiktari = (int)cmd.ExecuteScalar();

                            int satilanMiktar = Convert.ToInt32(item.SubItems[2].Text);
                            if (stokMiktari < satilanMiktar)
                            {
                                throw new Exception("Stok miktarı yetersiz: " + item.SubItems[1].Text);
                            }

                            using (SqlCommand updateCmd = new SqlCommand(updateStokQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@UrunID", item.SubItems[0].Text);
                                updateCmd.Parameters.AddWithValue("@Miktar", satilanMiktar);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Sipariş başarıyla kaydedildi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void buttonSiparisDetayGoruntule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count > 0)
            {
                int siparisID = Convert.ToInt32(dataGridViewSiparisler.SelectedRows[0].Cells["SiparisID"].Value);
                SiparisDetayFormu detayFormu = new SiparisDetayFormu(siparisID);
                detayFormu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Detaylarını görmek için bir sipariş seçin.");
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public string Fiyat { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}