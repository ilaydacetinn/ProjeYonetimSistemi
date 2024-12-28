using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeYonetimSistemi2;  // Calisan sınıfı bu namespace içinde tanımlandıysa



namespace ProjeYonetimSistemi2
{
    public partial class FormCalısanYonetimi : Form
    {
        // CalisanlarListesi adında bir liste tanımlıyoruz
        private List<Calisan> CalisanlarListesi;
        private List<Gorev> GorevListesi;
        public FormCalısanYonetimi()
        {
            InitializeComponent();

            CalisanlarListesi = new List<Calisan>();
            GorevListesi = new List<Gorev>();
        }

        private void listViewCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCalisanlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen detaylarını görmek istediğiniz çalışanı seçin!");
                return;
            }

            // Seçili çalışanın bilgilerini al
            ListViewItem selectedItem = listViewCalisanlar.SelectedItems[0];
            string calisanAdi = selectedItem.Text; // Çalışanın adı
            string calisanSoyadi = selectedItem.SubItems[1].Text; // Çalışanın soyadı

            // Çalışan nesnesini bul
            Calisan seciliCalisan = CalisanlarListesi.FirstOrDefault(
                c => c.Ad == calisanAdi && c.Soyad == calisanSoyadi);

            if (seciliCalisan == null)
            {
                MessageBox.Show("Çalışan bulunamadı!");
                return;
            }

            // Detay formunu aç
            FormCalisanDetay detayForm = new FormCalisanDetay
            {
                SeciliCalisan = seciliCalisan, // Seçili çalışanı gönder
                GorevListesi = GorevListesi // Görev listesini gönder
            };
            detayForm.ShowDialog();
        }

        private void FormCalısanYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniCalisan_Click(object sender, EventArgs e)
        {
            FormCalisanEkle calisanEkleForm = new FormCalisanEkle();
            if (calisanEkleForm.ShowDialog() == DialogResult.OK) // Kaydet butonuna basıldıysa
            {
                // Yeni çalışan bilgilerini al ve listeye ekle
                Calisan yeniCalisan = calisanEkleForm.Calisan;
                CalisanlarListesi.Add(yeniCalisan);
                CalisanlariListele(); // Listeyi güncelle
            }
        }

        // Listeyi görselleştirmek için bir metot ekleyebilirsiniz
        private void CalisanlariListele()
        {
            // Bu metodda listeyi, örneğin bir ListView ya da başka bir kontrol üzerinde gösterebilirsiniz.
            listViewCalisanlar.Items.Clear();

            foreach (Calisan calisan in CalisanlarListesi)
            {
                // ListView'ye çalışan bilgilerini ekleme örneği
                ListViewItem item = new ListViewItem(calisan.Ad);
                item.SubItems.Add(calisan.Soyad);

                listViewCalisanlar.Items.Add(item);
            }
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (listViewCalisanlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz çalışanı seçin!");
                return;
            }

            // Seçili çalışanın bilgilerini al
            ListViewItem selectedItem = listViewCalisanlar.SelectedItems[0];
            string calisanAdi = selectedItem.Text; // Çalışanın adı (ilk sütun)
            string calisanSoyadi = selectedItem.SubItems[1].Text; // Çalışanın soyadı (ikinci sütun)

            // Çalışanı liste(backend)den sil
            Calisan silinecekCalisan = CalisanlarListesi.FirstOrDefault(
                c => c.Ad == calisanAdi && c.Soyad == calisanSoyadi);

            if (silinecekCalisan != null)
            {
                CalisanlarListesi.Remove(silinecekCalisan); // Listeden kaldır
                MessageBox.Show($"{calisanAdi} {calisanSoyadi} başarıyla silindi!");
                CalisanlariListele(); // ListView'i güncelle
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız oldu. Çalışan bulunamadı.");
            }
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            if (listViewCalisanlar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz çalışanı seçin!");
                return;
            }

            // Seçili çalışanın bilgilerini al
            ListViewItem selectedItem = listViewCalisanlar.SelectedItems[0];
            string calisanAdi = selectedItem.Text; // Çalışanın adı (ilk sütun)
            string calisanSoyadi = selectedItem.SubItems[1].Text; // Çalışanın soyadı (ikinci sütun)

            // Güncellenecek çalışanın mevcut bilgilerini bul
            Calisan guncellenecekCalisan = CalisanlarListesi.FirstOrDefault(
                c => c.Ad == calisanAdi && c.Soyad == calisanSoyadi);

            if (guncellenecekCalisan == null)
            {
                MessageBox.Show("Güncelleme işlemi başarısız oldu. Çalışan bulunamadı.");
                return;
            }

            // Çalışan bilgilerini düzenlemek için bir form aç
            FormCalisanEkle guncelleForm = new FormCalisanEkle
            {
                Text = "Çalışan Güncelle",
                Calisan = new Calisan // Mevcut bilgileri forma gönder
                {
                    Ad = guncellenecekCalisan.Ad,
                    Soyad = guncellenecekCalisan.Soyad,
                    
                }
            };

            if (guncelleForm.ShowDialog() == DialogResult.OK) // Güncelleme işlemi tamamlandıysa
            {
                // Yeni bilgileri çalışana uygula
                guncellenecekCalisan.Ad = guncelleForm.Calisan.Ad;
                guncellenecekCalisan.Soyad = guncelleForm.Calisan.Soyad;
                

                MessageBox.Show("Çalışan başarıyla güncellendi!");
                CalisanlariListele(); // ListView'i güncelle
            }
        }
    }
}
