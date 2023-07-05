using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Mage : Champion
    {
        public Mage(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack)
        {

        }

        public static void Meteor(Champion champion)
        {
            Random random = new Random();

            if (random.NextDouble() < 0.3)
            {
                champion.attack += 5;
                Console.WriteLine($"Champion {champion.name} used a Meteor!");
            }
        }

        public void PhoenixFlames()
        {

        }

        public void BrainFreeze()
        {

        }
    }
}
