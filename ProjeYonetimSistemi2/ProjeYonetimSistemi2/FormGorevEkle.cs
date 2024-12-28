using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjeYonetimSistemi2.Program;

namespace ProjeYonetimSistemi2
{
    public partial class FormGorevEkle : Form
    {
        private string secilenProje;
        public FormGorevEkle(string projeAdi)
        {
            InitializeComponent();
            secilenProje = projeAdi;
        }
        public static List<Gorev> gorevListesi = new List<Gorev>();
        private void button1btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Adım: Çalışan seçimi kontrolü
            if (cmbCalisanSec.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir çalışan seçin!");
                return;
            }

            // Seçilen çalışan bilgisini al
            string secilenCalisan = cmbCalisanSec.SelectedItem.ToString();
            int calisanId = int.Parse(secilenCalisan.Split('-')[0].Trim()); // ID'yi al
            Calisan atananCalisan = GlobalData.CalisanlarListesi.FirstOrDefault(c => c.Id == calisanId);

            if (atananCalisan == null)
            {
                MessageBox.Show("Çalışan bulunamadı!");
                return;
            }

            // 2. Adım: Görev adı kontrolü
            string gorevAdi = txtGorevAdi.Text;
            if (string.IsNullOrWhiteSpace(gorevAdi))
            {
                MessageBox.Show("Lütfen bir görev adı giriniz!");
                return;
            }

            // 3. Adım: Adam-gün kontrolü
            int adamGun = (int)nudAdamGun.Value;
            DateTime baslangicTarihi = dtpGorevBaslangic.Value;
            DateTime bitisTarihi = dtpGorevBitis.Value;

            if (baslangicTarihi >= bitisTarihi)
            {
                MessageBox.Show("Başlangıç tarihi bitiş tarihinden önce olmalıdır!");
                return;
            }

            // 4. Adım: Yeni Görev oluşturma
            Gorev yeniGorev = new Gorev
            (
                labelProjeAdi.Text,   // ProjeAdi
                gorevAdi,             // GorevAdi
                atananCalisan.Ad + " " + atananCalisan.Soyad,  // AtananCalisan (Ad ve Soyad)
                baslangicTarihi,     // BaslangicTarihi
                adamGun,               // AdamGun
                "Tamamlanacak"       // Durum
            );

            GlobalData.GorevlerListesi.Add(yeniGorev);
            // 5. Adım: Görevin başarıyla atandığını bildiren mesaj
            MessageBox.Show($"{yeniGorev.Ad} görevi {atananCalisan.Ad} {atananCalisan.Soyad} çalışana atandı!");

            FormGorevEkle gorevEkleForm = new FormGorevEkle(secilenProje); // yeni formu oluştur
            gorevEkleForm.Owner = this; // Sahip formu ayarla (bu formu owner yap)
            gorevEkleForm.Show(); // Formu göster



            GlobalData.GorevlerListesi.Add(yeniGorev);

            FormGorevAtama gorevAtamaForm = new FormGorevAtama();
            FormGorevEkle gorvEkleForm = new FormGorevEkle(secilenProje);
            gorvEkleForm.Owner = gorevAtamaForm;  // Burada Owner'ı doğru şekilde ayarlayın
            gorvEkleForm.Show();

            FormGorevAtama formGorevAtama = this.Owner as FormGorevAtama;
            if (formGorevAtama != null)
            {
                formGorevAtama.RefreshListView();
            }

            

            this.Close();
        }

        private void FormGorevEkle_Load(object sender, EventArgs e)
        {// ComboBox'ı temizle
            cmbCalisanSec.Items.Clear();

            // Çalışanları doldur
            if (GlobalData.CalisanlarListesi != null && GlobalData.CalisanlarListesi.Count > 0)
            {
                foreach (var calisan in GlobalData.CalisanlarListesi)
                {
                    cmbCalisanSec.Items.Add($"{calisan.Id} - {calisan.Ad} {calisan.Soyad}");
                }
            }
            else
            {
                // Eğer çalışan yoksa uyarı ver
                cmbCalisanSec.Items.Add("Çalışan bulunamadı!");
            }

            // Eğer bir proje seçildiyse, proje adını label'a yaz
            if (!string.IsNullOrEmpty(secilenProje))
            {
                labelProjeAdi.Text = secilenProje;
            }
            else
            {
                labelProjeAdi.Text = "Proje seçilmedi!";
            }

        }

        public void RefreshComboBox()
        {
            cmbCalisanSec.Items.Clear();
            foreach (var calisan in GlobalData.CalisanlarListesi)
            {
                cmbCalisanSec.Items.Add($"{calisan.Id} - {calisan.Ad} {calisan.Soyad}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
