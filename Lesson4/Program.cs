using System;

namespace Lesson4
{
    /// <summary>
    /// Lesson 4: Methods
    /// </summary>
    class Program
    {
        // Actions
        private const int Attack      = 1;
        private const int Run         = 2;
        private const int DrinkPotion = 3;

        static void Main(string[] args)
        {
            // Your character
            int yourAttackStrength = 1;
            int yourHealthBar      = 5;
            int potions            = 1;
            int currentAction      = 0;

            // Your enemy
            int enemyAttack    = 1;
            int enemyHealthBar = 5;

            // Turn one
            Console.WriteLine("You are facing an enemy. Here is what we know....");
            Console.WriteLine("Your health is {0}. Your attack strength is {1}. You have {2} potion(s). Each potion will give you 2 health points.", yourHealthBar, yourAttackStrength, potions);
            Console.WriteLine("Your enemy's health is {0}. Your enemy's attack strength is {1}.", enemyHealthBar, enemyAttack);
            
            // Display options
            Console.WriteLine("Do you wish to fight or run or drink a potion?");
            Console.WriteLine("Fight = 1");
            Console.WriteLine("Run   = 2");
            Console.WriteLine("Drink = 3");
            
            // This is some parsing magic. Let's talk about it... 
            Int32.TryParse(Console.ReadLine(), out currentAction);

            // Evaluate your action
            switch (currentAction)
            {
                case Attack:
                    Console.WriteLine("You chose to attack. You punched that fool. You dealt {0} damage to your enemy", yourAttackStrength);

                    // Decrease enemy's health by the amount of your attack strength
                    enemyHealthBar -= yourAttackStrength;
                        break;

                case Run:
                    Console.WriteLine("You are a coward and ran like a little girl.");
                    Console.WriteLine("Do you want to call your mommy?");

                    // Exit the program ... that way I don't have to wrap everything in an if statement...
                    System.Environment.Exit(1);

                    break;

                case DrinkPotion:

                    if(potions > 0)
                    {
                        potions       -= 1;
                        yourHealthBar += 2;
                        Console.WriteLine("You health is now {0}. You have {1} potion(s) left.", yourHealthBar, potions);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough potions. You wasted your turn!");
                    }

                    break;

                default:
                    Console.WriteLine("You are a coward and ran like a little girl.");
                    Console.WriteLine("Do you want to call your mommy?");
                    break;
            }

            // Enemy attacks
            Console.WriteLine("Enemy attacks dealing {0} damage to you", enemyAttack);
            yourHealthBar -= enemyAttack; // This decreases your health by whatever value is stored in "enemyAttack"

            // Turn 2
            Console.WriteLine("Your health is {0}. Your attack strength is {1}. You have {2} potion(s). Each potion will give you 2 health points.", yourHealthBar, yourAttackStrength, potions);
            Console.WriteLine("Your enemy's health is {0}. Your enemy's attack strength is {1}.", enemyHealthBar, enemyAttack);

            // Display options
            Console.WriteLine("Do you wish to fight or run or drink a potion?");
            Console.WriteLine("Fight = 1");
            Console.WriteLine("Run   = 2");
            Console.WriteLine("Drink = 3");

            // This is some parsing magic. Let's talk about it... 
            Int32.TryParse(Console.ReadLine(), out currentAction);

            // Evaluate your action
            switch (currentAction)
            {
                case Attack:
                    Console.WriteLine("You chose to attack. You punched that fool. You dealt {0} damage to your enemy", yourAttackStrength);
                    
                    // Decrease enemy's health
                    enemyHealthBar -= yourAttackStrength;

                    break;
                case Run:
                    Console.WriteLine("You are a coward and ran like a little girl.");
                    Console.WriteLine("Do you want to call your mommy?");

                    // Exit the program ... that way I don't have to wrap everything in an if statement...
                    System.Environment.Exit(1);

                    break;
                case DrinkPotion:
                    if (potions > 0)
                    {
                        potions -= 1;
                        yourHealthBar += 2;
                        Console.WriteLine("You health is now {0}. You have {1} potion(s) left.", yourHealthBar, potions);
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough potions. You wasted your turn!");
                    }
                    break;
                default:
                    Console.WriteLine("You are a coward and ran like a little girl.");
                    Console.WriteLine("Do you want to call your mommy?");
                    break;
            }

            /*
             * I need help finishing this program...
             * I am noticing that for every turn I have to copy and paste the same thing
             * over and over again.
             * I wish there was a way I could reuse code!
             */

        }
    }
}
