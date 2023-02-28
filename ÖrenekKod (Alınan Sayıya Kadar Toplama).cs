using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrenekKod__Alınan_Sayıya_Kadar_Toplama_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Sayınızı Giriniz: ");
            int sayı = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for(int i =1; i<=sayı; i++)
            {
                toplam += i; 


            }



            



        }
    }
}
