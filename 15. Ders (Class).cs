using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Ders__Class_
{
    public class araba

    {
        public araba() 
        {
            Console.WriteLine("Yapıcı Metot Çalışıyor...");   //Class yapısındaki referansları döndürmeden önce ilk bu yapıcı methoda gelir içine değer atanabilir
        
        }


        public int Kapı_sayısı;
        public string Araba_Rengi;

        public void morot_calistir()
        {
            Console.WriteLine("Motor Çalıştırılıyor...");
        }
        public void kapı_kilitle()
        {
            Console.WriteLine("Kapılar Kilitleniyor...");
        }
    }
}
