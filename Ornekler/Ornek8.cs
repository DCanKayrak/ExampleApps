using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Ornek8
    {
        static void Main()
        {
            int i = 0,a,n;

            Console.WriteLine("Sayı Gir :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Artım Miktarı : ");
            a = Convert.ToInt32(Console.ReadLine());

            for (; i < n;)
            {
                Console.WriteLine("{0} ",i);
                i += a;
            }
        }
    }
}
