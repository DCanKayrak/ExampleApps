using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_6
{
    class Indexleyici
    {
        public double rakam;
        public double this[double index]
        {
            get { return Math.Pow(index, 2); }
            set { rakam = value; }
        }
    }
    class Ornek2
    {
        static void Main(string[] args)
        {
            Indexleyici i = new Indexleyici();
            Console.WriteLine("i[3.4]={0}",i[3.4]);
            i[10] = 10;
            Console.WriteLine(i.rakam);
            i[10] = 15;
            Console.WriteLine(i.rakam);
            Console.WriteLine("i[10]={0}",i[10]);
        }
    }
}
