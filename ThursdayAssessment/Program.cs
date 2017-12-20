using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThursdayAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1.) Create a new console application project.
            // (2.) Add main menu for the following exercises.
            // (3.) Write a method palindrome() that computes the reversal of a string,
            /////// returning true if the string is a palindrome (the same forwards and backwards – “radar” for example),
            /////// and false if otherwise.
            // (4.) Write a method findLongestWord() that finds and displays the longest word
            /////// in a list that has been passed in as an argument.
            // (5.) (Bonus Exercise) Write a method wordFreq() that displays a frequency listing of the words
            /////// contained in a list that has been passed in as an argument.Order the words by frequency.

            Assessment assessment = new Assessment();
            assessment.MainMenu();
        }
    }
}
