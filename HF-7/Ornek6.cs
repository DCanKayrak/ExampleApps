using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_7
{
    class Ornek6
    {
        static void Main(string[] args)
        {
            int yil, ay, gun;
            Console.WriteLine("Doğum yılınız : ");
            yil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğum ayınız : ");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğum gününüz : ");
            gun = Convert.ToInt32(Console.ReadLine());

            DateTime Bugun = DateTime.Today;
            DateTime DogumGunu = new DateTime(yil, ay, gun);

            TimeSpan fark = Bugun - DogumGunu;

            Console.WriteLine("Dogdugunuz gün = "+DogumGunu.DayOfWeek);
            Console.WriteLine("Gün : "+fark.Days);

            Console.WriteLine();
            Console.Write("Gün sayısı :");
            gun = Convert.ToInt32(Console.ReadLine());

            TimeSpan GunSayisi = new TimeSpan(gun, 0, 0, 0);
            DateTime Gelecek = DateTime.Today + GunSayisi;
            Console.WriteLine("{0} gün sonra günlerden {1} dir.",gun,Gelecek.DayOfWeek);
        }
    }
}
