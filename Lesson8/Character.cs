using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int AttackStrength { get; set; }
        public int DefenseStrength { get; set; }
        public int HealthBar { get; set; }

        public abstract void Attack(Character opponent);
        public abstract void Defend(Character opponent);
    }
}
