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

            // check which is smaller
            switch (num1 > num2)
            {
                case true:
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                    break;
                default:
                    break;
            }

            // check sum
            int small = num1;
            int sum = 0;
            for (int i = small; i <= num2; i++)
            {
                if (i % small == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine("Sum between " + num1 + " and " + num2 + " that are divisible by " + small + " equals " + sum);
        }
    }
}
 
   







