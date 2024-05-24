using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static MarketOtomasyon.dbhelper;

namespace MarketOtomasyon
{
    public partial class MusteriIliskileriYonetimiFormu : Form
    {
        public MusteriIliskileriYonetimiFormu()
        {
            InitializeComponent();
        }

        private void MusteriIliskileriYonetimiFormu_Load(object sender, EventArgs e)
        {
            MusteriListele();
        }

        private void MusteriListele()
        {
            string connectionString = "Data Source=PC\\SQLEXPRESS;Initial Catalog=MarketOtomasyon;Integrated Security=True;";
            string query = "SELECT MusteriID, MusteriAdi, MusteriSoyadi, Telefon FROM Musteriler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMusteriListesi.DataSource = table;
                }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string searchValue = txtMusteriArama.Text;
            string connectionString = "Data Source=PC\\SQLEXPRESS;Initial Catalog=MarketOtomasyon;Integrated Security=True;";
            string query = "SELECT MusteriID, MusteriAdi, MusteriSoyadi, Telefon FROM Musteriler WHERE MusteriAdi LIKE '%' + @search + '%' OR MusteriSoyadi LIKE '%' + @search + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", searchValue);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMusteriListesi.DataSource = table;
                }
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            MusteriEkleFormu musteriEkleFormu = new MusteriEkleFormu();
            musteriEkleFormu.ShowDialog();
            MusteriListele();
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriListesi.SelectedRows.Count > 0)
            {
                int musteriId = Convert.ToInt32(dgvMusteriListesi.SelectedRows[0].Cells[0].Value);
                MusteriGuncelleFormu musteriGuncelleFormu = new MusteriGuncelleFormu(musteriId);
                musteriGuncelleFormu.ShowDialog();
                MusteriListele();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriListesi.SelectedRows.Count > 0)
            {
                int musteriId = Convert.ToInt32(dgvMusteriListesi.SelectedRows[0].Cells[0].Value);
                ConnectionStringProvider provider = new ConnectionStringProvider();
                string connectionString = provider.GetConnectionString();
                string query = "DELETE FROM Musteriler WHERE MusteriID = @MusteriID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MusteriID", musteriId);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MusteriListele();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
