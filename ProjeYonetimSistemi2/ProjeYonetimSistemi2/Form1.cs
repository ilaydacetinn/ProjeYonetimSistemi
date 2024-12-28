namespace ProjeYonetimSistemi2
{
    public partial class Form1 : Form
    {
        private List<Proje> projeler = new List<Proje>();

        public Form1()
        {
            InitializeComponent();
        }
        public void ProjeEkle(Proje yeniProje)
        {
            // Projeyi listeye ekle
            projeler.Add(yeniProje);
            ListeyiGuncelle();
            // Ýsteðe baðlý olarak listeyi güncelleyin, örneðin ListView kontrolünde
            MessageBox.Show("Proje baþarýyla eklendi!");
        }
        private void ListeyiGuncelle()
        {
            listView1.Items.Clear();
            foreach (var proje in projeler)
            {
                var item = new ListViewItem(proje.ProjeAdi);
                item.SubItems.Add(proje.BaslangicTarihi.ToShortDateString());
                item.SubItems.Add(proje.BitisTarihi.ToShortDateString());
                listView1.Items.Add(item);
            }
        }

        public void GorevEkleSecilenProje(Gorev yeniGorev)
        {
            // Burada, görevin ekleneceði projeyi seçmek gerekiyor.
            // Örnek olarak, aktif seçili projeyi alýyoruz (gereksinimlerinize göre bu kýsým deðiþebilir).
            Proje secilenProje = GetSecilenProje();

            if (secilenProje != null)
            {
                // Görevi projeye ekle
                secilenProje.Gorevler.Add(yeniGorev);
                MessageBox.Show("Görev, projeye baþarýyla eklendi!");
            }
            else
            {
                MessageBox.Show("Lütfen bir proje seçin!");
            }
        }
        private Proje GetSecilenProje()
        {
            // Burada, kullanýcý tarafýndan seçilen projeyi almayý simüle ediyoruz.
            // Gerçek uygulamada, örneðin, bir ListBox veya ComboBox ile seçilen projeyi buradan alabilirsiniz.

            // Örneðin, ilk projeyi döndürüyoruz.
            // Bu kýsým, kullanýcý arayüzünüzdeki projeyi seçme mantýðýna göre deðiþebilir.
            return projeler.FirstOrDefault();  // Ýlk projeyi döndürüyoruz.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Proje Butonuna Týklandý!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormYeniProje formYeniProje = new FormYeniProje();
            formYeniProje.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGorevAtama formGorevAtama = new FormGorevAtama();
            formGorevAtama.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var secilenProje = listView1.SelectedItems[0].Text;
                MessageBox.Show($"Seçilen proje: {secilenProje}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCalýsanYonetimi formCalýsanYonetimi = new FormCalýsanYonetimi();
            formCalýsanYonetimi.ShowDialog();

        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen görev eklemek istediðiniz projeyi seçin!");
                return;
            }

            string secilenProje = listView1.SelectedItems[0].Text;

            FormGorevEkle gorevEkleForm = new FormGorevEkle(secilenProje);
            gorevEkleForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
