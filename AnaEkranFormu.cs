using System;
using System.Windows.Forms;

namespace MarketOtomasyon
{
    public partial class AnaEkranFormu : Form
    {
        public AnaEkranFormu()
        {
            InitializeComponent();
        }

        private void btnUrunKayit_Click(object sender, EventArgs e)
        {
            UrunKayitFormu urunKayitFormu = new UrunKayitFormu();
            urunKayitFormu.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StokEkrani stokEkrani = new StokEkrani();
            stokEkrani.Show();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            SiparisFormu siparisFormu = new SiparisFormu();
            siparisFormu.Show();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            SatisFormu satisFormu = new SatisFormu();
            satisFormu.Show();
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            ZRaporuFormu zRaporuFormu = new ZRaporuFormu();
            zRaporuFormu.Show();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriIliskileriYonetimiFormu musteriIliskileriFormu = new MusteriIliskileriYonetimiFormu();
            musteriIliskileriFormu.Show();
        }

        private void AnaEkranFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
