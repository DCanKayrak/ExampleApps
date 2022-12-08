using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9
{
    class oto
    {
        protected double boy = 5;
        protected double agirlik = 800;
        protected string renk = "Sarı";
        public void Goster()
        {
            Console.WriteLine("Boy = "+boy);
            Console.WriteLine("Ağırlık = " + agirlik);
            Console.WriteLine("Renk = "+renk);
        }

    }
    class model1 : oto
    {
        public string tur;
        public int silindir_sayisi;
        public int tork;
        public int subap_sayisi;
        public int guc;
        public void ozellikyaz()
        {
            Console.WriteLine("Tur = "+tur);
            Console.WriteLine(boy);
            Console.WriteLine(agirlik);
            Console.WriteLine(renk);
            Console.WriteLine(silindir_sayisi);
            Console.WriteLine(subap_sayisi);
            Console.WriteLine(tork);
            Console.WriteLine(guc);
        }
    }
    class model2 : oto
    {
        public double model2_boy
        {
            get { return boy; }
            set { boy = value; }
        }
        public double model2_agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }
        public string model2_renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public string tur = "Hatchback";
        public int silindir_sayisi = 8;
        public int tork= 16;
        public int subap_sayisi = 3;
        public int guc= 5000;

        public void OzellikYaz()
        {
            Console.WriteLine(tur);
            Console.WriteLine(model2_boy);
            Console.WriteLine(model2_agirlik);
            Console.WriteLine(model2_renk);
            Console.WriteLine(silindir_sayisi);
            Console.WriteLine(subap_sayisi);
            Console.WriteLine(tork);
            Console.WriteLine(guc);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            model1 oto1 = new model1();
            model2 oto2 = new model2();
            oto1.tur = "Sedan";
            oto1.silindir_sayisi = 4;
            oto1.subap_sayisi = 8;
            oto1.guc = 75;
            oto1.tork = 100;
            oto1.ozellikyaz();
            Console.WriteLine("********");
            oto2.model2_boy = 6;
            oto2.model2_renk = "Mavi";
            oto2.model2_agirlik = 900;
            oto2.OzellikYaz();
            Console.WriteLine("********");
            oto2.Goster();
            Console.WriteLine("*********");
            oto1.Goster();
            Console.ReadLine();
        }
    }
}
