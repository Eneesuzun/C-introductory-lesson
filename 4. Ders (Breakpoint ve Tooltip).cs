using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ders__Breakpoint_ve_Tooltip_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("İsminizi Giriniz : ");                          //ALINAN DEĞERLERİN HEPSİ STRİNG VERİ TİPİNDEDİR

            string isim = Console.ReadLine();

            Console.Write("Soyisminizi Giriniz : ");

            string soyisim = Console.ReadLine();

            Console.WriteLine("İsim = " + isim);
            Console.WriteLine("Soyisim = " + soyisim);
            Console.ReadLine();
        }
    }
}
