using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek3
    {
        static void Main(string[] args)
        {
            int[][] dizi = new int[3][];
            dizi[0] = new int[] { 1, 2 };
            dizi[1] = new int[] { 3, 4, 5, 6, 7 };
            dizi[2] = new int[] { 8, 9, 0 };

            foreach (int[] eleman in dizi)
            {
                Console.WriteLine("{0,3}",eleman);
            }
            Console.WriteLine();
        }
    }
}
