using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__Öğrenci_Arayüzü_Uygulaması_
{
    public class Ogrenci
    {
        private string ogrno;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulisim;

        public Ogrenci(string _ogrno, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulisim)
        {
          ogrno = _ogrno;
          isim = _isim;
          soyisim = _soyisim;
          vize1 = _vize1;
          vize2 = _vize2;
          final = _final;
          okulisim = _okulisim;

        }

        public void ogrenciBilgileriGoster()
        {
            Console.WriteLine("                                                              ");
            Console.WriteLine("Öğrenci Numarası :" + ogrno);
            Console.WriteLine("Öğrenci İsmi :" + isim);
            Console.WriteLine("Öğrenci Vize1 Puanı :" + vize1);
            Console.WriteLine("Öğrenci Vize2 Puanı :" + vize2);
            Console.WriteLine("Öğrenci Final Puanı :" + final);
            Console.WriteLine("Öğretim Gördüğü Okulun İsmi :" + okulisim);
            Console.WriteLine("                                                       ");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("                                                       ");

        }

        public double ogrenciOrtalamasıBul()
        {

            double not_ortalamsı = vize1 * 1/5 + vize2 * 1/5 + final * 3/5;
                return not_ortalamsı;

        }

        public void okulGetir()
        {
            Console.WriteLine("                                                              ");
            Console.WriteLine("Öğrencinin Okuduğu Okulun ismi :" + okulisim);
            Console.WriteLine("                                                              ");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("                                                              ");

        }

    }
}
