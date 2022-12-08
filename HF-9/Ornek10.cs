using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_9
{
class Koleksiyon : IEnumerable
    {
        int[] Dizi;
        public Koleksiyon(int[] dizi)
        { this.Dizi = dizi; }
        IEnumerator IEnumerable.GetEnumerator()
        { return new ENumaralandırma(this); }
        class ENumaralandırma : IEnumerator
        {
            int indeks;
            Koleksiyon koleksiyon;
            public ENumaralandırma(Koleksiyon
            koleksiyon)
            {
                this.koleksiyon = koleksiyon;
                indeks = -1;
            }
            public void Reset()
            { indeks = -1; }
public bool MoveNext()
            {
                indeks++;
                if (indeks < koleksiyon.Dizi.Length)
                    return true;
                else return false;
            }
            object IEnumerator.Current
            {
                get { return (koleksiyon.Dizi[indeks]); }
            }
        }
    }
    class MainMetodu
    {
        static void Main()
        {
            int[] dizi = { 1, 2, 3, 8, 6, 9, 7 };
            Koleksiyon k = new Koleksiyon(dizi);
            foreach (int i in k)
                Console.Write(i + " ");
        }
    }

}
