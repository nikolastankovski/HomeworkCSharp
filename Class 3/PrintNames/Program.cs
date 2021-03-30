using System;

namespace PrintNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1];
            int i = 0;
            while (true)
            {
                Console.Write("Enter a name: ");
                string userInput = Console.ReadLine();
                names[i] = userInput;

                Console.Write("Continue (Y/N): ");
                string proceed = Console.ReadLine();

                if(proceed.ToLower() == "n")
                {
                    for(int j = 0; j < names.Length; j++)
                    {
                        Console.WriteLine($"{j + 1}. {names[j]}");
                    }
                    break;
                }
                else if(proceed.ToLower() == "y")
                {
                    Array.Resize(ref names, names.Length + 1);
                    i++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }

            }
        }
    }
}
