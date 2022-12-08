using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek7
    {
        static int BuyukBul(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static int BuyukBul3(int a,int b,int c)
        {
            return BuyukBul(a, BuyukBul(b, c));
        }
        static void Main(string[] args)
        {
            int s1, s2,s3;
            Console.WriteLine("1.sayı");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.sayı");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.sayı");
            s3 = Convert.ToInt32(Console.ReadLine());

            int enbuyuk = BuyukBul3(s1, s2,s3);
            Console.WriteLine(enbuyuk);
        }
    }
}
