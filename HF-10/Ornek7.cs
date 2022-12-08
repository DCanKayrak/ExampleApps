using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    public class UrunTemel
    {
        private int urunKodu;
        private double urunFiyati;
        private string urunBilgisi;
        public UrunTemel(int kod, double
       fiyat, string bilgi)
        {
            urunKodu = kod;
            urunFiyati = fiyat;
            urunBilgisi = bilgi;
        }
        public int UrunKodu
        {
            get { return urunKodu; }
        }
        public double BirimFiyat
        {
            get { return urunFiyati; }
        }
        public string UrunTanimi
        {
            get { return urunBilgisi; }
        }
    }
    public class Lastik : UrunTemel
    {
        private int capi;
        private int genislik;
        private string tipi;
        public Lastik(int kodu, double fiyat,
       string bilgi) : base(kodu, fiyat, bilgi) { }
        public int Cap
        {
            get { return capi; }
            set { capi = value; }
        }
        public int Genislik
        {
            get { return genislik; }
            set { genislik = value; }
        }
        public string Tip
        {
            get { return tipi; }
            set { tipi = value; }
        }
        public override string ToString()
        {
            return UrunKodu.ToString() + " " +
         BirimFiyat.ToString() + " " + UrunTanimi + " "
         + Cap.ToString() + " " + Genislik.ToString() +
         Tip;
        }
    }

}
