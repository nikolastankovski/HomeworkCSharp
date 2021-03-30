using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

                Test Data:
                Enter the First number: 10
                Enter the Second number: 15
                Enter the third number: 20
                Enter the fourth number: 30
            */

            int i = 1;
            int numbers = 0;
            string[] ordinals = new string[] {"","st", "nd", "rd", "th"};
            while (i <= 4)
            {
                switch (i)
                {
                    case 1:
                        Console.Write($"Enter {i}{ordinals[i]} number: ");
                        break;
                    case 2:
                        Console.Write($"Enter {i}{ordinals[i]} number: ");
                        break;
                    case 3:
                        Console.Write($"Enter {i}{ordinals[i]} number: ");
                        break;
                    default:
                        Console.Write($"Enter {i}{ordinals[4]} number: ");
                        break;

                }

                bool isOkNum = int.TryParse(Console.ReadLine(), out int num);

                if (isOkNum)
                {
                    numbers = numbers + num;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            Console.WriteLine($"Average: {numbers / 4}");

        }
    }
}
