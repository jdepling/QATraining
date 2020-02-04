using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Practice
{
    public class Monster
    {
       public int AC  { get; set; }
       public int HP { get; set; }
       public string Name { get; set; }

        public virtual void Attack() 
        {
            Console.WriteLine("The monster attacks! RUN!!!!");
        }
    }
}
