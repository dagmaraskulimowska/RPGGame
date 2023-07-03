using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Game
{
    public class Champion
    {
        public string name;
        public string className;
        public int health;
        public int attack;

        public Champion(string Name, string ClassName, int Health, int Attack)
        {
            name = Name;
            className = ClassName;
            health = Health;
            attack = Attack;
        }
    }
}
