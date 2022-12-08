using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    class Ornek9
    {
    }
    class Anaa
    {
        static void Main()
        {
            Urunler<UrunTemel> urunler = new
         Urunler<UrunTemel>();
            Lastik lst = new Lastik(1000, 10,
           "Otomobil Lastiği");
            lst.Tip = "Kış Lastiği";
            lst.Cap = 185;
            lst.Genislik = 75;
            Silecek slc = new Silecek(1001, 5,
           "On silecek takimi");
            slc.Uzunluk = 60;
            urunler.Ekle(lst);
            urunler.Ekle(slc);
            urunler.Listele();
        }
    }
}
