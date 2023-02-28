using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _7.Ders__Döngüler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1'den 10'a kadar olan sayıları alt alta ekrana yazdıran programı kodlayınız..
            /*
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();
            */

            //1'den 10'a kadar olan çift sayıları alt alta ekrana yazdıran programı kodlayınız..
            /*
            for(int i = 2; i <= 10; i=i+2)
            {

                Console.WriteLine(i);

            }
            Console.ReadLine();
            */

            for(int i = 1; i < 10; i++) { 
            
                for(int n = 1; n <= i; n++) {

                    Console.Write(n);

               
                }
                Console.WriteLine("");         
            }
            Console.ReadLine();
      
          













        }
    }
}
