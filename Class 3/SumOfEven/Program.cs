using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Make a console application called SumOfEven. Inside it create an array of 6 integers. 
             Get numbers from the input, find and print the sum of the even numbers from the array:
            */

            int[] numbers = { };
            int i = 0;
            string[] ordinals = new string[] { "", "st", "nd", "rd", "th" };

            while (i < 6)
            {

                switch (i)
                {
                    case 1:
                        Console.Write($"Enter {i}{ordinals[i + 1]} number: ");
                        break;
                    case 2:
                        Console.Write($"Enter {i}{ordinals[i + 1]} number: ");
                        break;
                    case 3:
                        Console.Write($"Enter {i}{ordinals[i + 1]} number: ");
                        break;
                    default:
                        Console.Write($"Enter {i}{ordinals[5]} number: ");
                        break;

                }

                bool isOkNum = int.TryParse(Console.ReadLine(), out int num);

                if (isOkNum)
                {
                    numbers[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            int sumEvenNumbers = 0;
            foreach (int x in numbers)
            {
                if(x % 2 == 0)
                {
                    sumEvenNumbers += x;
                }
            }

            Console.WriteLine($"Sum of even numbers: {sumEvenNumbers}");


        }
    }
}
