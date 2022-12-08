using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    class deneme {
        static void Main() {
            for (; ; ) {
                try {
                    Console.Write("Lütfen çıkmak için 0 ya da 1 girin: ");
                  string a = Console.ReadLine();
                    if (a == "0" || a == "1") break;
           else {
               throw new IndexOutOfRangeException("Devam ediliyor");
                    }
            catch (IndexOutOfRangeException nesne) {
                    Console.WriteLine(nesne.Message); continue;
                }
           }
        }
    }
}
