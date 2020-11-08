using System;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.IO;

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
            Console.ReadLine();
            vladik.HungryStatusChanged += putin;
            bochka.HungryStatusChanged += putin;

        }

        private static void putin(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Cat cat = (Cat)sender;
            if (cat.HungryStatus < 20 && rnd.Next(0, 10) < 5)
                cat.Feed();
            else
                cat.GetStatus();
        }

    }
}
    
    

       
    


