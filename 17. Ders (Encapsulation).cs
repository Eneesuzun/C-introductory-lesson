using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Ders__Encapsulation_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //geter ve seter methodu

            bilgiler bilgiler1 = new bilgiler();

            bilgiler1.setname("Enes");
            string gelenisim = bilgiler1.getName();

            if(gelenisim == "Enes")
            {
                Console.WriteLine("Başarılı");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Başarısız");
                Console.ReadLine();


            }
            
        }
    }
}
