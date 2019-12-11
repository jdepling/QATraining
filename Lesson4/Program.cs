using System;

namespace Lesson4
{
    /// <summary>
    /// Lesson 4: Methods
    ///     - Pass by value
    ///     - Pass by reference
    ///         - ref
    ///         - out
    ///      - Importance of code reuse
    /// </summary>
    class Program
    {
        // Actions
        private const int Attack      = 1;
        private const int Run         = 2;
        private const int DrinkPotion = 3;

        static void Main(string[] args)
        {
            // Your character's stats
            int yourAttackStrength = 1;
            int yourHealthBar      = 5;
            int potions            = 1;
            int currentAction      = 0;

            // Your enemy's stats
            int enemyAttack    = 1;
            int enemyHealthBar = 5;

            while (yourHealthBar > 0 && enemyHealthBar > 0)
            {
                // Your turn
                GetAction(ref currentAction, yourHealthBar, yourAttackStrength, potions, enemyHealthBar, enemyAttack);

                // Evaluate your action
                EvaluateAction(currentAction, ref enemyHealthBar, ref yourAttackStrength, ref potions, ref yourHealthBar);

                // Enemy's turn
                if (enemyHealthBar > 0)
                    EnemyAttack(ref yourHealthBar, ref enemyAttack);
            }

            // Report
            if (yourHealthBar > 0 && enemyHealthBar == 0)
            {
                Console.WriteLine("Congratulations, you have won the fight!");
                Console.WriteLine("Your health: {0}", yourHealthBar);
                Console.WriteLine("Your potions: {0}", potions);
                Console.WriteLine("Enemy's health: {0}", enemyHealthBar);
            }
            else
            {
                Console.WriteLine("You were defeated");
            }
        }

        /// <summary>
        /// Evaluates the user's choice to either Attack, Drink, or Run
        /// </summary>
        public static void EvaluateAction(int choice, ref int enemyHealthBar, ref int yourAttackStrength, ref int potions, ref int yourHealthBar)
        {
            Console.WriteLine("");
            switch (choice)
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

                    // Exit the program ... that way I don't have to wrap everything in an if statement...
                    System.Environment.Exit(1);

                    break;
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Get the User's choice
        /// </summary>
        public static void GetAction(ref int currentAction, int yourHealthBar, int yourAttackStrength, int potions, int enemyHealthBar, int enemyAttack)
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("You are facing an enemy. Here is what we know....");
            Console.WriteLine("Your health is {0}. Your attack strength is {1}. You have {2} potion(s). Each potion will give you 2 health points.", yourHealthBar, yourAttackStrength, potions);
            Console.WriteLine("Your enemy's health is {0}. Your enemy's attack strength is {1}.", enemyHealthBar, enemyAttack);

            // Display options
            Console.WriteLine("");
            Console.WriteLine("Do you wish to fight or run or drink a potion?");
            Console.WriteLine("Fight = 1");
            Console.WriteLine("Run   = 2");
            Console.WriteLine("Drink = 3");

            // This is some parsing magic. Let's talk about it... 
            Int32.TryParse(Console.ReadLine(), out currentAction);
        }

        /// <summary>
        /// Decrease your health because the enemy just attacked you
        /// </summary>
        public static void EnemyAttack(ref int yourHealthBar, ref int enemyAttack)
        {
            Console.WriteLine("");
            Console.WriteLine("Enemy attacks dealing {0} damage to you", enemyAttack);
            yourHealthBar -= enemyAttack;
            Console.WriteLine("");
        }
    }
}
