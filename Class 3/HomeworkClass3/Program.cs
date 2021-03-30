using System;

namespace HomeworkClass3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6]; 
            int i = 0;

            while (i < 6)
            { 
                Console.Write($"Enter number: ");

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
                if (x % 2 == 0)
                {
                    sumEvenNumbers += x;
                }
            }

            Console.WriteLine($"Sum of even numbers: {sumEvenNumbers}");
        }
    }
}
