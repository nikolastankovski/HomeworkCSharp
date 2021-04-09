using System;
using System.Collections.Generic;
using System.Text;
using ATM.Helper;

namespace ATM.Models
{
    public class Customer
    {
        public Customer(string name, string surname, Card card)
        {
            Name = name;
            Surname = surname;
            Card = card;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public Card Card { get; set; }

        public static Customer GetCustomer(Customer[] customers, int cardNumber)
        {
            foreach(Customer x in customers)
            {
                if(x.Card.CardNumber == cardNumber)
                {
                    return x;
                }
            }
            return null;
        }

        public bool CheckBalance()
        {
            Console.WriteLine($"You have {Card.GetBalance()}$ left.");
            return Shared.Choice("Would you like to make another transaction? (Y/N): ", "y", "n");
        }

        public bool MakeWithdrawal()
        {
            while (true)
            {
                Console.Write("How much would you like to withdraw: ");
                bool isOkNum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isOkNum || amount < 0)
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                if (Card.GetBalance() < amount)
                {
                    Console.WriteLine("You don't have enough money. Try again!");
                    continue;
                }
                Card.Withdraw(amount);
                Console.WriteLine($"You withdrew {amount}$. You have {Card.GetBalance()}$ left.");
                break;
            }

            return Shared.Choice("Would you like to make another transaction? (Y/N): ", "y", "n");
        }

        public bool CashDeposit()
        {
            while (true)
            {
                Console.Write("How much would you like to deposit: ");
                bool isOkNum = double.TryParse(Console.ReadLine(), out double amount);
                if (!isOkNum || amount < 0)
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                Card.Deposit(amount);
                Console.WriteLine($"You deposited {amount}$. You have {Card.GetBalance()}$.");
                break;
            }
            return Shared.Choice("Would you like to make another transaction? (Y/N): ", "y", "n");

        }
    }
}
