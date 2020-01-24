using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    public class Monster : Character
    {
        public override void Attack(Character opponent)
        {
            Console.WriteLine("{0} attacks {1} attempting to deal {2} damage", Name, opponent.Name, AttackStrength);
        }

        public override void Defend(Character opponent)
        {
            int damageToMonster = 0;
            if (DefenseStrength < opponent.AttackStrength)
            {
                damageToMonster = opponent.AttackStrength - DefenseStrength;
                HealthBar -= damageToMonster;
            }

            Console.WriteLine("{0} blocks {1} points of damage", Name, DefenseStrength);
            Console.WriteLine("{0} receives {1} damage", Name, damageToMonster);

        }
    }
}
