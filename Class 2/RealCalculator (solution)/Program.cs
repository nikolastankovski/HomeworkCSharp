using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            bool isOkNum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Enter second number: ");
            bool isOkNum2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.Write("Enter operation: ");
            string operation = Console.ReadLine();

            if (isOkNum1 && isOkNum2)
            {
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Incorrect operation");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter valid number, please, ty <3");
            }

        }
    }
}
