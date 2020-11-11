using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat bochka = new Cat(" Mephedrone ", new DateTime(1999, 10, 1));
            Cat vladik = new Cat(" Heroin ", new DateTime(1998, 11, 02));
            vladik.Makenois();
            vladik.HungryStatus = 150;
            Console.WriteLine($"Кошке по имени{vladik.Name} уже {vladik.GatAge()} лет");
            Console.SetCursorPosition(0, 3 + 1);
            Console.ReadLine();

            CatSmartHouse catSmartH = new CatSmartHouse(900);
            catSmartH.AddCat(vladik);
            catSmartH.AddCat(bochka);
        }

        
        
    }
}
    
    

       
    


