﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystals;
            int priceUnitCrystal = 10;

            Console.WriteLine("Добро пожаловать в наш магазин кристаллов.");
            Console.Write("Скажите, сколько у вас золота: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сегодня в продаже кристаллы по " + priceUnitCrystal + " золота.");
            Console.Write("Скажите, сколько кристаллов вы хотите купить: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            gold = gold - crystals * priceUnitCrystal;
            Console.WriteLine($"У вас теперь кристаллов {crystals}, остатаок золотв {gold}. Приятно было иметь с вами дело!");
        }
    }
}
