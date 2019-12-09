using System;
using System.Collections.Generic;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {

            // If statements
            int count = 15;

            if (count == 1)
            {
                Console.WriteLine("count is one");
            } else if (count == 2)
            {
                Console.WriteLine("count is two");
            }
            else
            {
                Console.WriteLine("I have no idea what count is");
            }


            // Switch statements
            switch (count)
            {
                case 1:
                    Console.WriteLine("count is 1");
                    break;

                case 2:
                    Console.WriteLine("count is 2");
                    break;

                case 3:
                    Console.WriteLine("count is 3");
                    break;

                default:
                    Console.WriteLine("I have no idea what count is");
                    break;
            }


            // Ternary
            string message = count >= 5 ? "I am greater than or equal to 5" : "I am not greater than or equal to 5";
            Console.WriteLine(message);
        }
    }
}
