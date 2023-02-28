using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Ders__Public_Ve_Private_Erişim_Belirleyici_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Müsteri musteri1 = new Müsteri();

            musteri1.isim = "Enes";
            musteri1.soyisim = "Uzun";
            musteri1.yas = 19;
            musteri1.cinsiyet = "Erkek";

            musteri1.MusteriBilgileriniGoster();


        }
    }
}
