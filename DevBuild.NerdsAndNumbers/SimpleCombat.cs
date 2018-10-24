using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevBuild.NerdsAndNumbers {
    class SimpleCombat {

        public static void Fight(List<GameCharacter> players) {
            Console.WriteLine("*whistles* \"Games without Frontiers\"");

            Random r = new Random();
            int combatant1 = 0;
            int combatant2 = 0;
            int winner = 0;

            while (players.Count > 1) {

                while (combatant1.Equals(combatant2) || combatant1 > players.Count || combatant2 > players.Count) {
                    combatant1 = r.Next(0, 65535)%players.Count;
                    Thread.Sleep(100);
                    combatant2 = r.Next(0, 65535)%players.Count;
                }
                //let's decide the winner by coin flip for now
                winner = r.Next(0, 2);

                switch (winner) 
                    {
                    case 0: {
                            Console.WriteLine(players[combatant1].Name + players[combatant1].AttackVictoryAction + players[combatant2].Name);
                            players.RemoveAt(combatant2);
                            break;
                        }
                    case 1: {
                            Console.WriteLine(players[combatant2].Name + players[combatant2].AttackVictoryAction + players[combatant1].Name);
                            players.RemoveAt(combatant1);
                            break;
                        }
                }
                combatant1 = 0;
                combatant2 = 0;
            }
            Console.WriteLine($"{players[0].Name} emerges victorious!");

        }

    }
}
