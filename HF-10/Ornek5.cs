using HF_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF_10
{
    public delegate void OlayYoneticisi();
    class AnaProgram
    {
        static void Main()
        {
            AnaProgram nesne = new AnaProgram();

            nesne.Olay += new OlayYoneticisi(Metot); //Olay sonrası işletilecek metotların eklenmesi
            nesne.Olay();
        }
        static void Metot()
        {
            Console.WriteLine("Butona tıklandı.");
        }
        event OlayYoneticisi Olay;
    }
    interface IArayuz
    {
        int Metot1(); int Metot2();
        int sahteozellik { set; get; }
        int this[int indeks] { get; }
        event OlayYoneticisi Olay;
    }
    class denemee : IArayuz
    {
        public int Metot1() { return 1; }
        public int Metot2() { return 2; }
        public int sahteozellik
        {
            set { }
            get { return 3; }
        }
        public int this[int indeks]
        { get { return indeks; } }
        public event OlayYoneticisi Olay;
        static void Main()
        {
            denemee nesne = new denemee();
            nesne.Olay += new
            OlayYoneticisi(nesne.Metot1);
            Console.WriteLine(nesne.Olay());
        }
    }
    public void ButonKlik()
 { Console.WriteLine("{0} nolu pencere olayı algıladı.",PencereNo);
 }
 }
 public class OlayTest
 { static void Main()
 {
 Buton buton=new Buton();
 Pencere p1=new Pencere(1);
 Pencere p2=new Pencere(2);
 //Geçerli ekleme:
 buton.ButonKlik+=new OlayYoneticisi(ButonKlik);
 buton.Kliklendi();Console.WriteLine();
 //Geçerli ekleme:
 buton.ButonKlik+=new OlayYoneticisi(p1.ButonKlik);
 buton.Kliklendi();
 Console.WriteLine();

 //Geçersiz ekleme (Olay dolu):
 buton.ButonKlik+=new OlayYoneticisi(p2.ButonKlik);
 buton.Kliklendi();
 Console.WriteLine();
 buton.ButonKlik-=new OlayYoneticisi(p1.ButonKlik);
 buton.Kliklendi();
 Console.WriteLine();
 buton.ButonKlik-=new OlayYoneticisi(ButonKlik);
 buton.Kliklendi();
 Console.WriteLine();
 //Geçersiz çıkarma (metot yok):
 buton.ButonKlik-=new OlayYoneticisi(ButonKlik);
 buton.Kliklendi(); }
 public static void ButonKlik()
 { Console.WriteLine("Buton kliklendi"); }
 }
    class Buton
    {
        OlayYoneticisi[] olay = new OlayYoneticisi[2];
        //Olay yöneticimiz türünden iki elemanlı bir dizi oluşturduk.

        public event OlayYoneticisi ButonKlik
        {
            add
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == null)
                    //Buradaki value olaya eklenen metottur. 
                    { olay[i] = value; break; }
                if (i == 2) Console.WriteLine("Olaya en fazla iki metot eklenebilir.");
            }
            remove
            {
                int i;
                for (i = 0; i < 2; ++i)
                    if (olay[i] == value)
                    {
                        olay[i] = null; break;
                    }
                if (i == 2)
                    Console.WriteLine("Metot bulunamadı");
            }
        }
        public void Kliklendi()
        {
            for (int i = 0; i < 2; ++i)
                if (olay[i] != null)
                    olay[i]();
        }
        
    }

    class Pencere
    {
        int PencereNo;
        public Pencere(int no)
        { PencereNo = no; }

    }
}
