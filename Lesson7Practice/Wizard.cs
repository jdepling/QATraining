using System.Collections.Generic;

namespace Lesson7Practice
{
    public class Wizard
    {
        public string Name { get; set; }
        public List<string> WizardSpells { get; set; }
        public Weapon Weapon { get; set; }
        public int AtkStrength { get; set; }
        public int DefStrength { get; set; }

        public Wizard(string name, List<string> wizardSpells, Weapon weapon, int atkStrength, int defStrength)
        {
            Name         = name;
            WizardSpells = wizardSpells;
            Weapon       = weapon;
            AtkStrength  = atkStrength;
            DefStrength  = defStrength;
        }
    }


    public enum Weapon
    {
        Staff,
        Sword,
        Bow,
        Bazooka
    }
}
