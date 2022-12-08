using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    delegate Ana temsilciAna(); delegate Yavru temsilciYavru();
    class Ana
    {

    }
    class Yavru : Ana
    {

    }
    class Program
    {
        static Ana MetotAna()
        {
            return new Ana();
        }
        static Yavru MetotYavru()
        {
            return new Yavru();
        }
            static void Main(string[] args)
        {
            temsilciAna nesneAna = new temsilciAna(MetotYavru);
            nesneAna += new temsilciAna(MetotAna); nesneAna();
            temsilciYavru nesneYavru = new temsilciYavru(MetotYavru);
            nesneYavru();
        }
    }
    
}
