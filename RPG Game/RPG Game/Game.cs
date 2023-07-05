using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Game : IShowPlayers
    {
        public static List<Champion> champions = new List<Champion>();
        public void Start()
        {
            Console.WriteLine("How many players are?");
            int numberOfPlayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Enter name for player " + (i + 1));
                string name = Console.ReadLine();
                string className = "";

                Console.WriteLine("Select class for: " + name);
                Console.WriteLine("1. Warrior");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Archer");
                Console.WriteLine("4. Shaman");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        className = "Warrior";
                        break;
                    case 2:
                        className = "Mage";
                        break;
                    case 3:
                        className = "Archer";
                        break;
                    case 4:
                        className = "Shaman";
                        break;
                    default:
                        Console.WriteLine("Wrong number! Please select correct number");
                        break;
                }

                if (className == "Warrior")
                {
                    Warrior warrior = new Warrior(name, className, RandomHealth(15), RandomAttack(3));
                    champions.Add(warrior);

                }
                else if (className == "Mage")
                {
                    Mage mage = new Mage(name, className, RandomHealth(13), RandomAttack(4));
                    champions.Add(mage);
                }
                else if (className == "Archer")
                {
                    Archer archer = new Archer(name, className, RandomHealth(9), RandomAttack(5));
                    champions.Add(archer);
                }
                else if (className == "Shaman")
                {
                    Shaman shaman = new Shaman(name, className, RandomHealth(11), RandomAttack(4));
                    champions.Add(shaman);
                }
            }
            
            Console.WriteLine("Player list: ");
            ShowPlayers();

            Console.WriteLine("\nThe fight has begun!");
            Fight fight = new Fight();

            fight.Battle(champions);
        }

        public interface ShowPlayersInterface
        {
            public void ShowPlayers();
        }
        public void ShowPlayers() 
        {
            int i = 0;
            foreach (var champion in champions)
            {
                i++;
                Console.WriteLine("Player " + i + " name: " + champion.name + ", class: " + champion.className + ", health: " + champion.health + ", attack: " + champion.attack);
            }
        }

        public int RandomHealth(int maxHealth)
        {
            Random random = new Random();
            int health = random.Next(8, maxHealth + 1);
            return health;
        }

        public int RandomAttack(int maxAttack)
        {
            Random random = new Random();
            int attack = random.Next(2, maxAttack + 1);
            return attack;
        }
    }
}
