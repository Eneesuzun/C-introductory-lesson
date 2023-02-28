using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__ATM_Uygulaması_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Atm Örneyği

            /*

            Console.WriteLine("Hoşgeldiniz \n Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine(" 1) Hesap Bakiyesi  \n 2) Para Çekme \n 3) Para Yatırma  \n 4) Çıkış Yapma");

            string a = Console.ReadLine();

            int hesapbakıyesı = 5000;

            if (a == "1")
            {
                Console.WriteLine("Hesap Bakiyeniz= " + hesapbakıyesı);
                
            }

            else if (a == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                int cekilmekistenen = Convert.ToInt32(Console.ReadLine());

                if (cekilmekistenen > hesapbakıyesı)
                {
                    Console.WriteLine("Yeterli bakiyeniz Bulunmamaktadır");
                    Console.ReadLine();

                }
                else
                {
                    ;

                    hesapbakıyesı -= cekilmekistenen;

                    Console.WriteLine("Lütfen Paranızı Para Bölmesinden Alınız  \n  Kalan bakiyeniz:" + hesapbakıyesı);
                    Console.ReadLine();
                }
            }

            else if (a == "3")
            {
                Console.WriteLine("Yatırmak İstediğniz Tutarı Para Bölmesine Koyunuz");
                int yatırılmakistenen = Convert.ToInt32(Console.ReadLine());

                hesapbakıyesı += yatırılmakistenen;
                Console.WriteLine("Hesabınızıdaki Bakiye:" + hesapbakıyesı);
                Console.ReadLine();
            }



            else if (a == "4")
            {
                Console.WriteLine("Atm'den Çıkış Yapılıyor \n İyi günler dileriz :)");
                Console.ReadLine();


            }

            else
                Console.WriteLine("Lütfen Geçerli Olan Tuşları Kullanınız");
                Console.ReadLine();

            } 
            }
            */


            //Öğrencinin notu sınıflandırma kod örneği  (Switch - Case - Break)



            Console.WriteLine("ATM'ye Hoşgeldiniz..");

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz");

            Console.WriteLine("1- Bakiye Görüntüle");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4- Çıkış Yapma");

            int bakiye = 2000;


            string islem = Console.ReadLine();

            switch (islem)
            {
                case "1":
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.Write("Çekmek istediğiniz tutarı giriniz= ");
                    int cekilenpara = Convert.ToInt32(Console.ReadLine());
                    if (cekilenpara > bakiye)
                    {
                        Console.Write("Bakiyenizden fazla para çekemessiniz");
                        Console.ReadLine();


                    }
                    else
                    {
                        Console.Write("Başarılı bir şekilde para çekilmişdir...");
                        bakiye = bakiye - cekilenpara;
                        Console.Write("\n Yeni Bakiyeniz =" + bakiye);
                        Console.ReadLine();

                    }
                    break;
                case "3":
                    

                        Console.Write("Lütfen yatırmak istediğiniz tutarı giriniz= ");
                        int yarıtılanpara = Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye + yarıtılanpara;
                        Console.Write("Paranız başarılı bir şekilde yatırılmışdır");
                        Console.Write("\n Yenş Bakitebiz = " + bakiye);
                        Console.ReadLine();
                        break;
                    

                case "4":
                    
                        Console.Write("Başarılı bir şekilde çıkış yapılmışdır.");
                        Console.ReadLine();

                        break;
                    
                default:
                        Console.WriteLine("Lütfen Geçerli bir tuşa basınız");
                        Console.ReadLine();

                        break;



                    }
            }
        }
    }

                    
            
      
