using System;
using System.Threading;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> numbers = new Queue<double>();
            while (true)
            {
                Console.Write("Enter a number: ");
                bool isOkNum = double.TryParse(Console.ReadLine(), out double num);
                if (isOkNum)
                {
                    numbers.Enqueue(num);
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a number!");
                    Thread.Sleep(1000);
                    continue;
                }

                string answer;
                while (true)
                {
                    Console.Write("Would you like continue (Y/N): ");
                    answer = Console.ReadLine().ToLower();

                    if(string.IsNullOrEmpty(answer) || answer != "y" && answer != "n")
                    {
                        Console.WriteLine("Invalid input! Try Again!");
                        continue;
                    }
                    break;
                }

                if (answer == "y")
                    continue;
                break;
            }

            foreach(double number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
