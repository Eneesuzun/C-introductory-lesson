using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders__Class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba araba1= new araba();

            araba1.Kapı_sayısı = 4;
            araba1.Araba_Rengi = "Siyah";
            araba1.kapı_kilitle();
            araba1.morot_calistir();


            Console.WriteLine("Arabanın Kapı Sayısı: "+araba1.Kapı_sayısı);
            Console.WriteLine("Arabanın Rengi: "+araba1.Araba_Rengi);
            Console.ReadLine();
        }
    }
}
