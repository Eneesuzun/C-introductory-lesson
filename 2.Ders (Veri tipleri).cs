using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ders__Veri_Tipleri_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 250;                   //byte veri tipi aşağıdaki kodda gösterildiği gibi max 255 değeri alır

            byte minDeger = byte.MinValue;     
            byte maxDeger = byte.MaxValue;

            
            short ikinci = 30496;              //short veri tipi aşağıda gösterdiğim gibi min = -32768  max = 32768 değerini alır

            short minDeger2 = short.MinValue;
            short maxDeger2 = short.MaxValue;

            int uçuncu = -146745952;           //int veri tipi aşağıda gösterdiğim gibi min = -2147483648  max = 2147483648 değerini alır

            int minDeger3 = int.MinValue;
            int maxDeger3 = int.MaxValue;


            long dorduncu = 415413513;         //long veri tipi aşağıda gösterdiğim gibi 18, 19 basamaklı değerler için kullanılır

            long minDeger4 = long.MinValue;
            long maxDeger4 = long.MaxValue;


            float besinci = -4.5f;            //float veri tipinde ondalıklı sayılar tanımlarınır  "f" kullanılır  7 basamağa kadar

            double altıncı = 7.4;            //double veri tipinde ondalıklı sayılar tanımlarır 15 basamağa kadar 
            
            char yedıncı = 'A';              //char veri tipi yanlızca tek bir karakter tutar  ' kullanmak zorunludur

            string sekızıncı = "Enes";       //string veri tipi metin yazmak için kullanılır

            bool dokuzuncu = false;           //bool veri tipi yanlızca doğru yanlış verilerini tutar
            bool dokuzuncu2 = true;

            bool dokuzuncu3 = 10 > 7;
            bool dokuzuncu4 = 10 > 11;




            Console.WriteLine(birinci);
            Console.WriteLine(minDeger);
            Console.WriteLine(maxDeger);

            Console.WriteLine(ikinci);
            Console.WriteLine(minDeger2);
            Console.WriteLine(maxDeger2);

            Console.WriteLine(uçuncu);
            Console.WriteLine(minDeger3);
            Console.WriteLine(maxDeger3);

            Console.WriteLine(dorduncu);
            Console.WriteLine(minDeger4);
            Console.WriteLine(maxDeger4);

            Console.WriteLine(besinci);

            Console.WriteLine(altıncı);

            Console.WriteLine(yedıncı);

            Console.WriteLine(sekızıncı);

            Console.WriteLine(dokuzuncu3);
            Console.WriteLine(dokuzuncu4);    



            Console.ReadLine();
        }
    }
}
