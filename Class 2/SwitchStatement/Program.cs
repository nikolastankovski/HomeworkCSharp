using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number from 1 to 3: ");
            bool isOkNum = int.TryParse(Console.ReadLine(), out int num);

            if (isOkNum)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("You got a new car");
                        break;
                    case 2:
                        Console.WriteLine("You got a new plane");
                        break;
                    case 3:
                        Console.WriteLine("You got a new bike");
                        break;
                    default:
                        Console.WriteLine("Wrong number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid unput");
            }
        }
    }
}
