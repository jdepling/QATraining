using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Practice
{
    public class Dragon : Monster
    {
        public Dragon(int ac, int hp, string name)
        {
            AC = ac;
            HP = hp;
            Name = name;
        }

        public override void Attack() 
        {
            Console.WriteLine("The dragon breathes his fiery flames of death upon you and melts your armor wow this is morbid");
        }
    }
}
