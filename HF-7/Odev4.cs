using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_7
{
    class Odev4
    {
        static void Main(string[] args)
        {
            DateTime Bugun = new DateTime();
            Bugun = DateTime.Now;
            Console.WriteLine(Bugun.Date);
            Console.WriteLine(Bugun.Day);
            Console.WriteLine(Bugun.Month);
            Console.WriteLine(Bugun.Year);
            Console.WriteLine(Bugun.DayOfWeek);
            Console.WriteLine(Bugun.DayOfYear);
            Console.WriteLine(Bugun.TimeOfDay);
            Console.WriteLine(Bugun.Hour);
            Console.WriteLine(Bugun.Minute);
            Console.WriteLine(Bugun.Second);
            Console.WriteLine(Bugun.Millisecond);
            Console.WriteLine(Bugun.Ticks);
        }
    }
}
