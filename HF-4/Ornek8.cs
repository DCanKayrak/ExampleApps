using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek8
    {
        static void DiziYaz(int[] a,int Sekil)
        {
            if(Sekil == 0)
            {
                foreach(Object o in a)
                {
                    Console.WriteLine(o.ToString()+" ");
                }
                Console.WriteLine();
            }
            else
            {
                int x = 1;
                foreach(Object o in a)
                {
                    Console.WriteLine("{0,5}",o.ToString());
                    if (x % 3 == 0)
                    {
                        Console.WriteLine();
                        x++;
                    }
                }else
                {
                    foreach(Object o in a)
                    {
                        Console.WriteLine(o.ToString());
                    }
                    Console.WriteLine();
                }
            }
           
        }
        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            DiziYaz(dizi, 0);
            DiziYaz(dizi, 1);
            DiziYaz(dizi, 2);
        }
    }
}
