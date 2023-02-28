using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ders__Public_Ve_Private_Erişim_Belirleyici_
{
    public class Müsteri
    {
        public string isim;
        public string soyisim;
        public int yas;
        public string cinsiyet;



        public void MusteriBilgileriniGoster()
        {
            Console.WriteLine("İsim :"+isim);
            Console.WriteLine("Soyisim :" + soyisim);            //Public erişim belirleyicisi clas veya başka yerlerde de erişime açıktır ve ulaşılır
            Console.WriteLine("Yaş :"+yas);
            Console.WriteLine("Cinsiyet :"+cinsiyet);

            Console.ReadLine();
        }

        private void isimsoyisimyazdır(string musteriisim, string musterisoyisim)            //Private erişim belirleyicisi sadece musteri {   } parantezinin arasında çağrılabilir
        {
            Console.WriteLine("Musterinin İsim Ve Soyismi :" + isim +" "+soyisim);
            Console.ReadLine();
        }


    }
}
