using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Ders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayı1 = "1";                
            string sayı2 = "2";

            int a = int.Parse(sayı1);          //String olan veri tipini 'Parse' komutu ile int e çeviririz 
            int b = int.Parse(sayı2);



            int sayı3 = 5;
            int sayı4 = 10;

            string c = sayı3.ToString();       //herhangi bir veri tipini 'X.ToString' komutu iile string veri tipine çeviririz
            string d = sayı4.ToString();



            double e = 2.89;                

            int f = Convert.ToInt32(e);         // double veri tipini int e dönüştürmemizi sağlar  (en yakına yuvarlayarak)

            //int g = int.Parse(e);             ilk olarak string veri tipine dönüştürmek gerekiyor


                                               
            
            
            Console.WriteLine(a + b);
            Console.WriteLine(c + d);
            Console.WriteLine(a.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(f);

            Console.ReadLine();




        }
    }
}
