using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat
    {
        public Cat(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }
        public string Name { get; set; }
        public void Makenois()
        {
            Console.WriteLine($"{Name} мяукает");
        }
        public DateTime Birthday { get; set; }
        public int GatAge()
        {
            return (DateTime.Today - Birthday).Days / 365;
        }
    }

}
