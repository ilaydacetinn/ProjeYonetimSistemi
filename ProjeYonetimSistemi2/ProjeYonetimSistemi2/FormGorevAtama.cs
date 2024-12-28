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
    public partial class FormGorevAtama : Form
    {
        private ComboBox cmbGorev;
        private List<Gorev> gorevler = new List<Gorev>();
        public FormGorevAtama()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormGorevAtama_Load(object sender, EventArgs e)
        {
            GorevleriListele();
        }

        private void GorevleriListele()
        {

            listViewGorevler.Items.Clear();

            // Örnek görev listesi (Veritabanından veya başka bir kaynaktan alınacak)
            List<Gorev> gorevler = new List<Gorev>
        {
            new Gorev { Adi = "Görev 1", BaslangicTarihi = DateTime.Now, BitisTarihi = DateTime.Now.AddDays(2), Durum = "Tamamlanacak" },
            new Gorev { Adi = "Görev 2", BaslangicTarihi = DateTime.Now, BitisTarihi = DateTime.Now.AddDays(5), Durum = "Devam Ediyor" }
        };

            foreach (var gorev in gorevler)
            {
                ListViewItem item = new ListViewItem(gorev.Adi);
                item.SubItems.Add(gorev.BaslangicTarihi.ToShortDateString());
                item.SubItems.Add(gorev.BitisTarihi.ToShortDateString());
                item.SubItems.Add(gorev.Durum);
                listViewGorevler.Items.Add(item);
            }
        }

        public class Gorev
        {
            public string Adi { get; set; }  // Görev Adı
            public DateTime BaslangicTarihi { get; set; }  // Başlangıç Tarihi
            public DateTime BitisTarihi { get; set; }  // Bitiş Tarihi
            public string Durum { get; set; }  // Görev Durumu
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
           

            if (listViewGorevler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen bir görev seçin!");
                return;
            }

            // Seçili görev
            ListViewItem seciliGorev = listViewGorevler.SelectedItems[0];
            string yeniDurum = cmbDurum.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(yeniDurum))
            {
                MessageBox.Show("Lütfen bir durum seçin!");
                return;
            }

            // Durumu güncelle
            seciliGorev.SubItems[3].Text = yeniDurum;
            MessageBox.Show("Görev durumu güncellendi!");
        }

        public void RefreshListView()
        {
            listViewGorevler.Items.Clear();

            // GlobalData veya başka bir veri kaynağından görevleri alıp, listViewGorevler'a ekle
            foreach (var gorev in GlobalData.GorevlerListesi)
            {
                ListViewItem item = new ListViewItem(gorev.GorevAdi);
                item.SubItems.Add(gorev.AtananCalisan);
                item.SubItems.Add(gorev.BaslangicTarihi.ToString("dd/MM/yyyy"));
                item.SubItems.Add(gorev.BitisTarihi.ToString("dd/MM/yyyy"));
                item.SubItems.Add(gorev.Durum);

                listViewGorevler.Items.Add(item);
            }
        }


    }
}
