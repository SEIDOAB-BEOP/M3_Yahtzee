using System;
using Helpers;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            #region sprint 3
            Console.WriteLine("\n\nSprint 3");

            ICupOfDice cup = null;
            Console.WriteLine($"Newly created cup\n{cup}");

            //Continue with your code
            #endregion

            #region sprint 4
            Console.WriteLine("\n\nSprint 4");

            ICupDoubleDice doubleDice = null;
            Console.WriteLine($"Cup of double dices\n{doubleDice}");

            //Continue with your code
            #endregion

            #region sprint 5
            Console.WriteLine("\n\nSprint 5");

            //Test the YahtzeeDices
            ICupYahtzeeDice yahtzeeDice = null;
            Console.WriteLine($"Cup of Yahtzee dices\n{yahtzeeDice}");

            #endregion

            //Continue with your code
            Console.WriteLine("\n\nThank you for playing");
        }
    }
}
