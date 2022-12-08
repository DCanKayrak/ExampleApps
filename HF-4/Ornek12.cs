using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek12
    {
        static void Yaz(object o)
        {
            Console.WriteLine("1.metot"+o);
        }
        static void Yaz(params object[] o)
        {
            if (o.Length == 0) return;
            Console.WriteLine("2.metot:");
            foreach(object n in o)
            {
                Console.WriteLine(n.ToString()+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Yaz(25);
            Yaz("Deneme1", "dENEME2");
            Yaz('a');
            Yaz('z', 1, 23f, 4, 56, "abc");
        }
    }
}
