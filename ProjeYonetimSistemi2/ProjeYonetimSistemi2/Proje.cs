using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimSistemi2
{
    public class Proje
    {
        public List<Gorev> Gorevler { get; set; } = new List<Gorev>();

        public void GorevEkle(Gorev gorev)
        {
            Gorevler.Add(gorev);
        }

        public string ProjeAdi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public Proje(string projeAdi, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            ProjeAdi = projeAdi;
            BaslangicTarihi = baslangicTarihi;
            BitisTarihi = bitisTarihi;
        }

        public override string ToString()
        {
            return $"{ProjeAdi} - {BaslangicTarihi.ToShortDateString()} - {BitisTarihi.ToShortDateString()}";
        }
    }

}
