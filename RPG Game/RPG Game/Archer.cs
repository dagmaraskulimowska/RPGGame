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
            champion.attack += 4;
        }

        public void FrostArrow()
        {

        }

        public void ThunderShock()
        {

        }
    }
}
