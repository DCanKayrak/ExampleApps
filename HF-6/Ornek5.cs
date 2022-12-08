using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_6
{
    enum notu : byte { basarisiz,basarili}
    class Ornek5
    {
        static void Main(string[] args)
        {
            notu a = notu.basarili;
            if(a == (notu)1)
            {
                Console.WriteLine("Başarılısınız.");
            }
            else
            {
                Console.WriteLine("Başarısızsınız.");
            }
        }
    }
}
