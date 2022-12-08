using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    public class Silecek : UrunTemel
    {
        private int uzunluk;
        public Silecek(int kodu, double fiyat,
       string bilgi) : base(kodu, fiyat, bilgi)
        {
        }
        public int Uzunluk
        {
            get { return uzunluk; }
            set { uzunluk = value; }
        }
        public override string ToString()
        {
            return UrunKodu.ToString() + " " +
           BirimFiyat.ToString() + " " + UrunTanimi +
           " " + Uzunluk.ToString();
        }
    }
    public class Urunler<T> where T : UrunTemel
    {
        private List<T> urunListe;
        public Urunler()
        {
            urunListe = new List<T>();
        }
        public void Ekle(T uye)
        {
            urunListe.Add(uye);
        }
        public void Sil(T uye)
        {
            urunListe.Remove(uye);
        }
        public void Listele()
        {
            foreach (T uye in urunListe)
            {

                Console.WriteLine(uye.ToString());
            }
        }
    }

}
