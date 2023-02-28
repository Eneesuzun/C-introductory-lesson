using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders__ARREY_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int için 
            /*
            int[] sayılar = new int[4];

            sayılar[0] = 10;
            sayılar[1] = 20;
            sayılar[2] = 30;
            sayılar[3] = 40;

            for(int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine(sayılar[i]);
                


            }
            Console.ReadLine();
            */

            //string için
            /*
            string[] isimler = { "Enes", "Yasin", "Mehmet", "Kasım" };

            Console.WriteLine(isimler[2]);
            Console.ReadLine();
            */


            int[] sayilar = new int[4];

            for(int i = 0; i< sayilar.Length; i++)
            {
                Console.Write("Lütfen Sayılar Dizisinin " + (i) + "'ıncı İndex Değerini Giriniz =");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("**********************************************************");

            for(int i =0; i< sayilar.Length; i++)
            {

                Console.WriteLine(sayilar[i]);

            }
            Console.ReadLine();


        }
    }
}
