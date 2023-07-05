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
            Random random = new Random();

            for (int i = 0; i < champions.Count; i++) 
            {
                for (int j = i+1; j < champions.Count; j++) 
                { 
                    while (champions[i].health > 0 && champions[j].health > 0)
                    {
                        champions[i].health -= champions[j].attack;
                        champions[j].health -= champions[i].attack;

                        if ((champions[i].className == "Warrior") || (champions[j].className == "Warrior"))
                        {
                                Warrior.MortalStrike(champions[i]);
                                Warrior.MortalStrike(champions[j]);
                        }

                        else if ((champions[i].className == "Mage") || (champions[j].className == "Mage"))
                        {                   
                                Mage.Meteor(champions[i]);
                                Mage.Meteor(champions[j]);                            
                        }

                        else if ((champions[i].className == "Shaman") || (champions[j].className == "Shaman"))
                        {
                                Shaman.LightningLasso(champions[i]);
                                Shaman.LightningLasso(champions[j]);
                        }

                        else if ((champions[i].className == "Archer") || (champions[j].className == "Archer"))
                        {
                                Archer.BlazingArrow(champions[i]);
                                Archer.BlazingArrow(champions[j]);
                        }

                        ShowPlayers();

                        if (champions[i].health <= 0)
                        {
                            Console.WriteLine($"Champion {champions[i].name} is dead!");
                            champions[i].attack = 0;
                            winners.Add(champions[j]);
                        }
                        else if (champions[j].health <= 0)  
                        {
                            Console.WriteLine($"Champion {champions[j].name} is dead!");
                            champions[j].attack = 0;
                            winners.Add(champions[i]);
                        }
                    }    
                }
            }
            winners.Reverse();
            Console.WriteLine("Winner: ");
            Console.WriteLine($"Player {winners[0].name} won!");
        }

        public void ShowPlayers()
        {
            int i = 0;
            foreach (var champion in Game.champions)
            {
                i++;
                Console.WriteLine($"Player {i} name: {champion.name}, class: {champion.className}, health: {champion.health}, attack: {champion.attack}");
            }
        }
    } 
}
