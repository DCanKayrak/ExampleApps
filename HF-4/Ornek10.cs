using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_4
{
    class Ornek10
    {
        static void Metot1(float x,float y)
        {
            Console.WriteLine("1. çağırıldı.");
        }
        static void Metot2(double x, double y)
        {
            Console.WriteLine("2. çağırıldı.");
        }
        static void Main(string[] args)
        {
            Metot1(5, 6);
        }
    }
    class Metotlar2
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. çağırıldı.");
        }
        static void Metot2(double x, double y)
        {
            Console.WriteLine("2. çağırıldı.");
        }
        static void Main(string[] args)
        {
            Metot1('f', 'g');
        }
    }
    class Metotlar
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("1. çağırıldı.");
        }
        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. çağırıldı.");
        }
        static void Main(string[] args)
        {
            Metot1(5, 6.4f);
        }
    }
    class Metotlar3
    {
        static void Metot1(float x, float y)
        {
            Console.WriteLine("3. çağırıldı.");
        }
        static void Metot1(int x, int y)
        {
            Console.WriteLine("2. çağırıldı.");
        }
        static void Metot1(int x, int y,int z)
        {
            Console.WriteLine("1. çağırıldı.");
        }
        static void Main(string[] args)
        {
            Metot1(3, 3, 6);
            Metot1(3.4f, 3);
            Metot1(1, 'h');
        }
    }
}
