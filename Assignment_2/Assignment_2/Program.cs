/*
 * Student: Vincent Cradler
 * Date: 08292021
 * Class: CSE 1322L 
 * section: #02
 * 
 * Assignment: {Assignment 2}
 * Instructor: Kavitha
 * Guesses a word, assuming that the word is inside of the string
 */
using System;

namespace Assignment_2
{
    class Program
    {
        static bool WordContainsLetter(string word, char letter)
        {
            char[] chararr = word.ToCharArray();
            foreach (char c in chararr)
            {
                if (c == letter) return true;
            }
            return false;
        }

        static bool WordContainsString(string word, string substr)
        {


            if (word.Contains(substr)) return true;
            return false;

        }

        static void guessWordWithLetters(English english, int length, string letters)
        {
            bool sentinel;
            Console.WriteLine("It might be any of these...");
            foreach (string word in english.words)
            {
                sentinel = false;
                if (word.Length == length)
                {
                    char[] chararr = letters.ToCharArray();
                    foreach (char c in chararr)
                    {
                        if (!WordContainsLetter(word, c))
                        {
                            sentinel = true;
                            break;
                        }
                    }
                    if (!sentinel)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }

        static void guessWordWithPattern(English english, int length, string pattern)
        {

            Console.WriteLine("It might be any of these...");
            foreach (string word in english.words)
            {
                if (length == word.Length)
                {
                    if (WordContainsString(word, pattern))
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            return;
        }


        static void Main(string[] args)
        {
            string pattern;
            English english = new English();
            Console.WriteLine("How many letters in the word?");
            int len = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Would you like to search by letters or by pattern");
            Console.WriteLine("1. Letters");
            Console.WriteLine("2. Pattern");
            int searchcriteria = Int16.Parse(Console.ReadLine());
            if (searchcriteria == 1)
            {
                Console.WriteLine("What letters do you want me to looks for?");
                pattern = Console.ReadLine();
                guessWordWithLetters(english, len, pattern);
            }
            else if (searchcriteria == 2)
            {
                Console.WriteLine("What pattern do you want me to looks for?");
                pattern = Console.ReadLine();
                guessWordWithPattern(english, len, pattern);
            }
            else
            {
                Console.WriteLine("Sorry that's not a valid option, please try again");
            }
        }
    }
}
