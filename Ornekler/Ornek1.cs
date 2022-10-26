using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Ornek1
    {
        static void Main()
        {
            #region Ornek1
            int a = 2;
            int b = 3;
            int c = 6;
            int d = 1;

            Console.WriteLine("(a<b) && (c<d) -->" + ((a < b) && (c < d)));
            Console.WriteLine("(a<b) || (c<d) -->" + ((a < b) || (c < d)));
            Console.WriteLine(" ! (a<b) -->" + (!(a < b)));
            Console.WriteLine("(a<b) & (c<d) -->" + ((a < b) & (c < d)));
            Console.WriteLine("(a<b) | (c<d) -->" + ((a < b) | (c < d)));
            Console.WriteLine("(a<b) ^ (c<d) -->" + ((a < b) ^ (c < d)));
            #endregion
        }
    }
}
