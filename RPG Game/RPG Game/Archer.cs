using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Archer : Champion
    {
        public Archer(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack)
        {

        }

        public static void BlazingArrow(Champion champion)
        {
            Random random = new Random();

            if (random.NextDouble() < 0.3)
            {
                champion.attack += 4;
                Console.WriteLine($"Champion {champion.name} used a Blazing arrow!");
            }
           
        }

        public void FrostArrow()
        {

        }

        public void ThunderShock()
        {

        }
    }
}
