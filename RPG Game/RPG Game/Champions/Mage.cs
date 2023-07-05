using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Champions
{
    public class Mage : Champion
    {
        static Random random = new Random();

        public Mage(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack)
        {

        }

        public static void Meteor(Champion champion)
        {
            if (champion.className == "Mage")
            {
                if (random.NextDouble() < 0.3)
                {
                    champion.attack += 5;
                    Console.WriteLine($"Champion {champion.name} used a Meteor!");
                }
            }
        }

        public static void BrainFreeze(Champion champion)
        {
            if (champion.className == "Mage")
            {
                if (random.NextDouble() < 0.4)
                {
                    champion.health += 5;
                    Console.WriteLine($"Champion {champion.name} used a Brain freeze!");
                }
            }
        }
    }
}
