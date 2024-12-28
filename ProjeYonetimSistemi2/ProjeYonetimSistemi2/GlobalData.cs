using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimSistemi2
{
    public static class GlobalData
    {
        // Görevleri tutacak statik bir liste
        public static List<Gorev> GorevlerListesi = new List<Gorev>();

        // Çalışanları tutacak bir liste (isteğe bağlı)
        public static List<Calisan> CalisanlarListesi = new List<Calisan>();
    }
}
