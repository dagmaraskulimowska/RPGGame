using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Champions
{
    public class Shaman : Champion
    {
        static Random random = new Random();

        public Shaman(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack)
        {

        }

        public static void LightningLasso(Champion champion)
        {
            if (random.NextDouble() < 0.3)
            {
                champion.health += 6;
                Console.WriteLine($"Champion {champion.name} used a Lightning lasso!");
            }
        }

        public static void EarthShock(Champion champion)
        {
            if (random.NextDouble() < 0.5)
            {
                champion.attack += 2;
                Console.WriteLine($"Champion {champion.name} used a Earth shock!");
            }
        }
    }
}
