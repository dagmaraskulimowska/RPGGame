using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    public class Fight : IShowPlayers
    {
        public void Battle(List<Champion> champions)
        {
            List<Champion> winners = new List<Champion>();

            for (int i = 0; i < champions.Count; i++) 
            {
                for (int j = i+1; j < champions.Count; j++) 
                { 
                    while (champions[i].health > 0 && champions[j].health > 0)
                    {
                        champions[i].health -= champions[j].attack;
                        champions[j].health -= champions[i].attack;

                        ShowPlayers();

                        if (champions[i].health <= 0)
                        {
                            Console.WriteLine("\nChampion " + champions[i].name + " is dead!");
                            champions[i].attack = 0;
                            winners.Add(champions[j]);
                        }
                        else if (champions[j].health <= 0)  
                        {
                            Console.WriteLine("\nChampion " + champions[j].name + " is dead!");
                            champions[j].attack = 0;
                            winners.Add(champions[i]);
                        }
                    }    
                }
            }
            winners.Reverse();
            Console.WriteLine("\nWinners: ");
        
            foreach (var winner in winners)
            {
                    Console.WriteLine("Player " + winner.name + " won!");
            }
        }
        public interface ShowPlayersInterface
        {
            public void ShowPlayers();
        }

        public void ShowPlayers()
        {
            int i = 0;
            foreach (var champion in Game.champions)
            {
                i++;
                Console.WriteLine("Player " + i + " name: " + champion.name + ", class: " + champion.className + ", health: " + champion.health + ", attack: " + champion.attack);
            }
        }
    } 
}
