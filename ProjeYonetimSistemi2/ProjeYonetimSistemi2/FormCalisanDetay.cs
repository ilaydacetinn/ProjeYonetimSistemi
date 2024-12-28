using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeYonetimSistemi2
{
    public partial class FormCalisanDetay : Form
    {
        public Calisan SeciliCalisan { get; set; }
        public List<Gorev> GorevListesi { get; set; }
        public FormCalisanDetay()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listViewGorevler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCalisanDetay_Load(object sender, EventArgs e)
        {
            if (SeciliCalisan == null || GorevListesi == null)
            {
                MessageBox.Show("Çalışan detayları yüklenemedi!");
                return;
            }

            // Çalışan bilgilerini göster
            lblCalisanAdi.Text = $"Ad: {SeciliCalisan.Ad}";
            lblCalisanSoyadi.Text = $"Soyad: {SeciliCalisan.Soyad}";

            // Görev istatistiklerini hesapla
            var calisanGorevleri = GorevListesi.Where(g => g.CalisanId == SeciliCalisan.Id).ToList();
            int tamamlanan = calisanGorevleri.Count(g => g.Durum == "Tamamlandı");
            int devamEden = calisanGorevleri.Count(g => g.Durum == "Devam Ediyor");
            int tamamlanacak = calisanGorevleri.Count(g => g.Durum == "Tamamlanacak");

            lblGorevIstatistikleri.Text = $"Tamamlanan: {tamamlanan}, Devam Eden: {devamEden}, Tamamlanacak: {tamamlanacak}";

            // Görev detaylarını listele
            foreach (var gorev in calisanGorevleri)
            {
                ListViewItem item = new ListViewItem(gorev.ProjeAdi);
                item.SubItems.Add(gorev.Ad);
                item.SubItems.Add(gorev.BaslangicTarihi.ToShortDateString());
                item.SubItems.Add(gorev.BitisTarihi.ToShortDateString());
                item.SubItems.Add(gorev.Durum);
                listViewGorevler.Items.Add(item);
            }
        }
    }
}
