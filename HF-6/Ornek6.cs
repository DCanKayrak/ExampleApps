using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_6
{
    struct university
    {
        public string fakulte;
        public string bolum;
        public string Ogr_gor;
        public university(string a,string b,string c)
        {
            fakulte = a; bolum = b; Ogr_gor = c;
        }
    }
    class Ornek6
    {
        static void Main(string[] args)
        {
            university k1 = new university("Teknoloji", "Yazılım", "2.sınıf");
            university k2;
            Console.WriteLine(k1.fakulte);
            Console.WriteLine(k1.bolum);
            Console.WriteLine(k1.Ogr_gor);
            k2.fakulte = "Tıp Fakültesi";
            Console.WriteLine();
            Console.WriteLine(k2.fakulte);
        }
    }
}
