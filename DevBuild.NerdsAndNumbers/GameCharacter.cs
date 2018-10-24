using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.NerdsAndNumbers {
    public class GameCharacter {
        public string   Name { get; set; }
        public int      HitPoints { get; set; } = 10;
        public int      Strength { get; set; }
        public int      Intelligence { get; set; }

        public GameCharacter(string characterName, int startingStrength, int startingIntelligence) {
            Name = characterName;
            Strength = startingStrength;
            Intelligence = startingIntelligence;
        }

        public virtual void Play() {
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Name is {Name}");
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Strength is {Strength}");
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Intelligence is {Intelligence}");
        }
    }

    public class Warrior : GameCharacter {

        public string WeaponType { get; set; }

        public Warrior(string characterName, int startingStrength, int startingIntelligence, string weapon) : 
                        base(characterName, startingStrength, startingIntelligence) {
            WeaponType = weapon;
        }

        public override void Play() {
            base.Play();
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Weapon Type is {WeaponType}");
        }
    }

    public class MagicUsingCharacter : GameCharacter {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter( string characterName, int startingStrength, int startingIntelligence, int startingMagicalEnergy) : 
                                        base(characterName, startingStrength, startingIntelligence) {
            MagicalEnergy = startingMagicalEnergy;
        }

        public override void Play() {
            base.Play();
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Magical Energy is {MagicalEnergy}");
        }
    }

    class Wizard : MagicUsingCharacter {
        public int SpellNumber { get; set; }
        public Wizard(string characterName, int startingStrength, int startingIntelligence, int startingMagicalEnergy, int startingSpellNumber) : 
                        base(characterName, startingStrength, startingIntelligence, startingMagicalEnergy) {
            SpellNumber = startingSpellNumber;
        }

        public override void Play() {
            base.Play();
            Console.WriteLine($"{this.GetType().Name.ToString()}'s Spell Number is {SpellNumber}");
        }
    }
}
