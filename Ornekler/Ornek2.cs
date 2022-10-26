using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekler
{
    class Ornek2
    {
        static void Main()
        {
            #region Ornek2
            int a = 2;
            int b = 3;
            int c = 6;

            Console.WriteLine(((a & b)));
            Console.WriteLine(((a | b)));
            Console.WriteLine(((a ^ b)));
            Console.WriteLine(~a);
            Console.WriteLine(~b);
            Console.WriteLine(~c);
            #endregion
        }
    }
}
