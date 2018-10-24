using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.NerdsAndNumbers {
    class Program {
        static void Main(string[] args) {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Brom", 150, 8, "a greatsword"));
            gameCharacters.Add(new Warrior("Dirk", 999, 5, "a big-ass warhammer"));
            gameCharacters.Add(new Wizard("Celeste", 6, 14, 150, 9));
            gameCharacters.Add(new Wizard("Asher", 8, 12, 120, 15));
            gameCharacters.Add(new Wizard("Morphumax", 5, 10, 80, 18));

            foreach (GameCharacter c in gameCharacters) {
                c.Play();
                Console.WriteLine();
            }

            SimpleCombat.Fight(gameCharacters);

            while (true) { }
        }
    }
}
