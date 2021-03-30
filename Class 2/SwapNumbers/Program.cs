using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOkNum1 = int.TryParse(Console.ReadLine(), out int num1);
            bool isOkNum2 = int.TryParse(Console.ReadLine(), out int num2);

            if (isOkNum1 && isOkNum2)
            { 
                Console.WriteLine($"Num1: {num1}, Num2: {num2}");

                int middleMan = 0;
                middleMan = num2;
                num2 = num1;
                num1 = num2;

                Console.WriteLine($"Num1: {num1}, Num2: {num2}");
            }
        }
    }
}
