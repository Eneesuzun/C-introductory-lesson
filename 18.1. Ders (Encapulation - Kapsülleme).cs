using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._1.Ders__Encapulation___Kapsülleme_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();

            m1.kilo1 = 70; //Değer atandığı zaman set blocklaı çalışır.

            Console.WriteLine(m1.kilo1); //atama yapılmassa get blockları çalışır.

            Console.ReadLine();

        }
    }
}
