using Lesson8.Heros.Spells;
using Lesson8.Items.Potions;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dwarf Hero
            Dwarf dwarfy = new Dwarf("Dwarfy", Gender.Male);
            dwarfy.Attack();
            dwarfy.DrinkPotion(PotionName.MegaPotion);

            // Wizard Hero
            Wizard Gandolf = new Wizard("Gandolf", Gender.Male);
            Gandolf.Attack();
            Gandolf.CastSpell(SpellName.FireBall);
            Gandolf.Defend();
        }
    }
}
