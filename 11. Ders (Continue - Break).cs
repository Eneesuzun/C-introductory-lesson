using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ders__Continue___Break_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break anahtar kelimesi döngüyü tamamen kırar

           
            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                    {

                    break;
                }
                Console.WriteLine("i nin değeri: "+i);
                
            }
            Console.ReadLine();
          


            //Continue anahtar kelimesi döngüyü sadece 1 kereye mahsus kırar
            /*
            for(int i=1; i<=10; i++) { 
            
                if(i==7) {

                    continue;
                
                }
                Console.WriteLine("i nin değeri: "+i);

            
            }
            Console.ReadLine();
            */

        }
    }
}
