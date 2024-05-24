using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class MusteriEkleFormu : Form
    {
        public MusteriEkleFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            ConnectionStringProvider provider = new ConnectionStringProvider();
            string connectionString = provider.GetConnectionString();
            string query = "INSERT INTO Musteriler (MusteriAdi, MusteriSoyadi, Telefon, Adres, Eposta, IletisimOnayi) VALUES (@MusteriAdi, @MusteriSoyadi, @Telefon, @Adres, @Eposta, @IletisimOnayi)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
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
                        MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Müşteri eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void MusteriEkleFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
