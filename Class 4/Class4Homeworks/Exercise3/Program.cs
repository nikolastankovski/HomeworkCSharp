using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Hello from SEDC Codeacademy 2021";
            while (true)
            {
                Console.Write("Enter number: ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out int num);
                if(isOkNum && num < testString.Length)
                {
                    SubStrings(testString, num);
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
            }

        }

        static void SubStrings(string text, int num)
        {
            string newString = text.Substring(0, num);
            Console.WriteLine($"{newString} is {newString.Length} long");
        }
    }
}
