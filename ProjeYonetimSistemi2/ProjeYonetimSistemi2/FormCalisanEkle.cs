using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjeYonetimSistemi2;
using static ProjeYonetimSistemi2.Program;




namespace ProjeYonetimSistemi2
{
    public partial class FormCalisanEkle : Form
    {
        public Calisan Calisan { get; set; }
        public FormCalisanEkle()
        {
            InitializeComponent();
        }


        private void FormCalisanEkle_Load(object sender, EventArgs e)
        {
            if (Calisan != null)
            {
                // Form üzerindeki alanlara mevcut çalışan bilgilerini doldur
                txtAd.Text = Calisan.Ad;
                txtSoyad.Text = Calisan.Soyad;
            }
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            // Çalışan bilgilerini TextBox'lardan al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;


            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            Calisan yeniCalisan = new Calisan
            {
                Id = GlobalData.CalisanlarListesi.Count + 1,
                Ad = ad,
                Soyad = soyad,
            };

            // Çalışan bilgilerini oluştur ve döndür
            Calisan = new Calisan
            {
                
                Ad = ad,
                Soyad = soyad,

            };

            GlobalData.CalisanlarListesi.Add(yeniCalisan);
            MessageBox.Show($"{yeniCalisan.Ad} {yeniCalisan.Soyad} başarıyla eklendi!");

            DialogResult = DialogResult.OK; // Formu başarıyla kapat
            Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
