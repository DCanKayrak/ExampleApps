using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_5
{
    class Ornek9
    {
        public int Zar()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
        public static void metotlar(int a,int b,int c)
        {
            Console.WriteLine("a= "+a+"b= "+b+"c= "+c);
        }
        static void Main(string[] args)
        {
            Ornek9 a = new Ornek9();
            metotlar(a.Zar(), a.Zar(), a.Zar());
        }
    }
}
