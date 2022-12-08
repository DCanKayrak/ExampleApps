using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_6
{
    enum Gunler : byte
    {
        PAZARTESI,SALI,CARSAMBA,PERSEMBE,CUMA,CUMARTESI,PAZAR
    }
    class Ornek7
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.PAZARTESI);
            Console.WriteLine((int)Gunler.PAZAR);
        }
    }
}
