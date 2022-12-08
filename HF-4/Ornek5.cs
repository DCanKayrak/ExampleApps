using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek5
    {
        static void Main(string[] args)
        {
            string[] isimler = { "ali", "ahmet", "selda", "canan" };
            Console.WriteLine("Aranan isim = ");
            string aranan = Console.ReadLine();

            foreach(string ss in isimler)
            {
                if (aranan.Equals(isimler[0]))
                {
                    Console.WriteLine("Bulundu!");
                }
                else
                {
                    Console.WriteLine("yok.");
                }
                Console.ReadKey();
            }
        }
    }
}
