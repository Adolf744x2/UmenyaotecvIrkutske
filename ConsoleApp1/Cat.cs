﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

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
        public event EventHandler HungryStatusChanged;
        byte _hungryStatus;
        public byte HungryStatus
        {
            get { return _hungryStatus; }
            set
            {
                if (value < 0)
                {
                    _hungryStatus = 0;
                    HungryStatusChanged?.Invoke(this, null);
                }
                else if (value > 100)
                {
                    _hungryStatus = 100;
                    HungryStatusChanged?.Invoke(this, null);
                }
                else
                {
                    _hungryStatus = value;
                    HungryStatusChanged?.Invoke(this, null);
                }
            }
        }
        public string GetStatus()

        {
            
            if (HungryStatus <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                return $"{Name} ,{GatAge()} , Кошка умирает от голода ";
            }
            else if (HungryStatus > 10 && HungryStatus <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return $"{Name} ,{GatAge()} , Кошка очень голодна");
            }
            else if (HungryStatus > 40 && HungryStatus <= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return $"{Name} ,{GatAge()} , Кошка хочет кушать ");
            }
            else if (HungryStatus > 70 && HungryStatus <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return $"{Name} ,{GatAge()} , Кошка не против перекусить ");
            }
            else if (HungryStatus > 90)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return $"{Name} ,{GatAge()} , Кошка недавно поела ");
            }
            Console.ResetColor();
            return GetStatus();
        }
        async Task LifeCircle()

        {
            await Task.Delay(10000);
            HungryStatus -= 10;
            await LifeCircle();
            
        }
        public void Feed(byte needfood)
        {
            HungryStatus += needfood;
        }
    }

}
