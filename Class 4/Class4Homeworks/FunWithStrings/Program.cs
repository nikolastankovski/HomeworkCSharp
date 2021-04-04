using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            FunWithString(userInput);
            RemoveExtraSpaceCharacters(userInput);
        }

        static void FunWithString(string someText)
        {
            ReverseString(someText);
            TotalVowels(someText);
            Palindrome(someText);
            LargestWord(someText);
            SmallestWord(someText);
            CountWords(someText);
            MostUsedCharacter(someText);
        }

        static void RemoveExtraSpaceCharacters(string text)
        {
            string[] splittedText = text.Split(" ");
            string[] onlyWordsArray = new string[1];

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (splittedText[i] != "")
                {
                    onlyWordsArray[onlyWordsArray.Length - 1] = splittedText[i];
                    Array.Resize(ref onlyWordsArray, onlyWordsArray.Length + 1);
                }
            }
            Console.WriteLine(string.Join(" ", onlyWordsArray));
        }

        static void ReverseString(string text) 
        {
            char[] charsReverseString = text.ToCharArray();
            Array.Reverse(charsReverseString);
            Console.WriteLine(charsReverseString);
        }
        static void TotalVowels(string text)
        {
            char[] charTotalVowelsString = text.ToCharArray();
            int totalVowels = 0;
            foreach (char x in charTotalVowelsString)
            {
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    totalVowels++;
                }
            }
            Console.WriteLine(totalVowels);
        }
        static void Palindrome(string text)
        {
            char[] charPalindromeString = text.ToCharArray();
            Array.Reverse(charPalindromeString);
            string palindrome = string.Join("", charPalindromeString);

            if (text == palindrome)
            {
                Console.WriteLine($"{text} is palindrome");
            }
            else
            {
                Console.WriteLine($"{text} is not a palindrome");
            }
        }
        static void LargestWord(string text)
        {
            string[] textArray = text.Split(" ");
            string largestWord = "";
            foreach(string x in textArray)
            {
                if (x.Length > largestWord.Length)
                {
                    largestWord = x;
                }
            }
            Console.WriteLine(largestWord);
        }
        static void SmallestWord(string text)
        {
            string[] textArray = text.Trim().Split(" ");
            string smallestWord = null;
            foreach (string x in textArray)
            {
                if(smallestWord == null)
                {
                    smallestWord = x;
                }
                if (x.Length < smallestWord.Length)
                {
                    smallestWord = x;
                }
            }
            Console.WriteLine(smallestWord);
        }
        static void CountWords(string text)
        {
            string[] textArray = text.Trim().Split(" ");
            Console.WriteLine(textArray.Length);
        }
        static void MostUsedCharacter(string text)
        {
            string[] splittedText = text.Split(" ");
            string joinedText = string.Join("", splittedText);

            char mostUsedCharacter = '.';
            int timesCharactedUsed = 0;

            for (int i = 0; i < joinedText.Length; i++)
            {
                char character = joinedText[i];
                int characterUsed = 0;
                for (int j = 0; j < joinedText.Length; j++)
                {
                    if (character == joinedText[j])
                    {
                        characterUsed++;
                    }
                }
                if (timesCharactedUsed < characterUsed)
                {
                    mostUsedCharacter = character;
                    timesCharactedUsed = characterUsed;
                }
            }
            Console.WriteLine($"{mostUsedCharacter} is used {timesCharactedUsed} times");
        }


    }
}
