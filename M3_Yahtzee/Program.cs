using System;
using System.Collections.Generic;
using Helpers;

namespace M3_Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region sprint 3
            Console.WriteLine("\n\nSprint 3");

            ICupOfDice cup = new csCupOfDice(4);
            Console.WriteLine($"Newly created cup\n{cup}");
            Console.WriteLine($"NrOfDice: {cup.Count}");
            Console.WriteLine($"Dice[0]: {cup[0]}");


            Console.WriteLine();
            ICupOfDice cup2 = new csCupOfDice(10);
            Console.WriteLine($"Newly created cup\n{cup2}");
            Console.WriteLine($"NrOfDice: {cup2.Count}");
            Console.WriteLine($"Dice[0]: {cup2[0]}");

            Console.WriteLine($"Sorted cup\n{cup2.Sort()}");
            Console.WriteLine($"Dice[0]: {cup2[0]}");

            Console.WriteLine($"Shaken cup\n{cup2.Shake()}");
            Console.WriteLine($"Dice[0]: {cup2[0]}");

            if (cup2 is csCupOfDice cup3)
            {
                int count;
                if (cup3.CountFace(enDiceFace.Six, out count))
                {
                    Console.WriteLine($"{count}");
                }
                if (cup3.CountFace(enDiceFace.Four, out count))
                {
                    Console.WriteLine($"{count}");
                }
            }

            csCupOfDice cup4 = cup2 as csCupOfDice;
            if(cup4 != null)
            {
                int count;
                if (cup4.CountFace(enDiceFace.Six, out count))
                {
                    Console.WriteLine($"{count}");
                }
                if (cup4.CountFace(enDiceFace.Four, out count))
                {
                    Console.WriteLine($"{count}");
                }
            }
           
            //Continue with your code
            #endregion

            /*
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
            */


            //Continue with your code
            Console.WriteLine("\n\nThank you for playing");

            Console.ReadKey();
        }
    }
}
