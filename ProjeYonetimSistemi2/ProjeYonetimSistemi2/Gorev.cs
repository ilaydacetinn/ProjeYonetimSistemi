using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimSistemi2
{
    public class Gorev
    {
        public string ProjeAdi { get; set; }
        public string Ad { get; set; }
        public int CalisanId { get; set; } // Görevle ilişkili çalışanın ID'si
        public string GorevAdi { get; set; }
        public string AtananCalisan { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public int AdamGun { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string Durum { get; set; } // Tamamlanacak, Devam Ediyor, Tamamlandı

        public Gorev(string projeAdi, string gorevAdi, string atananCalisan, DateTime baslangicTarihi, int adamGun, string durum)
        {
            ProjeAdi = projeAdi;
            GorevAdi = gorevAdi;
            AtananCalisan = atananCalisan;
            BaslangicTarihi = baslangicTarihi;
            AdamGun = adamGun;
            BitisTarihi = baslangicTarihi.AddDays(adamGun);
            Durum = durum;
        }



        public override string ToString()
        {
            return $"{GorevAdi} ({Durum}) - {AtananCalisan}";
        }
    }

}
