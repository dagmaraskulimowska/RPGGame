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
                            
                            if (random.NextDouble() < 0.3)
                            {
                                Warrior.MortalStrike(champions[i]);
                                Console.WriteLine($"Player {champions[i].name} used a Mortal Strike!");
                            }
                            else if (random.NextDouble() < 0.3)
                            {
                                Warrior.MortalStrike(champions[j]);
                                Console.WriteLine($"Player {champions[j].name} used a Mortal Strike!");
                            }
                        }

                        else if ((champions[i].className == "Mage") || (champions[j].className == "Mage"))
                        {

                            if (random.NextDouble() < 0.3)
                            {
                                Mage.Meteor(champions[i]);
                                Console.WriteLine($"Player {champions[i].name} used a Meteor!");
                            }
                            else if (random.NextDouble() < 0.3)
                            {
                                Mage.Meteor(champions[j]);
                                Console.WriteLine($"Player {champions[j].name} used a Meteor!");
                            }
                        }

                        else if ((champions[i].className == "Shaman") || (champions[j].className == "Shaman"))
                        {

                            if (random.NextDouble() < 0.3)
                            {
                                Shaman.LightningLasso(champions[i]);
                                Console.WriteLine($"Player {champions[i].name} used a Lightning lasso!");
                            }
                            else if (random.NextDouble() < 0.3)
                            {
                                Shaman.LightningLasso(champions[j]);
                                Console.WriteLine($"Player {champions[j].name} used a Lightning lasso!");
                            }
                        }

                        else if ((champions[i].className == "Archer") || (champions[j].className == "Archer"))
                        {

                            if (random.NextDouble() < 0.3)
                            {
                                Archer.BlazingArrow(champions[i]);
                                Console.WriteLine($"Player {champions[i].name} used a Blazing arrow!");
                            }
                            else if (random.NextDouble() < 0.3)
                            {
                                Archer.BlazingArrow(champions[j]);
                                Console.WriteLine($"Player {champions[j].name} used a Blazing arrow!");
                            }
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
