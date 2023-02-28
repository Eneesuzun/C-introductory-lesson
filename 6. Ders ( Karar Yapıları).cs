using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Ders___Karar_Yapıları_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Öğrencinin notu sınıflandırma kod örneği  (İF ,  ELSE  ,  ELSE İF)
            
            Console.Write("Notunuzu giriniz:");

            int cıkannot = Convert.ToInt32(Console.ReadLine());


            if (cıkannot >= 80)
            {
                Console.WriteLine("Harf Notunuz:AA");

            }

            else if (60 <= cıkannot && cıkannot < 80) 
            {
                Console.WriteLine("Harf Notunuz:BB");


            }

            else if(50<= cıkannot && cıkannot <60)
            {
                Console.WriteLine("Harf Notunuz:CC");


            }

            else
            {
                Console.WriteLine("Harf Notunuz:FF");
            }

            Console.ReadLine();

            


           
            }











        }
    }
}
