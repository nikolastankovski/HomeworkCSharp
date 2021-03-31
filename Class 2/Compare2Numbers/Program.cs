using System;

namespace Compare2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            bool isOkNum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Enter second number: ");
            bool isOkNum2 = int.TryParse(Console.ReadLine(), out int num2);

            if(isOkNum1 && isOkNum2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{num1} is bigger than {num2}");
                    if(num1 % 2 == 0)
                    {
                        Console.WriteLine($"{num1} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} is an odd number");
                    }
                }
                else if (num1 < num2)
                {
                    Console.WriteLine($"{num1} is smaller than {num2}");
                    if (num2 % 2 == 0)
                    {
                        Console.WriteLine($"{num2} is an even number");
                    }
                    else
                    {
                        Console.WriteLine($"{num2} is an odd number");
                    }
                }
                else
                {
                    Console.WriteLine("They are even");
                    if (num1 % 2 == 0)
                    {
                        Console.WriteLine($"{num1} & {num2} are an even numbers");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} & {num2} are an odd numbers");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
