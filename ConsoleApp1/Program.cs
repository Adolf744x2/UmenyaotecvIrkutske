using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat vladik = new Cat(" Heroin", new DateTime(1998, 11, 02));
            vladik.Makenois();
            vladik.HungryStatus = 150;
            Console.WriteLine($"Кошке по имени{vladik.Name} уже {vladik.GatAge()} лет");
            Console.ReadLine();

        }
    }

}
