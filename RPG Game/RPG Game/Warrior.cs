﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Warrior : Champion
    {
        public Warrior(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack) 
        {
    
        }  

        public static void MortalStrike(Champion champion)
        {
            champion.attack += 2;
        }

        public void StormWall()
        {
       
        }
        public void StormOfSwords()
        {

        }
    }
}
