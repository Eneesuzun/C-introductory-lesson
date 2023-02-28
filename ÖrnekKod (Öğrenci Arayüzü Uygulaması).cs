using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__Öğrenci_Arayüzü_Uygulaması_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                    ÖĞRENCİ BİLGİ SİSTEMİNE HOŞGELDİNİZ...");
            Console.WriteLine("                                   Lütfen Yapmak İstediğiniz İşlemi Seçiniz");
            Console.WriteLine("                                                              ");

            bool kontrol = true;
            Ogrenci ogrencibilgileri = new Ogrenci("b210104008","Enes","Uzun",45,36,78,"Sakarya Uygulamalı Bilimler Üniversitesi");

            while (kontrol)
            {
                Console.WriteLine("1-Öğrenci Bilgilerini Göster \n2-Öğrenci Ortalamsını Göster \n3-Öğrencinin Okulunu Öğre \n4-Çıkış Yap");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        ogrencibilgileri.ogrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenci_ortalamsaı = ogrencibilgileri.ogrenciOrtalamasıBul();
                            Console.WriteLine("                                                              ");
                            Console.WriteLine("Öğrencinin Not Ortalaması :" + ogrenci_ortalamsaı);
                            Console.WriteLine("                                                              ");
                            Console.WriteLine("**************************************************************");
                            Console.WriteLine("                                                              ");
                            break;
                
                    case "3":
                        ogrencibilgileri.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;

                  
                }
                    
                
            }

            
                
            

        }
    }
}
