using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Ders__Operatörler_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 12;
            int sayı2 = 74;
            int sayı3 = 18;

            int sonuc = (sayı1 + sayı2) - sayı3;


            int sayı4 = 8;
            int sayı5 = 10;
            int sayı6 = 2;

            int sonuc2 = (sayı4 * sayı5) / sayı6;


            int sayı7 = 10;
            int sayı8 = 3;

            int sonuc3 = (sayı7 % sayı8);

            
            int sayı9 = 20;

            sayı9++;                             // -- de 1 azaltır

            int sayı10 = 1;
            int sayı11 = 2;

            bool kontrolEt = sayı10 == sayı11;  // == operatörü iki şeyin eşitliğini belli eder


             
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sayı9);
            Console.WriteLine(kontrolEt);


            Console.ReadLine();

        }
    }
}
