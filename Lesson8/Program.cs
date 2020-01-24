using Lesson8.Heros.Spells;
using Lesson8.Items.Potions;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Monster
            Monster monster = new Monster()
            {
                Name = "monster",
                AttackStrength = 100,
                DefenseStrength = 100,
                HealthBar = 100
            };

            // Heros
            Dwarf dwarfy = new Dwarf("Dwarfy", Gender.Male);
            Wizard Gandolf = new Wizard("Gandolf", Gender.Male);
            
            // Dwarfy attacks 
            dwarfy.Attack(monster);

            // Monster defends itself
            monster.Defend(dwarfy);

            // Dwarfy is thirsty
            dwarfy.DrinkPotion(PotionName.MegaPotion);

            // Gandolf decides to do something useful
            Gandolf.Attack(monster);

            // Monster defends itself
            monster.Defend(Gandolf);

            // Gandolf wises up and uses his freaking magic
            Gandolf.CastSpell(SpellName.FireBall);

            // Monster gets pissed and attacks Gandolf
            monster.Attack(Gandolf);

            // Gandolf defends against monster
            Gandolf.Defend(monster);
        }
    }
}
