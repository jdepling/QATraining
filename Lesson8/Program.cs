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

            // Dwarf Hero
            Dwarf dwarfy = new Dwarf("Dwarfy", Gender.Male);
            dwarfy.Attack(monster);
            dwarfy.DrinkPotion(PotionName.MegaPotion);

            // Wizard Hero
            Wizard Gandolf = new Wizard("Gandolf", Gender.Male);
            Gandolf.Attack(monster);
            Gandolf.CastSpell(SpellName.FireBall);
            Gandolf.Defend(monster);
        }
    }
}
