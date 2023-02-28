using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekKod__Çarpım_Tablosu_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Çarpım tablosu örnekkodu

            for (int i=1; i<=10 ; i++)
            {
                for (int j=1; j<=10 ; j++)
                {
                    Console.WriteLine(j+"x"+i+"="+(i*j));
                }
            }
            Console.ReadLine();


        }
    }
}
