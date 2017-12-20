using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThursdayAssessment
{
    public class Assessment
    {
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("~~~ Main Menu ~~~");
            Console.WriteLine("1. Palindrome");
            Console.WriteLine("2. Find Longest Word");
            Console.WriteLine("3. Find Word Frequency");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Palindrome();
                    break;
                case "2":
                    FindLongestWord();
                    break;
                case "3":
                    WordFrequency();
                    break;
                default:
                    return;          
            }
        }

        public void Palindrome()
        {
            Console.Clear();
            Console.WriteLine("Please enter a word that is a palindrome");
            var input = Console.ReadLine().ToUpper();
            var inputNoSpaces = input.Replace(" ", "");
            char[] inputArray = inputNoSpaces.ToCharArray();
            Array.Reverse(inputArray);
            string reverse = new string(inputArray);

            if (inputNoSpaces == reverse)
            {
                Console.WriteLine("");
                Console.WriteLine(input + " is a palindrome!");
            }
            if (inputNoSpaces != reverse)
            {
                Console.WriteLine("");
                Console.WriteLine(input + " is not a palindrome :(");
            }
            Console.WriteLine("");
            Console.WriteLine("1. Try another word");
            Console.WriteLine("2. Return to main menu");
            var input2 = Console.ReadLine();
            if (input2 == "1")
            {
                this.Palindrome();
            }
            else if (input2 == "2")
            {
                this.MainMenu();
            }
            this.MainMenu();
        }

        public void FindLongestWord()
        {
            Console.Clear();
            Console.WriteLine("1. Check for longest of 3 words");
            Console.WriteLine("2. Check for longest of 5 words");
            Console.WriteLine("3. Check for longest of 10 words");
            var input = Console.ReadLine();
            if (input == "1")
            {
                var wordList = new List<string>();

                Console.WriteLine("Enter first word.");
                var word1 = Console.ReadLine();
                wordList.Add(word1);
                Console.WriteLine("Enter second word.");
                var word2 = Console.ReadLine();
                wordList.Add(word2);
                Console.WriteLine("Enter third word.");
                var word3 = Console.ReadLine();
                wordList.Add(word3);

                var longestWord = word1;

                foreach (var word in wordList)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine(longestWord + " is the longest word in this list.");
            }
            else if (input == "2")
            {
                var wordList = new List<string>();

                Console.WriteLine("Enter first word.");
                var word1 = Console.ReadLine();
                wordList.Add(word1);
                Console.WriteLine("Enter second word.");
                var word2 = Console.ReadLine();
                wordList.Add(word2);
                Console.WriteLine("Enter third word.");
                var word3 = Console.ReadLine();
                wordList.Add(word3);
                Console.WriteLine("Enter fourth word.");
                var word4 = Console.ReadLine();
                wordList.Add(word4);
                Console.WriteLine("Enter fifth word.");
                var word5 = Console.ReadLine();
                wordList.Add(word5);

                var longestWord = word1;

                foreach (var word in wordList)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine(longestWord + " is the longest word in this list.");
            }
            else if (input == "3")
            {
                var wordList = new List<string>();

                Console.WriteLine("Enter first word.");
                var word1 = Console.ReadLine();
                wordList.Add(word1);
                Console.WriteLine("Enter second word.");
                var word2 = Console.ReadLine();
                wordList.Add(word2);
                Console.WriteLine("Enter third word.");
                var word3 = Console.ReadLine();
                wordList.Add(word3);
                Console.WriteLine("Enter fourth word.");
                var word4 = Console.ReadLine();
                wordList.Add(word4);
                Console.WriteLine("Enter fifth word.");
                var word5 = Console.ReadLine();
                wordList.Add(word5);
                Console.WriteLine("Enter sixth word.");
                var word6 = Console.ReadLine();
                wordList.Add(word6);
                Console.WriteLine("Enter seventh word.");
                var word7 = Console.ReadLine();
                wordList.Add(word7);
                Console.WriteLine("Enter eighth word.");
                var word8 = Console.ReadLine();
                wordList.Add(word8);
                Console.WriteLine("Enter ninth word.");
                var word9 = Console.ReadLine();
                wordList.Add(word9);
                Console.WriteLine("Enter tenth word.");
                var word10 = Console.ReadLine();
                wordList.Add(word10);

                var longestWord = word1;
                foreach (var word in wordList)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
              
                Console.WriteLine("");
                Console.WriteLine(longestWord + " is the longest word in this list.");
            }
            else
            {
                return;
            }
            Console.WriteLine("");
            Console.WriteLine("1. Try more words");
            Console.WriteLine("2. Return to main menu");
            var input2 = Console.ReadLine();
            if (input2 == "1")
            {
                this.FindLongestWord();
            }
            else if (input2 == "2")
            {
                this.MainMenu();
            }
            this.MainMenu();
        }

        public void WordFrequency()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence or paragraph to check the frequency of each word.");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            var input = Console.ReadLine().ToLower();
            input = Regex.Replace(input, "[^a-zA-Z]+", " "); //Just cleaning up a bit
            string[] arr = input.Split(' '); //Create an array of words

            foreach (string word in arr) //let's loop over the words
            {
                //if (word.Length >= 3) //if it meets our criteria of at least 3 letters
                //{
                    if (dictionary.ContainsKey(word)) //if it's in the dictionary
                        dictionary[word] = dictionary[word] + 1; //Increment the count
                    else
                        dictionary[word] = 1; //put it in the dictionary with a count 1
                //}
            }

            Console.WriteLine("");
            foreach (KeyValuePair<string, int> pair in dictionary.OrderByDescending(d => d.Value)) //loop through the dictionary
            {
                Console.WriteLine(string.Format("{0}, {1}", pair.Key, pair.Value));
            }
            Console.WriteLine("");
            Console.WriteLine("1. Try again");
            Console.WriteLine("2. Return to main menu");
            var input2 = Console.ReadLine();
            if (input2 == "1")
            {
                this.WordFrequency();
            }
            else if (input2 == "2")
            {
                this.MainMenu();
            }
            this.MainMenu();
        }
    }
}
