using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_5
{

    // Hatanın sebebi bir nesne oluşturulmadan o özelliklere erişim sağlanamaz.

    class Dortgen1
    {
        public int En;
        public int Boy;
        public int Alan()
        {
            int Alan = En * Boy; return Alan;
        }
        public void EnBoyBelirle(int en, int boy)
        {
            En = en; Boy = boy;
        }
        public void Yaz()
        {
            Console.WriteLine("*************");
            Console.WriteLine(En);
            Console.WriteLine(Boy);
            Console.WriteLine(Alan());
            Console.WriteLine("*************");
        }
    }
    class Ornek6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(En);
            Console.WriteLine(Boy);
            Console.WriteLine(Alan());

         
        }
    }
}
