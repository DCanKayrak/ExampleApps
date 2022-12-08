using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9
{
    class Aa
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class Bb : A
    {
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }
    class Ana
    {
        static void Main()
        {
            Bb b = new Bb();
            //b.Metot1();
        }
    }
class Aaa
    {
        public void Metot1()
        { Metot2(); }
        public void Metot2()
        { Console.WriteLine("A sınıfı"); }
    }
    class Bbb : A
    {
        public new void Metot1()
        { Metot2(); }
        public new void Metot2()
        { Console.WriteLine("B sınıfı"); }
    }
    class Anaa
    {
        static void Main()
        {
            Bbb b = new Bbb();
            b.Metot1();
        }
    }

}
