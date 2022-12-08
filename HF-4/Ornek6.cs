using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek6
    {
            static int BuyukBul(int a,int b)
            {
                if(a > b)
                {
                    return a;
                }
                return b;
            }
            static void Main(string[] args)
            {
                int s1, s2;
            Console.WriteLine("1.sayı");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            s2 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul(s1, s2);
            Console.WriteLine(enbuyuk);
        }
    }
}
