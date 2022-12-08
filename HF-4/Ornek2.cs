using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek2
    {
        static void Main(string[] args)
        {
            int[,] dizi = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine(dizi[i,j]);
                }
            }
        }
    }
}
