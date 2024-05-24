using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class MusteriGuncelleFormu : Form
    {
        private int _musteriId;

        public MusteriGuncelleFormu(int musteriId)
        {
            InitializeComponent();
            _musteriId = musteriId;
        }

        private void MusteriGuncelleFormu_Load(object sender, EventArgs e)
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();
            string query = "SELECT MusteriAdi, MusteriSoyadi, Telefon, Adres, Eposta, IletisimOnayi FROM Musteriler WHERE MusteriID = @MusteriID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MusteriID", _musteriId);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMusteriAdi.Text = reader["MusteriAdi"].ToString();
                                txtMusteriSoyadi.Text = reader["MusteriSoyadi"].ToString();
                                txtTelefon.Text = reader["Telefon"].ToString();
                                txtAdres.Text = reader["Adres"].ToString();
                                txtEposta.Text = reader["Eposta"].ToString();
                                chkIletisimOnayi.Checked = (bool)reader["IletisimOnayi"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Müşteri bilgileri yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();
            string query = "UPDATE Musteriler SET MusteriAdi = @MusteriAdi, MusteriSoyadi = @MusteriSoyadi, Telefon = @Telefon, Adres = @Adres, Eposta = @Eposta, IletisimOnayi = @IletisimOnayi WHERE MusteriID = @MusteriID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MusteriID", _musteriId);
                    command.Parameters.AddWithValue("@MusteriAdi", txtMusteriAdi.Text);
                    command.Parameters.AddWithValue("@MusteriSoyadi", txtMusteriSoyadi.Text);
                    command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
                    command.Parameters.AddWithValue("@Adres", txtAdres.Text);
                    command.Parameters.AddWithValue("@Eposta", txtEposta.Text);
                    command.Parameters.AddWithValue("@IletisimOnayi", chkIletisimOnayi.Checked ? 1 : 0);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Müşteri güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
