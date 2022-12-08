using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_6
{
    enum Gunler : byte
    {
        PAZARTESI, SALI, CARSAMBA, PERSEMBE, CUMA, CUMARTESI, PAZAR
    }
    class Ornek8
    {
        static void Main(string[] args)
        {
            string[] sabitler = Enum.GetNames(typeof(Gunler));
            foreach (string s in sabitler)
            {
                Console.WriteLine(s);
            }
        }
    }
}
