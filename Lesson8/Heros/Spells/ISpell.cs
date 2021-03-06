﻿namespace Lesson8.Heros.Spells
{
    public interface ISpell
    {
        SpellName Name { get; set; }
        int MannaCost { get; set; }
        SpellType Type { get; set; }
        int HealthPointEffect { get; set; }
        void Cast(string wizardName, string targetName);
    }

}
