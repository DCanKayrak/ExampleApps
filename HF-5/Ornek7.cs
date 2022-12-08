using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_5
{
    class Topla
    {
        public int tpl;
        public Topla(int toplam)
        {
            tpl = toplam;
        }
        public int Toplama
        {
            get { return tpl; }
            set { tpl = value + tpl; }
        }
        static void Main(string[] args)
        {
            Topla ekle = new Topla(0);
            Console.WriteLine("Başlangıç Değeri ->"+ekle.Toplama);
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine("Toplam : "+ekle.Toplama);
            }
        }
    }
}
