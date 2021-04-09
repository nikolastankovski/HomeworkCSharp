using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Models
{
    public class Card
    {
        public Card(int cardNumber, int pin, double balance)
        {
            CardNumber = cardNumber;
            PIN = pin;
            Balance = balance;
        }
        public int CardNumber { get; set; }
        private int PIN { get; set; }
        private double Balance { get; set; }

        public static bool CheckIfCardExists(Card[] cards, int cardNumber)
        {
            foreach(Card card in cards)
            {
                if(card.CardNumber == cardNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public static Card GetCard(Card[] cards, int cardNumber)
        {
            foreach (Card card in cards)
            {
                if (card.CardNumber == cardNumber)
                {
                    return card;
                }
            }
            return null;
        }

        public bool ValidateCredentials(int userCardNumber, int userPIN)
        {
            if(userPIN == PIN && userCardNumber == CardNumber)
            {
                return true;
            }
            return false;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
