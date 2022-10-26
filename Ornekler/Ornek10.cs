using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Ornek10
    {
        static void Main()
        {
            int sayi;
            Console.WriteLine("Tam Sayı : ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(int bit = 32; bit >= 1; bit--)
            {
                Console.WriteLine("{0}",(sayi >> bit-1) & 1);
            }
            Console.WriteLine();
        }
    }
}
