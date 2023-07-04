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
        public string name { get; set; }
        /* private string name; - field
           public string Name - property
            {
             get { return name; }
             set { name = value; }
            }
        */
        public string className { get; set; }
        public int health { get; set; }
        public int attack { get; set; }

        public Champion(string Name, string ClassName, int Health, int Attack)
        {
            name = Name;
            className = ClassName;
            health = Health;
            attack = Attack;
        }
    }
}
