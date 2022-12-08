using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_8
{
    class Ornek2
    {
        static void Main(string[] args)
        {
            byte[] kaynak = [1, 2, 0, 1];
            short[] hedef = new short[5];

            Buffer.BlockCopy(kaynak, 0, hedef, 0, 4);

            foreach(short s in hedef)
                Console.WriteLine(s+" ");
            Console.WriteLine("\n"+Buffer.GetByte(hedef,0));
            Buffer.SetByte(hedef, 5, 3);

            foreach(short s in hedef)
            {
                Console.WriteLine(s+" ");
            }

            Console.WriteLine();
            Console.WriteLine(Buffer.ByteLength(kaynak));
            Console.WriteLine(Buffer.ByteLength(hedef));
        }
    }
}
