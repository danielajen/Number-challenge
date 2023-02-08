using System;

namespace Numberchallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            bool letter = false;

            while (letter == false)
            {
                Console.WriteLine("Enter a number");
                letter = int.TryParse(Console.ReadLine(), out num1);

                if (letter == false)
                {
                    Console.WriteLine("Invalid, enter a number instead");
                }
            }
            letter = false;

            while (letter == false)
            {
                Console.WriteLine("Enter another number");
                letter = int.TryParse(Console.ReadLine(), out num2);

                if (letter == false)
                {
                    Console.WriteLine("Invalid, enter a number instead");
                }
                else
                {
                    break;
                }
            }
            // da numz
            Console.WriteLine("The first number is: " + num1);
            Console.WriteLine("The second number is: " + num2);

            //check small
            #region math :(
            int small;
            if ( num1 < num2)
            {
                small = num1;
            }
            else
            {
                small = num2;
            }
            int sum = 0;
            for (int i = small; i<= num1; i++)
            {
                if (i % small == 0)
                {
                    sum += i;
                }
            }
            #endregion

            Console.WriteLine( " sum between " + num1 + " and "+ num2 + " that are divdible by " + small + " equals " + sum);
           ;
        }

    }
  }
  
 
   







