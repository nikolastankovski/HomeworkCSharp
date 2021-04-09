using System;
using System.Threading;
using ATM.Helper;
using ATM.Models;
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Card[] cards = Shared.CreateCards();
            Customer[] customers = Shared.CreateCustomers(cards);
            StartMenu(cards, customers);
        }
        static void StartMenu(Card[] cards, Customer[] customers)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome!");
                Console.WriteLine("");
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Register");
                Console.WriteLine("--------------------");
                Console.Write("Your choice: ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out int answer);
                if (isOkNum)
                {
                    switch (answer)
                    {
                        case 1:
                            {
                                Console.Clear();
                                LogIn(cards, customers);
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                (Customer[], Card[]) newUsernewCard = Register(cards, customers);
                                customers = newUsernewCard.Item1;
                                cards = newUsernewCard.Item2;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid choise. Try Again!");
                                Thread.Sleep(1000);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Try Again");
                    Thread.Sleep(1000);
                }
            }
        }
        static void LogIn(Card[] cards, Customer[] customers) 
        {
            Console.WriteLine("Welcome to the ATM app!");
            Console.WriteLine("---------------------------");
            int cardNumber;
            int PIN;

            while (true)
            {
                Console.Write("Please enter your card number (ex. 0000-0000) or Q for exit: ");
                string userInputCardNumber = Console.ReadLine();
                if(userInputCardNumber.ToLower() != "q")
                {
                    if (string.IsNullOrEmpty(userInputCardNumber))
                    {
                        Console.WriteLine("You need to enter card number!");
                        continue;
                    }
                    bool isOkNum = int.TryParse(userInputCardNumber.Replace("-", ""), out cardNumber);
                    if (!isOkNum || cardNumber.ToString().Length != 8)
                    {
                        Console.WriteLine("Invalid card number. Try again!");
                        continue;
                    }
                    
                    if (Card.CheckIfCardExists(cards, cardNumber))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card doesn't exist!");
                        if (Shared.Choice("Would you like to try again? (Y/N): ", "y", "n"))
                            continue;
                        return;

                    }
                }
                else
                {
                    return;
                }
            }

            while (true)
            {
                Customer cardUser = Customer.GetCustomer(customers, cardNumber);
                Card card = Card.GetCard(cards, cardNumber);
                Console.Write("Please enter your card PIN or Q for exit: ");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "q")
                {
                    bool cardPIN = int.TryParse(userInput, out PIN);
                    if (!cardPIN)
                    {
                        Console.WriteLine("You need to enter you car PIN!");
                        continue;
                    }
                    if (card.ValidateCredentials(cardNumber, PIN))
                    {
                        WelcomeMenu(cardUser);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid PIN. Try again!");
                        continue;
                    }
                }
                else
                    return;
            }
        }
        static void WelcomeMenu(Customer customer)
        {
            Console.Clear();
            Console.WriteLine($"Welcome, {customer.Name} {customer.Surname}");
            while (true)
            {
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Cash Withdrawal");
                Console.WriteLine("3. Cash Deposit");
                Console.Write("What would you like to do: ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out int option);

                if (!isOkNum)
                {
                    Console.WriteLine("Please enter a number!");
                    continue;
                }
                bool goAgain = true;
                switch (option)
                {
                    case 1:
                        goAgain = customer.CheckBalance(); 
                        break;
                    case 2:
                        goAgain = customer.MakeWithdrawal();
                        break;
                    case 3:
                        goAgain = customer.CashDeposit();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }

                if (goAgain)
                    continue;
                else
                    Console.WriteLine("Thank you using the ATM app");
                    Thread.Sleep(2000);
                    break;
            }
        }
        static (Customer[], Card[]) Register(Card[] cards, Customer[] customers)
        {
            string name;
            string surname;
            int cardNumber;
            int PIN;

            while (true)
            {
                Console.Write("Your Name: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Please enter your name!");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("Your Surname: ");
                surname = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Please enter your name!");
                    continue;
                }
                break;
            }
            while (true)
            {
                Console.Write("Enter Card number (ex. 0000-0000): ");
                string userInputCardNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(userInputCardNumber))
                {
                    Console.WriteLine("Please enter a card number!");
                    continue;
                }
                bool isOkNum = int.TryParse(userInputCardNumber.Replace("-", ""), out cardNumber);
                if(!isOkNum || cardNumber.ToString().Length != 8)
                {
                    Console.WriteLine("Invalid card number. Try Again!");
                    continue;
                }
                if(Card.CheckIfCardExists(cards, cardNumber))
                {
                    Console.WriteLine("Card already exists! Try Again!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Enter Card PIN: ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out PIN);
                if (!isOkNum)
                {
                    Console.WriteLine("Please a valid PIN!");
                    continue;
                }
                break;
            }

            if(!Shared.Choice("Would you like to register? (Y/N): ", "y", "n"))
            {
                return (customers, cards);
            }

            Card newCard = new Card(cardNumber, PIN, 500);
            Customer newCustomer = new Customer(name, surname, newCard);

            Array.Resize(ref cards, cards.Length + 1);
            cards[cards.Length - 1] = newCard;

            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = newCustomer;

            Console.WriteLine("You have successfully registered!");
            Thread.Sleep(1000);

            return (customers, cards);
        }
    }
}
