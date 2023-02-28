using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__Login_Uygulaması_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int kalan_hak = 3;

            while (true)
            {
                Console.Write("Lütfen Kullanıcı Adınızı Giriniz: ");
                string kullanıcıadı = Console.ReadLine();

                Console.Write("Lütfen Şifrenizi Giriniz: ");
                string sifre = Console.ReadLine();


                if(kullanıcıadı == "xkraltr" && sifre == "123")
                {
                    Console.WriteLine("Başarılı Bir Şekild Giriş Yaptınız...");
                    Console.ReadLine();
                    break;
                }

                else
                {
                    Console.WriteLine("Yanlış girdiniz Lütfen Bir Daha Deneyiniz.");
                    
                    if (kalan_hak > 0)
                    {
                        kalan_hak -= 1;
                        Console.WriteLine(kalan_hak + " Hakınız Kalmışdır");
                    }



                    if (kalan_hak == 0)
                    {
                        Console.WriteLine("Daha fazla giriş yapamssınız");
                        Console.ReadLine();
                        break;
                        
                    }

                }


            }




        }
    }
}
