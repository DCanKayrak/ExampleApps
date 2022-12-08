using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9
{
    class Kedi
    {
        protected int ayakSayisi = 4;
        public void yakalaAv()
        {
            Console.WriteLine("Kedi sınıfı yakaladı");
        }
    }
    class Kaplan : Kedi
    {
        public Kaplan()
        {
            Console.WriteLine("Ayak sayisi = "+ayakSayisi);
        }
    }
    class Ornek3
    {
        static void Main(string[] args)
        {
            Kedi kd = new Kedi();
            kd.yakalaAv();
            Kaplan kp = new Kaplan();
            kp.yakalaAv();
        }
    }
}
