using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Ornek5
    {
        static void Main()
        {
            int secim;
            do
            {
                Console.WriteLine("İşlemler:");
                Console.WriteLine("1-Toplama");
                Console.WriteLine("2-Çıkarma");
                Console.WriteLine("3-Çarpma");
                Console.WriteLine("4-Bölme");
                Console.WriteLine("0-Çıkış\n");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1: Console.WriteLine("Toplama"); break;
                    case 2: Console.WriteLine("Çıkarma"); break;
                    case 3: Console.WriteLine("Çarpma"); break;
                    case 4: Console.WriteLine("Bölme"); break;
                    case 0: Console.WriteLine("Çıkış"); break;
                    default: Console.WriteLine("Yanlış Seçim"); break;
                }
            } while (secim != 0);
        }
    }
}
