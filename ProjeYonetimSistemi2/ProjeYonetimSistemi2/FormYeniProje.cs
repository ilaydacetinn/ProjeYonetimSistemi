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
    public partial class FormYeniProje : Form
    {
        public FormYeniProje()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string projeAdi = txtProjeAdi.Text;
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;

            if (string.IsNullOrWhiteSpace(projeAdi))
            {
                MessageBox.Show("Lütfen bir proje adı giriniz!");
                return;
            }

            Proje yeniProje = new Proje(projeAdi, baslangicTarihi, bitisTarihi);

            // Form1'e projeyi gönder
            Form1 anaForm = (Form1)Application.OpenForms["Form1"];
            anaForm.ProjeEkle(yeniProje);

            MessageBox.Show("Proje başarıyla kaydedildi!");
            this.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormYeniProje_Load(object sender, EventArgs e)
        {

        }

        private void txtProjeAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
