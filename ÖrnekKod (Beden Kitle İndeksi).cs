using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__Beden_Kitle_İndeksi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beden Kitle İndeksi Kodu

            Console.Write("Lütfen Kilonuzu Giriniz: ");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen Boyunuzu Ondalıklı Olarak Giriniz: ");
            Double boy = Convert.ToDouble(Console.ReadLine());

            double indeks = kilo / (boy * boy);

            if (indeks <= 18 )
            {

                Console.WriteLine("Beden İndeksiniz ZAYIF");
                Console.ReadLine();
            }
            else if (indeks > 18 && indeks < 25)
            {

                Console.WriteLine("Beden İndeksiniz NORMAL");
                Console.ReadLine();

            }
            else if (indeks > 25)
            {

                Console.WriteLine("Beden İndeksiniz OBEZ");
                Console.ReadLine();


            }
            else
            {

                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                Console.ReadLine() ;

            }
                
            
            
            }







        }
    }

