using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentGroup1 = { "Martin", "Nikola", "Petko", "Trajko", "Mile", "Miki" };
            string[] studentGroup2 = { "Tea", "Petre", "Goce", "Blagoja", "Viktor", "Djole" };

            bool isOkGroup;

            while (true)
            {
                Console.Write("Enter 1 or 2 to display users: ");
                isOkGroup = int.TryParse(Console.ReadLine(), out int groupNumber);

                if (isOkGroup)
                {
                    if (groupNumber == 1)
                    {
                        for (int i = 0; i < studentGroup1.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("The Students of G1 are:");
                            }
                            Console.WriteLine($"{i + 1}. {studentGroup1[i]}");
                        }
                    }
                    else if (groupNumber == 2)
                    {
                        for (int i = 0; i < studentGroup2.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("The Students of G2 are:");
                            }
                            Console.WriteLine($"{i + 1}. {studentGroup2[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid group number");
                        continue;
                    }
                    break;
                }
                else
                    Console.WriteLine("Invalid group number");

            }
        }
    }
}
