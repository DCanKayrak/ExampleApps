using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9
{
    public class Hayvan
    {
        protected String a = "Hayvan.a";
        String b = "Hayvan.b"; // friendly
        private String c = "Hayvan.c";
        public String d = "Hayvan.d";
    }
    public class Kedii : Hayvan
    {
        public Kedii()
        {
            Console.WriteLine("Kedi olusturuluyor");
            Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
    class Ornek4
    {
        static void Main(string[] args)
        {
            Kedii k = new Kedii();
        }
    }
}
