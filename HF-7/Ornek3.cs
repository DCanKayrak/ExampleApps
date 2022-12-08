using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_7
{
    class Ornek3
    {
        static void Main(string[] args)
        {
            DateTime tarihsaat = new DateTime();
            tarihsaat = DateTime.Now;
            Console.WriteLine(tarihsaat);
            DateTime tarih = new DateTime();
            tarih = DateTime.Today;
            Console.WriteLine(tarih);
        }
    }
}
