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
            // �ste�e ba�l� olarak listeyi g�ncelleyin, �rne�in ListView kontrol�nde
            MessageBox.Show("Proje ba�ar�yla eklendi!");
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
            // Burada, g�revin eklenece�i projeyi se�mek gerekiyor.
            // �rnek olarak, aktif se�ili projeyi al�yoruz (gereksinimlerinize g�re bu k�s�m de�i�ebilir).
            Proje secilenProje = GetSecilenProje();

            if (secilenProje != null)
            {
                // G�revi projeye ekle
                secilenProje.Gorevler.Add(yeniGorev);
                MessageBox.Show("G�rev, projeye ba�ar�yla eklendi!");
            }
            else
            {
                MessageBox.Show("L�tfen bir proje se�in!");
            }
        }
        private Proje GetSecilenProje()
        {
            // Burada, kullan�c� taraf�ndan se�ilen projeyi almay� sim�le ediyoruz.
            // Ger�ek uygulamada, �rne�in, bir ListBox veya ComboBox ile se�ilen projeyi buradan alabilirsiniz.

            // �rne�in, ilk projeyi d�nd�r�yoruz.
            // Bu k�s�m, kullan�c� aray�z�n�zdeki projeyi se�me mant���na g�re de�i�ebilir.
            return projeler.FirstOrDefault();  // �lk projeyi d�nd�r�yoruz.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni Proje Butonuna T�kland�!");
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
                MessageBox.Show($"Se�ilen proje: {secilenProje}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCal�sanYonetimi formCal�sanYonetimi = new FormCal�sanYonetimi();
            formCal�sanYonetimi.ShowDialog();

        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("L�tfen g�rev eklemek istedi�iniz projeyi se�in!");
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
