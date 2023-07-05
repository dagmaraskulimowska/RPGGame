﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Warrior : Champion
    {
        static Random random = new Random();
        public Warrior(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack) 
        {
    
        }

        public static void MortalStrike(Champion champion)
        {
            if (random.NextDouble() < 0.5)
            {
                champion.attack += 2;
                Console.WriteLine($"Chamoion {champion.name} used a Mortal Strike!");
            }
        }

        public static void StormWall(Champion champion)
        {
            if (random.NextDouble() < 0.3)
            {
                champion.health += 5;
                Console.WriteLine($"Chamoion {champion.name} used a Storm wall!");
            }
        }
    }
}
