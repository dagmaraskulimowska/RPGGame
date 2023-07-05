using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Shaman : Champion
    {
        public Shaman(string Name, string ClassName, int Health, int Attack) : base(Name, ClassName, Health, Attack)
        {

        }

        public static void LightningLasso(Champion champion)
        {
            champion.health += 6;
        }

        public void EarthShock()
        {

        }

        public void ElementalBlast()
        {

        }
    }
}
