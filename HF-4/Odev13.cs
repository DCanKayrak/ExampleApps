using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Odev13
    {
        static int Faktoriyel(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            return a * Faktoriyel(a - 1);
        }
        static void Main()
        {
            Console.WriteLine("Faktöriyelini alacağınız sayıyı geriniz :");
            int fak_deger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Girmiş olduğunuz sayının faktöriyeli : "+Faktoriyel(fak_deger));
        }
    }
}
