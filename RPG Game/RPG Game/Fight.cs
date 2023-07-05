using RPG_Game.Champions;
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
                for (int j = i + 1; j < champions.Count; j++)
                {
                    while (champions[i].health > 0 && champions[j].health > 0)
                    {
                        champions[i].health -= champions[j].attack;
                        champions[j].health -= champions[i].attack;

                        Warrior.MortalStrike(champions[i]);
                        Warrior.StormWall(champions[i]);
                        Warrior.MortalStrike(champions[j]);
                        Warrior.StormWall(champions[j]);

                        Mage.Meteor(champions[i]);
                        Mage.BrainFreeze(champions[i]);
                        Mage.Meteor(champions[j]);
                        Mage.BrainFreeze(champions[j]);

                        Shaman.LightningLasso(champions[i]);
                        Shaman.EarthShock(champions[i]);
                        Shaman.LightningLasso(champions[j]);
                        Shaman.EarthShock(champions[j]);

                        Archer.BlazingArrow(champions[i]);
                        Archer.FrostArrow(champions[i]);
                        Archer.BlazingArrow(champions[j]);
                        Archer.FrostArrow(champions[j]);

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
            Console.WriteLine($"Player {winners[0].name} won!");

            if (winners.Count == 2)
            {
                Console.WriteLine($"Second place: {winners[1].name}");
            }
            else if (winners.Count > 2)
            {
                Console.WriteLine($"Second place: {winners[1].name}, third place: {winners[2].name}");
            }
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
