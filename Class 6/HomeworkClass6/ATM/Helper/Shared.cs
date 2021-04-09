using System;
using System.Collections.Generic;
using System.Text;
using ATM.Models;

namespace ATM.Helper
{
    public class Shared
    {
        public static bool Choice(string message, string positiveChoice, string negativeChoice)
        {
            while (true)
            {
                Console.Write(message);
                string answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer) && answer.ToLower() != positiveChoice && answer.ToLower() != negativeChoice)
                {
                    Console.WriteLine("Invalid answer.");
                    continue;
                }
                Console.Clear();
                if (answer.ToLower() == "y")
                    break;

                return false;
            }
            return true;
        }

        public static Card[] CreateCards()
        {
            return new Card[] {
                new Card (12341234, 1234, 5000),
                new Card (43214321, 4321, 5000),
                new Card (56785678, 5678, 5000)
            };
        }

        public static Customer[] CreateCustomers(Card[] cards)
        {
            return new Customer[]
            {
                new Customer("Nikola", "Nikolovski", cards[0]),
                new Customer("Martin", "Martinovski", cards[1]),
                new Customer("Petko", "Petkovski", cards[2]),
            };
        }
    }
}
